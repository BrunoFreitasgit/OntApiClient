using System;
using System.Threading.Tasks;
using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Infrastructure;

namespace OntApiClient.Rpc.Services.Transaction
{
    public class OntSendRawTransaction : RpcRequestResponseHandler<string>
    {
        public OntSendRawTransaction(IClient client) : base(client, RpcApiMethods.sendrawtransaction.ToString())
        {
        }

        public Task<string> SendRequestAsync(string serializedSignTransaction, object id = null)
        {
            if (string.IsNullOrEmpty(serializedSignTransaction))
                throw new ArgumentNullException(nameof(serializedSignTransaction));
            return base.SendRequestAsync(id, serializedSignTransaction);
        }

        public RpcRequest BuildRequest(string serializedSignTransaction, object id = null)
        {
            if (string.IsNullOrEmpty(serializedSignTransaction))
                throw new ArgumentNullException(nameof(serializedSignTransaction));
            return base.BuildRequest(id, serializedSignTransaction);
        }
    }
}