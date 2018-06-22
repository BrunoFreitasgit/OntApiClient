using Newtonsoft.Json.Linq;

namespace OntApiClient.JsonRpc.Client
{
    public class RpcError
    {
        public RpcError(long code, string message, JToken data = null)
        {
            Code = code;
            Message = message;
            Data = data;
        }

        public long Code { get; }
        public string Message { get; }
        public JToken Data { get; }
    }
}
