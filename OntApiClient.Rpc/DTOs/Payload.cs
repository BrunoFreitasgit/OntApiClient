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


    }
}
