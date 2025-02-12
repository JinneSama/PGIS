namespace Helpers.Service.Models
{
    public class TokenResponse
    {
        [Newtonsoft.Json.JsonProperty("token")]
        public string Token { get; set; }
    }
}
