using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_RaycastHit : BSWrapperObject < RaycastHit >

    {
        #region Public

        public BSWrapperObject_UnityEngine_RaycastHit( RaycastHit obj ) : base( obj )
        {
            m_Properties["collider"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Collider( m_InternalObject.collider ),
                null );

            m_Properties["point"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.point ),
                x => m_InternalObject.point = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["normal"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.normal ),
                x => m_InternalObject.normal = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["barycentricCoordinate"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.barycentricCoordinate ),
                x => m_InternalObject.barycentricCoordinate = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["distance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.distance ),
                x => m_InternalObject.distance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["triangleIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.triangleIndex ),
                null );

            m_Properties["textureCoord"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.textureCoord ),
                null );

            m_Properties["textureCoord2"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.textureCoord2 ),
                null );

            m_Properties["textureCoord1"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.textureCoord2 ),
                null );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.transform ),
                null );

            m_Properties["rigidbody"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rigidbody( m_InternalObject.rigidbody ),
                null );

            m_Properties["articulationBody"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ArticulationBody( m_InternalObject.articulationBody ),
                null );

            m_Properties["lightmapCoord"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.lightmapCoord ),
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
