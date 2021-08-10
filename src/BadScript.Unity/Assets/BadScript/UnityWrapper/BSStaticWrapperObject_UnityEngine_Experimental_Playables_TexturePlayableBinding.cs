using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Experimental.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Experimental_Playables_TexturePlayableBinding : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Experimental_Playables_TexturePlayableBinding() : base(
            typeof( TexturePlayableBinding ) )
        {
            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(name, key)",
                    a => new BSWrapperObject_UnityEngine_Playables_PlayableBinding(
                        TexturePlayableBinding.Create(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Object >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
