//Generated by Agni.Clients.Tools.AgniGluecCompiler

/* Auto generated by Glue Client Compiler tool (gluec)
on 12/11/2017 10:45:22 PM at LAPCHENKO_DESK by User
Do not modify this file by hand if you plan to regenerate this file again by the tool as manual changes will be lost
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using NFX.Glue;
using NFX.Glue.Protocol;


namespace Agni.Social.Graph
{
// This implementation needs @Agni.@Social.@Graph.@IGraphCommentSystemClient, so
// it can be used with ServiceClientHub class

  ///<summary>
  /// Client for glued contract Agni.Social.Graph.IGraphCommentSystem server.
  /// Each contract method has synchronous and asynchronous versions, the later denoted by 'Async_' prefix.
  /// May inject client-level inspectors here like so:
  ///   client.MsgInspectors.Register( new YOUR_CLIENT_INSPECTOR_TYPE());
  ///</summary>
  public class GraphCommentSystemClient : ClientEndPoint, @Agni.@Social.@Graph.@IGraphCommentSystemClient
  {

  #region Static Members

     private static TypeSpec s_ts_CONTRACT;
     private static MethodSpec @s_ms_Create_0;
     private static MethodSpec s_ms_Respond_1;
     private static MethodSpec @s_ms_Update_2;
     private static MethodSpec @s_ms_DeleteComment_3;
     private static MethodSpec @s_ms_Like_4;
     private static MethodSpec @s_ms_IsCommentedByAuthor_5;
     private static MethodSpec @s_ms_GetNodeSummaries_6;
     private static MethodSpec @s_ms_Fetch_7;
     private static MethodSpec @s_ms_FetchResponses_8;
     private static MethodSpec @s_ms_FetchComplaints_9;
     private static MethodSpec @s_ms_GetComment_10;
     private static MethodSpec @s_ms_Complain_11;
     private static MethodSpec @s_ms_Justify_12;

     //static .ctor
     static GraphCommentSystemClient()
     {
         var t = typeof(@Agni.@Social.@Graph.@IGraphCommentSystem);
         s_ts_CONTRACT = new TypeSpec(t);
         @s_ms_Create_0 = new MethodSpec(t.GetMethod("Create", new Type[]{ typeof(@NFX.@DataAccess.@Distributed.@GDID), typeof(@NFX.@DataAccess.@Distributed.@GDID), typeof(@System.@String), typeof(@System.@String), typeof(@System.@Byte[]), typeof(@Agni.@Social.@Graph.@PublicationState), typeof(@Agni.@Social.@Graph.@RatingValue), typeof(@System.@Nullable<@System.@DateTime>) }));
         @s_ms_Respond_1 = new MethodSpec(t.GetMethod("Respond", new Type[]{ typeof(@NFX.@DataAccess.@Distributed.@GDID), typeof(@Agni.@Social.@Graph.@CommentID), typeof(@System.@String), typeof(@System.@Byte[]) }));
         @s_ms_Update_2 = new MethodSpec(t.GetMethod("Update", new Type[]{ typeof(@Agni.@Social.@Graph.@CommentID), typeof(@Agni.@Social.@Graph.@RatingValue), typeof(@System.@String), typeof(@System.@Byte[]) }));
         @s_ms_DeleteComment_3 = new MethodSpec(t.GetMethod("DeleteComment", new Type[]{ typeof(@Agni.@Social.@Graph.@CommentID) }));
         @s_ms_Like_4 = new MethodSpec(t.GetMethod("Like", new Type[]{ typeof(@Agni.@Social.@Graph.@CommentID), typeof(@System.@Int32), typeof(@System.@Int32) }));
         @s_ms_IsCommentedByAuthor_5 = new MethodSpec(t.GetMethod("IsCommentedByAuthor", new Type[]{ typeof(@NFX.@DataAccess.@Distributed.@GDID), typeof(@NFX.@DataAccess.@Distributed.@GDID), typeof(@System.@String) }));
         @s_ms_GetNodeSummaries_6 = new MethodSpec(t.GetMethod("GetNodeSummaries", new Type[]{ typeof(@NFX.@DataAccess.@Distributed.@GDID) }));
         @s_ms_Fetch_7 = new MethodSpec(t.GetMethod("Fetch", new Type[]{ typeof(@Agni.@Social.@Graph.@CommentQuery) }));
         @s_ms_FetchResponses_8 = new MethodSpec(t.GetMethod("FetchResponses", new Type[]{ typeof(@Agni.@Social.@Graph.@CommentID) }));
         @s_ms_FetchComplaints_9 = new MethodSpec(t.GetMethod("FetchComplaints", new Type[]{ typeof(@Agni.@Social.@Graph.@CommentID) }));
         @s_ms_GetComment_10 = new MethodSpec(t.GetMethod("GetComment", new Type[]{ typeof(@Agni.@Social.@Graph.@CommentID) }));
         @s_ms_Complain_11 = new MethodSpec(t.GetMethod("Complain", new Type[]{ typeof(@Agni.@Social.@Graph.@CommentID), typeof(@NFX.@DataAccess.@Distributed.@GDID), typeof(@System.@String), typeof(@System.@String) }));
         @s_ms_Justify_12 = new MethodSpec(t.GetMethod("Justify", new Type[]{ typeof(@Agni.@Social.@Graph.@CommentID) }));
     }
  #endregion

  #region .ctor
     public GraphCommentSystemClient(string node, Binding binding = null) : base(node, binding) { ctor(); }
     public GraphCommentSystemClient(Node node, Binding binding = null) : base(node, binding) { ctor(); }
     public GraphCommentSystemClient(IGlue glue, string node, Binding binding = null) : base(glue, node, binding) { ctor(); }
     public GraphCommentSystemClient(IGlue glue, Node node, Binding binding = null) : base(glue, node, binding) { ctor(); }

     //common instance .ctor body
     private void ctor()
     {

     }

  #endregion

     public override Type Contract
     {
       get { return typeof(@Agni.@Social.@Graph.@IGraphCommentSystem); }
     }



  #region Contract Methods

         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.Create'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Agni.@Social.@Graph.@Comment' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Agni.@Social.@Graph.@Comment @Create(@NFX.@DataAccess.@Distributed.@GDID  @gAuthorNode, @NFX.@DataAccess.@Distributed.@GDID  @gTargetNode, @System.@String  @dimension, @System.@String  @content, @System.@Byte[]  @data, @Agni.@Social.@Graph.@PublicationState  @publicationState, @Agni.@Social.@Graph.@RatingValue  @value, @System.@Nullable<@System.@DateTime>  @timeStamp)
         {
            var call = Async_Create(@gAuthorNode, @gTargetNode, @dimension, @content, @data, @publicationState, @value, @timeStamp);
            return call.GetValue<@Agni.@Social.@Graph.@Comment>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.Create'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Create(@NFX.@DataAccess.@Distributed.@GDID  @gAuthorNode, @NFX.@DataAccess.@Distributed.@GDID  @gTargetNode, @System.@String  @dimension, @System.@String  @content, @System.@Byte[]  @data, @Agni.@Social.@Graph.@PublicationState  @publicationState, @Agni.@Social.@Graph.@RatingValue  @value, @System.@Nullable<@System.@DateTime>  @timeStamp)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Create_0, false, RemoteInstance, new object[]{@gAuthorNode, @gTargetNode, @dimension, @content, @data, @publicationState, @value, @timeStamp});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.Response'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Agni.@Social.@Graph.@Comment' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Agni.@Social.@Graph.@Comment Respond(@NFX.@DataAccess.@Distributed.@GDID  @gAuthorNode, @Agni.@Social.@Graph.@CommentID  @parent, @System.@String  @content, @System.@Byte[]  @data)
         {
            var call = Async_Respond(@gAuthorNode, @parent, @content, @data);
            return call.GetValue<@Agni.@Social.@Graph.@Comment>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.Response'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Respond(@NFX.@DataAccess.@Distributed.@GDID  @gAuthorNode, @Agni.@Social.@Graph.@CommentID  @parent, @System.@String  @content, @System.@Byte[]  @data)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, s_ms_Respond_1, false, RemoteInstance, new object[]{@gAuthorNode, @parent, @content, @data});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.Update'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Agni.@Social.@Graph.@GraphChangeStatus' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Agni.@Social.@Graph.@GraphChangeStatus @Update(@Agni.@Social.@Graph.@CommentID  @ratingId, @Agni.@Social.@Graph.@RatingValue  @value, @System.@String  @content, @System.@Byte[]  @data)
         {
            var call = Async_Update(@ratingId, @value, @content, @data);
            return call.GetValue<@Agni.@Social.@Graph.@GraphChangeStatus>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.Update'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Update(@Agni.@Social.@Graph.@CommentID  @ratingId, @Agni.@Social.@Graph.@RatingValue  @value, @System.@String  @content, @System.@Byte[]  @data)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Update_2, false, RemoteInstance, new object[]{@ratingId, @value, @content, @data});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.DeleteComment'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Agni.@Social.@Graph.@GraphChangeStatus' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Agni.@Social.@Graph.@GraphChangeStatus @DeleteComment(@Agni.@Social.@Graph.@CommentID  @commentId)
         {
            var call = Async_DeleteComment(@commentId);
            return call.GetValue<@Agni.@Social.@Graph.@GraphChangeStatus>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.DeleteComment'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_DeleteComment(@Agni.@Social.@Graph.@CommentID  @commentId)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_DeleteComment_3, false, RemoteInstance, new object[]{@commentId});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.Like'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Agni.@Social.@Graph.@GraphChangeStatus' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Agni.@Social.@Graph.@GraphChangeStatus @Like(@Agni.@Social.@Graph.@CommentID  @commentId, @System.@Int32  @deltaLike, @System.@Int32  @deltaDislike)
         {
            var call = Async_Like(@commentId, @deltaLike, @deltaDislike);
            return call.GetValue<@Agni.@Social.@Graph.@GraphChangeStatus>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.Like'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Like(@Agni.@Social.@Graph.@CommentID  @commentId, @System.@Int32  @deltaLike, @System.@Int32  @deltaDislike)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Like_4, false, RemoteInstance, new object[]{@commentId, @deltaLike, @deltaDislike});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.IsCommentedByAuthor'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@System.@Boolean' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @System.@Boolean @IsCommentedByAuthor(@NFX.@DataAccess.@Distributed.@GDID  @gNode, @NFX.@DataAccess.@Distributed.@GDID  @gAuthor, @System.@String  @dimension)
         {
            var call = Async_IsCommentedByAuthor(@gNode, @gAuthor, @dimension);
            return call.GetValue<@System.@Boolean>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.IsCommentedByAuthor'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_IsCommentedByAuthor(@NFX.@DataAccess.@Distributed.@GDID  @gNode, @NFX.@DataAccess.@Distributed.@GDID  @gAuthor, @System.@String  @dimension)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_IsCommentedByAuthor_5, false, RemoteInstance, new object[]{@gNode, @gAuthor, @dimension});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.GetNodeSummaries'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@System.@Collections.@Generic.@IEnumerable<@Agni.@Social.@Graph.@SummaryRating>' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @System.@Collections.@Generic.@IEnumerable<@Agni.@Social.@Graph.@SummaryRating> @GetNodeSummaries(@NFX.@DataAccess.@Distributed.@GDID  @gNode)
         {
            var call = Async_GetNodeSummaries(@gNode);
            return call.GetValue<@System.@Collections.@Generic.@IEnumerable<@Agni.@Social.@Graph.@SummaryRating>>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.GetNodeSummaries'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_GetNodeSummaries(@NFX.@DataAccess.@Distributed.@GDID  @gNode)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_GetNodeSummaries_6, false, RemoteInstance, new object[]{@gNode});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.Fetch'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@System.@Collections.@Generic.@IEnumerable<@Agni.@Social.@Graph.@Comment>' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @System.@Collections.@Generic.@IEnumerable<@Agni.@Social.@Graph.@Comment> @Fetch(@Agni.@Social.@Graph.@CommentQuery  @query)
         {
            var call = Async_Fetch(@query);
            return call.GetValue<@System.@Collections.@Generic.@IEnumerable<@Agni.@Social.@Graph.@Comment>>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.Fetch'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Fetch(@Agni.@Social.@Graph.@CommentQuery  @query)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Fetch_7, false, RemoteInstance, new object[]{@query});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.FetchResponses'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@System.@Collections.@Generic.@IEnumerable<@Agni.@Social.@Graph.@Comment>' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @System.@Collections.@Generic.@IEnumerable<@Agni.@Social.@Graph.@Comment> @FetchResponses(@Agni.@Social.@Graph.@CommentID  @commentId)
         {
            var call = Async_FetchResponses(@commentId);
            return call.GetValue<@System.@Collections.@Generic.@IEnumerable<@Agni.@Social.@Graph.@Comment>>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.FetchResponses'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_FetchResponses(@Agni.@Social.@Graph.@CommentID  @commentId)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_FetchResponses_8, false, RemoteInstance, new object[]{@commentId});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.FetchComplaints'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@System.@Collections.@Generic.@IEnumerable<@Agni.@Social.@Graph.@Complaint>' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @System.@Collections.@Generic.@IEnumerable<@Agni.@Social.@Graph.@Complaint> @FetchComplaints(@Agni.@Social.@Graph.@CommentID  @commentId)
         {
            var call = Async_FetchComplaints(@commentId);
            return call.GetValue<@System.@Collections.@Generic.@IEnumerable<@Agni.@Social.@Graph.@Complaint>>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.FetchComplaints'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_FetchComplaints(@Agni.@Social.@Graph.@CommentID  @commentId)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_FetchComplaints_9, false, RemoteInstance, new object[]{@commentId});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.GetComment'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Agni.@Social.@Graph.@Comment' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Agni.@Social.@Graph.@Comment @GetComment(@Agni.@Social.@Graph.@CommentID  @commentId)
         {
            var call = Async_GetComment(@commentId);
            return call.GetValue<@Agni.@Social.@Graph.@Comment>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.GetComment'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_GetComment(@Agni.@Social.@Graph.@CommentID  @commentId)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_GetComment_10, false, RemoteInstance, new object[]{@commentId});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.Complain'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Agni.@Social.@Graph.@GraphChangeStatus' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Agni.@Social.@Graph.@GraphChangeStatus @Complain(@Agni.@Social.@Graph.@CommentID  @commentId, @NFX.@DataAccess.@Distributed.@GDID  @gAuthorNode, @System.@String  @kind, @System.@String  @message)
         {
            var call = Async_Complain(@commentId, @gAuthorNode, @kind, @message);
            return call.GetValue<@Agni.@Social.@Graph.@GraphChangeStatus>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.Complain'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Complain(@Agni.@Social.@Graph.@CommentID  @commentId, @NFX.@DataAccess.@Distributed.@GDID  @gAuthorNode, @System.@String  @kind, @System.@String  @message)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Complain_11, false, RemoteInstance, new object[]{@commentId, @gAuthorNode, @kind, @message});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.Justify'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Agni.@Social.@Graph.@GraphChangeStatus' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Agni.@Social.@Graph.@GraphChangeStatus @Justify(@Agni.@Social.@Graph.@CommentID  @commentID)
         {
            var call = Async_Justify(@commentID);
            return call.GetValue<@Agni.@Social.@Graph.@GraphChangeStatus>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Social.Graph.IGraphCommentSystem.Justify'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Justify(@Agni.@Social.@Graph.@CommentID  @commentID)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Justify_12, false, RemoteInstance, new object[]{@commentID});
            return DispatchCall(request);
         }


  #endregion

  }//class
}//namespace
