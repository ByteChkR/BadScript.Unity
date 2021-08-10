using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Networking_DownloadHandlerBuffer : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Networking_DownloadHandlerBuffer() : base(
            typeof( DownloadHandlerBuffer ) )
        {
            m_StaticProperties["GetContent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetContent(www)",
                    a => new BSObject(
                        DownloadHandlerBuffer.GetContent( WrapperHelper.UnwrapObject < UnityWebRequest >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
