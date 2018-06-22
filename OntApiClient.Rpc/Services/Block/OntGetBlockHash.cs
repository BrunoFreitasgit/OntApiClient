using System;
using System.Threading.Tasks;
using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Infrastructure;

namespace OntApiClient.Rpc.Services.Block
{
    public class OntGetBlockHash : RpcRequestResponseHandler<string>
    {
        public OntGetBlockHash(IClient client) : base(client, RpcApiMethods.getblockhash.ToString())
        {
        }

        public Task<string> SendRequestAsync(int blockIndex, object id = null)
        {
            if (blockIndex < 0) throw new ArgumentOutOfRangeException(nameof(blockIndex));
            return base.SendRequestAsync(id, blockIndex, 1);
        }

        public RpcRequest BuildRequest(int blockIndex, object id = null)
        {
            if (blockIndex < 0) throw new ArgumentOutOfRangeException(nameof(blockIndex));
            return base.BuildRequest(id, blockIndex, 1);
        }
    }
}
