using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Services;

namespace OntApiClient.Rpc
{
    public class OntApiService : RpcClientWrapper
    {
        public OntApiBlockService Blocks { get; }
        public OntApiService(IClient client) : base(client)
        {
            Client = client;
            Blocks = new OntApiBlockService(client);
        }
    }
}
