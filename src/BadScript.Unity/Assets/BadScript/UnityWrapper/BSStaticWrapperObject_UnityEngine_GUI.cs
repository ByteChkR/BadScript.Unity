using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_GUI : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_GUI() : base( typeof( GUI ) )
        {
            m_StaticProperties["color"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( GUI.color ),
                x => GUI.color = WrapperHelper.UnwrapObject < Color >( x ) );

            m_StaticProperties["backgroundColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( GUI.backgroundColor ),
                x => GUI.backgroundColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_StaticProperties["contentColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( GUI.contentColor ),
                x => GUI.contentColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_StaticProperties["changed"] = new BSReflectionReference(
                () => GUI.changed ? BSObject.One : BSObject.Zero,
                x => GUI.changed = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["enabled"] = new BSReflectionReference(
                () => GUI.enabled ? BSObject.One : BSObject.Zero,
                x => GUI.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["depth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) GUI.depth ),
                x => GUI.depth = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["skin"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GUISkin( GUI.skin ),
                x => GUI.skin = WrapperHelper.UnwrapObject < GUISkin >( x ) );

            m_StaticProperties["matrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( GUI.matrix ),
                x => GUI.matrix = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_StaticProperties["tooltip"] = new BSReflectionReference(
                () => new BSObject( GUI.tooltip ),
                x => GUI.tooltip = WrapperHelper.UnwrapObject < string >( x ) );

            m_StaticProperties["Button"] = new BSFunctionReference(
                new BSFunction(
                    "function Button(position, text)",
                    a => GUI.Button(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < string >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["Button"] = new BSFunctionReference(
                new BSFunction(
                    "function Button(position, image)",
                    a => GUI.Button(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < Texture >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["Button"] = new BSFunctionReference(
                new BSFunction(
                    "function Button(position, content)",
                    a => GUI.Button(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < GUIContent >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["Button"] = new BSFunctionReference(
                new BSFunction(
                    "function Button(position, text, style)",
                    a => GUI.Button(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < string >( a[1] ),
                        WrapperHelper.UnwrapObject < GUIStyle >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Button"] = new BSFunctionReference(
                new BSFunction(
                    "function Button(position, image, style)",
                    a => GUI.Button(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < Texture >( a[1] ),
                        WrapperHelper.UnwrapObject < GUIStyle >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Button"] = new BSFunctionReference(
                new BSFunction(
                    "function Button(position, content, style)",
                    a => GUI.Button(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < GUIContent >( a[1] ),
                        WrapperHelper.UnwrapObject < GUIStyle >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["RepeatButton"] = new BSFunctionReference(
                new BSFunction(
                    "function RepeatButton(position, text)",
                    a => GUI.RepeatButton(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < string >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["RepeatButton"] = new BSFunctionReference(
                new BSFunction(
                    "function RepeatButton(position, image)",
                    a => GUI.RepeatButton(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < Texture >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["RepeatButton"] = new BSFunctionReference(
                new BSFunction(
                    "function RepeatButton(position, content)",
                    a => GUI.RepeatButton(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < GUIContent >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["RepeatButton"] = new BSFunctionReference(
                new BSFunction(
                    "function RepeatButton(position, text, style)",
                    a => GUI.RepeatButton(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < string >( a[1] ),
                        WrapperHelper.UnwrapObject < GUIStyle >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["RepeatButton"] = new BSFunctionReference(
                new BSFunction(
                    "function RepeatButton(position, image, style)",
                    a => GUI.RepeatButton(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < Texture >( a[1] ),
                        WrapperHelper.UnwrapObject < GUIStyle >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["RepeatButton"] = new BSFunctionReference(
                new BSFunction(
                    "function RepeatButton(position, content, style)",
                    a => GUI.RepeatButton(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < GUIContent >( a[1] ),
                        WrapperHelper.UnwrapObject < GUIStyle >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["TextField"] = new BSFunctionReference(
                new BSFunction(
                    "function TextField(position, text)",
                    a => new BSObject(
                        GUI.TextField(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["TextField"] = new BSFunctionReference(
                new BSFunction(
                    "function TextField(position, text, maxLength)",
                    a => new BSObject(
                        GUI.TextField(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["TextField"] = new BSFunctionReference(
                new BSFunction(
                    "function TextField(position, text, style)",
                    a => new BSObject(
                        GUI.TextField(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["TextField"] = new BSFunctionReference(
                new BSFunction(
                    "function TextField(position, text, maxLength, style)",
                    a => new BSObject(
                        GUI.TextField(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["PasswordField"] = new BSFunctionReference(
                new BSFunction(
                    "function PasswordField(position, password, maskChar)",
                    a => new BSObject(
                        GUI.PasswordField(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < char >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["PasswordField"] = new BSFunctionReference(
                new BSFunction(
                    "function PasswordField(position, password, maskChar, maxLength)",
                    a => new BSObject(
                        GUI.PasswordField(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < char >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["PasswordField"] = new BSFunctionReference(
                new BSFunction(
                    "function PasswordField(position, password, maskChar, style)",
                    a => new BSObject(
                        GUI.PasswordField(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < char >( a[2] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["PasswordField"] = new BSFunctionReference(
                new BSFunction(
                    "function PasswordField(position, password, maskChar, maxLength, style)",
                    a => new BSObject(
                        GUI.PasswordField(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < char >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["TextArea"] = new BSFunctionReference(
                new BSFunction(
                    "function TextArea(position, text)",
                    a => new BSObject(
                        GUI.TextArea(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["TextArea"] = new BSFunctionReference(
                new BSFunction(
                    "function TextArea(position, text, maxLength)",
                    a => new BSObject(
                        GUI.TextArea(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["TextArea"] = new BSFunctionReference(
                new BSFunction(
                    "function TextArea(position, text, style)",
                    a => new BSObject(
                        GUI.TextArea(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["TextArea"] = new BSFunctionReference(
                new BSFunction(
                    "function TextArea(position, text, maxLength, style)",
                    a => new BSObject(
                        GUI.TextArea(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["Toggle"] = new BSFunctionReference(
                new BSFunction(
                    "function Toggle(position, value, text)",
                    a => GUI.Toggle(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ),
                        WrapperHelper.UnwrapObject < string >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Toggle"] = new BSFunctionReference(
                new BSFunction(
                    "function Toggle(position, value, image)",
                    a => GUI.Toggle(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ),
                        WrapperHelper.UnwrapObject < Texture >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Toggle"] = new BSFunctionReference(
                new BSFunction(
                    "function Toggle(position, value, content)",
                    a => GUI.Toggle(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ),
                        WrapperHelper.UnwrapObject < GUIContent >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Toggle"] = new BSFunctionReference(
                new BSFunction(
                    "function Toggle(position, value, text, style)",
                    a => GUI.Toggle(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ),
                        WrapperHelper.UnwrapObject < string >( a[2] ),
                        WrapperHelper.UnwrapObject < GUIStyle >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["Toggle"] = new BSFunctionReference(
                new BSFunction(
                    "function Toggle(position, value, image, style)",
                    a => GUI.Toggle(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ),
                        WrapperHelper.UnwrapObject < Texture >( a[2] ),
                        WrapperHelper.UnwrapObject < GUIStyle >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["Toggle"] = new BSFunctionReference(
                new BSFunction(
                    "function Toggle(position, value, content, style)",
                    a => GUI.Toggle(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ),
                        WrapperHelper.UnwrapObject < GUIContent >( a[2] ),
                        WrapperHelper.UnwrapObject < GUIStyle >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["Toggle"] = new BSFunctionReference(
                new BSFunction(
                    "function Toggle(position, id, value, content, style)",
                    a => GUI.Toggle(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ),
                        WrapperHelper.UnwrapObject < bool >( a[2] ),
                        WrapperHelper.UnwrapObject < GUIContent >( a[3] ),
                        WrapperHelper.UnwrapObject < GUIStyle >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["HorizontalSlider"] = new BSFunctionReference(
                new BSFunction(
                    "function HorizontalSlider(position, value, leftValue, rightValue)",
                    a => new BSObject(
                        ( decimal ) GUI.HorizontalSlider(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["HorizontalSlider"] = new BSFunctionReference(
                new BSFunction(
                    "function HorizontalSlider(position, value, leftValue, rightValue, slider, thumb)",
                    a => new BSObject(
                        ( decimal ) GUI.HorizontalSlider(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[4] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["HorizontalSlider"] = new BSFunctionReference(
                new BSFunction(
                    "function HorizontalSlider(position, value, leftValue, rightValue, slider, thumb, thumbExtent)",
                    a => new BSObject(
                        ( decimal ) GUI.HorizontalSlider(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[4] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[5] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["VerticalSlider"] = new BSFunctionReference(
                new BSFunction(
                    "function VerticalSlider(position, value, topValue, bottomValue)",
                    a => new BSObject(
                        ( decimal ) GUI.VerticalSlider(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["VerticalSlider"] = new BSFunctionReference(
                new BSFunction(
                    "function VerticalSlider(position, value, topValue, bottomValue, slider, thumb)",
                    a => new BSObject(
                        ( decimal ) GUI.VerticalSlider(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[4] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["VerticalSlider"] = new BSFunctionReference(
                new BSFunction(
                    "function VerticalSlider(position, value, topValue, bottomValue, slider, thumb, thumbExtent)",
                    a => new BSObject(
                        ( decimal ) GUI.VerticalSlider(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[4] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[5] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["Slider"] = new BSFunctionReference(
                new BSFunction(
                    "function Slider(position, value, size, start, end, slider, thumb, horiz, id, thumbExtent)",
                    a => new BSObject(
                        ( decimal ) GUI.Slider(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[5] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[6] ),
                            WrapperHelper.UnwrapObject < bool >( a[7] ),
                            WrapperHelper.UnwrapObject < int >( a[8] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[9] ) ) ),
                    10 ) );

            m_StaticProperties["HorizontalScrollbar"] = new BSFunctionReference(
                new BSFunction(
                    "function HorizontalScrollbar(position, value, size, leftValue, rightValue)",
                    a => new BSObject(
                        ( decimal ) GUI.HorizontalScrollbar(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["HorizontalScrollbar"] = new BSFunctionReference(
                new BSFunction(
                    "function HorizontalScrollbar(position, value, size, leftValue, rightValue, style)",
                    a => new BSObject(
                        ( decimal ) GUI.HorizontalScrollbar(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["VerticalScrollbar"] = new BSFunctionReference(
                new BSFunction(
                    "function VerticalScrollbar(position, value, size, topValue, bottomValue)",
                    a => new BSObject(
                        ( decimal ) GUI.VerticalScrollbar(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["VerticalScrollbar"] = new BSFunctionReference(
                new BSFunction(
                    "function VerticalScrollbar(position, value, size, topValue, bottomValue, style)",
                    a => new BSObject(
                        ( decimal ) GUI.VerticalScrollbar(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["BeginScrollView"] = new BSFunctionReference(
                new BSFunction(
                    "function BeginScrollView(position, scrollPosition, viewRect)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        GUI.BeginScrollView(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < Rect >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["BeginScrollView"] = new BSFunctionReference(
                new BSFunction(
                    "function BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        GUI.BeginScrollView(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < Rect >( a[2] ),
                            WrapperHelper.UnwrapObject < bool >( a[3] ),
                            WrapperHelper.UnwrapObject < bool >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["BeginScrollView"] = new BSFunctionReference(
                new BSFunction(
                    "function BeginScrollView(position, scrollPosition, viewRect, horizontalScrollbar, verticalScrollbar)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        GUI.BeginScrollView(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < Rect >( a[2] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[3] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["BeginScrollView"] = new BSFunctionReference(
                new BSFunction(
                    "function BeginScrollView(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        GUI.BeginScrollView(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < Rect >( a[2] ),
                            WrapperHelper.UnwrapObject < bool >( a[3] ),
                            WrapperHelper.UnwrapObject < bool >( a[4] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[5] ),
                            WrapperHelper.UnwrapObject < GUIStyle >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["ScrollTowards"] = new BSFunctionReference(
                new BSFunction(
                    "function ScrollTowards(position, maxDelta)",
                    a => GUI.ScrollTowards(
                        WrapperHelper.UnwrapObject < Rect >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

        }

        #endregion
    }

}
