using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_QualitySettings : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_QualitySettings() : base( typeof( QualitySettings ) )
        {
            m_StaticProperties["pixelLightCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.pixelLightCount ),
                x => QualitySettings.pixelLightCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["shadowCascades"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.shadowCascades ),
                x => QualitySettings.shadowCascades = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["shadowDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.shadowDistance ),
                x => QualitySettings.shadowDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["shadowNearPlaneOffset"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.shadowNearPlaneOffset ),
                x => QualitySettings.shadowNearPlaneOffset = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["shadowCascade2Split"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.shadowCascade2Split ),
                x => QualitySettings.shadowCascade2Split = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["shadowCascade4Split"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( QualitySettings.shadowCascade4Split ),
                x => QualitySettings.shadowCascade4Split = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_StaticProperties["lodBias"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.lodBias ),
                x => QualitySettings.lodBias = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["masterTextureLimit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.masterTextureLimit ),
                x => QualitySettings.masterTextureLimit = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["maximumLODLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.maximumLODLevel ),
                x => QualitySettings.maximumLODLevel = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["particleRaycastBudget"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.particleRaycastBudget ),
                x => QualitySettings.particleRaycastBudget = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["softParticles"] = new BSReflectionReference(
                () => QualitySettings.softParticles ? BSObject.One : BSObject.Zero,
                x => QualitySettings.softParticles = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["softVegetation"] = new BSReflectionReference(
                () => QualitySettings.softVegetation ? BSObject.One : BSObject.Zero,
                x => QualitySettings.softVegetation = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["vSyncCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.vSyncCount ),
                x => QualitySettings.vSyncCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["antiAliasing"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.antiAliasing ),
                x => QualitySettings.antiAliasing = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["asyncUploadTimeSlice"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.asyncUploadTimeSlice ),
                x => QualitySettings.asyncUploadTimeSlice = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["asyncUploadBufferSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.asyncUploadBufferSize ),
                x => QualitySettings.asyncUploadBufferSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["asyncUploadPersistentBuffer"] = new BSReflectionReference(
                () => QualitySettings.asyncUploadPersistentBuffer ? BSObject.One : BSObject.Zero,
                x => QualitySettings.asyncUploadPersistentBuffer = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["realtimeReflectionProbes"] = new BSReflectionReference(
                () => QualitySettings.realtimeReflectionProbes ? BSObject.One : BSObject.Zero,
                x => QualitySettings.realtimeReflectionProbes = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["billboardsFaceCameraPosition"] = new BSReflectionReference(
                () => QualitySettings.billboardsFaceCameraPosition ? BSObject.One : BSObject.Zero,
                x => QualitySettings.billboardsFaceCameraPosition = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["resolutionScalingFixedDPIFactor"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.resolutionScalingFixedDPIFactor ),
                x => QualitySettings.resolutionScalingFixedDPIFactor = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["renderPipeline"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderPipelineAsset( QualitySettings.renderPipeline ),
                x => QualitySettings.renderPipeline = WrapperHelper.UnwrapObject < RenderPipelineAsset >( x ) );

            m_StaticProperties["streamingMipmapsActive"] = new BSReflectionReference(
                () => QualitySettings.streamingMipmapsActive ? BSObject.One : BSObject.Zero,
                x => QualitySettings.streamingMipmapsActive = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["streamingMipmapsMemoryBudget"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.streamingMipmapsMemoryBudget ),
                x => QualitySettings.streamingMipmapsMemoryBudget = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["streamingMipmapsRenderersPerFrame"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.streamingMipmapsRenderersPerFrame ),
                x => QualitySettings.streamingMipmapsRenderersPerFrame = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["streamingMipmapsMaxLevelReduction"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.streamingMipmapsMaxLevelReduction ),
                x => QualitySettings.streamingMipmapsMaxLevelReduction = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["streamingMipmapsAddAllCameras"] = new BSReflectionReference(
                () => QualitySettings.streamingMipmapsAddAllCameras ? BSObject.One : BSObject.Zero,
                x => QualitySettings.streamingMipmapsAddAllCameras = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["streamingMipmapsMaxFileIORequests"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.streamingMipmapsMaxFileIORequests ),
                x => QualitySettings.streamingMipmapsMaxFileIORequests = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["maxQueuedFrames"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) QualitySettings.maxQueuedFrames ),
                x => QualitySettings.maxQueuedFrames = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["GetRenderPipelineAssetAt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRenderPipelineAssetAt(index)",
                    a => new BSWrapperObject_UnityEngine_Rendering_RenderPipelineAsset(
                        QualitySettings.GetRenderPipelineAssetAt( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
