using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UI_ScrollRect : BSWrapperObject < ScrollRect >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UI_ScrollRect( ScrollRect obj ) : base( obj )
        {
            m_Properties["content"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RectTransform( m_InternalObject.content ),
                x => m_InternalObject.content = WrapperHelper.UnwrapObject < RectTransform >( x ) );

            m_Properties["horizontal"] = new BSReflectionReference(
                () => m_InternalObject.horizontal ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.horizontal = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["vertical"] = new BSReflectionReference(
                () => m_InternalObject.vertical ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.vertical = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["elasticity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.elasticity ),
                x => m_InternalObject.elasticity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["inertia"] = new BSReflectionReference(
                () => m_InternalObject.inertia ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.inertia = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["decelerationRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.decelerationRate ),
                x => m_InternalObject.decelerationRate = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["scrollSensitivity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.scrollSensitivity ),
                x => m_InternalObject.scrollSensitivity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["viewport"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RectTransform( m_InternalObject.viewport ),
                x => m_InternalObject.viewport = WrapperHelper.UnwrapObject < RectTransform >( x ) );

            m_Properties["horizontalScrollbar"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_Scrollbar( m_InternalObject.horizontalScrollbar ),
                x => m_InternalObject.horizontalScrollbar = WrapperHelper.UnwrapObject < Scrollbar >( x ) );

            m_Properties["verticalScrollbar"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_Scrollbar( m_InternalObject.verticalScrollbar ),
                x => m_InternalObject.verticalScrollbar = WrapperHelper.UnwrapObject < Scrollbar >( x ) );

            m_Properties["horizontalScrollbarSpacing"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.horizontalScrollbarSpacing ),
                x => m_InternalObject.horizontalScrollbarSpacing = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["verticalScrollbarSpacing"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.verticalScrollbarSpacing ),
                x => m_InternalObject.verticalScrollbarSpacing = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["velocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.velocity ),
                x => m_InternalObject.velocity = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["normalizedPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.normalizedPosition ),
                x => m_InternalObject.normalizedPosition = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["horizontalNormalizedPosition"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.horizontalNormalizedPosition ),
                x => m_InternalObject.horizontalNormalizedPosition = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["verticalNormalizedPosition"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.verticalNormalizedPosition ),
                x => m_InternalObject.verticalNormalizedPosition = WrapperHelper.UnwrapObject < float >( x ) );

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
