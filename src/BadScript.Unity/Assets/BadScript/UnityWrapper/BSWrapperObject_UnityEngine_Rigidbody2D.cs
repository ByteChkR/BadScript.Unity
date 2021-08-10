using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rigidbody2D : BSWrapperObject < Rigidbody2D >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rigidbody2D( Rigidbody2D obj ) : base( obj )
        {
            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["rotation"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.rotation ),
                x => m_InternalObject.rotation = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["velocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.velocity ),
                x => m_InternalObject.velocity = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["angularVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.angularVelocity ),
                x => m_InternalObject.angularVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["useAutoMass"] = new BSReflectionReference(
                () => m_InternalObject.useAutoMass ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useAutoMass = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["mass"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.mass ),
                x => m_InternalObject.mass = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["sharedMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_PhysicsMaterial2D( m_InternalObject.sharedMaterial ),
                x => m_InternalObject.sharedMaterial = WrapperHelper.UnwrapObject < PhysicsMaterial2D >( x ) );

            m_Properties["centerOfMass"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.centerOfMass ),
                x => m_InternalObject.centerOfMass = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["worldCenterOfMass"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.worldCenterOfMass ),
                null );

            m_Properties["inertia"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.inertia ),
                x => m_InternalObject.inertia = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["drag"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.drag ),
                x => m_InternalObject.drag = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["angularDrag"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.angularDrag ),
                x => m_InternalObject.angularDrag = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["gravityScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.gravityScale ),
                x => m_InternalObject.gravityScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["useFullKinematicContacts"] = new BSReflectionReference(
                () => m_InternalObject.useFullKinematicContacts ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useFullKinematicContacts = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isKinematic"] = new BSReflectionReference(
                () => m_InternalObject.isKinematic ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isKinematic = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["fixedAngle"] = new BSReflectionReference(
                () => m_InternalObject.fixedAngle ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.fixedAngle = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["freezeRotation"] = new BSReflectionReference(
                () => m_InternalObject.freezeRotation ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.freezeRotation = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["simulated"] = new BSReflectionReference(
                () => m_InternalObject.simulated ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.simulated = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["attachedColliderCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.attachedColliderCount ),
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

            m_Properties["GetPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPoint(point)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetPoint( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetRelativePoint"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRelativePoint(relativePoint)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetRelativePoint( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector(vector)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetVector( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetRelativeVector"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRelativeVector(relativeVector)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetRelativeVector( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetPointVelocity"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPointVelocity(point)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetPointVelocity( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetRelativePointVelocity"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRelativePointVelocity(relativePoint)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetRelativePointVelocity( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
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
