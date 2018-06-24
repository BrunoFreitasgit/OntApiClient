using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Services.Contract;

namespace OntApiClient.Rpc.Services
{
    public class OntApiContractService : RpcClientWrapper
    {
        public OntApiContractService(IClient client) : base(client)
        {
            GetStorage = new OntGetStorage(client);
        }

        public OntGetStorage GetStorage { get; }
    }
}