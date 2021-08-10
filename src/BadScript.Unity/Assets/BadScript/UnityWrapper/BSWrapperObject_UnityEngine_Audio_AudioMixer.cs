using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Audio;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Audio_AudioMixer : BSWrapperObject < AudioMixer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Audio_AudioMixer( AudioMixer obj ) : base( obj )
        {
            m_Properties["outputAudioMixerGroup"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Audio_AudioMixerGroup( m_InternalObject.outputAudioMixerGroup ),
                x => m_InternalObject.outputAudioMixerGroup = WrapperHelper.UnwrapObject < AudioMixerGroup >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["FindSnapshot"] = new BSFunctionReference(
                new BSFunction(
                    "function FindSnapshot(name)",
                    a => new BSWrapperObject_UnityEngine_Audio_AudioMixerSnapshot(
                        m_InternalObject.FindSnapshot( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["SetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function SetFloat(name, value)",
                    a => m_InternalObject.SetFloat(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["ClearFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function ClearFloat(name)",
                    a => m_InternalObject.ClearFloat( WrapperHelper.UnwrapObject < string >( a[0] ) )
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
