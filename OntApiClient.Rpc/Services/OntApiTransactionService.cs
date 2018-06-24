using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Services.Transaction;

namespace OntApiClient.Rpc.Services
{
    public class OntApiTransactionService : RpcClientWrapper
    {
        public OntApiTransactionService(IClient client) : base(client)
        {
            GetRawTransaction = new OntGetRawTransaction(client);
            GetRawTransactionVerbose = new OntGetRawTransactionVerbose(client);
        }

        public OntGetRawTransaction GetRawTransaction { get; }
        public OntGetRawTransactionVerbose GetRawTransactionVerbose { get; set; }
    }
}