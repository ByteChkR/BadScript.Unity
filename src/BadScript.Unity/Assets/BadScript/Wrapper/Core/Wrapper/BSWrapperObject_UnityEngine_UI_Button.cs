using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UI_Button : BSWrapperObject < Button >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UI_Button( Button obj ) : base( obj )
        {
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

            m_Properties["OnPointerClick"] = new BSFunctionReference(
                new BSFunction(
                    "function OnPointerClick(eventData)",
                    a =>
                    {
                        m_InternalObject.OnPointerClick( WrapperHelper.UnwrapObject < PointerEventData >( a[0] ) );

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

            m_Properties["OnPointerDown"] = new BSFunctionReference(
                new BSFunction(
                    "function OnPointerDown(eventData)",
                    a =>
                    {
                        m_InternalObject.OnPointerDown( WrapperHelper.UnwrapObject < PointerEventData >( a[0] ) );

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

            m_Properties["OnSelect"] = new BSFunctionReference(
                new BSFunction(
                    "function OnSelect(eventData)",
                    a =>
                    {
                        m_InternalObject.OnSelect( WrapperHelper.UnwrapObject < BaseEventData >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["OnDeselect"] = new BSFunctionReference(
                new BSFunction(
                    "function OnDeselect(eventData)",
                    a =>
                    {
                        m_InternalObject.OnDeselect( WrapperHelper.UnwrapObject < BaseEventData >( a[0] ) );

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
