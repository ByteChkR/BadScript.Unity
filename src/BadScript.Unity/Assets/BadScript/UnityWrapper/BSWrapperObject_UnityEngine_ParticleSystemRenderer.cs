using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ParticleSystemRenderer : BSWrapperObject < ParticleSystemRenderer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ParticleSystemRenderer( ParticleSystemRenderer obj ) : base( obj )
        {
            m_Properties["lengthScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lengthScale ),
                x => m_InternalObject.lengthScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["velocityScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.velocityScale ),
                x => m_InternalObject.velocityScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["cameraVelocityScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cameraVelocityScale ),
                x => m_InternalObject.cameraVelocityScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["normalDirection"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.normalDirection ),
                x => m_InternalObject.normalDirection = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["shadowBias"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shadowBias ),
                x => m_InternalObject.shadowBias = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["sortingFudge"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sortingFudge ),
                x => m_InternalObject.sortingFudge = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["minParticleSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minParticleSize ),
                x => m_InternalObject.minParticleSize = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maxParticleSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxParticleSize ),
                x => m_InternalObject.maxParticleSize = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["pivot"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.pivot ),
                x => m_InternalObject.pivot = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["flip"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.flip ),
                x => m_InternalObject.flip = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["trailMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.trailMaterial ),
                x => m_InternalObject.trailMaterial = WrapperHelper.UnwrapObject < Material >( x ) );

            m_Properties["enableGPUInstancing"] = new BSReflectionReference(
                () => m_InternalObject.enableGPUInstancing ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enableGPUInstancing = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["allowRoll"] = new BSReflectionReference(
                () => m_InternalObject.allowRoll ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.allowRoll = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["freeformStretching"] = new BSReflectionReference(
                () => m_InternalObject.freeformStretching ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.freeformStretching = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["rotateWithStretchDirection"] = new BSReflectionReference(
                () => m_InternalObject.rotateWithStretchDirection ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.rotateWithStretchDirection = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["mesh"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Mesh( m_InternalObject.mesh ),
                x => m_InternalObject.mesh = WrapperHelper.UnwrapObject < Mesh >( x ) );

            m_Properties["meshCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.meshCount ),
                null );

            m_Properties["activeVertexStreamsCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.activeVertexStreamsCount ),
                null );

            m_Properties["supportsMeshInstancing"] = new BSReflectionReference(
                () => m_InternalObject.supportsMeshInstancing ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["castShadows"] = new BSReflectionReference(
                () => m_InternalObject.castShadows ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.castShadows = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["motionVectors"] = new BSReflectionReference(
                () => m_InternalObject.motionVectors ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.motionVectors = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useLightProbes"] = new BSReflectionReference(
                () => m_InternalObject.useLightProbes ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useLightProbes = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["bounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Bounds( m_InternalObject.bounds ),
                null );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isVisible"] = new BSReflectionReference(
                () => m_InternalObject.isVisible ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["receiveShadows"] = new BSReflectionReference(
                () => m_InternalObject.receiveShadows ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.receiveShadows = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["forceRenderingOff"] = new BSReflectionReference(
                () => m_InternalObject.forceRenderingOff ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.forceRenderingOff = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["renderingLayerMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.renderingLayerMask ),
                x => m_InternalObject.renderingLayerMask = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["rendererPriority"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.rendererPriority ),
                x => m_InternalObject.rendererPriority = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["sortingLayerName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.sortingLayerName ),
                x => m_InternalObject.sortingLayerName = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["sortingLayerID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sortingLayerID ),
                x => m_InternalObject.sortingLayerID = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["sortingOrder"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sortingOrder ),
                x => m_InternalObject.sortingOrder = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["allowOcclusionWhenDynamic"] = new BSReflectionReference(
                () => m_InternalObject.allowOcclusionWhenDynamic ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.allowOcclusionWhenDynamic = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isPartOfStaticBatch"] = new BSReflectionReference(
                () => m_InternalObject.isPartOfStaticBatch ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["worldToLocalMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.worldToLocalMatrix ),
                null );

            m_Properties["localToWorldMatrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.localToWorldMatrix ),
                null );

            m_Properties["lightProbeProxyVolumeOverride"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.lightProbeProxyVolumeOverride ),
                x => m_InternalObject.lightProbeProxyVolumeOverride = WrapperHelper.UnwrapObject < GameObject >( x ) );

            m_Properties["probeAnchor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.probeAnchor ),
                x => m_InternalObject.probeAnchor = WrapperHelper.UnwrapObject < Transform >( x ) );

            m_Properties["lightmapIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lightmapIndex ),
                x => m_InternalObject.lightmapIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["realtimeLightmapIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.realtimeLightmapIndex ),
                x => m_InternalObject.realtimeLightmapIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["lightmapScaleOffset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.lightmapScaleOffset ),
                x => m_InternalObject.lightmapScaleOffset = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["realtimeLightmapScaleOffset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.realtimeLightmapScaleOffset ),
                x => m_InternalObject.realtimeLightmapScaleOffset = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["material"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.material ),
                x => m_InternalObject.material = WrapperHelper.UnwrapObject < Material >( x ) );

            m_Properties["sharedMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.sharedMaterial ),
                x => m_InternalObject.sharedMaterial = WrapperHelper.UnwrapObject < Material >( x ) );

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
