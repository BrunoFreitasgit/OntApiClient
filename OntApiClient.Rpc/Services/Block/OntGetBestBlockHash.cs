using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Infrastructure;

namespace OntApiClient.Rpc.Services.Block
{
    public class OntGetBestBlockHash : GenericRpcRequestResponseHandlerNoParam<string>
    {
        public OntGetBestBlockHash(IClient client) : base(client, RpcApiMethods.getbestblockhash.ToString())
        {
        }
    }
}