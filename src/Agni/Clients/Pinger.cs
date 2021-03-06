//Generated by Agni.Clients.Tools.AgniGluecCompiler

/* Auto generated by Glue Client Compiler tool (gluec)
on 4/4/2017 8:51:29 PM at CNONIM-PC by cnonim
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
// This implementation needs @Agni.@Contracts.@IPingerClient, so
// it can be used with ServiceClientHub class

  ///<summary>
  /// Client for glued contract Agni.Contracts.IPinger server.
  /// Each contract method has synchronous and asynchronous versions, the later denoted by 'Async_' prefix.
  /// May inject client-level inspectors here like so:
  ///   client.MsgInspectors.Register( new YOUR_CLIENT_INSPECTOR_TYPE());
  ///</summary>
  public class Pinger : ClientEndPoint, @Agni.@Contracts.@IPingerClient
  {

  #region Static Members

     private static TypeSpec s_ts_CONTRACT;
     private static MethodSpec @s_ms_Ping_0;

     //static .ctor
     static Pinger()
     {
         var t = typeof(@Agni.@Contracts.@IPinger);
         s_ts_CONTRACT = new TypeSpec(t);
         @s_ms_Ping_0 = new MethodSpec(t.GetMethod("Ping", new Type[]{  }));
     }
  #endregion

  #region .ctor
     public Pinger(string node, Binding binding = null) : base(node, binding) { ctor(); }
     public Pinger(Node node, Binding binding = null) : base(node, binding) { ctor(); }
     public Pinger(IGlue glue, string node, Binding binding = null) : base(glue, node, binding) { ctor(); }
     public Pinger(IGlue glue, Node node, Binding binding = null) : base(glue, node, binding) { ctor(); }

     //common instance .ctor body
     private void ctor()
     {

     }

  #endregion

     public override Type Contract
     {
       get { return typeof(@Agni.@Contracts.@IPinger); }
     }



  #region Contract Methods

         ///<summary>
         /// Synchronous invoker for  'Agni.Contracts.IPinger.Ping'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public void @Ping()
         {
            var call = Async_Ping();
            call.CheckVoidValue();
         }

         ///<summary>
         /// Asynchronous invoker for  'Agni.Contracts.IPinger.Ping'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Ping()
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Ping_0, false, RemoteInstance, new object[]{});
            return DispatchCall(request);
         }


  #endregion

  }//class
}//namespace
