using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UI_InputField : BSWrapperObject < InputField >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UI_InputField( InputField obj ) : base( obj )
        {
            m_Properties["shouldHideMobileInput"] = new BSReflectionReference(
                () => m_InternalObject.shouldHideMobileInput ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.shouldHideMobileInput = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["shouldActivateOnSelect"] = new BSReflectionReference(
                () => m_InternalObject.shouldActivateOnSelect ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.shouldActivateOnSelect = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["text"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.text ),
                x => m_InternalObject.text = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["isFocused"] = new BSReflectionReference(
                () => m_InternalObject.isFocused ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["caretBlinkRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.caretBlinkRate ),
                x => m_InternalObject.caretBlinkRate = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["caretWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.caretWidth ),
                x => m_InternalObject.caretWidth = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["textComponent"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_Text( m_InternalObject.textComponent ),
                x => m_InternalObject.textComponent = WrapperHelper.UnwrapObject < Text >( x ) );

            m_Properties["placeholder"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_Graphic( m_InternalObject.placeholder ),
                x => m_InternalObject.placeholder = WrapperHelper.UnwrapObject < Graphic >( x ) );

            m_Properties["caretColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.caretColor ),
                x => m_InternalObject.caretColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["customCaretColor"] = new BSReflectionReference(
                () => m_InternalObject.customCaretColor ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.customCaretColor = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["selectionColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.selectionColor ),
                x => m_InternalObject.selectionColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["characterLimit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.characterLimit ),
                x => m_InternalObject.characterLimit = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["touchScreenKeyboard"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_TouchScreenKeyboard( m_InternalObject.touchScreenKeyboard ),
                null );

            m_Properties["readOnly"] = new BSReflectionReference(
                () => m_InternalObject.readOnly ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.readOnly = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["multiLine"] = new BSReflectionReference(
                () => m_InternalObject.multiLine ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["asteriskChar"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Char( m_InternalObject.asteriskChar ),
                x => m_InternalObject.asteriskChar = WrapperHelper.UnwrapObject < char >( x ) );

            m_Properties["wasCanceled"] = new BSReflectionReference(
                () => m_InternalObject.wasCanceled ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["caretPosition"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.caretPosition ),
                x => m_InternalObject.caretPosition = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["selectionAnchorPosition"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.selectionAnchorPosition ),
                x => m_InternalObject.selectionAnchorPosition = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["selectionFocusPosition"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.selectionFocusPosition ),
                x => m_InternalObject.selectionFocusPosition = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["minWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minWidth ),
                null );

            m_Properties["preferredWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.preferredWidth ),
                null );

            m_Properties["flexibleWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.flexibleWidth ),
                null );

            m_Properties["minHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minHeight ),
                null );

            m_Properties["preferredHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.preferredHeight ),
                null );

            m_Properties["flexibleHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.flexibleHeight ),
                null );

            m_Properties["layoutPriority"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.layoutPriority ),
                null );

            m_Properties["navigation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_Navigation( m_InternalObject.navigation ),
                x => m_InternalObject.navigation = WrapperHelper.UnwrapObject < Navigation >( x ) );

            m_Properties["colors"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_ColorBlock( m_InternalObject.colors ),
                x => m_InternalObject.colors = WrapperHelper.UnwrapObject < ColorBlock >( x ) );

            m_Properties["spriteState"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_SpriteState( m_InternalObject.spriteState ),
                x => m_InternalObject.spriteState = WrapperHelper.UnwrapObject < SpriteState >( x ) );

            m_Properties["animationTriggers"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_AnimationTriggers( m_InternalObject.animationTriggers ),
                x => m_InternalObject.animationTriggers = WrapperHelper.UnwrapObject < AnimationTriggers >( x ) );

            m_Properties["targetGraphic"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_Graphic( m_InternalObject.targetGraphic ),
                x => m_InternalObject.targetGraphic = WrapperHelper.UnwrapObject < Graphic >( x ) );

            m_Properties["interactable"] = new BSReflectionReference(
                () => m_InternalObject.interactable ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.interactable = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["image"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_Image( m_InternalObject.image ),
                x => m_InternalObject.image = WrapperHelper.UnwrapObject < Image >( x ) );

            m_Properties["animator"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Animator( m_InternalObject.animator ),
                null );

            m_Properties["useGUILayout"] = new BSReflectionReference(
                () => m_InternalObject.useGUILayout ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useGUILayout = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["runInEditMode"] = new BSReflectionReference(
                () => m_InternalObject.runInEditMode ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.runInEditMode = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isActiveAndEnabled"] = new BSReflectionReference(
                () => m_InternalObject.isActiveAndEnabled ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.transform ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.gameObject ),
                null );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["ScreenToLocal"] = new BSFunctionReference(
                new BSFunction(
                    "function ScreenToLocal(screen)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.ScreenToLocal( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_Properties["FindSelectable"] = new BSFunctionReference(
                new BSFunction(
                    "function FindSelectable(dir)",
                    a => new BSWrapperObject_UnityEngine_UI_Selectable(
                        m_InternalObject.FindSelectable( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["IsInvoking"] = new BSFunctionReference(
                new BSFunction(
                    "function IsInvoking(methodName)",
                    a => m_InternalObject.IsInvoking( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["StartCoroutine"] = new BSFunctionReference(
                new BSFunction(
                    "function StartCoroutine(methodName)",
                    a => new BSWrapperObject_UnityEngine_Coroutine(
                        m_InternalObject.StartCoroutine( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["StartCoroutine"] = new BSFunctionReference(
                new BSFunction(
                    "function StartCoroutine(methodName, value)",
                    a => new BSWrapperObject_UnityEngine_Coroutine(
                        m_InternalObject.StartCoroutine(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) ) ),
                    2 ) );

            m_Properties["StartCoroutine"] = new BSFunctionReference(
                new BSFunction(
                    "function StartCoroutine(routine)",
                    a => new BSWrapperObject_UnityEngine_Coroutine(
                        m_InternalObject.StartCoroutine( WrapperHelper.UnwrapObject < IEnumerator >( a[0] ) ) ),
                    1 ) );

            m_Properties["StartCoroutine_Auto"] = new BSFunctionReference(
                new BSFunction(
                    "function StartCoroutine_Auto(routine)",
                    a => new BSWrapperObject_UnityEngine_Coroutine(
                        m_InternalObject.StartCoroutine( WrapperHelper.UnwrapObject < IEnumerator >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_UnityEngine_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
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
