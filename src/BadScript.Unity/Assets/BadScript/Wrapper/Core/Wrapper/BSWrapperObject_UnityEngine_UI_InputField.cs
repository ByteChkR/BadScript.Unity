using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
#pragma warning disable 618

namespace BadScript.Unity.Wrapper.Core.Generated
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

            m_Properties["SetTextWithoutNotify"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTextWithoutNotify(input)",
                    a =>
                    {
                        m_InternalObject.SetTextWithoutNotify( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["MoveTextEnd"] = new BSFunctionReference(
                new BSFunction(
                    "function MoveTextEnd(shift)",
                    a =>
                    {
                        m_InternalObject.MoveTextEnd( WrapperHelper.UnwrapObject < bool >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["MoveTextStart"] = new BSFunctionReference(
                new BSFunction(
                    "function MoveTextStart(shift)",
                    a =>
                    {
                        m_InternalObject.MoveTextStart( WrapperHelper.UnwrapObject < bool >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["ScreenToLocal"] = new BSFunctionReference(
                new BSFunction(
                    "function ScreenToLocal(screen)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.ScreenToLocal( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_Properties["OnBeginDrag"] = new BSFunctionReference(
                new BSFunction(
                    "function OnBeginDrag(eventData)",
                    a =>
                    {
                        m_InternalObject.OnBeginDrag( WrapperHelper.UnwrapObject < PointerEventData >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["OnDrag"] = new BSFunctionReference(
                new BSFunction(
                    "function OnDrag(eventData)",
                    a =>
                    {
                        m_InternalObject.OnDrag( WrapperHelper.UnwrapObject < PointerEventData >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["OnEndDrag"] = new BSFunctionReference(
                new BSFunction(
                    "function OnEndDrag(eventData)",
                    a =>
                    {
                        m_InternalObject.OnEndDrag( WrapperHelper.UnwrapObject < PointerEventData >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["OnPointerDown"] = new BSFunctionReference(
                new BSFunction(
                    "function OnPointerDown(eventData)",
                    a =>
                    {
                        m_InternalObject.OnPointerDown( WrapperHelper.UnwrapObject < PointerEventData >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["ProcessEvent"] = new BSFunctionReference(
                new BSFunction(
                    "function ProcessEvent(e)",
                    a =>
                    {
                        m_InternalObject.ProcessEvent( WrapperHelper.UnwrapObject < Event >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["OnUpdateSelected"] = new BSFunctionReference(
                new BSFunction(
                    "function OnUpdateSelected(eventData)",
                    a =>
                    {
                        m_InternalObject.OnUpdateSelected( WrapperHelper.UnwrapObject < BaseEventData >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["ForceLabelUpdate"] = new BSFunctionReference(
                new BSFunction(
                    "function ForceLabelUpdate()",
                    a =>
                    {
                        m_InternalObject.ForceLabelUpdate();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["LayoutComplete"] = new BSFunctionReference(
                new BSFunction(
                    "function LayoutComplete()",
                    a =>
                    {
                        m_InternalObject.LayoutComplete();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["GraphicUpdateComplete"] = new BSFunctionReference(
                new BSFunction(
                    "function GraphicUpdateComplete()",
                    a =>
                    {
                        m_InternalObject.GraphicUpdateComplete();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["ActivateInputField"] = new BSFunctionReference(
                new BSFunction(
                    "function ActivateInputField()",
                    a =>
                    {
                        m_InternalObject.ActivateInputField();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["OnSelect"] = new BSFunctionReference(
                new BSFunction(
                    "function OnSelect(eventData)",
                    a =>
                    {
                        m_InternalObject.OnSelect( WrapperHelper.UnwrapObject < BaseEventData >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["OnPointerClick"] = new BSFunctionReference(
                new BSFunction(
                    "function OnPointerClick(eventData)",
                    a =>
                    {
                        m_InternalObject.OnPointerClick( WrapperHelper.UnwrapObject < PointerEventData >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["DeactivateInputField"] = new BSFunctionReference(
                new BSFunction(
                    "function DeactivateInputField()",
                    a =>
                    {
                        m_InternalObject.DeactivateInputField();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["OnDeselect"] = new BSFunctionReference(
                new BSFunction(
                    "function OnDeselect(eventData)",
                    a =>
                    {
                        m_InternalObject.OnDeselect( WrapperHelper.UnwrapObject < BaseEventData >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["OnSubmit"] = new BSFunctionReference(
                new BSFunction(
                    "function OnSubmit(eventData)",
                    a =>
                    {
                        m_InternalObject.OnSubmit( WrapperHelper.UnwrapObject < BaseEventData >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["CalculateLayoutInputHorizontal"] = new BSFunctionReference(
                new BSFunction(
                    "function CalculateLayoutInputHorizontal()",
                    a =>
                    {
                        m_InternalObject.CalculateLayoutInputHorizontal();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["CalculateLayoutInputVertical"] = new BSFunctionReference(
                new BSFunction(
                    "function CalculateLayoutInputVertical()",
                    a =>
                    {
                        m_InternalObject.CalculateLayoutInputVertical();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["IsInteractable"] = new BSFunctionReference(
                new BSFunction(
                    "function IsInteractable()",
                    a => m_InternalObject.IsInteractable() ? BSObject.One : BSObject.Zero,
                    0 ) );

            m_Properties["FindSelectable"] = new BSFunctionReference(
                new BSFunction(
                    "function FindSelectable(dir)",
                    a => new BSWrapperObject_UnityEngine_UI_Selectable(
                        m_InternalObject.FindSelectable( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["FindSelectableOnLeft"] = new BSFunctionReference(
                new BSFunction(
                    "function FindSelectableOnLeft()",
                    a => new BSWrapperObject_UnityEngine_UI_Selectable( m_InternalObject.FindSelectableOnLeft() ),
                    0 ) );

            m_Properties["FindSelectableOnRight"] = new BSFunctionReference(
                new BSFunction(
                    "function FindSelectableOnRight()",
                    a => new BSWrapperObject_UnityEngine_UI_Selectable( m_InternalObject.FindSelectableOnRight() ),
                    0 ) );

            m_Properties["FindSelectableOnUp"] = new BSFunctionReference(
                new BSFunction(
                    "function FindSelectableOnUp()",
                    a => new BSWrapperObject_UnityEngine_UI_Selectable( m_InternalObject.FindSelectableOnUp() ),
                    0 ) );

            m_Properties["FindSelectableOnDown"] = new BSFunctionReference(
                new BSFunction(
                    "function FindSelectableOnDown()",
                    a => new BSWrapperObject_UnityEngine_UI_Selectable( m_InternalObject.FindSelectableOnDown() ),
                    0 ) );

            m_Properties["OnMove"] = new BSFunctionReference(
                new BSFunction(
                    "function OnMove(eventData)",
                    a =>
                    {
                        m_InternalObject.OnMove( WrapperHelper.UnwrapObject < AxisEventData >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["OnPointerUp"] = new BSFunctionReference(
                new BSFunction(
                    "function OnPointerUp(eventData)",
                    a =>
                    {
                        m_InternalObject.OnPointerUp( WrapperHelper.UnwrapObject < PointerEventData >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["OnPointerEnter"] = new BSFunctionReference(
                new BSFunction(
                    "function OnPointerEnter(eventData)",
                    a =>
                    {
                        m_InternalObject.OnPointerEnter( WrapperHelper.UnwrapObject < PointerEventData >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["OnPointerExit"] = new BSFunctionReference(
                new BSFunction(
                    "function OnPointerExit(eventData)",
                    a =>
                    {
                        m_InternalObject.OnPointerExit( WrapperHelper.UnwrapObject < PointerEventData >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["Select"] = new BSFunctionReference(
                new BSFunction(
                    "function Select()",
                    a =>
                    {
                        m_InternalObject.Select();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["IsActive"] = new BSFunctionReference(
                new BSFunction(
                    "function IsActive()",
                    a => m_InternalObject.IsActive() ? BSObject.One : BSObject.Zero,
                    0 ) );

            m_Properties["IsDestroyed"] = new BSFunctionReference(
                new BSFunction(
                    "function IsDestroyed()",
                    a => m_InternalObject.IsDestroyed() ? BSObject.One : BSObject.Zero,
                    0 ) );

            m_Properties["IsInvoking"] = new BSFunctionReference(
                new BSFunction(
                    "function IsInvoking()",
                    a => m_InternalObject.IsInvoking() ? BSObject.One : BSObject.Zero,
                    0 ) );

            m_Properties["CancelInvoke"] = new BSFunctionReference(
                new BSFunction(
                    "function CancelInvoke()",
                    a =>
                    {
                        m_InternalObject.CancelInvoke();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Invoke"] = new BSFunctionReference(
                new BSFunction(
                    "function Invoke(methodName, time)",
                    a =>
                    {
                        m_InternalObject.Invoke(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["InvokeRepeating"] = new BSFunctionReference(
                new BSFunction(
                    "function InvokeRepeating(methodName, time, repeatRate)",
                    a =>
                    {
                        m_InternalObject.InvokeRepeating(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["CancelInvoke"] = new BSFunctionReference(
                new BSFunction(
                    "function CancelInvoke(methodName)",
                    a =>
                    {
                        m_InternalObject.CancelInvoke( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
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

            m_Properties["StopCoroutine"] = new BSFunctionReference(
                new BSFunction(
                    "function StopCoroutine(routine)",
                    a =>
                    {
                        m_InternalObject.StopCoroutine( WrapperHelper.UnwrapObject < IEnumerator >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["StopCoroutine"] = new BSFunctionReference(
                new BSFunction(
                    "function StopCoroutine(routine)",
                    a =>
                    {
                        m_InternalObject.StopCoroutine( WrapperHelper.UnwrapObject < Coroutine >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["StopCoroutine"] = new BSFunctionReference(
                new BSFunction(
                    "function StopCoroutine(methodName)",
                    a =>
                    {
                        m_InternalObject.StopCoroutine( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["StopAllCoroutines"] = new BSFunctionReference(
                new BSFunction(
                    "function StopAllCoroutines()",
                    a =>
                    {
                        m_InternalObject.StopAllCoroutines();

                        return new BSObject( null );
                    },
                    0 ) );

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

            m_Properties["SendMessageUpwards"] = new BSFunctionReference(
                new BSFunction(
                    "function SendMessageUpwards(methodName, value)",
                    a =>
                    {
                        m_InternalObject.SendMessageUpwards(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SendMessageUpwards"] = new BSFunctionReference(
                new BSFunction(
                    "function SendMessageUpwards(methodName)",
                    a =>
                    {
                        m_InternalObject.SendMessageUpwards( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SendMessage"] = new BSFunctionReference(
                new BSFunction(
                    "function SendMessage(methodName, value)",
                    a =>
                    {
                        m_InternalObject.SendMessage(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SendMessage"] = new BSFunctionReference(
                new BSFunction(
                    "function SendMessage(methodName)",
                    a =>
                    {
                        m_InternalObject.SendMessage( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["BroadcastMessage"] = new BSFunctionReference(
                new BSFunction(
                    "function BroadcastMessage(methodName, parameter)",
                    a =>
                    {
                        m_InternalObject.BroadcastMessage(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["BroadcastMessage"] = new BSFunctionReference(
                new BSFunction(
                    "function BroadcastMessage(methodName)",
                    a =>
                    {
                        m_InternalObject.BroadcastMessage( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["GetInstanceID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInstanceID()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetInstanceID() ),
                    0 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}
