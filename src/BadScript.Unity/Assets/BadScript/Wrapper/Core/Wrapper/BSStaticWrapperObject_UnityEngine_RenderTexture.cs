using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_RenderTexture : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_RenderTexture() : base( typeof( RenderTexture ) )
        {
            m_StaticProperties["active"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderTexture( RenderTexture.active ),
                x => RenderTexture.active = WrapperHelper.UnwrapObject < RenderTexture >( x ) );

            m_StaticProperties["enabled"] = new BSReflectionReference(
                () => RenderTexture.enabled ? BSObject.One : BSObject.Zero,
                x => RenderTexture.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["SupportsStencil"] = new BSFunctionReference(
                new BSFunction(
                    "function SupportsStencil(rt)",
                    a => RenderTexture.SupportsStencil( WrapperHelper.UnwrapObject < RenderTexture >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["ReleaseTemporary"] = new BSFunctionReference(
                new BSFunction(
                    "function ReleaseTemporary(temp)",
                    a =>
                    {
                        RenderTexture.ReleaseTemporary( WrapperHelper.UnwrapObject < RenderTexture >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["GetTemporary"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTemporary(desc)",
                    a => new BSWrapperObject_UnityEngine_RenderTexture(
                        RenderTexture.GetTemporary( WrapperHelper.UnwrapObject < RenderTextureDescriptor >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetTemporary"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTemporary(width, height, depthBuffer)",
                    a => new BSWrapperObject_UnityEngine_RenderTexture(
                        RenderTexture.GetTemporary(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["GetTemporary"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTemporary(width, height)",
                    a => new BSWrapperObject_UnityEngine_RenderTexture(
                        RenderTexture.GetTemporary(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
