using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Animations_AnimationLayerMixerPlayable : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Animations_AnimationLayerMixerPlayable() : base(
            typeof( AnimationLayerMixerPlayable ) )
        {
            m_StaticProperties["Null"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Animations_AnimationLayerMixerPlayable(
                    AnimationLayerMixerPlayable.Null ),
                null );

            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(graph, inputCount)",
                    a => new BSWrapperObject_UnityEngine_Animations_AnimationLayerMixerPlayable(
                        AnimationLayerMixerPlayable.Create(
                            WrapperHelper.UnwrapObject < PlayableGraph >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
