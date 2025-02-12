using Helpers.Interface;
using Helpers.Service.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Service
{
    public class AuthBackend : ITokenCache
    {
        private readonly ITokenCache _tokenHandler;
        private static readonly HttpClient httpAuthClient = new HttpClient
        {
            BaseAddress = new Uri(ConfigurationManager.AppSettings["AuthURL"])
        };

        public AuthBackend()
        {
            _tokenHandler = new TokenCache();
        }
        public async Task<string> CheckAuthentication()
        {
            string username = ConfigurationManager.AppSettings["Username"];
            string password = ConfigurationManager.AppSettings["Password"];

            string token = CheckCache();
            if (string.IsNullOrEmpty(token))
            {
                token = await AuthenticateUser(username, password, "");
                StoreCache(token);
            };

            return token;
        }

        public string CheckCache()
        {
            return _tokenHandler.CheckCache();
        }

        public void StoreCache(string token)
        {
            _tokenHandler.StoreCache(token);
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
                Newtonsoft.Json.JsonConvert.SerializeObject(loginRequest),
                Encoding.UTF8,
                "application/json");

            var response = await httpAuthClient.PostAsync("login/", content);

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var tokenResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<TokenResponse>(jsonResponse);
                return tokenResponse.Token;
            }
            else return string.Empty;
        }
    }
}
