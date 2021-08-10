using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Animations;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Animations_AnimationPlayableBinding : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Animations_AnimationPlayableBinding() : base(
            typeof( AnimationPlayableBinding ) )
        {
            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(name, key)",
                    a => new BSWrapperObject_UnityEngine_Playables_PlayableBinding(
                        AnimationPlayableBinding.Create(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Object >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
