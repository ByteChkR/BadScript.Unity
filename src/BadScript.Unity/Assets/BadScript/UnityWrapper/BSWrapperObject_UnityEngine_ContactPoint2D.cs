using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ContactPoint2D : BSWrapperObject < ContactPoint2D >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ContactPoint2D( ContactPoint2D obj ) : base( obj )
        {
            m_Properties["point"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.point ),
                null );

            m_Properties["normal"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.normal ),
                null );

            m_Properties["separation"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.separation ),
                null );

            m_Properties["normalImpulse"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.normalImpulse ),
                null );

            m_Properties["tangentImpulse"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.tangentImpulse ),
                null );

            m_Properties["relativeVelocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.relativeVelocity ),
                null );

            m_Properties["collider"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Collider2D( m_InternalObject.collider ),
                null );

            m_Properties["otherCollider"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Collider2D( m_InternalObject.otherCollider ),
                null );

            m_Properties["rigidbody"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rigidbody2D( m_InternalObject.rigidbody ),
                null );

            m_Properties["otherRigidbody"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rigidbody2D( m_InternalObject.otherRigidbody ),
                null );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                null );

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
