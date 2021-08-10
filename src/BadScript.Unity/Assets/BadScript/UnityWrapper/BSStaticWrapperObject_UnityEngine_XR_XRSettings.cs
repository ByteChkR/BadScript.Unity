using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.XR;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_XR_XRSettings : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_XR_XRSettings() : base( typeof( XRSettings ) )
        {
            m_StaticProperties["enabled"] = new BSReflectionReference(
                () => XRSettings.enabled ? BSObject.One : BSObject.Zero,
                x => XRSettings.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["isDeviceActive"] = new BSReflectionReference(
                () => XRSettings.isDeviceActive ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["showDeviceView"] = new BSReflectionReference(
                () => XRSettings.showDeviceView ? BSObject.One : BSObject.Zero,
                x => XRSettings.showDeviceView = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["eyeTextureResolutionScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) XRSettings.eyeTextureResolutionScale ),
                x => XRSettings.eyeTextureResolutionScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["eyeTextureWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) XRSettings.eyeTextureWidth ),
                null );

            m_StaticProperties["eyeTextureHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) XRSettings.eyeTextureHeight ),
                null );

            m_StaticProperties["eyeTextureDesc"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderTextureDescriptor( XRSettings.eyeTextureDesc ),
                null );

            m_StaticProperties["renderViewportScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) XRSettings.renderViewportScale ),
                x => XRSettings.renderViewportScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["occlusionMaskScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) XRSettings.occlusionMaskScale ),
                x => XRSettings.occlusionMaskScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["useOcclusionMesh"] = new BSReflectionReference(
                () => XRSettings.useOcclusionMesh ? BSObject.One : BSObject.Zero,
                x => XRSettings.useOcclusionMesh = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["loadedDeviceName"] = new BSReflectionReference(
                () => new BSObject( XRSettings.loadedDeviceName ),
                null );

        }

        #endregion
    }

}
