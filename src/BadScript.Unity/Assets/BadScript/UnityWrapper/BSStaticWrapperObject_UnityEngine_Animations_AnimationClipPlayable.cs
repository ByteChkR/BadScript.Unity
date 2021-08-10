using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Animations_AnimationClipPlayable : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Animations_AnimationClipPlayable() : base(
            typeof( AnimationClipPlayable ) )
        {
            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(graph, clip)",
                    a => new BSWrapperObject_UnityEngine_Animations_AnimationClipPlayable(
                        AnimationClipPlayable.Create(
                            WrapperHelper.UnwrapObject < PlayableGraph >( a[0] ),
                            WrapperHelper.UnwrapObject < AnimationClip >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
