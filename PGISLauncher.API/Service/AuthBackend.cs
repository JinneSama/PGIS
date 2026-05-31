using Newtonsoft.Json;
using PGISLauncher.DataModels;
using PGISLauncher.Interfaces;
using System;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PGISLauncher.API.Service
{
    public class AuthBackend
    {
        private readonly ITokenCache _tokenHandler;
        private static readonly HttpClient httpAuthClient = new HttpClient
        {
            BaseAddress = new Uri(ConfigurationManager.AppSettings["AuthURL"])
        };

        public AuthBackend(ITokenCache tokenHandler)
        {
            _tokenHandler = tokenHandler;
        }
        public async Task<string> CheckAuthentication()
        {
            string username = ConfigurationManager.AppSettings["Username"];
            string password = ConfigurationManager.AppSettings["Password"];

            string token = _tokenHandler.CheckCache();
            if (string.IsNullOrEmpty(token))
            {
                token = await AuthenticateUser(username, password, "");
                _tokenHandler.StoreCache(token);
            }
            ;
            return token;
        }

        private async Task<string> AuthenticateUser(string username, string password, string fileName)
        {
            var loginRequest = new LoginRequest
            {
                Username = username,
                Password = password,
                FileName = fileName
            };

            var content = new StringContent(
                JsonConvert.SerializeObject(loginRequest),
                Encoding.UTF8,
                "application/json");

            var response = await httpAuthClient.PostAsync("login/", content);

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(jsonResponse);
                return tokenResponse.Token;
            }
            else return string.Empty;
        }
    }
}
