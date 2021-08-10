using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_EventSystems_EventSystem : BSWrapperObject < EventSystem >

    {
        #region Public

        public BSWrapperObject_UnityEngine_EventSystems_EventSystem( EventSystem obj ) : base( obj )
        {
            m_Properties["sendNavigationEvents"] = new BSReflectionReference(
                () => m_InternalObject.sendNavigationEvents ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.sendNavigationEvents = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["pixelDragThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pixelDragThreshold ),
                x => m_InternalObject.pixelDragThreshold = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["currentInputModule"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_EventSystems_BaseInputModule(
                    m_InternalObject.currentInputModule ),
                null );

            m_Properties["firstSelectedGameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.firstSelectedGameObject ),
                x => m_InternalObject.firstSelectedGameObject = WrapperHelper.UnwrapObject < GameObject >( x ) );

            m_Properties["currentSelectedGameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.currentSelectedGameObject ),
                null );

            m_Properties["lastSelectedGameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.lastSelectedGameObject ),
                null );

            m_Properties["isFocused"] = new BSReflectionReference(
                () => m_InternalObject.isFocused ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["alreadySelecting"] = new BSReflectionReference(
                () => m_InternalObject.alreadySelecting ? BSObject.One : BSObject.Zero,
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

            m_Properties["IsPointerOverGameObject"] = new BSFunctionReference(
                new BSFunction(
                    "function IsPointerOverGameObject(pointerId)",
                    a => m_InternalObject.IsPointerOverGameObject( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
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
