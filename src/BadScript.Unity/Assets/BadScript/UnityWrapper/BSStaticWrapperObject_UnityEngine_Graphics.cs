using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Graphics : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Graphics() : base( typeof( Graphics ) )
        {
            m_StaticProperties["preserveFramebufferAlpha"] = new BSReflectionReference(
                () => Graphics.preserveFramebufferAlpha ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["activeColorBuffer"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderBuffer( Graphics.activeColorBuffer ),
                null );

            m_StaticProperties["activeDepthBuffer"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderBuffer( Graphics.activeDepthBuffer ),
                null );

            m_StaticProperties["ConvertTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function ConvertTexture(src, dst)",
                    a => Graphics.ConvertTexture(
                        WrapperHelper.UnwrapObject < Texture >( a[0] ),
                        WrapperHelper.UnwrapObject < Texture >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["ConvertTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function ConvertTexture(src, srcElement, dst, dstElement)",
                    a => Graphics.ConvertTexture(
                        WrapperHelper.UnwrapObject < Texture >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ),
                        WrapperHelper.UnwrapObject < Texture >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

        }

        #endregion
    }

}
