using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_RenderTexture : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_RenderTexture() : base(typeof(UnityEngine.RenderTexture))
        {
            m_StaticProperties["active"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_RenderTexture(UnityEngine.RenderTexture.active), x=> UnityEngine.RenderTexture.active = WrapperHelper.UnwrapObject<UnityEngine.RenderTexture>(x));
            m_StaticProperties["enabled"] = new BSReflectionReference(() => UnityEngine.RenderTexture.enabled ? BSObject.One : BSObject.Zero, x=> UnityEngine.RenderTexture.enabled = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["SupportsStencil"] = new BSFunctionReference(new BSFunction("function SupportsStencil(rt)", a => UnityEngine.RenderTexture.SupportsStencil(WrapperHelper.UnwrapObject<UnityEngine.RenderTexture>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["ReleaseTemporary"] = new BSFunctionReference(new BSFunction("function ReleaseTemporary(temp)", a => {
                UnityEngine.RenderTexture.ReleaseTemporary(WrapperHelper.UnwrapObject<UnityEngine.RenderTexture>(a[0]));
                return new BSObject(null);
            }, 1));
            m_StaticProperties["GetTemporary"] = new BSFunctionReference(new BSFunction("function GetTemporary(desc)", a => new BSWrapperObject_UnityEngine_RenderTexture(UnityEngine.RenderTexture.GetTemporary(WrapperHelper.UnwrapObject<UnityEngine.RenderTextureDescriptor>(a[0]))), 1));
            m_StaticProperties["GetTemporary"] = new BSFunctionReference(new BSFunction("function GetTemporary(width, height, depthBuffer)", a => new BSWrapperObject_UnityEngine_RenderTexture(UnityEngine.RenderTexture.GetTemporary(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]))), 3));
            m_StaticProperties["GetTemporary"] = new BSFunctionReference(new BSFunction("function GetTemporary(width, height)", a => new BSWrapperObject_UnityEngine_RenderTexture(UnityEngine.RenderTexture.GetTemporary(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));

        }
    }

}