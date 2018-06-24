using System;
using System.Threading.Tasks;
using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Infrastructure;

namespace OntApiClient.Rpc.Services.Transaction
{
    public class OntGetRawTransaction : RpcRequestResponseHandler<string>
    {
        public OntGetRawTransaction(IClient client) : base(client, RpcApiMethods.getrawtransaction.ToString())
        {
        }

        public Task<string> SendRequestAsync(string transactionHash, object id = null)
        {
            if (string.IsNullOrEmpty(transactionHash)) throw new ArgumentNullException(nameof(transactionHash));
            return base.SendRequestAsync(id, transactionHash, 0);
        }

        public RpcRequest BuildRequest(string transactionHash, object id = null)
        {
            if (string.IsNullOrEmpty(transactionHash)) throw new ArgumentNullException(nameof(transactionHash));
            return base.BuildRequest(id, transactionHash, 0);
        }
    }
}