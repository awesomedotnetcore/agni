//Generated by Agni.Clients.Tools.AgniGluecCompiler

/* Auto generated by Glue Client Compiler tool (gluec)
on 2/18/2015 8:21:59 PM at SEXTOD by Anton
Do not modify this file by hand if you plan to regenerate this file again by the tool as manual changes will be lost
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using NFX.Glue;
using NFX.Glue.Protocol;


namespace Agni.Clients
{
// This implementation needs @Agni.@Contracts.@IRemoteTerminalClient, so
// it can be used with ServiceClientHub class

  ///<summary>
  /// Client for glued contract Agni.Contracts.IRemoteTerminal server.
  /// Each contract method has synchronous and asynchronous versions, the later denoted by 'Async_' prefix.
  /// May inject client-level inspectors here like so:
  ///   client.MsgInspectors.Register( new YOUR_CLIENT_INSPECTOR_TYPE());
  ///</summary>
  public class RemoteTerminal : ClientEndPoint, @Agni.@Contracts.@IRemoteTerminalClient
  {

  #region Static Members

     private static TypeSpec s_ts_CONTRACT;
     private static MethodSpec @s_ms_Connect_0;
     private static MethodSpec @s_ms_Execute_1;
     private static MethodSpec @s_ms_Disconnect_2;

     //static .ctor
     static RemoteTerminal()
     {
         var t = typeof(@Agni.@Contracts.@IRemoteTerminal);
         s_ts_CONTRACT = new TypeSpec(t);
         @s_ms_Connect_0 = new MethodSpec(t.GetMethod("Connect", new Type[]{ typeof(@System.@String) }));
         @s_ms_Execute_1 = new MethodSpec(t.GetMethod("Execute", new Type[]{ typeof(@System.@String) }));
         @s_ms_Disconnect_2 = new MethodSpec(t.GetMethod("Disconnect", new Type[]{  }));
     }
  #endregion

  #region .ctor
     public RemoteTerminal(string node, Binding binding = null) : base(node, binding) { ctor(); }
     public RemoteTerminal(Node node, Binding binding = null) : base(node, binding) { ctor(); }
     public RemoteTerminal(IGlue glue, string node, Binding binding = null) : base(glue, node, binding) { ctor(); }
     public RemoteTerminal(IGlue glue, Node node, Binding binding = null) : base(glue, node, binding) { ctor(); }

     //common instance .ctor body
     private void ctor()
     {

     }

  #endregion

     public override Type Contract
     {
       get { return typeof(@Agni.@Contracts.@IRemoteTerminal); }
     }



  #region Contract Methods

         ///<summary>
         /// Synchronous invoker for  'Agni.Contracts.IRemoteTerminal.Connect'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Agni.@Contracts.@RemoteTerminalInfo' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Agni.@Contracts.@RemoteTerminalInfo @Connect(@System.@String  @who)
         {
            var call = Async_Connect(@who);
            return call.GetValue<@Agni.@Contracts.@RemoteTerminalInfo>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Contracts.IRemoteTerminal.Connect'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Connect(@System.@String  @who)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Connect_0, false, RemoteInstance, new object[]{@who});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Contracts.IRemoteTerminal.Execute'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@System.@String' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @System.@String @Execute(@System.@String  @command)
         {
            var call = Async_Execute(@command);
            return call.GetValue<@System.@String>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Contracts.IRemoteTerminal.Execute'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Execute(@System.@String  @command)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Execute_1, false, RemoteInstance, new object[]{@command});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Agni.Contracts.IRemoteTerminal.Disconnect'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@System.@String' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @System.@String @Disconnect()
         {
            var call = Async_Disconnect();
            return call.GetValue<@System.@String>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Contracts.IRemoteTerminal.Disconnect'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Disconnect()
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Disconnect_2, false, RemoteInstance, new object[]{});
            return DispatchCall(request);
         }


  #endregion

  }//class
}//namespace
