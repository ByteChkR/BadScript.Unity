using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
#pragma warning disable 618

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Renderer : BSWrapperObject < Renderer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Renderer( Renderer obj ) : base( obj )
        {
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

            m_Properties["HasPropertyBlock"] = new BSFunctionReference(
                new BSFunction(
                    "function HasPropertyBlock()",
                    a => m_InternalObject.HasPropertyBlock() ? BSObject.One : BSObject.Zero,
                    0 ) );

            m_Properties["SetPropertyBlock"] = new BSFunctionReference(
                new BSFunction(
                    "function SetPropertyBlock(properties)",
                    a =>
                    {
                        m_InternalObject.SetPropertyBlock(
                            WrapperHelper.UnwrapObject < MaterialPropertyBlock >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetPropertyBlock"] = new BSFunctionReference(
                new BSFunction(
                    "function SetPropertyBlock(properties, materialIndex)",
                    a =>
                    {
                        m_InternalObject.SetPropertyBlock(
                            WrapperHelper.UnwrapObject < MaterialPropertyBlock >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["GetPropertyBlock"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPropertyBlock(properties)",
                    a =>
                    {
                        m_InternalObject.GetPropertyBlock(
                            WrapperHelper.UnwrapObject < MaterialPropertyBlock >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["GetPropertyBlock"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPropertyBlock(properties, materialIndex)",
                    a =>
                    {
                        m_InternalObject.GetPropertyBlock(
                            WrapperHelper.UnwrapObject < MaterialPropertyBlock >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

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

            m_Properties["SendMessageUpwards"] = new BSFunctionReference(
                new BSFunction(
                    "function SendMessageUpwards(methodName, value)",
                    a =>
                    {
                        m_InternalObject.SendMessageUpwards(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SendMessageUpwards"] = new BSFunctionReference(
                new BSFunction(
                    "function SendMessageUpwards(methodName)",
                    a =>
                    {
                        m_InternalObject.SendMessageUpwards( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SendMessage"] = new BSFunctionReference(
                new BSFunction(
                    "function SendMessage(methodName, value)",
                    a =>
                    {
                        m_InternalObject.SendMessage(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SendMessage"] = new BSFunctionReference(
                new BSFunction(
                    "function SendMessage(methodName)",
                    a =>
                    {
                        m_InternalObject.SendMessage( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["BroadcastMessage"] = new BSFunctionReference(
                new BSFunction(
                    "function BroadcastMessage(methodName, parameter)",
                    a =>
                    {
                        m_InternalObject.BroadcastMessage(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["BroadcastMessage"] = new BSFunctionReference(
                new BSFunction(
                    "function BroadcastMessage(methodName)",
                    a =>
                    {
                        m_InternalObject.BroadcastMessage( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["GetInstanceID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInstanceID()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetInstanceID() ),
                    0 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}
