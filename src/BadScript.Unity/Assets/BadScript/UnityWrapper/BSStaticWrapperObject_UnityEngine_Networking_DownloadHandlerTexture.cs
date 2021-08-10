using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Networking_DownloadHandlerTexture : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Networking_DownloadHandlerTexture() : base(
            typeof( DownloadHandlerTexture ) )
        {
            m_StaticProperties["GetContent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetContent(www)",
                    a => new BSWrapperObject_UnityEngine_Texture2D(
                        DownloadHandlerTexture.GetContent( WrapperHelper.UnwrapObject < UnityWebRequest >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
