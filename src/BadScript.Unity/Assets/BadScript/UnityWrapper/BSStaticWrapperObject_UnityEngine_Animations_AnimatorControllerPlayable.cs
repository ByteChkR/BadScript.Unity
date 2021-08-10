using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Animations_AnimatorControllerPlayable : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Animations_AnimatorControllerPlayable() : base(
            typeof( AnimatorControllerPlayable ) )
        {
            m_StaticProperties["Null"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Animations_AnimatorControllerPlayable(
                    AnimatorControllerPlayable.Null ),
                null );

            m_StaticProperties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create(graph, controller)",
                    a => new BSWrapperObject_UnityEngine_Animations_AnimatorControllerPlayable(
                        AnimatorControllerPlayable.Create(
                            WrapperHelper.UnwrapObject < PlayableGraph >( a[0] ),
                            WrapperHelper.UnwrapObject < RuntimeAnimatorController >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
