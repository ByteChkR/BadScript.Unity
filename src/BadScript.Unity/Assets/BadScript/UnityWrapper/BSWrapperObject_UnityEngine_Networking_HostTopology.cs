using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Networking_HostTopology : BSWrapperObject < HostTopology >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Networking_HostTopology( HostTopology obj ) : base( obj )
        {
            m_Properties["DefaultConfig"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Networking_ConnectionConfig( m_InternalObject.DefaultConfig ),
                null );

            m_Properties["MaxDefaultConnections"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MaxDefaultConnections ),
                null );

            m_Properties["SpecialConnectionConfigsCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.SpecialConnectionConfigsCount ),
                null );

            m_Properties["ReceivedMessagePoolSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.ReceivedMessagePoolSize ),
                x => m_InternalObject.ReceivedMessagePoolSize = WrapperHelper.UnwrapObject < ushort >( x ) );

            m_Properties["SentMessagePoolSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.SentMessagePoolSize ),
                x => m_InternalObject.SentMessagePoolSize = WrapperHelper.UnwrapObject < ushort >( x ) );

            m_Properties["MessagePoolSizeGrowthFactor"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MessagePoolSizeGrowthFactor ),
                x => m_InternalObject.MessagePoolSizeGrowthFactor = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["GetSpecialConnectionConfig"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSpecialConnectionConfig(i)",
                    a => new BSWrapperObject_UnityEngine_Networking_ConnectionConfig(
                        m_InternalObject.GetSpecialConnectionConfig( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["AddSpecialConnectionConfig"] = new BSFunctionReference(
                new BSFunction(
                    "function AddSpecialConnectionConfig(config)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.AddSpecialConnectionConfig(
                            WrapperHelper.UnwrapObject < ConnectionConfig >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
