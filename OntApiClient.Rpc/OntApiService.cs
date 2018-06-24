using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Services;

namespace OntApiClient.Rpc
{
    public class OntApiService : RpcClientWrapper
    {
        public OntApiService(IClient client) : base(client)
        {
            Client = client;
            Blocks = new OntApiBlockService(client);
            Contracts = new OntApiContractService(client);
            Transactions = new OntApiTransactionService(client);
            Nodes = new OntApiNodeService(client);
        }

        public OntApiBlockService Blocks { get; }
        public OntApiContractService Contracts { get; }
        public OntApiNodeService Nodes { get; }
        public OntApiTransactionService Transactions { get; }
    }
}