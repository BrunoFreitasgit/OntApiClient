using System.Collections.Generic;
using Newtonsoft.Json;

namespace OntApiClient.Rpc.DTOs
{
    public class Transaction
    {
        [JsonProperty("Version")]
        public byte Version { get; set; }

        [JsonProperty("Nonce")]
        public uint Nonce { get; set; }

        [JsonProperty("TxType")]
        public long TxType { get; set; }

        [JsonProperty("Payload")]
        public Payload Payload { get; set; }

        [JsonProperty("Attributes")]
        public List<object> Attributes { get; set; }

        [JsonProperty("Fee")]
        public List<object> Fee { get; set; }

        [JsonProperty("NetworkFee")]
        public long NetworkFee { get; set; }

        [JsonProperty("Sigs")]
        public List<Sig> Sigs { get; set; }

        [JsonProperty("Hash")]
        public string Hash { get; set; }
    }
}
