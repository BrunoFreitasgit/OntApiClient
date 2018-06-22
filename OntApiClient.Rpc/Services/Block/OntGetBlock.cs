using System;
using System.Threading.Tasks;
using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Infrastructure;

namespace OntApiClient.Rpc.Services.Block
{
    public class OntGetBlock : RpcRequestResponseHandler<string>
    {
        public OntGetBlock(IClient client) : base(client, RpcApiMethods.getblock.ToString())
        {
        }

        public Task<string> SendRequestAsync(int blockIndex, object id = null)
        {
            if (blockIndex < 0) throw new ArgumentOutOfRangeException(nameof(blockIndex));
            return base.SendRequestAsync(id, blockIndex, 0);
        }

        public RpcRequest BuildRequest(int blockIndex, object id = null)
        {
            if (blockIndex < 0) throw new ArgumentOutOfRangeException(nameof(blockIndex));
            return base.BuildRequest(id, blockIndex, 0);
        }

        public Task<string> SendRequestAsync(string blockHash, object id = null)
        {
            if (string.IsNullOrEmpty(blockHash)) throw new ArgumentNullException(nameof(blockHash));
            return base.SendRequestAsync(id, blockHash, 0);
        }

        public RpcRequest BuildRequest(string blockHash, object id = null)
        {
            if (string.IsNullOrEmpty(blockHash)) throw new ArgumentNullException(nameof(blockHash));
            return base.BuildRequest(id, blockHash, 0);
        }
    }
}