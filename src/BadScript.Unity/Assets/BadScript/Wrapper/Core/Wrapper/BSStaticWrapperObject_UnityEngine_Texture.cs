using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Texture : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Texture() : base(typeof(UnityEngine.Texture))
        {
            m_StaticProperties["masterTextureLimit"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Texture.masterTextureLimit), x=> UnityEngine.Texture.masterTextureLimit = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_StaticProperties["totalTextureMemory"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Texture.totalTextureMemory), null);
            m_StaticProperties["desiredTextureMemory"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Texture.desiredTextureMemory), null);
            m_StaticProperties["targetTextureMemory"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Texture.targetTextureMemory), null);
            m_StaticProperties["currentTextureMemory"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Texture.currentTextureMemory), null);
            m_StaticProperties["nonStreamingTextureMemory"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Texture.nonStreamingTextureMemory), null);
            m_StaticProperties["streamingMipmapUploadCount"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Texture.streamingMipmapUploadCount), null);
            m_StaticProperties["streamingRendererCount"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Texture.streamingRendererCount), null);
            m_StaticProperties["streamingTextureCount"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Texture.streamingTextureCount), null);
            m_StaticProperties["nonStreamingTextureCount"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Texture.nonStreamingTextureCount), null);
            m_StaticProperties["streamingTexturePendingLoadCount"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Texture.streamingTexturePendingLoadCount), null);
            m_StaticProperties["streamingTextureLoadingCount"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Texture.streamingTextureLoadingCount), null);
            m_StaticProperties["streamingTextureForceLoadAll"] = new BSReflectionReference(() => UnityEngine.Texture.streamingTextureForceLoadAll ? BSObject.One : BSObject.Zero, x=> UnityEngine.Texture.streamingTextureForceLoadAll = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["streamingTextureDiscardUnusedMips"] = new BSReflectionReference(() => UnityEngine.Texture.streamingTextureDiscardUnusedMips ? BSObject.One : BSObject.Zero, x=> UnityEngine.Texture.streamingTextureDiscardUnusedMips = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["allowThreadedTextureCreation"] = new BSReflectionReference(() => UnityEngine.Texture.allowThreadedTextureCreation ? BSObject.One : BSObject.Zero, x=> UnityEngine.Texture.allowThreadedTextureCreation = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["GenerateAllMips"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Texture.GenerateAllMips), null);
            m_StaticProperties["SetGlobalAnisotropicFilteringLimits"] = new BSFunctionReference(new BSFunction("function SetGlobalAnisotropicFilteringLimits(forcedMin, globalMax)", a => {
                UnityEngine.Texture.SetGlobalAnisotropicFilteringLimits(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetStreamingTextureMaterialDebugProperties"] = new BSFunctionReference(new BSFunction("function SetStreamingTextureMaterialDebugProperties()", a => {
                UnityEngine.Texture.SetStreamingTextureMaterialDebugProperties();
                return new BSObject(null);
            }, 0));

        }
    }

}