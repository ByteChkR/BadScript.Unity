using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking.PlayerConnection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Networking_PlayerConnection_PlayerConnection : BSWrapperObject < PlayerConnection >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Networking_PlayerConnection_PlayerConnection( PlayerConnection obj ) : base(
            obj )
        {
            m_Properties["isConnected"] = new BSReflectionReference(
                () => m_InternalObject.isConnected ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["BlockUntilRecvMsg"] = new BSFunctionReference(
                new BSFunction(
                    "function BlockUntilRecvMsg(messageId, timeout)",
                    a => m_InternalObject.BlockUntilRecvMsg(
                        WrapperHelper.UnwrapObject < Guid >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
