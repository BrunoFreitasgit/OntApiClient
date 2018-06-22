using System.Threading.Tasks;
using OntApiClient.JsonRpc.Client;

namespace OntApiClient.Rpc.Infrastructure
{
    public class GenericRpcRequestResponseHandlerNoParam<TResponse> : RpcRequestResponseHandlerNoParam<TResponse>
    {
        public GenericRpcRequestResponseHandlerNoParam(IClient client, string methodName) : base(client, methodName)
        {
        }

        public new Task<TResponse> SendRequestAsync(object id = null)
        {
            return base.SendRequestAsync(id);
        }
    }
}