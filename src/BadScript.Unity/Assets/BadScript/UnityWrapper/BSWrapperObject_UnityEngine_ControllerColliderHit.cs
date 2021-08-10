using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ControllerColliderHit : BSWrapperObject < ControllerColliderHit >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ControllerColliderHit( ControllerColliderHit obj ) : base( obj )
        {
            m_Properties["controller"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_CharacterController( m_InternalObject.controller ),
                null );

            m_Properties["collider"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Collider( m_InternalObject.collider ),
                null );

            m_Properties["rigidbody"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rigidbody( m_InternalObject.rigidbody ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.gameObject ),
                null );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.transform ),
                null );

            m_Properties["point"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.point ),
                null );

            m_Properties["normal"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.normal ),
                null );

            m_Properties["moveDirection"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.moveDirection ),
                null );

            m_Properties["moveLength"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.moveLength ),
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
