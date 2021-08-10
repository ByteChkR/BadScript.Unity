using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_RectTransformUtility : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_RectTransformUtility() : base( typeof( RectTransformUtility ) )
        {
            m_StaticProperties["PixelAdjustPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function PixelAdjustPoint(point, elementTransform, canvas)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        RectTransformUtility.PixelAdjustPoint(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Transform >( a[1] ),
                            WrapperHelper.UnwrapObject < Canvas >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["PixelAdjustRect"] = new BSFunctionReference(
                new BSFunction(
                    "function PixelAdjustRect(rectTransform, canvas)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        RectTransformUtility.PixelAdjustRect(
                            WrapperHelper.UnwrapObject < RectTransform >( a[0] ),
                            WrapperHelper.UnwrapObject < Canvas >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["RectangleContainsScreenPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function RectangleContainsScreenPoint(rect, screenPoint)",
                    a => RectTransformUtility.RectangleContainsScreenPoint(
                        WrapperHelper.UnwrapObject < RectTransform >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector2 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["RectangleContainsScreenPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function RectangleContainsScreenPoint(rect, screenPoint, cam)",
                    a => RectTransformUtility.RectangleContainsScreenPoint(
                        WrapperHelper.UnwrapObject < RectTransform >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                        WrapperHelper.UnwrapObject < Camera >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["RectangleContainsScreenPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function RectangleContainsScreenPoint(rect, screenPoint, cam, offset)",
                    a => RectTransformUtility.RectangleContainsScreenPoint(
                        WrapperHelper.UnwrapObject < RectTransform >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                        WrapperHelper.UnwrapObject < Camera >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector4 >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["ScreenPointToRay"] = new BSFunctionReference(
                new BSFunction(
                    "function ScreenPointToRay(cam, screenPos)",
                    a => new BSWrapperObject_UnityEngine_Ray(
                        RectTransformUtility.ScreenPointToRay(
                            WrapperHelper.UnwrapObject < Camera >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["WorldToScreenPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function WorldToScreenPoint(cam, worldPoint)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        RectTransformUtility.WorldToScreenPoint(
                            WrapperHelper.UnwrapObject < Camera >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["CalculateRelativeRectTransformBounds"] = new BSFunctionReference(
                new BSFunction(
                    "function CalculateRelativeRectTransformBounds(root, child)",
                    a => new BSWrapperObject_UnityEngine_Bounds(
                        RectTransformUtility.CalculateRelativeRectTransformBounds(
                            WrapperHelper.UnwrapObject < Transform >( a[0] ),
                            WrapperHelper.UnwrapObject < Transform >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["CalculateRelativeRectTransformBounds"] = new BSFunctionReference(
                new BSFunction(
                    "function CalculateRelativeRectTransformBounds(trans)",
                    a => new BSWrapperObject_UnityEngine_Bounds(
                        RectTransformUtility.CalculateRelativeRectTransformBounds(
                            WrapperHelper.UnwrapObject < Transform >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
