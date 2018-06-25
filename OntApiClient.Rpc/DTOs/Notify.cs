using System.Collections.Generic;
using Newtonsoft.Json;

namespace OntApiClient.Rpc.DTOs
{
    public class Notify
    {
        [JsonProperty("ContractAddress")]
        public string ContractAddress { get; set; }

        [JsonProperty("States")]
        public List<State> States { get; set; }
    }

    public struct State
    {
        public long? Integer;
        public string String;

        public bool IsNull => Integer == null && String == null;
    }
}
