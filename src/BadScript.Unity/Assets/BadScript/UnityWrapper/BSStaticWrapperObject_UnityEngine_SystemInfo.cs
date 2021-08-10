using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_SystemInfo : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_SystemInfo() : base( typeof( SystemInfo ) )
        {
            m_StaticProperties["batteryLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.batteryLevel ),
                null );

            m_StaticProperties["operatingSystem"] = new BSReflectionReference(
                () => new BSObject( SystemInfo.operatingSystem ),
                null );

            m_StaticProperties["processorType"] = new BSReflectionReference(
                () => new BSObject( SystemInfo.processorType ),
                null );

            m_StaticProperties["processorFrequency"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.processorFrequency ),
                null );

            m_StaticProperties["processorCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.processorCount ),
                null );

            m_StaticProperties["systemMemorySize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.systemMemorySize ),
                null );

            m_StaticProperties["deviceUniqueIdentifier"] = new BSReflectionReference(
                () => new BSObject( SystemInfo.deviceUniqueIdentifier ),
                null );

            m_StaticProperties["deviceName"] = new BSReflectionReference(
                () => new BSObject( SystemInfo.deviceName ),
                null );

            m_StaticProperties["deviceModel"] = new BSReflectionReference(
                () => new BSObject( SystemInfo.deviceModel ),
                null );

            m_StaticProperties["supportsAccelerometer"] = new BSReflectionReference(
                () => SystemInfo.supportsAccelerometer ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsGyroscope"] = new BSReflectionReference(
                () => SystemInfo.supportsGyroscope ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsLocationService"] = new BSReflectionReference(
                () => SystemInfo.supportsLocationService ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsVibration"] = new BSReflectionReference(
                () => SystemInfo.supportsVibration ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsAudio"] = new BSReflectionReference(
                () => SystemInfo.supportsAudio ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["graphicsMemorySize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.graphicsMemorySize ),
                null );

            m_StaticProperties["graphicsDeviceName"] = new BSReflectionReference(
                () => new BSObject( SystemInfo.graphicsDeviceName ),
                null );

            m_StaticProperties["graphicsDeviceVendor"] = new BSReflectionReference(
                () => new BSObject( SystemInfo.graphicsDeviceVendor ),
                null );

            m_StaticProperties["graphicsDeviceID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.graphicsDeviceID ),
                null );

            m_StaticProperties["graphicsDeviceVendorID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.graphicsDeviceVendorID ),
                null );

            m_StaticProperties["graphicsUVStartsAtTop"] = new BSReflectionReference(
                () => SystemInfo.graphicsUVStartsAtTop ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["graphicsDeviceVersion"] = new BSReflectionReference(
                () => new BSObject( SystemInfo.graphicsDeviceVersion ),
                null );

            m_StaticProperties["graphicsShaderLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.graphicsShaderLevel ),
                null );

            m_StaticProperties["graphicsMultiThreaded"] = new BSReflectionReference(
                () => SystemInfo.graphicsMultiThreaded ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["hasHiddenSurfaceRemovalOnGPU"] = new BSReflectionReference(
                () => SystemInfo.hasHiddenSurfaceRemovalOnGPU ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["hasDynamicUniformArrayIndexingInFragmentShaders"] = new BSReflectionReference(
                () => SystemInfo.hasDynamicUniformArrayIndexingInFragmentShaders ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsShadows"] = new BSReflectionReference(
                () => SystemInfo.supportsShadows ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsRawShadowDepthSampling"] = new BSReflectionReference(
                () => SystemInfo.supportsRawShadowDepthSampling ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsMotionVectors"] = new BSReflectionReference(
                () => SystemInfo.supportsMotionVectors ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supports3DTextures"] = new BSReflectionReference(
                () => SystemInfo.supports3DTextures ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsCompressed3DTextures"] = new BSReflectionReference(
                () => SystemInfo.supportsCompressed3DTextures ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supports2DArrayTextures"] = new BSReflectionReference(
                () => SystemInfo.supports2DArrayTextures ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supports3DRenderTextures"] = new BSReflectionReference(
                () => SystemInfo.supports3DRenderTextures ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsCubemapArrayTextures"] = new BSReflectionReference(
                () => SystemInfo.supportsCubemapArrayTextures ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsComputeShaders"] = new BSReflectionReference(
                () => SystemInfo.supportsComputeShaders ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsConservativeRaster"] = new BSReflectionReference(
                () => SystemInfo.supportsConservativeRaster ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsMultiview"] = new BSReflectionReference(
                () => SystemInfo.supportsMultiview ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsGeometryShaders"] = new BSReflectionReference(
                () => SystemInfo.supportsGeometryShaders ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsTessellationShaders"] = new BSReflectionReference(
                () => SystemInfo.supportsTessellationShaders ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsRenderTargetArrayIndexFromVertexShader"] = new BSReflectionReference(
                () => SystemInfo.supportsRenderTargetArrayIndexFromVertexShader ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsInstancing"] = new BSReflectionReference(
                () => SystemInfo.supportsInstancing ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsHardwareQuadTopology"] = new BSReflectionReference(
                () => SystemInfo.supportsHardwareQuadTopology ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supports32bitsIndexBuffer"] = new BSReflectionReference(
                () => SystemInfo.supports32bitsIndexBuffer ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsSparseTextures"] = new BSReflectionReference(
                () => SystemInfo.supportsSparseTextures ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportedRenderTargetCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.supportedRenderTargetCount ),
                null );

            m_StaticProperties["supportsSeparatedRenderTargetsBlend"] = new BSReflectionReference(
                () => SystemInfo.supportsSeparatedRenderTargetsBlend ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportedRandomWriteTargetCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.supportedRandomWriteTargetCount ),
                null );

            m_StaticProperties["supportsMultisampledTextures"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.supportsMultisampledTextures ),
                null );

            m_StaticProperties["supportsMultisampled2DArrayTextures"] = new BSReflectionReference(
                () => SystemInfo.supportsMultisampled2DArrayTextures ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsMultisampleAutoResolve"] = new BSReflectionReference(
                () => SystemInfo.supportsMultisampleAutoResolve ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsTextureWrapMirrorOnce"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.supportsTextureWrapMirrorOnce ),
                null );

            m_StaticProperties["usesReversedZBuffer"] = new BSReflectionReference(
                () => SystemInfo.usesReversedZBuffer ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["maxTextureSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.maxTextureSize ),
                null );

            m_StaticProperties["maxCubemapSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.maxCubemapSize ),
                null );

            m_StaticProperties["maxComputeBufferInputsVertex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.maxComputeBufferInputsVertex ),
                null );

            m_StaticProperties["maxComputeBufferInputsFragment"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.maxComputeBufferInputsFragment ),
                null );

            m_StaticProperties["maxComputeBufferInputsGeometry"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.maxComputeBufferInputsGeometry ),
                null );

            m_StaticProperties["maxComputeBufferInputsDomain"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.maxComputeBufferInputsDomain ),
                null );

            m_StaticProperties["maxComputeBufferInputsHull"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.maxComputeBufferInputsHull ),
                null );

            m_StaticProperties["maxComputeBufferInputsCompute"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.maxComputeBufferInputsCompute ),
                null );

            m_StaticProperties["maxComputeWorkGroupSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.maxComputeWorkGroupSize ),
                null );

            m_StaticProperties["maxComputeWorkGroupSizeX"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.maxComputeWorkGroupSizeX ),
                null );

            m_StaticProperties["maxComputeWorkGroupSizeY"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.maxComputeWorkGroupSizeY ),
                null );

            m_StaticProperties["maxComputeWorkGroupSizeZ"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.maxComputeWorkGroupSizeZ ),
                null );

            m_StaticProperties["supportsAsyncCompute"] = new BSReflectionReference(
                () => SystemInfo.supportsAsyncCompute ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsGpuRecorder"] = new BSReflectionReference(
                () => SystemInfo.supportsGpuRecorder ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsGraphicsFence"] = new BSReflectionReference(
                () => SystemInfo.supportsGraphicsFence ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsAsyncGPUReadback"] = new BSReflectionReference(
                () => SystemInfo.supportsAsyncGPUReadback ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsRayTracing"] = new BSReflectionReference(
                () => SystemInfo.supportsRayTracing ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsSetConstantBuffer"] = new BSReflectionReference(
                () => SystemInfo.supportsSetConstantBuffer ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["constantBufferOffsetAlignment"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.constantBufferOffsetAlignment ),
                null );

            m_StaticProperties["minConstantBufferOffsetAlignment"] = new BSReflectionReference(
                () => SystemInfo.minConstantBufferOffsetAlignment ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["hasMipMaxLevel"] = new BSReflectionReference(
                () => SystemInfo.hasMipMaxLevel ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsMipStreaming"] = new BSReflectionReference(
                () => SystemInfo.supportsMipStreaming ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["usesLoadStoreActions"] = new BSReflectionReference(
                () => SystemInfo.usesLoadStoreActions ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsStoreAndResolveAction"] = new BSReflectionReference(
                () => SystemInfo.supportsStoreAndResolveAction ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsRenderTextures"] = new BSReflectionReference(
                () => SystemInfo.supportsRenderTextures ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsRenderToCubemap"] = new BSReflectionReference(
                () => SystemInfo.supportsRenderToCubemap ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsImageEffects"] = new BSReflectionReference(
                () => SystemInfo.supportsImageEffects ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["supportsStencil"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.supportsStencil ),
                null );

            m_StaticProperties["graphicsPixelFillrate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SystemInfo.graphicsPixelFillrate ),
                null );

            m_StaticProperties["supportsVertexPrograms"] = new BSReflectionReference(
                () => SystemInfo.supportsVertexPrograms ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["unsupportedIdentifier"] = new BSReflectionReference(
                () => new BSObject( SystemInfo.unsupportedIdentifier ),
                null );

            m_StaticProperties["GetRenderTextureSupportedMSAASampleCount"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRenderTextureSupportedMSAASampleCount(desc)",
                    a => new BSObject(
                        ( decimal ) SystemInfo.GetRenderTextureSupportedMSAASampleCount(
                            WrapperHelper.UnwrapObject < RenderTextureDescriptor >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
