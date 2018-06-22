using System.Collections.Generic;
using Newtonsoft.Json;

namespace OntApiClient.Rpc.DTOs
{
    public class Header
    {
        [JsonProperty("Version")]
        public uint Version { get; set; }

        [JsonProperty("PrevBlockHash")]
        public string PrevBlockHash { get; set; }

        [JsonProperty("TransactionsRoot")]
        public string TransactionsRoot { get; set; }

        [JsonProperty("BlockRoot")]
        public string BlockRoot { get; set; }

        [JsonProperty("Timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("Height")]
        public int Height { get; set; }

        [JsonProperty("ConsensusData")]
        public ulong ConsensusData { get; set; }

        [JsonProperty("NextBookkeeper")]
        public string NextBookkeeper { get; set; }

        [JsonProperty("Bookkeepers")]
        public List<string> Bookkeepers { get; set; }

        [JsonProperty("SigData")]
        public List<string> SigData { get; set; }

        [JsonProperty("Hash")]
        public string Hash { get; set; }
    }
}
