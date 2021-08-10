using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Video;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Video_VideoClip : BSWrapperObject < VideoClip >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Video_VideoClip( VideoClip obj ) : base( obj )
        {
            m_Properties["originalPath"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.originalPath ),
                null );

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

            m_Properties["sRGB"] = new BSReflectionReference(
                () => m_InternalObject.sRGB ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["audioTrackCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.audioTrackCount ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetAudioChannelCount"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAudioChannelCount(audioTrackIdx)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetAudioChannelCount(
                            WrapperHelper.UnwrapObject < ushort >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetAudioSampleRate"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAudioSampleRate(audioTrackIdx)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetAudioSampleRate(
                            WrapperHelper.UnwrapObject < ushort >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetAudioLanguage"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAudioLanguage(audioTrackIdx)",
                    a => new BSObject(
                        m_InternalObject.GetAudioLanguage( WrapperHelper.UnwrapObject < ushort >( a[0] ) ) ),
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
