using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Services.Node;

namespace OntApiClient.Rpc.Services
{
    public class OntApiNodeService : RpcClientWrapper
    {
        public OntApiNodeService(IClient client) : base(client)
        {
            GetConnectionCount = new OntGetConnectionCount(client);
        }

        public OntGetConnectionCount GetConnectionCount { get; }
    }
}