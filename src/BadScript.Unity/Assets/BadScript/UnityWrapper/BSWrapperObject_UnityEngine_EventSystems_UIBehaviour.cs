using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.EventSystems;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_EventSystems_UIBehaviour : BSWrapperObject < UIBehaviour >

    {
        #region Public

        public BSWrapperObject_UnityEngine_EventSystems_UIBehaviour( UIBehaviour obj ) : base( obj )
        {
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
