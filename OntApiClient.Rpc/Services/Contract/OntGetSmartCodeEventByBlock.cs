using System;
using System.Threading.Tasks;
using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Infrastructure;

namespace OntApiClient.Rpc.Services.Contract
{
    public class OntGetSmartCodeEventByBlock : RpcRequestResponseHandler<string[]>
    {
        public OntGetSmartCodeEventByBlock(IClient client) : base(client, RpcApiMethods.getsmartcodeevent.ToString())
        {
        }

        public Task<string[]> SendRequestAsync(int blockIndex, object id = null)
        {
            if (blockIndex < 0) throw new ArgumentOutOfRangeException(nameof(blockIndex));
            return base.SendRequestAsync(id, blockIndex, 0);
        }

        public RpcRequest BuildRequest(int blockIndex, object id = null)
        {
            if (blockIndex < 0) throw new ArgumentOutOfRangeException(nameof(blockIndex));
            return base.BuildRequest(id, blockIndex, 0);
        }
    }
}