using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Video;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Video_VideoPlayer : BSWrapperObject < VideoPlayer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Video_VideoPlayer( VideoPlayer obj ) : base( obj )
        {
            m_Properties["url"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.url ),
                x => m_InternalObject.url = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["clip"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Video_VideoClip( m_InternalObject.clip ),
                x => m_InternalObject.clip = WrapperHelper.UnwrapObject < VideoClip >( x ) );

            m_Properties["targetCamera"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Camera( m_InternalObject.targetCamera ),
                x => m_InternalObject.targetCamera = WrapperHelper.UnwrapObject < Camera >( x ) );

            m_Properties["targetTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderTexture( m_InternalObject.targetTexture ),
                x => m_InternalObject.targetTexture = WrapperHelper.UnwrapObject < RenderTexture >( x ) );

            m_Properties["targetMaterialRenderer"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Renderer( m_InternalObject.targetMaterialRenderer ),
                x => m_InternalObject.targetMaterialRenderer = WrapperHelper.UnwrapObject < Renderer >( x ) );

            m_Properties["targetMaterialProperty"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.targetMaterialProperty ),
                x => m_InternalObject.targetMaterialProperty = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["targetCameraAlpha"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.targetCameraAlpha ),
                x => m_InternalObject.targetCameraAlpha = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["texture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture( m_InternalObject.texture ),
                null );

            m_Properties["isPrepared"] = new BSReflectionReference(
                () => m_InternalObject.isPrepared ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["waitForFirstFrame"] = new BSReflectionReference(
                () => m_InternalObject.waitForFirstFrame ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.waitForFirstFrame = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["playOnAwake"] = new BSReflectionReference(
                () => m_InternalObject.playOnAwake ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.playOnAwake = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isPlaying"] = new BSReflectionReference(
                () => m_InternalObject.isPlaying ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isPaused"] = new BSReflectionReference(
                () => m_InternalObject.isPaused ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["canSetTime"] = new BSReflectionReference(
                () => m_InternalObject.canSetTime ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["time"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.time ),
                x => m_InternalObject.time = WrapperHelper.UnwrapObject < double >( x ) );

            m_Properties["frame"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.frame ),
                x => m_InternalObject.frame = WrapperHelper.UnwrapObject < long >( x ) );

            m_Properties["clockTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.clockTime ),
                null );

            m_Properties["canStep"] = new BSReflectionReference(
                () => m_InternalObject.canStep ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["canSetPlaybackSpeed"] = new BSReflectionReference(
                () => m_InternalObject.canSetPlaybackSpeed ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["playbackSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.playbackSpeed ),
                x => m_InternalObject.playbackSpeed = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["isLooping"] = new BSReflectionReference(
                () => m_InternalObject.isLooping ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isLooping = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["canSetTimeSource"] = new BSReflectionReference(
                () => m_InternalObject.canSetTimeSource ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["externalReferenceTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.externalReferenceTime ),
                x => m_InternalObject.externalReferenceTime = WrapperHelper.UnwrapObject < double >( x ) );

            m_Properties["canSetSkipOnDrop"] = new BSReflectionReference(
                () => m_InternalObject.canSetSkipOnDrop ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["skipOnDrop"] = new BSReflectionReference(
                () => m_InternalObject.skipOnDrop ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.skipOnDrop = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["frameCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.frameCount ),
                null );

            m_Properties["frameRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.frameRate ),
                null );

            m_Properties["length"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.length ),
                null );

            m_Properties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.width ),
                null );

            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                null );

            m_Properties["pixelAspectRatioNumerator"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pixelAspectRatioNumerator ),
                null );

            m_Properties["pixelAspectRatioDenominator"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pixelAspectRatioDenominator ),
                null );

            m_Properties["audioTrackCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.audioTrackCount ),
                null );

            m_Properties["controlledAudioTrackCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.controlledAudioTrackCount ),
                x => m_InternalObject.controlledAudioTrackCount = WrapperHelper.UnwrapObject < ushort >( x ) );

            m_Properties["canSetDirectAudioVolume"] = new BSReflectionReference(
                () => m_InternalObject.canSetDirectAudioVolume ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["sendFrameReadyEvents"] = new BSReflectionReference(
                () => m_InternalObject.sendFrameReadyEvents ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.sendFrameReadyEvents = WrapperHelper.UnwrapObject < bool >( x ) );

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

            m_Properties["GetAudioLanguageCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAudioLanguageCode(trackIndex)",
                    a => new BSObject(
                        m_InternalObject.GetAudioLanguageCode( WrapperHelper.UnwrapObject < ushort >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetAudioChannelCount"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAudioChannelCount(trackIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetAudioChannelCount(
                            WrapperHelper.UnwrapObject < ushort >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetAudioSampleRate"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAudioSampleRate(trackIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetAudioSampleRate(
                            WrapperHelper.UnwrapObject < ushort >( a[0] ) ) ),
                    1 ) );

            m_Properties["IsAudioTrackEnabled"] = new BSFunctionReference(
                new BSFunction(
                    "function IsAudioTrackEnabled(trackIndex)",
                    a => m_InternalObject.IsAudioTrackEnabled( WrapperHelper.UnwrapObject < ushort >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetDirectAudioVolume"] = new BSFunctionReference(
                new BSFunction(
                    "function GetDirectAudioVolume(trackIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetDirectAudioVolume(
                            WrapperHelper.UnwrapObject < ushort >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetDirectAudioMute"] = new BSFunctionReference(
                new BSFunction(
                    "function GetDirectAudioMute(trackIndex)",
                    a => m_InternalObject.GetDirectAudioMute( WrapperHelper.UnwrapObject < ushort >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetTargetAudioSource"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTargetAudioSource(trackIndex)",
                    a => new BSWrapperObject_UnityEngine_AudioSource(
                        m_InternalObject.GetTargetAudioSource( WrapperHelper.UnwrapObject < ushort >( a[0] ) ) ),
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
