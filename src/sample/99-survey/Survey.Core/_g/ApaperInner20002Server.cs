// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: service/inner/apaper_inner_20002.proto
#region Designer generated code

using System; 
using System.Threading.Tasks; 
using DotBPE.Rpc; 
using DotBPE.Protocol.Amp; 
using Google.Protobuf; 

namespace Survey.Core {

//start for class AbstractAPaperInnerService
   public abstract class APaperInnerServiceBase : ServiceActor 
   {
      protected override int ServiceId => 20002;
      //调用委托
      private async Task<AmpMessage> ProcessSaveAPaperAsync(AmpMessage req)
      {
         SaveAPaperReq request = null;

         if(req.Data == null ){
            request = new SaveAPaperReq();
         }
         else {
            request = SaveAPaperReq.Parser.ParseFrom(req.Data);
         }

         var result = await SaveAPaperAsync(request);
         var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);
         response.Code = result.Code;
         if( result.Data !=null )
         {
             response.Data = result.Data.ToByteArray();
         }
         return response;
      }

      //抽象方法
      public abstract Task<RpcResult<SaveAPaperRsp>> SaveAPaperAsync(SaveAPaperReq request);
      //调用委托
      private async Task<AmpMessage> ProcessQueryAPaperListAsync(AmpMessage req)
      {
         QueryAPaperReq request = null;

         if(req.Data == null ){
            request = new QueryAPaperReq();
         }
         else {
            request = QueryAPaperReq.Parser.ParseFrom(req.Data);
         }

         var result = await QueryAPaperListAsync(request);
         var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);
         response.Code = result.Code;
         if( result.Data !=null )
         {
             response.Data = result.Data.ToByteArray();
         }
         return response;
      }

      //抽象方法
      public abstract Task<RpcResult<APaperListRsp>> QueryAPaperListAsync(QueryAPaperReq request);
      //调用委托
      private async Task<AmpMessage> ProcessGetAPaperAsync(AmpMessage req)
      {
         GetAPaperReq request = null;

         if(req.Data == null ){
            request = new GetAPaperReq();
         }
         else {
            request = GetAPaperReq.Parser.ParseFrom(req.Data);
         }

         var result = await GetAPaperAsync(request);
         var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);
         response.Code = result.Code;
         if( result.Data !=null )
         {
             response.Data = result.Data.ToByteArray();
         }
         return response;
      }

      //抽象方法
      public abstract Task<RpcResult<APaperRsp>> GetAPaperAsync(GetAPaperReq request);
      //调用委托
      private async Task<AmpMessage> ProcessGetAPaperStaAsync(AmpMessage req)
      {
         GetAPaperStaDetailReq request = null;

         if(req.Data == null ){
            request = new GetAPaperStaDetailReq();
         }
         else {
            request = GetAPaperStaDetailReq.Parser.ParseFrom(req.Data);
         }

         var result = await GetAPaperStaAsync(request);
         var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);
         response.Code = result.Code;
         if( result.Data !=null )
         {
             response.Data = result.Data.ToByteArray();
         }
         return response;
      }

      //抽象方法
      public abstract Task<RpcResult<APaperStaDetailRsp>> GetAPaperStaAsync(GetAPaperStaDetailReq request);
      public override Task<AmpMessage> ProcessAsync(AmpMessage req)
      {
         switch(req.MessageId){
            //方法APaperInnerService.SaveAPaper
            case 1: return this.ProcessSaveAPaperAsync(req);
            //方法APaperInnerService.QueryAPaperList
            case 2: return this.ProcessQueryAPaperListAsync(req);
            //方法APaperInnerService.GetAPaper
            case 3: return this.ProcessGetAPaperAsync(req);
            //方法APaperInnerService.GetAPaperSta
            case 4: return this.ProcessGetAPaperStaAsync(req);
            default: return base.ProcessNotFoundAsync(req);
         }
      }
   }
//end for class AbstractAPaperInnerService
}

#endregion

