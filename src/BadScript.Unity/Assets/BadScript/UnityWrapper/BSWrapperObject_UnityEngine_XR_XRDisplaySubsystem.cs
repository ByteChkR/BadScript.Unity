using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;
using UnityEngine.XR;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_XR_XRDisplaySubsystem : BSWrapperObject < XRDisplaySubsystem >

    {
        #region Public

        public BSWrapperObject_UnityEngine_XR_XRDisplaySubsystem( XRDisplaySubsystem obj ) : base( obj )
        {
            m_Properties["singlePassRenderingDisabled"] = new BSReflectionReference(
                () => m_InternalObject.singlePassRenderingDisabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.singlePassRenderingDisabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["displayOpaque"] = new BSReflectionReference(
                () => m_InternalObject.displayOpaque ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["contentProtectionEnabled"] = new BSReflectionReference(
                () => m_InternalObject.contentProtectionEnabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.contentProtectionEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["scaleOfAllViewports"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.scaleOfAllViewports ),
                x => m_InternalObject.scaleOfAllViewports = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["scaleOfAllRenderTargets"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.scaleOfAllRenderTargets ),
                x => m_InternalObject.scaleOfAllRenderTargets = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["zNear"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.zNear ),
                x => m_InternalObject.zNear = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["zFar"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.zFar ),
                x => m_InternalObject.zFar = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["sRGB"] = new BSReflectionReference(
                () => m_InternalObject.sRGB ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.sRGB = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["disableLegacyRenderer"] = new BSReflectionReference(
                () => m_InternalObject.disableLegacyRenderer ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.disableLegacyRenderer = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["subsystemDescriptor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_XR_XRDisplaySubsystemDescriptor(
                    m_InternalObject.subsystemDescriptor ),
                null );

            m_Properties["SubsystemDescriptor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_XR_XRDisplaySubsystemDescriptor(
                    m_InternalObject.SubsystemDescriptor ),
                null );

            m_Properties["running"] = new BSReflectionReference(
                () => m_InternalObject.running ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["GetRenderTextureForRenderPass"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRenderTextureForRenderPass(renderPass)",
                    a => new BSWrapperObject_UnityEngine_RenderTexture(
                        m_InternalObject.GetRenderTextureForRenderPass( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["AddGraphicsThreadMirrorViewBlit"] = new BSFunctionReference(
                new BSFunction(
                    "function AddGraphicsThreadMirrorViewBlit(cmd, allowGraphicsStateInvalidate)",
                    a => m_InternalObject.AddGraphicsThreadMirrorViewBlit(
                        WrapperHelper.UnwrapObject < CommandBuffer >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["AddGraphicsThreadMirrorViewBlit"] = new BSFunctionReference(
                new BSFunction(
                    "function AddGraphicsThreadMirrorViewBlit(cmd, allowGraphicsStateInvalidate, mode)",
                    a => m_InternalObject.AddGraphicsThreadMirrorViewBlit(
                        WrapperHelper.UnwrapObject < CommandBuffer >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

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
