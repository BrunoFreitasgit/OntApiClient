using Newtonsoft.Json;

namespace OntApiClient.Rpc.DTOs
{
    public class Payload
    {
        [JsonProperty("Nonce")]
        public long Nonce { get; set; }

        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("GasLimit")]
        public int GasLimit { get; set; }

        [JsonProperty("VmType")]
        public int VmType { get; set; }

        //todo: depends on txtype, return here
        [JsonProperty("NeedStorage")]
        public bool NeedStorage { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("CodeVersion")]
        public string CodeVersion { get; set; }

        [JsonProperty("Author")]
        public string Author { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }
}
