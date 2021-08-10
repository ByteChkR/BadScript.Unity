using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Apple.ReplayKit;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Apple_ReplayKit_ReplayKit : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Apple_ReplayKit_ReplayKit() : base( typeof( ReplayKit ) )
        {
            m_StaticProperties["APIAvailable"] = new BSReflectionReference(
                () => ReplayKit.APIAvailable ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["broadcastingAPIAvailable"] = new BSReflectionReference(
                () => ReplayKit.broadcastingAPIAvailable ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["recordingAvailable"] = new BSReflectionReference(
                () => ReplayKit.recordingAvailable ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["isRecording"] = new BSReflectionReference(
                () => ReplayKit.isRecording ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["isBroadcasting"] = new BSReflectionReference(
                () => ReplayKit.isBroadcasting ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["isBroadcastingPaused"] = new BSReflectionReference(
                () => ReplayKit.isBroadcastingPaused ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["isPreviewControllerActive"] = new BSReflectionReference(
                () => ReplayKit.isPreviewControllerActive ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["cameraEnabled"] = new BSReflectionReference(
                () => ReplayKit.cameraEnabled ? BSObject.One : BSObject.Zero,
                x => ReplayKit.cameraEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["microphoneEnabled"] = new BSReflectionReference(
                () => ReplayKit.microphoneEnabled ? BSObject.One : BSObject.Zero,
                x => ReplayKit.microphoneEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["broadcastURL"] = new BSReflectionReference(
                () => new BSObject( ReplayKit.broadcastURL ),
                null );

            m_StaticProperties["lastError"] = new BSReflectionReference(
                () => new BSObject( ReplayKit.lastError ),
                null );

            m_StaticProperties["StartRecording"] = new BSFunctionReference(
                new BSFunction(
                    "function StartRecording(enableMicrophone, enableCamera)",
                    a => ReplayKit.StartRecording(
                        WrapperHelper.UnwrapObject < bool >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["StartRecording"] = new BSFunctionReference(
                new BSFunction(
                    "function StartRecording(enableMicrophone)",
                    a => ReplayKit.StartRecording( WrapperHelper.UnwrapObject < bool >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["ShowCameraPreviewAt"] = new BSFunctionReference(
                new BSFunction(
                    "function ShowCameraPreviewAt(posX, posY)",
                    a => ReplayKit.ShowCameraPreviewAt(
                        WrapperHelper.UnwrapObject < float >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["ShowCameraPreviewAt"] = new BSFunctionReference(
                new BSFunction(
                    "function ShowCameraPreviewAt(posX, posY, width, height)",
                    a => ReplayKit.ShowCameraPreviewAt(
                        WrapperHelper.UnwrapObject < float >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < float >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

        }

        #endregion
    }

}
