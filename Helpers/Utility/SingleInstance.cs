using Helpers.Interface;
using System;
using System.IO.Pipes;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Helpers.Utility
{
    public class SingleInstance : ISingleInstance
    {
        private static Mutex mutex;
        private readonly string _appId;
        private Action _showFormCallback;
        private CancellationTokenSource _cts;
        public SingleInstance(string appId, Action showFormCallback = null)
        {
            _appId = appId;
            _showFormCallback = showFormCallback;
            _cts = new CancellationTokenSource();
            Task.Run(() => StartListeningForShowRequest(_cts.Token));
        }
        public void ReleaseInstance()
        {
            mutex.ReleaseMutex();
            mutex.Dispose();
        }
        public void ShowExistingForm()
        {
            _showFormCallback?.Invoke();
        }

        public bool IsSingleInstance()
        {
            bool createdNew;
            mutex = new Mutex(true, _appId, out createdNew);
            return createdNew;
        }
        public void ShowExistingInstance()
        {
            using (NamedPipeClientStream client = new NamedPipeClientStream(".", "PGISPipe", PipeDirection.Out))
            {
                client.Connect(500);
                using (StreamWriter writer = new StreamWriter(client))
                {
                    writer.WriteLine("SHOW");
                    writer.Flush();
                }
            }
        }
        private void StartListeningForShowRequest(CancellationToken token)
        {
            while (!token.IsCancellationRequested) 
            {
                using (NamedPipeServerStream server = new NamedPipeServerStream("PGISPipe", PipeDirection.In))
                {
                    server.WaitForConnection();
                    using (StreamReader reader = new StreamReader(server))
                    {
                        if (reader.ReadLine() == "SHOW")
                        {
                            ShowExistingForm();
                        }
                    }
                    if(server.IsConnected) server.Disconnect();
                }
            }
        }
    }
}
