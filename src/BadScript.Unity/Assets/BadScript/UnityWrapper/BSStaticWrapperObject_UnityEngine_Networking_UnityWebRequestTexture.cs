using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Networking_UnityWebRequestTexture : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Networking_UnityWebRequestTexture() : base(
            typeof( UnityWebRequestTexture ) )
        {
            m_StaticProperties["GetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTexture(uri)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequestTexture.GetTexture( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTexture(uri)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequestTexture.GetTexture( WrapperHelper.UnwrapObject < Uri >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTexture(uri, nonReadable)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequestTexture.GetTexture(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTexture(uri, nonReadable)",
                    a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                        UnityWebRequestTexture.GetTexture(
                            WrapperHelper.UnwrapObject < Uri >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
