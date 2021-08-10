using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Audio_AudioClipPlayable : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Audio_AudioClipPlayable() : base( typeof( AudioClipPlayable ) )
        {
            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(graph, clip, looping)",
                    a => new BSWrapperObject_UnityEngine_Audio_AudioClipPlayable(
                        AudioClipPlayable.Create(
                            WrapperHelper.UnwrapObject < PlayableGraph >( a[0] ),
                            WrapperHelper.UnwrapObject < AudioClip >( a[1] ),
                            WrapperHelper.UnwrapObject < bool >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}
