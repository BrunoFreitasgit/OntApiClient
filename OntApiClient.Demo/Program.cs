using System;
using System.Threading.Tasks;
using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc;

namespace OntApiClient.Demo
{
    public class Program
    {
        //@Panthers private network
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
            var bestBlockHashDto = await service.Blocks.GetBestBlockHash.SendRequestAsync();
            var blockDto = await service.Blocks.GetBlock.SendRequestAsync(1);
            var blockVerboseDto = await service.Blocks.GetBlockVerbose.SendRequestAsync(1);
            var blockCountDto = await service.Blocks.GetBlockCount.SendRequestAsync();
            var getRawTransactionDto =
                await service.Transactions.GetRawTransaction.SendRequestAsync(
                    "594d82eb2b5b688d4bb031552d92c6bf195a5754755cfbada3b7df746f5e6085");
            var getRawTransactionVerboseDto =
                await service.Transactions.GetRawTransactionVerbose.SendRequestAsync(
                    "594d82eb2b5b688d4bb031552d92c6bf195a5754755cfbada3b7df746f5e6085");
            var getSmartCodeEventByBlock = await service.Contracts.GetSmartCodeEventByBlock.SendRequestAsync(0);
            var getSmartCodeEventByTx =
                await service.Contracts.GetSmartCodeEventByTx.SendRequestAsync(getSmartCodeEventByBlock[0]);
        }
    }
}
