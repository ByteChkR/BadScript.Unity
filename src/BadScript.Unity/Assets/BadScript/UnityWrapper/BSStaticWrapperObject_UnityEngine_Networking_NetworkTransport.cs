using System.Net;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Networking_NetworkTransport : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Networking_NetworkTransport() : base( typeof( NetworkTransport ) )
        {
            m_StaticProperties["IsStarted"] = new BSReflectionReference(
                () => NetworkTransport.IsStarted ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["DoesEndPointUsePlatformProtocols"] = new BSFunctionReference(
                new BSFunction(
                    "function DoesEndPointUsePlatformProtocols(endPoint)",
                    a => NetworkTransport.DoesEndPointUsePlatformProtocols(
                        WrapperHelper.UnwrapObject < EndPoint >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetAssetId"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAssetId(go)",
                    a => new BSObject(
                        NetworkTransport.GetAssetId( WrapperHelper.UnwrapObject < GameObject >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["AddHostWithSimulator"] = new BSFunctionReference(
                new BSFunction(
                    "function AddHostWithSimulator(topology, minTimeout, maxTimeout, port, ip)",
                    a => new BSObject(
                        ( decimal ) NetworkTransport.AddHostWithSimulator(
                            WrapperHelper.UnwrapObject < HostTopology >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < string >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["AddHostWithSimulator"] = new BSFunctionReference(
                new BSFunction(
                    "function AddHostWithSimulator(topology, minTimeout, maxTimeout, port)",
                    a => new BSObject(
                        ( decimal ) NetworkTransport.AddHostWithSimulator(
                            WrapperHelper.UnwrapObject < HostTopology >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["AddHostWithSimulator"] = new BSFunctionReference(
                new BSFunction(
                    "function AddHostWithSimulator(topology, minTimeout, maxTimeout)",
                    a => new BSObject(
                        ( decimal ) NetworkTransport.AddHostWithSimulator(
                            WrapperHelper.UnwrapObject < HostTopology >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["AddHost"] = new BSFunctionReference(
                new BSFunction(
                    "function AddHost(topology, port, ip)",
                    a => new BSObject(
                        ( decimal ) NetworkTransport.AddHost(
                            WrapperHelper.UnwrapObject < HostTopology >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["AddHost"] = new BSFunctionReference(
                new BSFunction(
                    "function AddHost(topology, port)",
                    a => new BSObject(
                        ( decimal ) NetworkTransport.AddHost(
                            WrapperHelper.UnwrapObject < HostTopology >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["AddHost"] = new BSFunctionReference(
                new BSFunction(
                    "function AddHost(topology)",
                    a => new BSObject(
                        ( decimal ) NetworkTransport.AddHost( WrapperHelper.UnwrapObject < HostTopology >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["AddWebsocketHost"] = new BSFunctionReference(
                new BSFunction(
                    "function AddWebsocketHost(topology, port, ip)",
                    a => new BSObject(
                        ( decimal ) NetworkTransport.AddWebsocketHost(
                            WrapperHelper.UnwrapObject < HostTopology >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["AddWebsocketHost"] = new BSFunctionReference(
                new BSFunction(
                    "function AddWebsocketHost(topology, port)",
                    a => new BSObject(
                        ( decimal ) NetworkTransport.AddWebsocketHost(
                            WrapperHelper.UnwrapObject < HostTopology >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["RemoveHost"] = new BSFunctionReference(
                new BSFunction(
                    "function RemoveHost(hostId)",
                    a => NetworkTransport.RemoveHost( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetHostPort"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHostPort(hostId)",
                    a => new BSObject(
                        ( decimal ) NetworkTransport.GetHostPort( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadEncryptionLibrary"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadEncryptionLibrary(libraryName)",
                    a => NetworkTransport.LoadEncryptionLibrary( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetEncryptionSafeMaxPacketSize"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEncryptionSafeMaxPacketSize(maxPacketSize)",
                    a => new BSObject(
                        ( decimal ) NetworkTransport.GetEncryptionSafeMaxPacketSize(
                            WrapperHelper.UnwrapObject < short >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
