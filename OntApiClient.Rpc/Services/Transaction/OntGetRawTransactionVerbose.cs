using System;
using System.Threading.Tasks;
using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Infrastructure;

namespace OntApiClient.Rpc.Services.Transaction
{
    public class OntGetRawTransactionVerbose : RpcRequestResponseHandler<DTOs.Transaction>
    {
        public OntGetRawTransactionVerbose(IClient client) : base(client, RpcApiMethods.getrawtransaction.ToString())
        {
        }

        public Task<DTOs.Transaction> SendRequestAsync(string transactionHash, object id = null)
        {
            if (string.IsNullOrEmpty(transactionHash)) throw new ArgumentNullException(nameof(transactionHash));
            return base.SendRequestAsync(id, transactionHash, 1);
        }

        public RpcRequest BuildRequest(string transactionHash, object id = null)
        {
            if (string.IsNullOrEmpty(transactionHash)) throw new ArgumentNullException(nameof(transactionHash));
            return base.BuildRequest(id, transactionHash, 1);
        }
    }
}
