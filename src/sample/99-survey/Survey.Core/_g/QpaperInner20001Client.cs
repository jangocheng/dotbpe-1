// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: service/inner/qpaper_inner_20001.proto
#region Designer generated code

using System; 
using System.Threading.Tasks; 
using DotBPE.Rpc; 
using DotBPE.Protocol.Amp; 
using DotBPE.Rpc.Exceptions; 
using Google.Protobuf; 

namespace Survey.Core {

//start for class QPaperInnerServiceClient
   public sealed class QPaperInnerServiceClient : AmpInvokeClient 
    {
        public QPaperInnerServiceClient(IRpcClient<AmpMessage> client) : base(client)
        {
        }
        public QPaperInnerServiceClient(string remoteAddress) : base(remoteAddress)
        {
        }
        public async Task<RpcResult<SaveQPaperRsp>> SaveQPaperAsync(SaveQPaperReq request,int timeOut=3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 1);
            message.Data = request.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message,timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<SaveQPaperRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = SaveQPaperRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        //同步方法
        public RpcResult<SaveQPaperRsp> SaveQPaper(SaveQPaperReq request)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 1);
            message.Data = request.ToByteArray();
            var response =  base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<SaveQPaperRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = SaveQPaperRsp.Parser.ParseFrom(response.Data);
            }
            return result;
         }
        public async Task<RpcResult<QPaperListRsp>> QueryQPaperListAsync(QueryQPaperReq request,int timeOut=3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 2);
            message.Data = request.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message,timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<QPaperListRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = QPaperListRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        //同步方法
        public RpcResult<QPaperListRsp> QueryQPaperList(QueryQPaperReq request)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 2);
            message.Data = request.ToByteArray();
            var response =  base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<QPaperListRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = QPaperListRsp.Parser.ParseFrom(response.Data);
            }
            return result;
         }
        public async Task<RpcResult<QPaperRsp>> GetQPaperAsync(GetQPaperReq request,int timeOut=3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 3);
            message.Data = request.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message,timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<QPaperRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = QPaperRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        //同步方法
        public RpcResult<QPaperRsp> GetQPaper(GetQPaperReq request)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 3);
            message.Data = request.ToByteArray();
            var response =  base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<QPaperRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = QPaperRsp.Parser.ParseFrom(response.Data);
            }
            return result;
         }
        public async Task<RpcResult<QPaperFullRsp>> GetQPaperFullAsync(GetQPaperReq request,int timeOut=3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 4);
            message.Data = request.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message,timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<QPaperFullRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = QPaperFullRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        //同步方法
        public RpcResult<QPaperFullRsp> GetQPaperFull(GetQPaperReq request)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 4);
            message.Data = request.ToByteArray();
            var response =  base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<QPaperFullRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = QPaperFullRsp.Parser.ParseFrom(response.Data);
            }
            return result;
         }
        public async Task<RpcResult<VoidRsp>> AddAPaperCountAsync(AddAPaperReq request,int timeOut=3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 5);
            message.Data = request.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message,timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<VoidRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = VoidRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        //同步方法
        public RpcResult<VoidRsp> AddAPaperCount(AddAPaperReq request)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 5);
            message.Data = request.ToByteArray();
            var response =  base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<VoidRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = VoidRsp.Parser.ParseFrom(response.Data);
            }
            return result;
         }
     }
//end for class QPaperInnerServiceClient
}
#endregion
