using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Services.Contract;

namespace OntApiClient.Rpc.Services
{
    public class OntApiContractService : RpcClientWrapper
    {
        public OntApiContractService(IClient client) : base(client)
        {
            GetStorage = new OntGetStorage(client);
            GetSmartCodeEventByBlock = new OntGetSmartCodeEventByBlock(client);
            GetSmartCodeEventByTx = new OntGetSmartCodeEventByTx(client);
        }

        public OntGetStorage GetStorage { get; }
        public OntGetSmartCodeEventByBlock GetSmartCodeEventByBlock { get; }
        public OntGetSmartCodeEventByTx GetSmartCodeEventByTx { get; }
    }
}