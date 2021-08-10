using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_GUIStyle : BSWrapperObject < GUIStyle >

    {
        #region Public

        public BSWrapperObject_UnityEngine_GUIStyle( GUIStyle obj ) : base( obj )
        {
            m_Properties["font"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Font( m_InternalObject.font ),
                x => m_InternalObject.font = WrapperHelper.UnwrapObject < Font >( x ) );

            m_Properties["wordWrap"] = new BSReflectionReference(
                () => m_InternalObject.wordWrap ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.wordWrap = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["contentOffset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.contentOffset ),
                x => m_InternalObject.contentOffset = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["fixedWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fixedWidth ),
                x => m_InternalObject.fixedWidth = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["fixedHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fixedHeight ),
                x => m_InternalObject.fixedHeight = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["stretchWidth"] = new BSReflectionReference(
                () => m_InternalObject.stretchWidth ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.stretchWidth = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["stretchHeight"] = new BSReflectionReference(
                () => m_InternalObject.stretchHeight ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.stretchHeight = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["fontSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fontSize ),
                x => m_InternalObject.fontSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["richText"] = new BSReflectionReference(
                () => m_InternalObject.richText ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.richText = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["clipOffset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.clipOffset ),
                x => m_InternalObject.clipOffset = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["normal"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyleState( m_InternalObject.normal ),
                x => m_InternalObject.normal = WrapperHelper.UnwrapObject < GUIStyleState >( x ) );

            m_Properties["hover"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyleState( m_InternalObject.hover ),
                x => m_InternalObject.hover = WrapperHelper.UnwrapObject < GUIStyleState >( x ) );

            m_Properties["active"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyleState( m_InternalObject.active ),
                x => m_InternalObject.active = WrapperHelper.UnwrapObject < GUIStyleState >( x ) );

            m_Properties["onNormal"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyleState( m_InternalObject.onNormal ),
                x => m_InternalObject.onNormal = WrapperHelper.UnwrapObject < GUIStyleState >( x ) );

            m_Properties["onHover"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyleState( m_InternalObject.onHover ),
                x => m_InternalObject.onHover = WrapperHelper.UnwrapObject < GUIStyleState >( x ) );

            m_Properties["onActive"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyleState( m_InternalObject.onActive ),
                x => m_InternalObject.onActive = WrapperHelper.UnwrapObject < GUIStyleState >( x ) );

            m_Properties["focused"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyleState( m_InternalObject.focused ),
                x => m_InternalObject.focused = WrapperHelper.UnwrapObject < GUIStyleState >( x ) );

            m_Properties["onFocused"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyleState( m_InternalObject.onFocused ),
                x => m_InternalObject.onFocused = WrapperHelper.UnwrapObject < GUIStyleState >( x ) );

            m_Properties["border"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RectOffset( m_InternalObject.border ),
                x => m_InternalObject.border = WrapperHelper.UnwrapObject < RectOffset >( x ) );

            m_Properties["margin"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RectOffset( m_InternalObject.margin ),
                x => m_InternalObject.margin = WrapperHelper.UnwrapObject < RectOffset >( x ) );

            m_Properties["padding"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RectOffset( m_InternalObject.padding ),
                x => m_InternalObject.padding = WrapperHelper.UnwrapObject < RectOffset >( x ) );

            m_Properties["overflow"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RectOffset( m_InternalObject.overflow ),
                x => m_InternalObject.overflow = WrapperHelper.UnwrapObject < RectOffset >( x ) );

            m_Properties["lineHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lineHeight ),
                null );

            m_Properties["isHeightDependantOnWidth"] = new BSReflectionReference(
                () => m_InternalObject.isHeightDependantOnWidth ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["GetCursorPixelPosition"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCursorPixelPosition(position, content, cursorStringIndex)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetCursorPixelPosition(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < GUIContent >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_Properties["GetCursorStringIndex"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCursorStringIndex(position, content, cursorPixelPosition)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetCursorStringIndex(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < GUIContent >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[2] ) ) ),
                    3 ) );

            m_Properties["CalcSize"] = new BSFunctionReference(
                new BSFunction(
                    "function CalcSize(content)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.CalcSize( WrapperHelper.UnwrapObject < GUIContent >( a[0] ) ) ),
                    1 ) );

            m_Properties["CalcScreenSize"] = new BSFunctionReference(
                new BSFunction(
                    "function CalcScreenSize(contentSize)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.CalcScreenSize( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_Properties["CalcHeight"] = new BSFunctionReference(
                new BSFunction(
                    "function CalcHeight(content, width)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.CalcHeight(
                            WrapperHelper.UnwrapObject < GUIContent >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

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
