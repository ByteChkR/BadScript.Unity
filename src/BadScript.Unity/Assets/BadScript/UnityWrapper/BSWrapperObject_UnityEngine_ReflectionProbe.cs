using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ReflectionProbe : BSWrapperObject < ReflectionProbe >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ReflectionProbe( ReflectionProbe obj ) : base( obj )
        {
            m_Properties["size"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.size ),
                x => m_InternalObject.size = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["center"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.center ),
                x => m_InternalObject.center = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["nearClipPlane"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.nearClipPlane ),
                x => m_InternalObject.nearClipPlane = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["farClipPlane"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.farClipPlane ),
                x => m_InternalObject.farClipPlane = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["intensity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.intensity ),
                x => m_InternalObject.intensity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Bounds( m_InternalObject.bounds ),
                null );

            m_Properties["hdr"] = new BSReflectionReference(
                () => m_InternalObject.hdr ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.hdr = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["renderDynamicObjects"] = new BSReflectionReference(
                () => m_InternalObject.renderDynamicObjects ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.renderDynamicObjects = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["shadowDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shadowDistance ),
                x => m_InternalObject.shadowDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["resolution"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.resolution ),
                x => m_InternalObject.resolution = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["cullingMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cullingMask ),
                x => m_InternalObject.cullingMask = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["backgroundColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.backgroundColor ),
                x => m_InternalObject.backgroundColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["blendDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.blendDistance ),
                x => m_InternalObject.blendDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["boxProjection"] = new BSReflectionReference(
                () => m_InternalObject.boxProjection ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.boxProjection = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["importance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.importance ),
                x => m_InternalObject.importance = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["bakedTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture( m_InternalObject.bakedTexture ),
                x => m_InternalObject.bakedTexture = WrapperHelper.UnwrapObject < Texture >( x ) );

            m_Properties["customBakedTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture( m_InternalObject.customBakedTexture ),
                x => m_InternalObject.customBakedTexture = WrapperHelper.UnwrapObject < Texture >( x ) );

            m_Properties["realtimeTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderTexture( m_InternalObject.realtimeTexture ),
                x => m_InternalObject.realtimeTexture = WrapperHelper.UnwrapObject < RenderTexture >( x ) );

            m_Properties["texture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture( m_InternalObject.texture ),
                null );

            m_Properties["textureHDRDecodeValues"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.textureHDRDecodeValues ),
                null );

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

            m_Properties["RenderProbe"] = new BSFunctionReference(
                new BSFunction(
                    "function RenderProbe(targetTexture)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.RenderProbe(
                            WrapperHelper.UnwrapObject < RenderTexture >( a[0] ) ) ),
                    1 ) );

            m_Properties["IsFinishedRendering"] = new BSFunctionReference(
                new BSFunction(
                    "function IsFinishedRendering(renderId)",
                    a => m_InternalObject.IsFinishedRendering( WrapperHelper.UnwrapObject < int >( a[0] ) )
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
