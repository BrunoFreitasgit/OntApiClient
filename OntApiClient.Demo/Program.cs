using System;
using System.Threading.Tasks;
using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc;

namespace OntApiClient.Demo
{
    public class Program
    {
        private static readonly RpcClient RpcClient = new RpcClient(new Uri("http://54.66.154.140:20336"));

        static void Main(string[] args)
        {
            try
            {
                TestBlocks().Wait();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        private static async Task TestBlocks()
        {
            var service = new OntApiService(RpcClient);
            var bestBlockHash = await service.Blocks.GetBestBlockHash.SendRequestAsync();
            var block = await service.Blocks.GetBlock.SendRequestAsync(1);
            var blockVerbose = await service.Blocks.GetBlockVerbose.SendRequestAsync(1);
            var blockCount = await service.Blocks.GetBlockCount.SendRequestAsync();
        }
    }
}
