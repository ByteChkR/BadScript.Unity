using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Audio;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Audio_AudioMixerPlayable : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Audio_AudioMixerPlayable() : base( typeof( AudioMixerPlayable ) )
        {
            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(graph, inputCount, normalizeInputVolumes)",
                    a => new BSWrapperObject_UnityEngine_Audio_AudioMixerPlayable(
                        AudioMixerPlayable.Create(
                            WrapperHelper.UnwrapObject < PlayableGraph >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < bool >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}
