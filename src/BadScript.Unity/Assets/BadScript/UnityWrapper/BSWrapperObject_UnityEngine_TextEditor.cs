using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_TextEditor : BSWrapperObject < TextEditor >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TextEditor( TextEditor obj ) : base( obj )
        {
            m_Properties["content"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIContent( m_InternalObject.content ),
                x => m_InternalObject.content = WrapperHelper.UnwrapObject < GUIContent >( x ) );

            m_Properties["text"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.text ),
                x => m_InternalObject.text = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Rect >( x ) );

            m_Properties["cursorIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cursorIndex ),
                x => m_InternalObject.cursorIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["selectIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.selectIndex ),
                x => m_InternalObject.selectIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["altCursorPosition"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.altCursorPosition ),
                x => m_InternalObject.altCursorPosition = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["hasSelection"] = new BSReflectionReference(
                () => m_InternalObject.hasSelection ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["SelectedText"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.SelectedText ),
                null );

            m_Properties["keyboardOnScreen"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_TouchScreenKeyboard( m_InternalObject.keyboardOnScreen ),
                x => m_InternalObject.keyboardOnScreen = WrapperHelper.UnwrapObject < TouchScreenKeyboard >( x ) );

            m_Properties["controlID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.controlID ),
                x => m_InternalObject.controlID = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["style"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.style ),
                x => m_InternalObject.style = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["multiline"] = new BSReflectionReference(
                () => m_InternalObject.multiline ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.multiline = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["hasHorizontalCursorPos"] = new BSReflectionReference(
                () => m_InternalObject.hasHorizontalCursorPos ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.hasHorizontalCursorPos = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isPasswordField"] = new BSReflectionReference(
                () => m_InternalObject.isPasswordField ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isPasswordField = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["scrollOffset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.scrollOffset ),
                x => m_InternalObject.scrollOffset = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["graphicalCursorPos"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.graphicalCursorPos ),
                x => m_InternalObject.graphicalCursorPos = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["graphicalSelectCursorPos"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.graphicalSelectCursorPos ),
                x => m_InternalObject.graphicalSelectCursorPos = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["HandleKeyEvent"] = new BSFunctionReference(
                new BSFunction(
                    "function HandleKeyEvent(e)",
                    a => m_InternalObject.HandleKeyEvent( WrapperHelper.UnwrapObject < Event >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["IsOverSelection"] = new BSFunctionReference(
                new BSFunction(
                    "function IsOverSelection(cursorPosition)",
                    a => m_InternalObject.IsOverSelection( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["FindStartOfNextWord"] = new BSFunctionReference(
                new BSFunction(
                    "function FindStartOfNextWord(p)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.FindStartOfNextWord(
                            WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
