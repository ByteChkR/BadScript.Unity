using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_LineRenderer : BSWrapperObject < LineRenderer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_LineRenderer( LineRenderer obj ) : base( obj )
        {
            m_Properties["numPositions"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.positionCount ),
                x => m_InternalObject.positionCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["startWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.startWidth ),
                x => m_InternalObject.startWidth = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["endWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.endWidth ),
                x => m_InternalObject.endWidth = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["widthMultiplier"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.widthMultiplier ),
                x => m_InternalObject.widthMultiplier = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["numCornerVertices"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.numCornerVertices ),
                x => m_InternalObject.numCornerVertices = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["numCapVertices"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.numCapVertices ),
                x => m_InternalObject.numCapVertices = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["useWorldSpace"] = new BSReflectionReference(
                () => m_InternalObject.useWorldSpace ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useWorldSpace = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["loop"] = new BSReflectionReference(
                () => m_InternalObject.loop ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.loop = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["startColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.startColor ),
                x => m_InternalObject.startColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["endColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.endColor ),
                x => m_InternalObject.endColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["positionCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.positionCount ),
                x => m_InternalObject.positionCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["shadowBias"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shadowBias ),
                x => m_InternalObject.shadowBias = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["generateLightingData"] = new BSReflectionReference(
                () => m_InternalObject.generateLightingData ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.generateLightingData = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["widthCurve"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AnimationCurve( m_InternalObject.widthCurve ),
                x => m_InternalObject.widthCurve = WrapperHelper.UnwrapObject < AnimationCurve >( x ) );

            m_Properties["colorGradient"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Gradient( m_InternalObject.colorGradient ),
                x => m_InternalObject.colorGradient = WrapperHelper.UnwrapObject < Gradient >( x ) );

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

            m_Properties["GetPosition"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPosition(index)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.GetPosition( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
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
