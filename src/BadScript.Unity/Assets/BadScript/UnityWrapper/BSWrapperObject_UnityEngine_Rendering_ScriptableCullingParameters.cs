using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Rendering_ScriptableCullingParameters : BSWrapperObject <
            ScriptableCullingParameters >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_ScriptableCullingParameters( ScriptableCullingParameters obj ) :
            base( obj )
        {
            m_Properties["maximumVisibleLights"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maximumVisibleLights ),
                x => m_InternalObject.maximumVisibleLights = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["cullingPlaneCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cullingPlaneCount ),
                x => m_InternalObject.cullingPlaneCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["isOrthographic"] = new BSReflectionReference(
                () => m_InternalObject.isOrthographic ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isOrthographic = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["lodParameters"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_LODParameters( m_InternalObject.lodParameters ),
                x => m_InternalObject.lodParameters = WrapperHelper.UnwrapObject < LODParameters >( x ) );

            m_Properties["cullingMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cullingMask ),
                x => m_InternalObject.cullingMask = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["cullingMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.cullingMatrix ),
                x => m_InternalObject.cullingMatrix = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["origin"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.origin ),
                x => m_InternalObject.origin = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["shadowDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shadowDistance ),
                x => m_InternalObject.shadowDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["cameraProperties"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_CameraProperties( m_InternalObject.cameraProperties ),
                x => m_InternalObject.cameraProperties = WrapperHelper.UnwrapObject < CameraProperties >( x ) );

            m_Properties["stereoViewMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.stereoViewMatrix ),
                x => m_InternalObject.stereoViewMatrix = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["stereoProjectionMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.stereoProjectionMatrix ),
                x => m_InternalObject.stereoProjectionMatrix = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["stereoSeparationDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.stereoSeparationDistance ),
                x => m_InternalObject.stereoSeparationDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["accurateOcclusionThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.accurateOcclusionThreshold ),
                x => m_InternalObject.accurateOcclusionThreshold = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maximumPortalCullingJobs"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maximumPortalCullingJobs ),
                x => m_InternalObject.maximumPortalCullingJobs = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["GetLayerCullingDistance"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLayerCullingDistance(layerIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetLayerCullingDistance(
                            WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetCullingPlane"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCullingPlane(index)",
                    a => new BSWrapperObject_UnityEngine_Plane(
                        m_InternalObject.GetCullingPlane( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < ScriptableCullingParameters >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
