using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Camera : BSWrapperObject < Camera >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Camera( Camera obj ) : base( obj )
        {
            m_Properties["nearClipPlane"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.nearClipPlane ),
                x => m_InternalObject.nearClipPlane = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["farClipPlane"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.farClipPlane ),
                x => m_InternalObject.farClipPlane = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["fieldOfView"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fieldOfView ),
                x => m_InternalObject.fieldOfView = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["allowHDR"] = new BSReflectionReference(
                () => m_InternalObject.allowHDR ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.allowHDR = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["allowMSAA"] = new BSReflectionReference(
                () => m_InternalObject.allowMSAA ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.allowMSAA = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["allowDynamicResolution"] = new BSReflectionReference(
                () => m_InternalObject.allowDynamicResolution ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.allowDynamicResolution = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["forceIntoRenderTexture"] = new BSReflectionReference(
                () => m_InternalObject.forceIntoRenderTexture ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.forceIntoRenderTexture = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["orthographicSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.orthographicSize ),
                x => m_InternalObject.orthographicSize = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["orthographic"] = new BSReflectionReference(
                () => m_InternalObject.orthographic ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.orthographic = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["transparencySortAxis"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.transparencySortAxis ),
                x => m_InternalObject.transparencySortAxis = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["depth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.depth ),
                x => m_InternalObject.depth = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["aspect"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.aspect ),
                x => m_InternalObject.aspect = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["velocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.velocity ),
                null );

            m_Properties["cullingMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cullingMask ),
                x => m_InternalObject.cullingMask = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["eventMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.eventMask ),
                x => m_InternalObject.eventMask = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["layerCullSpherical"] = new BSReflectionReference(
                () => m_InternalObject.layerCullSpherical ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.layerCullSpherical = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["overrideSceneCullingMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.overrideSceneCullingMask ),
                x => m_InternalObject.overrideSceneCullingMask = WrapperHelper.UnwrapObject < ulong >( x ) );

            m_Properties["useOcclusionCulling"] = new BSReflectionReference(
                () => m_InternalObject.useOcclusionCulling ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useOcclusionCulling = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["cullingMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.cullingMatrix ),
                x => m_InternalObject.cullingMatrix = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["backgroundColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.backgroundColor ),
                x => m_InternalObject.backgroundColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["clearStencilAfterLightingPass"] = new BSReflectionReference(
                () => m_InternalObject.clearStencilAfterLightingPass ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.clearStencilAfterLightingPass = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["usePhysicalProperties"] = new BSReflectionReference(
                () => m_InternalObject.usePhysicalProperties ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.usePhysicalProperties = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["sensorSize"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.sensorSize ),
                x => m_InternalObject.sensorSize = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["lensShift"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.lensShift ),
                x => m_InternalObject.lensShift = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["focalLength"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.focalLength ),
                x => m_InternalObject.focalLength = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["rect"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( m_InternalObject.rect ),
                x => m_InternalObject.rect = WrapperHelper.UnwrapObject < Rect >( x ) );

            m_Properties["pixelRect"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( m_InternalObject.pixelRect ),
                x => m_InternalObject.pixelRect = WrapperHelper.UnwrapObject < Rect >( x ) );

            m_Properties["pixelWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pixelWidth ),
                null );

            m_Properties["pixelHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pixelHeight ),
                null );

            m_Properties["scaledPixelWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.scaledPixelWidth ),
                null );

            m_Properties["scaledPixelHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.scaledPixelHeight ),
                null );

            m_Properties["targetTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderTexture( m_InternalObject.targetTexture ),
                x => m_InternalObject.targetTexture = WrapperHelper.UnwrapObject < RenderTexture >( x ) );

            m_Properties["activeTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderTexture( m_InternalObject.activeTexture ),
                null );

            m_Properties["targetDisplay"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.targetDisplay ),
                x => m_InternalObject.targetDisplay = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["cameraToWorldMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.cameraToWorldMatrix ),
                null );

            m_Properties["worldToCameraMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.worldToCameraMatrix ),
                x => m_InternalObject.worldToCameraMatrix = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["projectionMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.projectionMatrix ),
                x => m_InternalObject.projectionMatrix = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["nonJitteredProjectionMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.nonJitteredProjectionMatrix ),
                x => m_InternalObject.nonJitteredProjectionMatrix = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["useJitteredProjectionMatrixForTransparentRendering"] = new BSReflectionReference(
                () => m_InternalObject.useJitteredProjectionMatrixForTransparentRendering
                    ? BSObject.One
                    : BSObject.Zero,
                x => m_InternalObject.useJitteredProjectionMatrixForTransparentRendering =
                    WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["previousViewProjectionMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.previousViewProjectionMatrix ),
                null );

            m_Properties["scene"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SceneManagement_Scene( m_InternalObject.scene ),
                x => m_InternalObject.scene = WrapperHelper.UnwrapObject < Scene >( x ) );

            m_Properties["stereoEnabled"] = new BSReflectionReference(
                () => m_InternalObject.stereoEnabled ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["stereoSeparation"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.stereoSeparation ),
                x => m_InternalObject.stereoSeparation = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["stereoConvergence"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.stereoConvergence ),
                x => m_InternalObject.stereoConvergence = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["areVRStereoViewMatricesWithinSingleCullTolerance"] = new BSReflectionReference(
                () => m_InternalObject.areVRStereoViewMatricesWithinSingleCullTolerance ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["commandBufferCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.commandBufferCount ),
                null );

            m_Properties["near"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.nearClipPlane ),
                x => m_InternalObject.nearClipPlane = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["far"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.farClipPlane ),
                x => m_InternalObject.farClipPlane = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["fov"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fieldOfView ),
                x => m_InternalObject.fieldOfView = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["hdr"] = new BSReflectionReference(
                () => m_InternalObject.allowHDR ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.allowHDR = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isActiveAndEnabled"] = new BSReflectionReference(
                () => m_InternalObject.isActiveAndEnabled ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.transform ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.gameObject ),
                null );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["CalculateObliqueMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function CalculateObliqueMatrix(clipPlane)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        m_InternalObject.CalculateObliqueMatrix( WrapperHelper.UnwrapObject < Vector4 >( a[0] ) ) ),
                    1 ) );

            m_Properties["WorldToScreenPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function WorldToScreenPoint(position)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.WorldToScreenPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["WorldToViewportPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function WorldToViewportPoint(position)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.WorldToViewportPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["ViewportToWorldPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ViewportToWorldPoint(position)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.ViewportToWorldPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["ScreenToWorldPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ScreenToWorldPoint(position)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.ScreenToWorldPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["ScreenToViewportPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ScreenToViewportPoint(position)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.ScreenToViewportPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["ViewportToScreenPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ViewportToScreenPoint(position)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.ViewportToScreenPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["ViewportPointToRay"] = new BSFunctionReference(
                new BSFunction(
                    "function ViewportPointToRay(pos)",
                    a => new BSWrapperObject_UnityEngine_Ray(
                        m_InternalObject.ViewportPointToRay( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["ScreenPointToRay"] = new BSFunctionReference(
                new BSFunction(
                    "function ScreenPointToRay(pos)",
                    a => new BSWrapperObject_UnityEngine_Ray(
                        m_InternalObject.ScreenPointToRay( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["RenderToCubemap"] = new BSFunctionReference(
                new BSFunction(
                    "function RenderToCubemap(cubemap, faceMask)",
                    a => m_InternalObject.RenderToCubemap(
                        WrapperHelper.UnwrapObject < Cubemap >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["RenderToCubemap"] = new BSFunctionReference(
                new BSFunction(
                    "function RenderToCubemap(cubemap)",
                    a => m_InternalObject.RenderToCubemap( WrapperHelper.UnwrapObject < Cubemap >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["RenderToCubemap"] = new BSFunctionReference(
                new BSFunction(
                    "function RenderToCubemap(cubemap, faceMask)",
                    a => m_InternalObject.RenderToCubemap(
                        WrapperHelper.UnwrapObject < RenderTexture >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["RenderToCubemap"] = new BSFunctionReference(
                new BSFunction(
                    "function RenderToCubemap(cubemap)",
                    a => m_InternalObject.RenderToCubemap( WrapperHelper.UnwrapObject < RenderTexture >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_UnityEngine_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
