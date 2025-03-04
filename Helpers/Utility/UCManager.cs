using DevExpress.XtraEditors;
using Helpers.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Helpers.Utility
{
    public class UCManager<TControl> : IUCManager<TControl> where TControl : Control
    {
        private Dictionary<string, TControl> _ucSystemDetailsCache = new Dictionary<string, TControl>();
        private PanelControl _panelDetails;
        private List<string> _history = new List<string>();
        private int _historyIndex = -1;
        private readonly Control _parentControl;

        public UCManager(PanelControl panelDetails)
        {
            _panelDetails = panelDetails;
            _parentControl = _panelDetails.Parent.Parent;
        }

        public void ShowUCSystemDetails(string key, object rowData)
        {
            TControl control;

            if (!_ucSystemDetailsCache.TryGetValue(key, out control))
            {
                control = (TControl)Activator.CreateInstance(typeof(TControl), rowData, _parentControl);
                control.Dock = DockStyle.Fill;
                _ucSystemDetailsCache[key] = control;
            }

            if (_historyIndex == -1 || _historyIndex == _history.Count - 1 || _history[_historyIndex] != key)
            {
                _history.Add(key);
                _historyIndex++;
            }

            _panelDetails.Controls.Clear();
            _panelDetails.Controls.Add(control);
        }

        public void RemoveUCSystemDetails(string key)
        {
            if (!_ucSystemDetailsCache.ContainsKey(key)) return;

            _ucSystemDetailsCache.Remove(key);
            _history.Remove(key);
            if (_historyIndex >= _history.Count)
                _historyIndex = _history.Count - 1;
        }

        public void ClearCache()
        {
            _ucSystemDetailsCache.Clear();
            _history.Clear();
            _historyIndex = -1;
        }

        public void NavigateBack()
        {
            if (!(_historyIndex > 0)) return;

            _historyIndex--;
            string key = _history[_historyIndex];
            if (_ucSystemDetailsCache.ContainsKey(key))
            {
                _panelDetails.Controls.Clear();
                _panelDetails.Controls.Add(_ucSystemDetailsCache[key]);
            }
        }

        public void NavigateForward()
        {
            if (!(_historyIndex < _history.Count - 1)) return;

            _historyIndex++;
            string key = _history[_historyIndex];
            if (_ucSystemDetailsCache.ContainsKey(key))
            {
                _panelDetails.Controls.Clear();
                _panelDetails.Controls.Add(_ucSystemDetailsCache[key]);
            }
        }
    }
}
