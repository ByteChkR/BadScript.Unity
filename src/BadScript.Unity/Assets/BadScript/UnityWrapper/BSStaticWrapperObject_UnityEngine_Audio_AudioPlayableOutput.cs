using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Audio_AudioPlayableOutput : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Audio_AudioPlayableOutput() : base( typeof( AudioPlayableOutput ) )
        {
            m_StaticProperties["Null"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Audio_AudioPlayableOutput( AudioPlayableOutput.Null ),
                null );

            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(graph, name, target)",
                    a => new BSWrapperObject_UnityEngine_Audio_AudioPlayableOutput(
                        AudioPlayableOutput.Create(
                            WrapperHelper.UnwrapObject < PlayableGraph >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < AudioSource >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}
