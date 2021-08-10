using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Audio;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Audio_AudioMixerSnapshot : BSWrapperObject < AudioMixerSnapshot >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Audio_AudioMixerSnapshot( AudioMixerSnapshot obj ) : base( obj )
        {
            m_Properties["audioMixer"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Audio_AudioMixer( m_InternalObject.audioMixer ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

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
