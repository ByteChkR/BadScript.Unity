using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_MeshCollider : BSWrapperObject < MeshCollider >

    {
        #region Public

        public BSWrapperObject_UnityEngine_MeshCollider( MeshCollider obj ) : base( obj )
        {
            m_Properties["sharedMesh"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Mesh( m_InternalObject.sharedMesh ),
                x => m_InternalObject.sharedMesh = WrapperHelper.UnwrapObject < Mesh >( x ) );

            m_Properties["convex"] = new BSReflectionReference(
                () => m_InternalObject.convex ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.convex = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["inflateMesh"] = new BSReflectionReference(
                () => m_InternalObject.inflateMesh ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.inflateMesh = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["skinWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.skinWidth ),
                x => m_InternalObject.skinWidth = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["smoothSphereCollisions"] = new BSReflectionReference(
                () => m_InternalObject.smoothSphereCollisions ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.smoothSphereCollisions = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["attachedRigidbody"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rigidbody( m_InternalObject.attachedRigidbody ),
                null );

            m_Properties["attachedArticulationBody"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ArticulationBody( m_InternalObject.attachedArticulationBody ),
                null );

            m_Properties["isTrigger"] = new BSReflectionReference(
                () => m_InternalObject.isTrigger ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isTrigger = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["contactOffset"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.contactOffset ),
                x => m_InternalObject.contactOffset = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Bounds( m_InternalObject.bounds ),
                null );

            m_Properties["sharedMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_PhysicMaterial( m_InternalObject.sharedMaterial ),
                x => m_InternalObject.sharedMaterial = WrapperHelper.UnwrapObject < PhysicMaterial >( x ) );

            m_Properties["material"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_PhysicMaterial( m_InternalObject.material ),
                x => m_InternalObject.material = WrapperHelper.UnwrapObject < PhysicMaterial >( x ) );

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

            m_Properties["ClosestPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPoint(position)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.ClosestPoint( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["ClosestPointOnBounds"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPointOnBounds(position)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.ClosestPointOnBounds( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
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
