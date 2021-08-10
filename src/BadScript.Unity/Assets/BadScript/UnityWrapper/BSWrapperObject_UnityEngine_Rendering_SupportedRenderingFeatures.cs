using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Rendering_SupportedRenderingFeatures : BSWrapperObject < SupportedRenderingFeatures
        >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_SupportedRenderingFeatures( SupportedRenderingFeatures obj ) :
            base( obj )
        {
            m_Properties["enlighten"] = new BSReflectionReference(
                () => m_InternalObject.enlighten ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enlighten = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["lightProbeProxyVolumes"] = new BSReflectionReference(
                () => m_InternalObject.lightProbeProxyVolumes ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.lightProbeProxyVolumes = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["motionVectors"] = new BSReflectionReference(
                () => m_InternalObject.motionVectors ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.motionVectors = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["receiveShadows"] = new BSReflectionReference(
                () => m_InternalObject.receiveShadows ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.receiveShadows = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["reflectionProbes"] = new BSReflectionReference(
                () => m_InternalObject.reflectionProbes ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.reflectionProbes = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["rendererPriority"] = new BSReflectionReference(
                () => m_InternalObject.rendererPriority ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.rendererPriority = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["terrainDetailUnsupported"] = new BSReflectionReference(
                () => m_InternalObject.terrainDetailUnsupported ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.terrainDetailUnsupported = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["rendersUIOverlay"] = new BSReflectionReference(
                () => m_InternalObject.rendersUIOverlay ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.rendersUIOverlay = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["overridesEnvironmentLighting"] = new BSReflectionReference(
                () => m_InternalObject.overridesEnvironmentLighting ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.overridesEnvironmentLighting = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["overridesFog"] = new BSReflectionReference(
                () => m_InternalObject.overridesFog ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.overridesFog = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["overridesRealtimeReflectionProbes"] = new BSReflectionReference(
                () => m_InternalObject.overridesRealtimeReflectionProbes ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.overridesRealtimeReflectionProbes = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["overridesOtherLightingSettings"] = new BSReflectionReference(
                () => m_InternalObject.overridesOtherLightingSettings ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.overridesOtherLightingSettings = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["editableMaterialRenderQueue"] = new BSReflectionReference(
                () => m_InternalObject.editableMaterialRenderQueue ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.editableMaterialRenderQueue = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["overridesLODBias"] = new BSReflectionReference(
                () => m_InternalObject.overridesLODBias ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.overridesLODBias = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["overridesMaximumLODLevel"] = new BSReflectionReference(
                () => m_InternalObject.overridesMaximumLODLevel ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.overridesMaximumLODLevel = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["rendererProbes"] = new BSReflectionReference(
                () => m_InternalObject.rendererProbes ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.rendererProbes = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["particleSystemInstancing"] = new BSReflectionReference(
                () => m_InternalObject.particleSystemInstancing ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.particleSystemInstancing = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["autoAmbientProbeBaking"] = new BSReflectionReference(
                () => m_InternalObject.autoAmbientProbeBaking ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.autoAmbientProbeBaking = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["autoDefaultReflectionProbeBaking"] = new BSReflectionReference(
                () => m_InternalObject.autoDefaultReflectionProbeBaking ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.autoDefaultReflectionProbeBaking = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["overridesShadowmask"] = new BSReflectionReference(
                () => m_InternalObject.overridesShadowmask ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.overridesShadowmask = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["overrideShadowmaskMessage"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.overrideShadowmaskMessage ),
                x => m_InternalObject.overrideShadowmaskMessage = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["shadowmaskMessage"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.shadowmaskMessage ),
                null );

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
