using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Animations;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Animations_AnimatorJobExtensions : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Animations_AnimatorJobExtensions() : base(
            typeof( AnimatorJobExtensions ) )
        {
            m_StaticProperties["BindStreamTransform"] = new BSFunctionReference(
                new BSFunction(
                    "function BindStreamTransform(animator, transform)",
                    a => new BSWrapperObject_UnityEngine_Animations_TransformStreamHandle(
                        AnimatorJobExtensions.BindStreamTransform(
                            WrapperHelper.UnwrapObject < Animator >( a[0] ),
                            WrapperHelper.UnwrapObject < Transform >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["BindSceneTransform"] = new BSFunctionReference(
                new BSFunction(
                    "function BindSceneTransform(animator, transform)",
                    a => new BSWrapperObject_UnityEngine_Animations_TransformSceneHandle(
                        AnimatorJobExtensions.BindSceneTransform(
                            WrapperHelper.UnwrapObject < Animator >( a[0] ),
                            WrapperHelper.UnwrapObject < Transform >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
