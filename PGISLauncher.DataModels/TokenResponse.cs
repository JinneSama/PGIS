using Newtonsoft.Json;

namespace PGISLauncher.DataModels
{
    public class TokenResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
