using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Light : BSWrapperObject < Light >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Light( Light obj ) : base( obj )
        {
            m_Properties["spotAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.spotAngle ),
                x => m_InternalObject.spotAngle = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["innerSpotAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.innerSpotAngle ),
                x => m_InternalObject.innerSpotAngle = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["color"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.color ),
                x => m_InternalObject.color = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["colorTemperature"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.colorTemperature ),
                x => m_InternalObject.colorTemperature = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["useColorTemperature"] = new BSReflectionReference(
                () => m_InternalObject.useColorTemperature ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useColorTemperature = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["intensity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.intensity ),
                x => m_InternalObject.intensity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bounceIntensity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bounceIntensity ),
                x => m_InternalObject.bounceIntensity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["useBoundingSphereOverride"] = new BSReflectionReference(
                () => m_InternalObject.useBoundingSphereOverride ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useBoundingSphereOverride = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["boundingSphereOverride"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( m_InternalObject.boundingSphereOverride ),
                x => m_InternalObject.boundingSphereOverride = WrapperHelper.UnwrapObject < Vector4 >( x ) );

            m_Properties["useViewFrustumForShadowCasterCull"] = new BSReflectionReference(
                () => m_InternalObject.useViewFrustumForShadowCasterCull ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useViewFrustumForShadowCasterCull = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["shadowCustomResolution"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shadowCustomResolution ),
                x => m_InternalObject.shadowCustomResolution = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["shadowBias"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shadowBias ),
                x => m_InternalObject.shadowBias = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["shadowNormalBias"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shadowNormalBias ),
                x => m_InternalObject.shadowNormalBias = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["shadowNearPlane"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shadowNearPlane ),
                x => m_InternalObject.shadowNearPlane = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["useShadowMatrixOverride"] = new BSReflectionReference(
                () => m_InternalObject.useShadowMatrixOverride ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useShadowMatrixOverride = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["shadowMatrixOverride"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.shadowMatrixOverride ),
                x => m_InternalObject.shadowMatrixOverride = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_Properties["range"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.range ),
                x => m_InternalObject.range = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["flare"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Flare( m_InternalObject.flare ),
                x => m_InternalObject.flare = WrapperHelper.UnwrapObject < Flare >( x ) );

            m_Properties["bakingOutput"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_LightBakingOutput( m_InternalObject.bakingOutput ),
                x => m_InternalObject.bakingOutput = WrapperHelper.UnwrapObject < LightBakingOutput >( x ) );

            m_Properties["cullingMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cullingMask ),
                x => m_InternalObject.cullingMask = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["renderingLayerMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.renderingLayerMask ),
                x => m_InternalObject.renderingLayerMask = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["shadowRadius"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shadowRadius ),
                x => m_InternalObject.shadowRadius = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["shadowAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shadowAngle ),
                x => m_InternalObject.shadowAngle = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["shadowStrength"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shadowStrength ),
                x => m_InternalObject.shadowStrength = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["cookieSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cookieSize ),
                x => m_InternalObject.cookieSize = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["cookie"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture( m_InternalObject.cookie ),
                x => m_InternalObject.cookie = WrapperHelper.UnwrapObject < Texture >( x ) );

            m_Properties["areaSize"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.areaSize ),
                x => m_InternalObject.areaSize = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["commandBufferCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.commandBufferCount ),
                null );

            m_Properties["isBaked"] = new BSReflectionReference(
                () => m_InternalObject.isBaked ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["alreadyLightmapped"] = new BSReflectionReference(
                () => m_InternalObject.alreadyLightmapped ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.alreadyLightmapped = WrapperHelper.UnwrapObject < bool >( x ) );

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
