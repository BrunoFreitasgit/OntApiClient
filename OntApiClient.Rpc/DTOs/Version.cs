using Newtonsoft.Json;

namespace OntApiClient.Rpc.DTOs
{
    public class Version //todo docs have non capitalized properties
    {
        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("nonce")]
        public long Nonce { get; set; }

        [JsonProperty("useragent")]
        public string UserAgent { get; set; }
    }
}