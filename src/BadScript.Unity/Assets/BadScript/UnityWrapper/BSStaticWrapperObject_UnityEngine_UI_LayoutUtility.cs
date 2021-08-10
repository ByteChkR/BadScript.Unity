using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UI_LayoutUtility : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UI_LayoutUtility() : base( typeof( LayoutUtility ) )
        {
            m_StaticProperties["GetMinSize"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMinSize(rect, axis)",
                    a => new BSObject(
                        ( decimal ) LayoutUtility.GetMinSize(
                            WrapperHelper.UnwrapObject < RectTransform >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetPreferredSize"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPreferredSize(rect, axis)",
                    a => new BSObject(
                        ( decimal ) LayoutUtility.GetPreferredSize(
                            WrapperHelper.UnwrapObject < RectTransform >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetFlexibleSize"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFlexibleSize(rect, axis)",
                    a => new BSObject(
                        ( decimal ) LayoutUtility.GetFlexibleSize(
                            WrapperHelper.UnwrapObject < RectTransform >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetMinWidth"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMinWidth(rect)",
                    a => new BSObject(
                        ( decimal ) LayoutUtility.GetMinWidth( WrapperHelper.UnwrapObject < RectTransform >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetPreferredWidth"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPreferredWidth(rect)",
                    a => new BSObject(
                        ( decimal ) LayoutUtility.GetPreferredWidth(
                            WrapperHelper.UnwrapObject < RectTransform >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetFlexibleWidth"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFlexibleWidth(rect)",
                    a => new BSObject(
                        ( decimal ) LayoutUtility.GetFlexibleWidth(
                            WrapperHelper.UnwrapObject < RectTransform >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetMinHeight"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMinHeight(rect)",
                    a => new BSObject(
                        ( decimal ) LayoutUtility.GetMinHeight(
                            WrapperHelper.UnwrapObject < RectTransform >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetPreferredHeight"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPreferredHeight(rect)",
                    a => new BSObject(
                        ( decimal ) LayoutUtility.GetPreferredHeight(
                            WrapperHelper.UnwrapObject < RectTransform >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetFlexibleHeight"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFlexibleHeight(rect)",
                    a => new BSObject(
                        ( decimal ) LayoutUtility.GetFlexibleHeight(
                            WrapperHelper.UnwrapObject < RectTransform >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
