using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_AvatarBuilder : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_AvatarBuilder() : base( typeof( AvatarBuilder ) )
        {
            m_StaticProperties["BuildHumanAvatar"] = new BSFunctionReference(
                new BSFunction(
                    "function BuildHumanAvatar(go, humanDescription)",
                    a => new BSWrapperObject_UnityEngine_Avatar(
                        AvatarBuilder.BuildHumanAvatar(
                            WrapperHelper.UnwrapObject < GameObject >( a[0] ),
                            WrapperHelper.UnwrapObject < HumanDescription >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["BuildGenericAvatar"] = new BSFunctionReference(
                new BSFunction(
                    "function BuildGenericAvatar(go, rootMotionTransformName)",
                    a => new BSWrapperObject_UnityEngine_Avatar(
                        AvatarBuilder.BuildGenericAvatar(
                            WrapperHelper.UnwrapObject < GameObject >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
