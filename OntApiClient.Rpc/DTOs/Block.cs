using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Newtonsoft.Json;

namespace OntApiClient.Rpc.DTOs
{
    public class Block
    {
        [JsonProperty("Hash")]
        public string Hash { get; set; }

        [JsonProperty("Header")]
        public Header Header { get; set; }

        [JsonProperty("Transactions")]
        public List<Transaction> Transactions { get; set; }
    }

    public class Sig
    {
        [JsonProperty("PubKeys")]
        public List<string> PubKeys { get; set; }

        [JsonProperty("M")]
        public byte M { get; set; }

        [JsonProperty("SigData")]
        public List<string> SigData { get; set; }
    }

}
