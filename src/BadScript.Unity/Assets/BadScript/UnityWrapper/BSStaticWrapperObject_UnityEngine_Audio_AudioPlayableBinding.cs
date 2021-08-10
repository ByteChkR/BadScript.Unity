using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Audio;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Audio_AudioPlayableBinding : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Audio_AudioPlayableBinding() : base( typeof( AudioPlayableBinding ) )
        {
            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(name, key)",
                    a => new BSWrapperObject_UnityEngine_Playables_PlayableBinding(
                        AudioPlayableBinding.Create(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Object >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
