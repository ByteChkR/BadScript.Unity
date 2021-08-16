using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_EventSystems_BaseInput : BSWrapperObject < BaseInput >

    {
        #region Public

        public BSWrapperObject_UnityEngine_EventSystems_BaseInput( BaseInput obj ) : base( obj )
        {
            m_Properties["compositionString"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.compositionString ),
                null );

            m_Properties["compositionCursorPos"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.compositionCursorPos ),
                x => m_InternalObject.compositionCursorPos = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["mousePresent"] = new BSReflectionReference(
                () => m_InternalObject.mousePresent ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["mousePosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.mousePosition ),
                null );

            m_Properties["mouseScrollDelta"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.mouseScrollDelta ),
                null );

            m_Properties["touchSupported"] = new BSReflectionReference(
                () => m_InternalObject.touchSupported ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["touchCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.touchCount ),
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

            m_Properties["GetMouseButtonDown"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMouseButtonDown(button)",
                    a => m_InternalObject.GetMouseButtonDown( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetMouseButtonUp"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMouseButtonUp(button)",
                    a => m_InternalObject.GetMouseButtonUp( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetMouseButton"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMouseButton(button)",
                    a => m_InternalObject.GetMouseButton( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetTouch"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTouch(index)",
                    a => new BSWrapperObject_UnityEngine_Touch(
                        m_InternalObject.GetTouch( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetAxisRaw"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAxisRaw(axisName)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetAxisRaw( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetButtonDown"] = new BSFunctionReference(
                new BSFunction(
                    "function GetButtonDown(buttonName)",
                    a => m_InternalObject.GetButtonDown( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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
