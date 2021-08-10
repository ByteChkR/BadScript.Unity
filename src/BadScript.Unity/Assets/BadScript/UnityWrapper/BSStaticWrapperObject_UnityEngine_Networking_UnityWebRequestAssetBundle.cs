using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Networking_UnityWebRequestAssetBundle : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Networking_UnityWebRequestAssetBundle() : base(
            typeof( UnityWebRequestAssetBundle ) )
        {
            m_StaticProperties["GetAssetBundle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAssetBundle(uri)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequestAssetBundle.GetAssetBundle( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetAssetBundle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAssetBundle(uri)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequestAssetBundle.GetAssetBundle( WrapperHelper.UnwrapObject < Uri >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetAssetBundle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAssetBundle(uri, crc)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequestAssetBundle.GetAssetBundle(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetAssetBundle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAssetBundle(uri, crc)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequestAssetBundle.GetAssetBundle(
                            WrapperHelper.UnwrapObject < Uri >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetAssetBundle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAssetBundle(uri, version, crc)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequestAssetBundle.GetAssetBundle(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["GetAssetBundle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAssetBundle(uri, version, crc)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequestAssetBundle.GetAssetBundle(
                            WrapperHelper.UnwrapObject < Uri >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["GetAssetBundle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAssetBundle(uri, hash, crc)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequestAssetBundle.GetAssetBundle(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Hash128 >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["GetAssetBundle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAssetBundle(uri, hash, crc)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequestAssetBundle.GetAssetBundle(
                            WrapperHelper.UnwrapObject < Uri >( a[0] ),
                            WrapperHelper.UnwrapObject < Hash128 >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["GetAssetBundle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAssetBundle(uri, cachedAssetBundle, crc)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequestAssetBundle.GetAssetBundle(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < CachedAssetBundle >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["GetAssetBundle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAssetBundle(uri, cachedAssetBundle, crc)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequestAssetBundle.GetAssetBundle(
                            WrapperHelper.UnwrapObject < Uri >( a[0] ),
                            WrapperHelper.UnwrapObject < CachedAssetBundle >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}
