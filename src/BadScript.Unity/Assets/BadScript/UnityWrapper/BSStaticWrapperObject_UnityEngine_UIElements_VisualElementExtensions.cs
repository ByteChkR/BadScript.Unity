using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_VisualElementExtensions : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_VisualElementExtensions() : base(
            typeof( VisualElementExtensions ) )
        {
            m_StaticProperties["WorldToLocal"] = new BSFunctionReference(
                new BSFunction(
                    "function WorldToLocal(ele, p)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        VisualElementExtensions.WorldToLocal(
                            WrapperHelper.UnwrapObject < VisualElement >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["LocalToWorld"] = new BSFunctionReference(
                new BSFunction(
                    "function LocalToWorld(ele, p)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        VisualElementExtensions.LocalToWorld(
                            WrapperHelper.UnwrapObject < VisualElement >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["WorldToLocal"] = new BSFunctionReference(
                new BSFunction(
                    "function WorldToLocal(ele, r)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        VisualElementExtensions.WorldToLocal(
                            WrapperHelper.UnwrapObject < VisualElement >( a[0] ),
                            WrapperHelper.UnwrapObject < Rect >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["LocalToWorld"] = new BSFunctionReference(
                new BSFunction(
                    "function LocalToWorld(ele, r)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        VisualElementExtensions.LocalToWorld(
                            WrapperHelper.UnwrapObject < VisualElement >( a[0] ),
                            WrapperHelper.UnwrapObject < Rect >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["ChangeCoordinatesTo"] = new BSFunctionReference(
                new BSFunction(
                    "function ChangeCoordinatesTo(src, dest, point)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        VisualElementExtensions.ChangeCoordinatesTo(
                            WrapperHelper.UnwrapObject < VisualElement >( a[0] ),
                            WrapperHelper.UnwrapObject < VisualElement >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["ChangeCoordinatesTo"] = new BSFunctionReference(
                new BSFunction(
                    "function ChangeCoordinatesTo(src, dest, rect)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        VisualElementExtensions.ChangeCoordinatesTo(
                            WrapperHelper.UnwrapObject < VisualElement >( a[0] ),
                            WrapperHelper.UnwrapObject < VisualElement >( a[1] ),
                            WrapperHelper.UnwrapObject < Rect >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}
