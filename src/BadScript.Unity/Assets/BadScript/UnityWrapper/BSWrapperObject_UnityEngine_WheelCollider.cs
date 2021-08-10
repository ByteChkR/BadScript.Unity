using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_WheelCollider : BSWrapperObject < WheelCollider >

    {
        #region Public

        public BSWrapperObject_UnityEngine_WheelCollider( WheelCollider obj ) : base( obj )
        {
            m_Properties["center"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.center ),
                x => m_InternalObject.center = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["radius"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.radius ),
                x => m_InternalObject.radius = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["suspensionDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.suspensionDistance ),
                x => m_InternalObject.suspensionDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["suspensionSpring"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_JointSpring( m_InternalObject.suspensionSpring ),
                x => m_InternalObject.suspensionSpring = WrapperHelper.UnwrapObject < JointSpring >( x ) );

            m_Properties["suspensionExpansionLimited"] = new BSReflectionReference(
                () => m_InternalObject.suspensionExpansionLimited ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.suspensionExpansionLimited = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["forceAppPointDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.forceAppPointDistance ),
                x => m_InternalObject.forceAppPointDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["mass"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.mass ),
                x => m_InternalObject.mass = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["wheelDampingRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.wheelDampingRate ),
                x => m_InternalObject.wheelDampingRate = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["forwardFriction"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_WheelFrictionCurve( m_InternalObject.forwardFriction ),
                x => m_InternalObject.forwardFriction = WrapperHelper.UnwrapObject < WheelFrictionCurve >( x ) );

            m_Properties["sidewaysFriction"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_WheelFrictionCurve( m_InternalObject.sidewaysFriction ),
                x => m_InternalObject.sidewaysFriction = WrapperHelper.UnwrapObject < WheelFrictionCurve >( x ) );

            m_Properties["motorTorque"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.motorTorque ),
                x => m_InternalObject.motorTorque = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["brakeTorque"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.brakeTorque ),
                x => m_InternalObject.brakeTorque = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["steerAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.steerAngle ),
                x => m_InternalObject.steerAngle = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["isGrounded"] = new BSReflectionReference(
                () => m_InternalObject.isGrounded ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["rpm"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.rpm ),
                null );

            m_Properties["sprungMass"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sprungMass ),
                x => m_InternalObject.sprungMass = WrapperHelper.UnwrapObject < float >( x ) );

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
