using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_ScreenCapture : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_ScreenCapture() : base( typeof( ScreenCapture ) )
        {
            m_StaticProperties["CaptureScreenshotAsTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function CaptureScreenshotAsTexture(superSize)",
                    a => new BSWrapperObject_UnityEngine_Texture2D(
                        ScreenCapture.CaptureScreenshotAsTexture( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
