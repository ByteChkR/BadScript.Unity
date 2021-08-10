using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_RenderSettings : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_RenderSettings() : base( typeof( RenderSettings ) )
        {
            m_StaticProperties["ambientSkyboxAmount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) RenderSettings.ambientIntensity ),
                x => RenderSettings.ambientIntensity = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["fog"] = new BSReflectionReference(
                () => RenderSettings.fog ? BSObject.One : BSObject.Zero,
                x => RenderSettings.fog = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["fogStartDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) RenderSettings.fogStartDistance ),
                x => RenderSettings.fogStartDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["fogEndDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) RenderSettings.fogEndDistance ),
                x => RenderSettings.fogEndDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["fogColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( RenderSettings.fogColor ),
                x => RenderSettings.fogColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_StaticProperties["fogDensity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) RenderSettings.fogDensity ),
                x => RenderSettings.fogDensity = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["ambientSkyColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( RenderSettings.ambientSkyColor ),
                x => RenderSettings.ambientSkyColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_StaticProperties["ambientEquatorColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( RenderSettings.ambientEquatorColor ),
                x => RenderSettings.ambientEquatorColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_StaticProperties["ambientGroundColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( RenderSettings.ambientGroundColor ),
                x => RenderSettings.ambientGroundColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_StaticProperties["ambientIntensity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) RenderSettings.ambientIntensity ),
                x => RenderSettings.ambientIntensity = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["ambientLight"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( RenderSettings.ambientLight ),
                x => RenderSettings.ambientLight = WrapperHelper.UnwrapObject < Color >( x ) );

            m_StaticProperties["subtractiveShadowColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( RenderSettings.subtractiveShadowColor ),
                x => RenderSettings.subtractiveShadowColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_StaticProperties["skybox"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( RenderSettings.skybox ),
                x => RenderSettings.skybox = WrapperHelper.UnwrapObject < Material >( x ) );

            m_StaticProperties["sun"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Light( RenderSettings.sun ),
                x => RenderSettings.sun = WrapperHelper.UnwrapObject < Light >( x ) );

            m_StaticProperties["ambientProbe"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_SphericalHarmonicsL2( RenderSettings.ambientProbe ),
                x => RenderSettings.ambientProbe = WrapperHelper.UnwrapObject < SphericalHarmonicsL2 >( x ) );

            m_StaticProperties["customReflection"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Cubemap( RenderSettings.customReflection ),
                x => RenderSettings.customReflection = WrapperHelper.UnwrapObject < Cubemap >( x ) );

            m_StaticProperties["reflectionIntensity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) RenderSettings.reflectionIntensity ),
                x => RenderSettings.reflectionIntensity = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["reflectionBounces"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) RenderSettings.reflectionBounces ),
                x => RenderSettings.reflectionBounces = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["defaultReflectionResolution"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) RenderSettings.defaultReflectionResolution ),
                x => RenderSettings.defaultReflectionResolution = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["haloStrength"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) RenderSettings.haloStrength ),
                x => RenderSettings.haloStrength = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["flareStrength"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) RenderSettings.flareStrength ),
                x => RenderSettings.flareStrength = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["flareFadeSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) RenderSettings.flareFadeSpeed ),
                x => RenderSettings.flareFadeSpeed = WrapperHelper.UnwrapObject < float >( x ) );

        }

        #endregion
    }

}
