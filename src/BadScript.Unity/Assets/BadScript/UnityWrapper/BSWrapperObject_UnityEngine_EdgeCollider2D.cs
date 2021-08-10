using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_EdgeCollider2D : BSWrapperObject < EdgeCollider2D >

    {
        #region Public

        public BSWrapperObject_UnityEngine_EdgeCollider2D( EdgeCollider2D obj ) : base( obj )
        {
            m_Properties["edgeRadius"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.edgeRadius ),
                x => m_InternalObject.edgeRadius = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["edgeCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.edgeCount ),
                null );

            m_Properties["pointCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pointCount ),
                null );

            m_Properties["useAdjacentStartPoint"] = new BSReflectionReference(
                () => m_InternalObject.useAdjacentStartPoint ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useAdjacentStartPoint = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useAdjacentEndPoint"] = new BSReflectionReference(
                () => m_InternalObject.useAdjacentEndPoint ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useAdjacentEndPoint = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["adjacentStartPoint"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.adjacentStartPoint ),
                x => m_InternalObject.adjacentStartPoint = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["adjacentEndPoint"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.adjacentEndPoint ),
                x => m_InternalObject.adjacentEndPoint = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["density"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.density ),
                x => m_InternalObject.density = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["isTrigger"] = new BSReflectionReference(
                () => m_InternalObject.isTrigger ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isTrigger = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["usedByEffector"] = new BSReflectionReference(
                () => m_InternalObject.usedByEffector ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.usedByEffector = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["usedByComposite"] = new BSReflectionReference(
                () => m_InternalObject.usedByComposite ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.usedByComposite = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["composite"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_CompositeCollider2D( m_InternalObject.composite ),
                null );

            m_Properties["offset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.offset ),
                x => m_InternalObject.offset = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["attachedRigidbody"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rigidbody2D( m_InternalObject.attachedRigidbody ),
                null );

            m_Properties["shapeCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.shapeCount ),
                null );

            m_Properties["bounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Bounds( m_InternalObject.bounds ),
                null );

            m_Properties["sharedMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_PhysicsMaterial2D( m_InternalObject.sharedMaterial ),
                x => m_InternalObject.sharedMaterial = WrapperHelper.UnwrapObject < PhysicsMaterial2D >( x ) );

            m_Properties["friction"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.friction ),
                null );

            m_Properties["bounciness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bounciness ),
                null );

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

            m_Properties["CreateMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateMesh(useBodyPosition, useBodyRotation)",
                    a => new BSWrapperObject_UnityEngine_Mesh(
                        m_InternalObject.CreateMesh(
                            WrapperHelper.UnwrapObject < bool >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

            m_Properties["IsTouching"] = new BSFunctionReference(
                new BSFunction(
                    "function IsTouching(collider)",
                    a => m_InternalObject.IsTouching( WrapperHelper.UnwrapObject < Collider2D >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["IsTouching"] = new BSFunctionReference(
                new BSFunction(
                    "function IsTouching(collider, contactFilter)",
                    a => m_InternalObject.IsTouching(
                        WrapperHelper.UnwrapObject < Collider2D >( a[0] ),
                        WrapperHelper.UnwrapObject < ContactFilter2D >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["IsTouching"] = new BSFunctionReference(
                new BSFunction(
                    "function IsTouching(contactFilter)",
                    a => m_InternalObject.IsTouching( WrapperHelper.UnwrapObject < ContactFilter2D >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["IsTouchingLayers"] = new BSFunctionReference(
                new BSFunction(
                    "function IsTouchingLayers(layerMask)",
                    a => m_InternalObject.IsTouchingLayers( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["OverlapPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapPoint(point)",
                    a => m_InternalObject.OverlapPoint( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Distance"] = new BSFunctionReference(
                new BSFunction(
                    "function Distance(collider)",
                    a => new BSWrapperObject_UnityEngine_ColliderDistance2D(
                        m_InternalObject.Distance( WrapperHelper.UnwrapObject < Collider2D >( a[0] ) ) ),
                    1 ) );

            m_Properties["ClosestPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPoint(position)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.ClosestPoint( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
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
