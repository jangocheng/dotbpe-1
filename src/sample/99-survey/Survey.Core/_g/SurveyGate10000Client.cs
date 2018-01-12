// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: service/gate/survey_gate_10000.proto
#region Designer generated code

using System; 
using System.Threading.Tasks; 
using DotBPE.Rpc; 
using DotBPE.Protocol.Amp; 
using DotBPE.Rpc.Exceptions; 
using Google.Protobuf; 

namespace Survey.Core {

//start for class SurveyGateServiceClient
   public sealed class SurveyGateServiceClient : AmpInvokeClient 
    {
        public SurveyGateServiceClient(IRpcClient<AmpMessage> client) : base(client)
        {
        }
        public SurveyGateServiceClient(string remoteAddress) : base(remoteAddress)
        {
        }
        public async Task<RpcResult<SaveQPaperRsp>> SaveQPaperAsync(SaveQPaperReq request,int timeOut=3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(10000, 11);
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
            AmpMessage message = AmpMessage.CreateRequestMessage(10000, 11);
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
            AmpMessage message = AmpMessage.CreateRequestMessage(10000, 12);
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
            AmpMessage message = AmpMessage.CreateRequestMessage(10000, 12);
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
            AmpMessage message = AmpMessage.CreateRequestMessage(10000, 13);
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
            AmpMessage message = AmpMessage.CreateRequestMessage(10000, 13);
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
        public async Task<RpcResult<SaveAPaperRsp>> SaveAPaperAsync(SaveAPaperReq request,int timeOut=3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(10000, 21);
            message.Data = request.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message,timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<SaveAPaperRsp>();
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
                result.Data = SaveAPaperRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        //同步方法
        public RpcResult<SaveAPaperRsp> SaveAPaper(SaveAPaperReq request)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(10000, 21);
            message.Data = request.ToByteArray();
            var response =  base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<SaveAPaperRsp>();
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
                result.Data = SaveAPaperRsp.Parser.ParseFrom(response.Data);
            }
            return result;
         }
        public async Task<RpcResult<APaperListRsp>> QueryAPaperListAsync(QueryAPaperReq request,int timeOut=3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(10000, 22);
            message.Data = request.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message,timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<APaperListRsp>();
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
                result.Data = APaperListRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        //同步方法
        public RpcResult<APaperListRsp> QueryAPaperList(QueryAPaperReq request)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(10000, 22);
            message.Data = request.ToByteArray();
            var response =  base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<APaperListRsp>();
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
                result.Data = APaperListRsp.Parser.ParseFrom(response.Data);
            }
            return result;
         }
        public async Task<RpcResult<APaperRsp>> GetAPaperAsync(GetAPaperReq request,int timeOut=3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(10000, 23);
            message.Data = request.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message,timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<APaperRsp>();
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
                result.Data = APaperRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        //同步方法
        public RpcResult<APaperRsp> GetAPaper(GetAPaperReq request)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(10000, 23);
            message.Data = request.ToByteArray();
            var response =  base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<APaperRsp>();
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
                result.Data = APaperRsp.Parser.ParseFrom(response.Data);
            }
            return result;
         }
     }
//end for class SurveyGateServiceClient
}
#endregion