using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Texture : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Texture() : base( typeof( Texture ) )
        {
            m_StaticProperties["masterTextureLimit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Texture.masterTextureLimit ),
                x => Texture.masterTextureLimit = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["totalTextureMemory"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Texture.totalTextureMemory ),
                null );

            m_StaticProperties["desiredTextureMemory"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Texture.desiredTextureMemory ),
                null );

            m_StaticProperties["targetTextureMemory"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Texture.targetTextureMemory ),
                null );

            m_StaticProperties["currentTextureMemory"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Texture.currentTextureMemory ),
                null );

            m_StaticProperties["nonStreamingTextureMemory"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Texture.nonStreamingTextureMemory ),
                null );

            m_StaticProperties["streamingMipmapUploadCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Texture.streamingMipmapUploadCount ),
                null );

            m_StaticProperties["streamingRendererCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Texture.streamingRendererCount ),
                null );

            m_StaticProperties["streamingTextureCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Texture.streamingTextureCount ),
                null );

            m_StaticProperties["nonStreamingTextureCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Texture.nonStreamingTextureCount ),
                null );

            m_StaticProperties["streamingTexturePendingLoadCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Texture.streamingTexturePendingLoadCount ),
                null );

            m_StaticProperties["streamingTextureLoadingCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Texture.streamingTextureLoadingCount ),
                null );

            m_StaticProperties["streamingTextureForceLoadAll"] = new BSReflectionReference(
                () => Texture.streamingTextureForceLoadAll ? BSObject.One : BSObject.Zero,
                x => Texture.streamingTextureForceLoadAll = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["streamingTextureDiscardUnusedMips"] = new BSReflectionReference(
                () => Texture.streamingTextureDiscardUnusedMips ? BSObject.One : BSObject.Zero,
                x => Texture.streamingTextureDiscardUnusedMips = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["allowThreadedTextureCreation"] = new BSReflectionReference(
                () => Texture.allowThreadedTextureCreation ? BSObject.One : BSObject.Zero,
                x => Texture.allowThreadedTextureCreation = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["GenerateAllMips"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Texture.GenerateAllMips ),
                null );

            m_StaticProperties["SetGlobalAnisotropicFilteringLimits"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalAnisotropicFilteringLimits(forcedMin, globalMax)",
                    a =>
                    {
                        Texture.SetGlobalAnisotropicFilteringLimits(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetStreamingTextureMaterialDebugProperties"] = new BSFunctionReference(
                new BSFunction(
                    "function SetStreamingTextureMaterialDebugProperties()",
                    a =>
                    {
                        Texture.SetStreamingTextureMaterialDebugProperties();

                        return new BSObject( null );
                    },
                    0 ) );

        }

        #endregion
    }

}
