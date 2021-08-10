using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_RaycastHit2D : BSWrapperObject < RaycastHit2D >

    {
        #region Public

        public BSWrapperObject_UnityEngine_RaycastHit2D( RaycastHit2D obj ) : base( obj )
        {
            m_Properties["centroid"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.centroid ),
                x => m_InternalObject.centroid = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["point"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.point ),
                x => m_InternalObject.point = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["normal"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.normal ),
                x => m_InternalObject.normal = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["distance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.distance ),
                x => m_InternalObject.distance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["fraction"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fraction ),
                x => m_InternalObject.fraction = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["collider"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Collider2D( m_InternalObject.collider ),
                null );

            m_Properties["rigidbody"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rigidbody2D( m_InternalObject.rigidbody ),
                null );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.transform ),
                null );

            m_Properties["CompareTo"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTo(other)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.CompareTo( WrapperHelper.UnwrapObject < RaycastHit2D >( a[0] ) ) ),
                    1 ) );

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
