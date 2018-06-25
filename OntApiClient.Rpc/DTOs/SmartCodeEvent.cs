using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OntApiClient.Rpc.DTOs
{
    public class SmartCodeEvent //todo error here
    {
        [JsonProperty("TxHash")]
        public string TxHash { get; set; }

        [JsonProperty("State")]
        public long State { get; set; }

        [JsonProperty("GasConsumed")]
        public long GasConsumed { get; set; }

        [JsonProperty("Notify")]
        public List<Notify> Notify { get; set; }
    }
}
