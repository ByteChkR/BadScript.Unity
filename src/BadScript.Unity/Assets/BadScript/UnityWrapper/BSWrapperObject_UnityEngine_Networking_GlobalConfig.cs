using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Networking_GlobalConfig : BSWrapperObject < GlobalConfig >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Networking_GlobalConfig( GlobalConfig obj ) : base( obj )
        {
            m_Properties["ThreadAwakeTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.ThreadAwakeTimeout ),
                x => m_InternalObject.ThreadAwakeTimeout = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["ReactorMaximumReceivedMessages"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.ReactorMaximumReceivedMessages ),
                x => m_InternalObject.ReactorMaximumReceivedMessages = WrapperHelper.UnwrapObject < ushort >( x ) );

            m_Properties["ReactorMaximumSentMessages"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.ReactorMaximumSentMessages ),
                x => m_InternalObject.ReactorMaximumSentMessages = WrapperHelper.UnwrapObject < ushort >( x ) );

            m_Properties["MaxPacketSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MaxPacketSize ),
                x => m_InternalObject.MaxPacketSize = WrapperHelper.UnwrapObject < ushort >( x ) );

            m_Properties["MaxHosts"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MaxHosts ),
                x => m_InternalObject.MaxHosts = WrapperHelper.UnwrapObject < ushort >( x ) );

            m_Properties["ThreadPoolSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.ThreadPoolSize ),
                x => m_InternalObject.ThreadPoolSize = WrapperHelper.UnwrapObject < byte >( x ) );

            m_Properties["MinTimerTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MinTimerTimeout ),
                x => m_InternalObject.MinTimerTimeout = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["MaxTimerTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MaxTimerTimeout ),
                x => m_InternalObject.MaxTimerTimeout = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["MinNetSimulatorTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MinNetSimulatorTimeout ),
                x => m_InternalObject.MinNetSimulatorTimeout = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["MaxNetSimulatorTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MaxNetSimulatorTimeout ),
                x => m_InternalObject.MaxNetSimulatorTimeout = WrapperHelper.UnwrapObject < uint >( x ) );

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
