using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_GUISkin : BSWrapperObject < GUISkin >

    {
        #region Public

        public BSWrapperObject_UnityEngine_GUISkin( GUISkin obj ) : base( obj )
        {
            m_Properties["font"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Font( m_InternalObject.font ),
                x => m_InternalObject.font = WrapperHelper.UnwrapObject < Font >( x ) );

            m_Properties["box"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.box ),
                x => m_InternalObject.box = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["label"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.label ),
                x => m_InternalObject.label = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["textField"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.textField ),
                x => m_InternalObject.textField = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["textArea"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.textArea ),
                x => m_InternalObject.textArea = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["button"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.button ),
                x => m_InternalObject.button = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["toggle"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.toggle ),
                x => m_InternalObject.toggle = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["window"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.window ),
                x => m_InternalObject.window = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["horizontalSlider"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.horizontalSlider ),
                x => m_InternalObject.horizontalSlider = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["horizontalSliderThumb"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.horizontalSliderThumb ),
                x => m_InternalObject.horizontalSliderThumb = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["verticalSlider"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.verticalSlider ),
                x => m_InternalObject.verticalSlider = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["verticalSliderThumb"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.verticalSliderThumb ),
                x => m_InternalObject.verticalSliderThumb = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["horizontalScrollbar"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.horizontalScrollbar ),
                x => m_InternalObject.horizontalScrollbar = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["horizontalScrollbarThumb"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.horizontalScrollbarThumb ),
                x => m_InternalObject.horizontalScrollbarThumb = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["horizontalScrollbarLeftButton"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.horizontalScrollbarLeftButton ),
                x => m_InternalObject.horizontalScrollbarLeftButton = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["horizontalScrollbarRightButton"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.horizontalScrollbarRightButton ),
                x => m_InternalObject.horizontalScrollbarRightButton = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["verticalScrollbar"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.verticalScrollbar ),
                x => m_InternalObject.verticalScrollbar = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["verticalScrollbarThumb"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.verticalScrollbarThumb ),
                x => m_InternalObject.verticalScrollbarThumb = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["verticalScrollbarUpButton"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.verticalScrollbarUpButton ),
                x => m_InternalObject.verticalScrollbarUpButton = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["verticalScrollbarDownButton"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.verticalScrollbarDownButton ),
                x => m_InternalObject.verticalScrollbarDownButton = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["scrollView"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUIStyle( m_InternalObject.scrollView ),
                x => m_InternalObject.scrollView = WrapperHelper.UnwrapObject < GUIStyle >( x ) );

            m_Properties["settings"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUISettings( m_InternalObject.settings ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetStyle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStyle(styleName)",
                    a => new BSWrapperObject_UnityEngine_GUIStyle(
                        m_InternalObject.GetStyle( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["FindStyle"] = new BSFunctionReference(
                new BSFunction(
                    "function FindStyle(styleName)",
                    a => new BSWrapperObject_UnityEngine_GUIStyle(
                        m_InternalObject.FindStyle( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
