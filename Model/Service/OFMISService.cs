using Helpers.Service;
using Model.Service.Dto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Model.Service
{
    public class OFMISService
    {
        private static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(ConfigurationManager.AppSettings["OFMISURL"])
        };

        private readonly AuthBackend _authBackend;
        public OFMISService()
        {
            _authBackend = new AuthBackend();
        }
        public async Task<OFMISUsersDto> GetUser(string username)
        {
            string jwtToken = await _authBackend.CheckAuthentication();
            if (string.IsNullOrEmpty(jwtToken)) return null;
            var request = new HttpRequestMessage(HttpMethod.Get, httpClient.BaseAddress + "user/" + username);
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwtToken);
            var response = await httpClient.SendAsync(request);
            if(!response.IsSuccessStatusCode) return null;

            var json = await response.Content.ReadAsStringAsync();
            var user = JsonSerializer.Deserialize<OFMISUsersDto>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return user;
        }

        public async Task<IEnumerable<OFMISUsersDto>> GetAllUsers()
        {
            string jwtToken = await _authBackend.CheckAuthentication();
            if (string.IsNullOrEmpty(jwtToken)) return null;
            var request = new HttpRequestMessage(HttpMethod.Get, httpClient.BaseAddress + "users/");
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwtToken);
            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var users = JsonSerializer.Deserialize<IEnumerable<OFMISUsersDto>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return users;
        }
    }
}
