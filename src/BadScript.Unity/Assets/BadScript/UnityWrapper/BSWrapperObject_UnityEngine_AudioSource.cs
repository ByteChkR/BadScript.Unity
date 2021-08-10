using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Audio;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AudioSource : BSWrapperObject < AudioSource >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AudioSource( AudioSource obj ) : base( obj )
        {
            m_Properties["volume"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.volume ),
                x => m_InternalObject.volume = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["pitch"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pitch ),
                x => m_InternalObject.pitch = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["time"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.time ),
                x => m_InternalObject.time = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["timeSamples"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.timeSamples ),
                x => m_InternalObject.timeSamples = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["clip"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AudioClip( m_InternalObject.clip ),
                x => m_InternalObject.clip = WrapperHelper.UnwrapObject < AudioClip >( x ) );

            m_Properties["outputAudioMixerGroup"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Audio_AudioMixerGroup( m_InternalObject.outputAudioMixerGroup ),
                x => m_InternalObject.outputAudioMixerGroup = WrapperHelper.UnwrapObject < AudioMixerGroup >( x ) );

            m_Properties["isPlaying"] = new BSReflectionReference(
                () => m_InternalObject.isPlaying ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isVirtual"] = new BSReflectionReference(
                () => m_InternalObject.isVirtual ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["loop"] = new BSReflectionReference(
                () => m_InternalObject.loop ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.loop = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["ignoreListenerVolume"] = new BSReflectionReference(
                () => m_InternalObject.ignoreListenerVolume ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.ignoreListenerVolume = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["playOnAwake"] = new BSReflectionReference(
                () => m_InternalObject.playOnAwake ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.playOnAwake = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["ignoreListenerPause"] = new BSReflectionReference(
                () => m_InternalObject.ignoreListenerPause ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.ignoreListenerPause = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["panStereo"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.panStereo ),
                x => m_InternalObject.panStereo = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["spatialBlend"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.spatialBlend ),
                x => m_InternalObject.spatialBlend = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["spatialize"] = new BSReflectionReference(
                () => m_InternalObject.spatialize ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.spatialize = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["spatializePostEffects"] = new BSReflectionReference(
                () => m_InternalObject.spatializePostEffects ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.spatializePostEffects = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["reverbZoneMix"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.reverbZoneMix ),
                x => m_InternalObject.reverbZoneMix = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bypassEffects"] = new BSReflectionReference(
                () => m_InternalObject.bypassEffects ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.bypassEffects = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["bypassListenerEffects"] = new BSReflectionReference(
                () => m_InternalObject.bypassListenerEffects ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.bypassListenerEffects = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["bypassReverbZones"] = new BSReflectionReference(
                () => m_InternalObject.bypassReverbZones ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.bypassReverbZones = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["dopplerLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.dopplerLevel ),
                x => m_InternalObject.dopplerLevel = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["spread"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.spread ),
                x => m_InternalObject.spread = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["priority"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.priority ),
                x => m_InternalObject.priority = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["mute"] = new BSReflectionReference(
                () => m_InternalObject.mute ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.mute = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["minDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minDistance ),
                x => m_InternalObject.minDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maxDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxDistance ),
                x => m_InternalObject.maxDistance = WrapperHelper.UnwrapObject < float >( x ) );

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

            m_Properties["SetSpatializerFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function SetSpatializerFloat(index, value)",
                    a => m_InternalObject.SetSpatializerFloat(
                        WrapperHelper.UnwrapObject < int >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["SetAmbisonicDecoderFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function SetAmbisonicDecoderFloat(index, value)",
                    a => m_InternalObject.SetAmbisonicDecoderFloat(
                        WrapperHelper.UnwrapObject < int >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
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
