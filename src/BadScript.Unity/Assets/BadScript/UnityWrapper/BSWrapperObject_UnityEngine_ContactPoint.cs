using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ContactPoint : BSWrapperObject < ContactPoint >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ContactPoint( ContactPoint obj ) : base( obj )
        {
            m_Properties["point"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.point ),
                null );

            m_Properties["normal"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.normal ),
                null );

            m_Properties["thisCollider"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Collider( m_InternalObject.thisCollider ),
                null );

            m_Properties["otherCollider"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Collider( m_InternalObject.otherCollider ),
                null );

            m_Properties["separation"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.separation ),
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
