using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Infrastructure;

namespace OntApiClient.Rpc.Services.Block
{
    public class OntGetGenerateBlockTime : GenericRpcRequestResponseHandlerNoParam<string>
    {
        public OntGetGenerateBlockTime(IClient client) : base(client, RpcApiMethods.getgenerateblocktime.ToString())
        {
        }
    }
}
