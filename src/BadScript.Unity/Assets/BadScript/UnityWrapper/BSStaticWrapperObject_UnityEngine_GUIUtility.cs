using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_GUIUtility : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_GUIUtility() : base( typeof( GUIUtility ) )
        {
            m_StaticProperties["hasModalWindow"] = new BSReflectionReference(
                () => GUIUtility.hasModalWindow ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["systemCopyBuffer"] = new BSReflectionReference(
                () => new BSObject( GUIUtility.systemCopyBuffer ),
                x => GUIUtility.systemCopyBuffer = WrapperHelper.UnwrapObject < string >( x ) );

            m_StaticProperties["hotControl"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) GUIUtility.hotControl ),
                x => GUIUtility.hotControl = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["keyboardControl"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) GUIUtility.keyboardControl ),
                x => GUIUtility.keyboardControl = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["GUIToScreenPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function GUIToScreenPoint(guiPoint)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        GUIUtility.GUIToScreenPoint( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GUIToScreenRect"] = new BSFunctionReference(
                new BSFunction(
                    "function GUIToScreenRect(guiRect)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        GUIUtility.GUIToScreenRect( WrapperHelper.UnwrapObject < Rect >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ScreenToGUIPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ScreenToGUIPoint(screenPoint)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        GUIUtility.ScreenToGUIPoint( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ScreenToGUIRect"] = new BSFunctionReference(
                new BSFunction(
                    "function ScreenToGUIRect(screenRect)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        GUIUtility.ScreenToGUIRect( WrapperHelper.UnwrapObject < Rect >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["AlignRectToDevice"] = new BSFunctionReference(
                new BSFunction(
                    "function AlignRectToDevice(rect)",
                    a => new BSWrapperObject_UnityEngine_Rect(
                        GUIUtility.AlignRectToDevice( WrapperHelper.UnwrapObject < Rect >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
