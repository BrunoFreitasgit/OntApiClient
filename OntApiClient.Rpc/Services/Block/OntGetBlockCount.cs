using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Infrastructure;

namespace OntApiClient.Rpc.Services.Block
{
    public class OntGetBlockCount : GenericRpcRequestResponseHandlerNoParam<long>
    {
        public OntGetBlockCount(IClient client) : base(client, RpcApiMethods.getblockcount.ToString())
        {
        }
    }
}
