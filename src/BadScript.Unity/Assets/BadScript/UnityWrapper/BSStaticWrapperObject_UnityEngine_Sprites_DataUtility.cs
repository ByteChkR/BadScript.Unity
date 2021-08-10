using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Sprites;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Sprites_DataUtility : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Sprites_DataUtility() : base( typeof( DataUtility ) )
        {
            m_StaticProperties["GetInnerUV"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInnerUV(sprite)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        DataUtility.GetInnerUV( WrapperHelper.UnwrapObject < Sprite >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetOuterUV"] = new BSFunctionReference(
                new BSFunction(
                    "function GetOuterUV(sprite)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        DataUtility.GetOuterUV( WrapperHelper.UnwrapObject < Sprite >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetPadding"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPadding(sprite)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        DataUtility.GetPadding( WrapperHelper.UnwrapObject < Sprite >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetMinSize"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMinSize(sprite)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        DataUtility.GetMinSize( WrapperHelper.UnwrapObject < Sprite >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
