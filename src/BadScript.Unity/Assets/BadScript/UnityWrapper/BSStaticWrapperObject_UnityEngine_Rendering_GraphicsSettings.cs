using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_GraphicsSettings : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_GraphicsSettings() : base( typeof( GraphicsSettings ) )
        {
            m_StaticProperties["transparencySortAxis"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( GraphicsSettings.transparencySortAxis ),
                x => GraphicsSettings.transparencySortAxis = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_StaticProperties["realtimeDirectRectangularAreaLights"] = new BSReflectionReference(
                () => GraphicsSettings.realtimeDirectRectangularAreaLights ? BSObject.One : BSObject.Zero,
                x => GraphicsSettings.realtimeDirectRectangularAreaLights = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["lightsUseLinearIntensity"] = new BSReflectionReference(
                () => GraphicsSettings.lightsUseLinearIntensity ? BSObject.One : BSObject.Zero,
                x => GraphicsSettings.lightsUseLinearIntensity = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["lightsUseColorTemperature"] = new BSReflectionReference(
                () => GraphicsSettings.lightsUseColorTemperature ? BSObject.One : BSObject.Zero,
                x => GraphicsSettings.lightsUseColorTemperature = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["defaultRenderingLayerMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) GraphicsSettings.defaultRenderingLayerMask ),
                x => GraphicsSettings.defaultRenderingLayerMask = WrapperHelper.UnwrapObject < uint >( x ) );

            m_StaticProperties["useScriptableRenderPipelineBatching"] = new BSReflectionReference(
                () => GraphicsSettings.useScriptableRenderPipelineBatching ? BSObject.One : BSObject.Zero,
                x => GraphicsSettings.useScriptableRenderPipelineBatching = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["logWhenShaderIsCompiled"] = new BSReflectionReference(
                () => GraphicsSettings.logWhenShaderIsCompiled ? BSObject.One : BSObject.Zero,
                x => GraphicsSettings.logWhenShaderIsCompiled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["disableBuiltinCustomRenderTextureUpdate"] = new BSReflectionReference(
                () => GraphicsSettings.disableBuiltinCustomRenderTextureUpdate ? BSObject.One : BSObject.Zero,
                x => GraphicsSettings.disableBuiltinCustomRenderTextureUpdate =
                    WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["currentRenderPipeline"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderPipelineAsset(
                    GraphicsSettings.currentRenderPipeline ),
                null );

            m_StaticProperties["renderPipelineAsset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderPipelineAsset(
                    GraphicsSettings.renderPipelineAsset ),
                x => GraphicsSettings.renderPipelineAsset = WrapperHelper.UnwrapObject < RenderPipelineAsset >( x ) );

            m_StaticProperties["defaultRenderPipeline"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderPipelineAsset(
                    GraphicsSettings.defaultRenderPipeline ),
                x => GraphicsSettings.defaultRenderPipeline = WrapperHelper.UnwrapObject < RenderPipelineAsset >( x ) );

        }

        #endregion
    }

}
