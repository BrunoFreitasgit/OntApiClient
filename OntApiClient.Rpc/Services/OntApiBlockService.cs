using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.Services.Block;

namespace OntApiClient.Rpc.Services
{
    public class OntApiBlockService : RpcClientWrapper
    {
        public OntApiBlockService(IClient client) : base(client)
        {
            GetBlock = new OntGetBlock(client);
            GetBlockVerbose = new OntGetBlockVerbose(client);
            GetBestBlockHash = new OntGetBestBlockHash(client);
            GetBlockCount = new OntGetBlockCount(client);
        }

        public OntGetBlock GetBlock { get; }
        public OntGetBlockVerbose GetBlockVerbose { get; }
        public OntGetBestBlockHash GetBestBlockHash { get; }
        public OntGetBlockCount GetBlockCount { get; }
    }
}