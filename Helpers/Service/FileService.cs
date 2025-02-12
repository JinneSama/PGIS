using System.Configuration;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Drawing;

namespace Helpers.Service
{
    public class FileService
    {
        private static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(ConfigurationManager.AppSettings["FolderURL"])
        };

        private readonly AuthBackend _authBackend;
        public FileService()
        {
            _authBackend = new AuthBackend();
        }
        public async Task UploadFile(Image img, string fileName)
        {
            if (img == null) return;
            string jwtToken = await _authBackend.CheckAuthentication();
            using (var content = new MultipartFormDataContent())
            {
                using (var memoryStream = new MemoryStream())
                {
                    img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    memoryStream.Seek(0, SeekOrigin.Begin);

                    var imageContent = new StreamContent(memoryStream);
                    imageContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
                    content.Add(imageContent, "file", fileName);

                    httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwtToken);

                    var response = await httpClient.PostAsync("upload/", content);
                    response.EnsureSuccessStatusCode();
                }
            }
        }

        public async Task<Image> DownloadFile(string fileName)
        {
            string jwtToken = await _authBackend.CheckAuthentication();
            if (string.IsNullOrEmpty(jwtToken)) return null;
            var request = new HttpRequestMessage(HttpMethod.Get, httpClient.BaseAddress + "download/" + fileName);
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwtToken);
            var response = await httpClient.SendAsync(request);

            Image img = null;
            if (response.IsSuccessStatusCode)
            {
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    img = Image.FromStream(stream);
                }
            }
            else return null;

            return img;
        }
    }
}
