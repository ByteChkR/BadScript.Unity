using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Rigidbody : BSWrapperObject < Rigidbody >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rigidbody( Rigidbody obj ) : base( obj )
        {
            m_Properties["velocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.velocity ),
                x => m_InternalObject.velocity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["angularVelocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.angularVelocity ),
                x => m_InternalObject.angularVelocity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["drag"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.drag ),
                x => m_InternalObject.drag = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["angularDrag"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.angularDrag ),
                x => m_InternalObject.angularDrag = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["mass"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.mass ),
                x => m_InternalObject.mass = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["useGravity"] = new BSReflectionReference(
                () => m_InternalObject.useGravity ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useGravity = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["maxDepenetrationVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxDepenetrationVelocity ),
                x => m_InternalObject.maxDepenetrationVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["isKinematic"] = new BSReflectionReference(
                () => m_InternalObject.isKinematic ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isKinematic = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["freezeRotation"] = new BSReflectionReference(
                () => m_InternalObject.freezeRotation ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.freezeRotation = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["centerOfMass"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.centerOfMass ),
                x => m_InternalObject.centerOfMass = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["worldCenterOfMass"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.worldCenterOfMass ),
                null );

            m_Properties["inertiaTensorRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.inertiaTensorRotation ),
                x => m_InternalObject.inertiaTensorRotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["inertiaTensor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.inertiaTensor ),
                x => m_InternalObject.inertiaTensor = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["detectCollisions"] = new BSReflectionReference(
                () => m_InternalObject.detectCollisions ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.detectCollisions = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["rotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.rotation ),
                x => m_InternalObject.rotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["solverIterations"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.solverIterations ),
                x => m_InternalObject.solverIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["sleepThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sleepThreshold ),
                x => m_InternalObject.sleepThreshold = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["maxAngularVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxAngularVelocity ),
                x => m_InternalObject.maxAngularVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["solverVelocityIterations"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.solverVelocityIterations ),
                x => m_InternalObject.solverVelocityIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["sleepVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sleepVelocity ),
                x => m_InternalObject.sleepVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["sleepAngularVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sleepAngularVelocity ),
                x => m_InternalObject.sleepAngularVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["useConeFriction"] = new BSReflectionReference(
                () => m_InternalObject.useConeFriction ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useConeFriction = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["solverIterationCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.solverIterations ),
                x => m_InternalObject.solverIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["solverVelocityIterationCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.solverVelocityIterations ),
                x => m_InternalObject.solverVelocityIterations = WrapperHelper.UnwrapObject < int >( x ) );

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

            m_Properties["SetDensity"] = new BSFunctionReference(
                new BSFunction(
                    "function SetDensity(density)",
                    a =>
                    {
                        m_InternalObject.SetDensity( WrapperHelper.UnwrapObject < float >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["MovePosition"] = new BSFunctionReference(
                new BSFunction(
                    "function MovePosition(position)",
                    a =>
                    {
                        m_InternalObject.MovePosition( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["MoveRotation"] = new BSFunctionReference(
                new BSFunction(
                    "function MoveRotation(rot)",
                    a =>
                    {
                        m_InternalObject.MoveRotation( WrapperHelper.UnwrapObject < Quaternion >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["Sleep"] = new BSFunctionReference(
                new BSFunction(
                    "function Sleep()",
                    a =>
                    {
                        m_InternalObject.Sleep();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["IsSleeping"] = new BSFunctionReference(
                new BSFunction(
                    "function IsSleeping()",
                    a => m_InternalObject.IsSleeping() ? BSObject.One : BSObject.Zero,
                    0 ) );

            m_Properties["WakeUp"] = new BSFunctionReference(
                new BSFunction(
                    "function WakeUp()",
                    a =>
                    {
                        m_InternalObject.WakeUp();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["ResetCenterOfMass"] = new BSFunctionReference(
                new BSFunction(
                    "function ResetCenterOfMass()",
                    a =>
                    {
                        m_InternalObject.ResetCenterOfMass();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["ResetInertiaTensor"] = new BSFunctionReference(
                new BSFunction(
                    "function ResetInertiaTensor()",
                    a =>
                    {
                        m_InternalObject.ResetInertiaTensor();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["GetRelativePointVelocity"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRelativePointVelocity(relativePoint)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.GetRelativePointVelocity( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetPointVelocity"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPointVelocity(worldPoint)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.GetPointVelocity( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_Properties["SetMaxAngularVelocity"] = new BSFunctionReference(
                new BSFunction(
                    "function SetMaxAngularVelocity(a)",
                    a =>
                    {
                        m_InternalObject.SetMaxAngularVelocity( WrapperHelper.UnwrapObject < float >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["AddForce"] = new BSFunctionReference(
                new BSFunction(
                    "function AddForce(force)",
                    a =>
                    {
                        m_InternalObject.AddForce( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["AddForce"] = new BSFunctionReference(
                new BSFunction(
                    "function AddForce(x, y, z)",
                    a =>
                    {
                        m_InternalObject.AddForce(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["AddRelativeForce"] = new BSFunctionReference(
                new BSFunction(
                    "function AddRelativeForce(force)",
                    a =>
                    {
                        m_InternalObject.AddRelativeForce( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["AddRelativeForce"] = new BSFunctionReference(
                new BSFunction(
                    "function AddRelativeForce(x, y, z)",
                    a =>
                    {
                        m_InternalObject.AddRelativeForce(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["AddTorque"] = new BSFunctionReference(
                new BSFunction(
                    "function AddTorque(torque)",
                    a =>
                    {
                        m_InternalObject.AddTorque( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["AddTorque"] = new BSFunctionReference(
                new BSFunction(
                    "function AddTorque(x, y, z)",
                    a =>
                    {
                        m_InternalObject.AddTorque(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["AddRelativeTorque"] = new BSFunctionReference(
                new BSFunction(
                    "function AddRelativeTorque(torque)",
                    a =>
                    {
                        m_InternalObject.AddRelativeTorque( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["AddRelativeTorque"] = new BSFunctionReference(
                new BSFunction(
                    "function AddRelativeTorque(x, y, z)",
                    a =>
                    {
                        m_InternalObject.AddRelativeTorque(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["AddForceAtPosition"] = new BSFunctionReference(
                new BSFunction(
                    "function AddForceAtPosition(force, position)",
                    a =>
                    {
                        m_InternalObject.AddForceAtPosition(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddExplosionForce"] = new BSFunctionReference(
                new BSFunction(
                    "function AddExplosionForce(explosionForce, explosionPosition, explosionRadius, upwardsModifier)",
                    a =>
                    {
                        m_InternalObject.AddExplosionForce(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["AddExplosionForce"] = new BSFunctionReference(
                new BSFunction(
                    "function AddExplosionForce(explosionForce, explosionPosition, explosionRadius)",
                    a =>
                    {
                        m_InternalObject.AddExplosionForce(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

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

            m_Properties["SendMessageUpwards"] = new BSFunctionReference(
                new BSFunction(
                    "function SendMessageUpwards(methodName, value)",
                    a =>
                    {
                        m_InternalObject.SendMessageUpwards(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SendMessageUpwards"] = new BSFunctionReference(
                new BSFunction(
                    "function SendMessageUpwards(methodName)",
                    a =>
                    {
                        m_InternalObject.SendMessageUpwards( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SendMessage"] = new BSFunctionReference(
                new BSFunction(
                    "function SendMessage(methodName, value)",
                    a =>
                    {
                        m_InternalObject.SendMessage(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SendMessage"] = new BSFunctionReference(
                new BSFunction(
                    "function SendMessage(methodName)",
                    a =>
                    {
                        m_InternalObject.SendMessage( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["BroadcastMessage"] = new BSFunctionReference(
                new BSFunction(
                    "function BroadcastMessage(methodName, parameter)",
                    a =>
                    {
                        m_InternalObject.BroadcastMessage(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["BroadcastMessage"] = new BSFunctionReference(
                new BSFunction(
                    "function BroadcastMessage(methodName)",
                    a =>
                    {
                        m_InternalObject.BroadcastMessage( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["GetInstanceID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInstanceID()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetInstanceID() ),
                    0 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}
