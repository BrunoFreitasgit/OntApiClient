using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Infrastructure;
using Version = OntApiClient.Rpc.DTOs.Version;

namespace OntApiClient.Rpc.Services.Node
{
    public class OntGetVersion : GenericRpcRequestResponseHandlerNoParam<Version>
    {
        public OntGetVersion(IClient client) : base(client, RpcApiMethods.getversion.ToString())
        {
        }
    }
}
