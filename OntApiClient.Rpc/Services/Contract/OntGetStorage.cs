using System;
using System.Threading.Tasks;
using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Infrastructure;

namespace OntApiClient.Rpc.Services.Contract
{
    public class OntGetStorage : RpcRequestResponseHandler<string>
    {
        public OntGetStorage(IClient client) : base(client, RpcApiMethods.getstorage.ToString())
        {
        }

        public Task<string> SendRequestAsync(string contractScriptHash, string storedKey, object id = null)
        {
            if (string.IsNullOrEmpty(contractScriptHash)) throw new ArgumentNullException(nameof(contractScriptHash));
            if (string.IsNullOrEmpty(storedKey)) throw new ArgumentNullException(nameof(storedKey));
            return base.SendRequestAsync(id, contractScriptHash, storedKey);
        }

        public RpcRequest BuildRequest(string contractScriptHash, string storedKey, object id = null)
        {
            if (string.IsNullOrEmpty(contractScriptHash)) throw new ArgumentNullException(nameof(contractScriptHash));
            if (string.IsNullOrEmpty(storedKey)) throw new ArgumentNullException(nameof(storedKey));
            return base.BuildRequest(id, contractScriptHash, storedKey);
        }
    }
}