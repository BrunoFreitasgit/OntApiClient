using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OntApiClient.JsonRpc.Client;
using OntApiClient.Rpc.DTOs;
using OntApiClient.Rpc.Infrastructure;

namespace OntApiClient.Rpc.Services.Contract
{
    public class OntGetSmartCodeEventByTx : RpcRequestResponseHandler<List<SmartCodeEvent>>
    {
        public OntGetSmartCodeEventByTx(IClient client) : base(client, RpcApiMethods.getsmartcodeevent.ToString())
        {
        }


        public Task<List<SmartCodeEvent>> SendRequestAsync(string txHash, object id = null)
        {
            if (string.IsNullOrEmpty(txHash)) throw new ArgumentNullException(nameof(txHash));
            return base.SendRequestAsync(id, txHash);
        }

        public RpcRequest BuildRequest(string txHash, object id = null)
        {
            if (string.IsNullOrEmpty(txHash)) throw new ArgumentNullException(nameof(txHash));
            return base.BuildRequest(id, txHash);
        }
    }
}