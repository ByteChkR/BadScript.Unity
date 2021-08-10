using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Animations;
using UnityEngine.Experimental.Animations;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSStaticWrapperObject_UnityEngine_Experimental_Animations_AnimationPlayableOutputExtensions :
            BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Experimental_Animations_AnimationPlayableOutputExtensions() : base(
            typeof( AnimationPlayableOutputExtensions ) )
        {
            m_StaticProperties["GetSortingOrder"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSortingOrder(output)",
                    a => new BSObject(
                        ( decimal ) AnimationPlayableOutputExtensions.GetSortingOrder(
                            WrapperHelper.UnwrapObject < AnimationPlayableOutput >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
