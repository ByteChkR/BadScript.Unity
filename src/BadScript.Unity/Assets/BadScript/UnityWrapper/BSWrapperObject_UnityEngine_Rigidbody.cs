using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
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
