using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Experimental.Playables;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Experimental_Playables_TextureMixerPlayable : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Experimental_Playables_TextureMixerPlayable() : base(
            typeof( TextureMixerPlayable ) )
        {
            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(graph)",
                    a => new BSWrapperObject_UnityEngine_Experimental_Playables_TextureMixerPlayable(
                        TextureMixerPlayable.Create( WrapperHelper.UnwrapObject < PlayableGraph >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
