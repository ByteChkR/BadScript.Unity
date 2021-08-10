using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Networking_ConnectionConfig : BSWrapperObject < ConnectionConfig >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Networking_ConnectionConfig( ConnectionConfig obj ) : base( obj )
        {
            m_Properties["PacketSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.PacketSize ),
                x => m_InternalObject.PacketSize = WrapperHelper.UnwrapObject < ushort >( x ) );

            m_Properties["FragmentSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.FragmentSize ),
                x => m_InternalObject.FragmentSize = WrapperHelper.UnwrapObject < ushort >( x ) );

            m_Properties["ResendTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.ResendTimeout ),
                x => m_InternalObject.ResendTimeout = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["DisconnectTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.DisconnectTimeout ),
                x => m_InternalObject.DisconnectTimeout = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["ConnectTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.ConnectTimeout ),
                x => m_InternalObject.ConnectTimeout = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["MinUpdateTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MinUpdateTimeout ),
                x => m_InternalObject.MinUpdateTimeout = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["PingTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.PingTimeout ),
                x => m_InternalObject.PingTimeout = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["ReducedPingTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.ReducedPingTimeout ),
                x => m_InternalObject.ReducedPingTimeout = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["AllCostTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.AllCostTimeout ),
                x => m_InternalObject.AllCostTimeout = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["NetworkDropThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.NetworkDropThreshold ),
                x => m_InternalObject.NetworkDropThreshold = WrapperHelper.UnwrapObject < byte >( x ) );

            m_Properties["OverflowDropThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.OverflowDropThreshold ),
                x => m_InternalObject.OverflowDropThreshold = WrapperHelper.UnwrapObject < byte >( x ) );

            m_Properties["MaxConnectionAttempt"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MaxConnectionAttempt ),
                x => m_InternalObject.MaxConnectionAttempt = WrapperHelper.UnwrapObject < byte >( x ) );

            m_Properties["AckDelay"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.AckDelay ),
                x => m_InternalObject.AckDelay = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["SendDelay"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.SendDelay ),
                x => m_InternalObject.SendDelay = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["MaxCombinedReliableMessageSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MaxCombinedReliableMessageSize ),
                x => m_InternalObject.MaxCombinedReliableMessageSize = WrapperHelper.UnwrapObject < ushort >( x ) );

            m_Properties["MaxCombinedReliableMessageCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MaxCombinedReliableMessageCount ),
                x => m_InternalObject.MaxCombinedReliableMessageCount = WrapperHelper.UnwrapObject < ushort >( x ) );

            m_Properties["MaxSentMessageQueueSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MaxSentMessageQueueSize ),
                x => m_InternalObject.MaxSentMessageQueueSize = WrapperHelper.UnwrapObject < ushort >( x ) );

            m_Properties["IsAcksLong"] = new BSReflectionReference(
                () => m_InternalObject.IsAcksLong ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.IsAcksLong = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["UsePlatformSpecificProtocols"] = new BSReflectionReference(
                () => m_InternalObject.UsePlatformSpecificProtocols ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.UsePlatformSpecificProtocols = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["InitialBandwidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.InitialBandwidth ),
                x => m_InternalObject.InitialBandwidth = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["BandwidthPeakFactor"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.BandwidthPeakFactor ),
                x => m_InternalObject.BandwidthPeakFactor = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["WebSocketReceiveBufferMaxSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.WebSocketReceiveBufferMaxSize ),
                x => m_InternalObject.WebSocketReceiveBufferMaxSize = WrapperHelper.UnwrapObject < ushort >( x ) );

            m_Properties["UdpSocketReceiveBufferMaxSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.UdpSocketReceiveBufferMaxSize ),
                x => m_InternalObject.UdpSocketReceiveBufferMaxSize = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["SSLCertFilePath"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.SSLCertFilePath ),
                x => m_InternalObject.SSLCertFilePath = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["SSLPrivateKeyFilePath"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.SSLPrivateKeyFilePath ),
                x => m_InternalObject.SSLPrivateKeyFilePath = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["SSLCAFilePath"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.SSLCAFilePath ),
                x => m_InternalObject.SSLCAFilePath = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["ChannelCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.ChannelCount ),
                null );

            m_Properties["SharedOrderChannelCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.SharedOrderChannelCount ),
                null );

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
