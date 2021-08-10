using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Color32 : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Color32() : base( typeof( Color32 ) )
        {
            m_StaticProperties["Lerp"] = new BSFunctionReference(
                new BSFunction(
                    "function Lerp(a, b, t)",
                    a => new BSWrapperObject_UnityEngine_Color32(
                        Color32.Lerp(
                            WrapperHelper.UnwrapObject < Color32 >( a[0] ),
                            WrapperHelper.UnwrapObject < Color32 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["LerpUnclamped"] = new BSFunctionReference(
                new BSFunction(
                    "function LerpUnclamped(a, b, t)",
                    a => new BSWrapperObject_UnityEngine_Color32(
                        Color32.LerpUnclamped(
                            WrapperHelper.UnwrapObject < Color32 >( a[0] ),
                            WrapperHelper.UnwrapObject < Color32 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}
