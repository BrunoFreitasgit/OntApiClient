using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Infrastructure;

namespace OntApiClient.Rpc.Services.Node
{
    public class OntGetConnectionCount : GenericRpcRequestResponseHandlerNoParam<string>
    {
        public OntGetConnectionCount(IClient client) : base(client, RpcApiMethods.getconnectioncount.ToString())
        {
        }
    }
}
