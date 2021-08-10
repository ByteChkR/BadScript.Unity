using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Experimental.Audio;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Experimental_Audio_AudioSampleProvider : BSWrapperObject < AudioSampleProvider >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Experimental_Audio_AudioSampleProvider( AudioSampleProvider obj ) : base(
            obj )
        {
            m_Properties["id"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.id ),
                null );

            m_Properties["trackIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.trackIndex ),
                null );

            m_Properties["owner"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Object( m_InternalObject.owner ),
                null );

            m_Properties["valid"] = new BSReflectionReference(
                () => m_InternalObject.valid ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["channelCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.channelCount ),
                null );

            m_Properties["sampleRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sampleRate ),
                null );

            m_Properties["maxSampleFrameCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxSampleFrameCount ),
                null );

            m_Properties["availableSampleFrameCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.availableSampleFrameCount ),
                null );

            m_Properties["freeSampleFrameCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.freeSampleFrameCount ),
                null );

            m_Properties["freeSampleFrameCountLowThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.freeSampleFrameCountLowThreshold ),
                x => m_InternalObject.freeSampleFrameCountLowThreshold = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["enableSampleFramesAvailableEvents"] = new BSReflectionReference(
                () => m_InternalObject.enableSampleFramesAvailableEvents ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enableSampleFramesAvailableEvents = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["enableSilencePadding"] = new BSReflectionReference(
                () => m_InternalObject.enableSilencePadding ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enableSilencePadding = WrapperHelper.UnwrapObject < bool >( x ) );

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
