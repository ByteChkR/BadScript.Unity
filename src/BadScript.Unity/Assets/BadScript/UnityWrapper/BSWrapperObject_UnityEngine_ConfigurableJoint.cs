using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ConfigurableJoint : BSWrapperObject < ConfigurableJoint >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ConfigurableJoint( ConfigurableJoint obj ) : base( obj )
        {
            m_Properties["secondaryAxis"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.secondaryAxis ),
                x => m_InternalObject.secondaryAxis = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["linearLimitSpring"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SoftJointLimitSpring( m_InternalObject.linearLimitSpring ),
                x => m_InternalObject.linearLimitSpring = WrapperHelper.UnwrapObject < SoftJointLimitSpring >( x ) );

            m_Properties["angularXLimitSpring"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SoftJointLimitSpring( m_InternalObject.angularXLimitSpring ),
                x => m_InternalObject.angularXLimitSpring = WrapperHelper.UnwrapObject < SoftJointLimitSpring >( x ) );

            m_Properties["angularYZLimitSpring"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SoftJointLimitSpring( m_InternalObject.angularYZLimitSpring ),
                x => m_InternalObject.angularYZLimitSpring = WrapperHelper.UnwrapObject < SoftJointLimitSpring >( x ) );

            m_Properties["linearLimit"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SoftJointLimit( m_InternalObject.linearLimit ),
                x => m_InternalObject.linearLimit = WrapperHelper.UnwrapObject < SoftJointLimit >( x ) );

            m_Properties["lowAngularXLimit"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SoftJointLimit( m_InternalObject.lowAngularXLimit ),
                x => m_InternalObject.lowAngularXLimit = WrapperHelper.UnwrapObject < SoftJointLimit >( x ) );

            m_Properties["highAngularXLimit"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SoftJointLimit( m_InternalObject.highAngularXLimit ),
                x => m_InternalObject.highAngularXLimit = WrapperHelper.UnwrapObject < SoftJointLimit >( x ) );

            m_Properties["angularYLimit"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SoftJointLimit( m_InternalObject.angularYLimit ),
                x => m_InternalObject.angularYLimit = WrapperHelper.UnwrapObject < SoftJointLimit >( x ) );

            m_Properties["angularZLimit"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SoftJointLimit( m_InternalObject.angularZLimit ),
                x => m_InternalObject.angularZLimit = WrapperHelper.UnwrapObject < SoftJointLimit >( x ) );

            m_Properties["targetPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.targetPosition ),
                x => m_InternalObject.targetPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["targetVelocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.targetVelocity ),
                x => m_InternalObject.targetVelocity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["xDrive"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_JointDrive( m_InternalObject.xDrive ),
                x => m_InternalObject.xDrive = WrapperHelper.UnwrapObject < JointDrive >( x ) );

            m_Properties["yDrive"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_JointDrive( m_InternalObject.yDrive ),
                x => m_InternalObject.yDrive = WrapperHelper.UnwrapObject < JointDrive >( x ) );

            m_Properties["zDrive"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_JointDrive( m_InternalObject.zDrive ),
                x => m_InternalObject.zDrive = WrapperHelper.UnwrapObject < JointDrive >( x ) );

            m_Properties["targetRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.targetRotation ),
                x => m_InternalObject.targetRotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["targetAngularVelocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.targetAngularVelocity ),
                x => m_InternalObject.targetAngularVelocity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["angularXDrive"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_JointDrive( m_InternalObject.angularXDrive ),
                x => m_InternalObject.angularXDrive = WrapperHelper.UnwrapObject < JointDrive >( x ) );

            m_Properties["angularYZDrive"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_JointDrive( m_InternalObject.angularYZDrive ),
                x => m_InternalObject.angularYZDrive = WrapperHelper.UnwrapObject < JointDrive >( x ) );

            m_Properties["slerpDrive"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_JointDrive( m_InternalObject.slerpDrive ),
                x => m_InternalObject.slerpDrive = WrapperHelper.UnwrapObject < JointDrive >( x ) );

            m_Properties["projectionDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.projectionDistance ),
                x => m_InternalObject.projectionDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["projectionAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.projectionAngle ),
                x => m_InternalObject.projectionAngle = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["configuredInWorldSpace"] = new BSReflectionReference(
                () => m_InternalObject.configuredInWorldSpace ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.configuredInWorldSpace = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["swapBodies"] = new BSReflectionReference(
                () => m_InternalObject.swapBodies ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.swapBodies = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["connectedBody"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rigidbody( m_InternalObject.connectedBody ),
                x => m_InternalObject.connectedBody = WrapperHelper.UnwrapObject < Rigidbody >( x ) );

            m_Properties["connectedArticulationBody"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ArticulationBody( m_InternalObject.connectedArticulationBody ),
                x => m_InternalObject.connectedArticulationBody =
                    WrapperHelper.UnwrapObject < ArticulationBody >( x ) );

            m_Properties["axis"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.axis ),
                x => m_InternalObject.axis = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["anchor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.anchor ),
                x => m_InternalObject.anchor = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["connectedAnchor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.connectedAnchor ),
                x => m_InternalObject.connectedAnchor = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["autoConfigureConnectedAnchor"] = new BSReflectionReference(
                () => m_InternalObject.autoConfigureConnectedAnchor ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.autoConfigureConnectedAnchor = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["breakForce"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.breakForce ),
                x => m_InternalObject.breakForce = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["breakTorque"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.breakTorque ),
                x => m_InternalObject.breakTorque = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["enableCollision"] = new BSReflectionReference(
                () => m_InternalObject.enableCollision ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enableCollision = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["enablePreprocessing"] = new BSReflectionReference(
                () => m_InternalObject.enablePreprocessing ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enablePreprocessing = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["massScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.massScale ),
                x => m_InternalObject.massScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["connectedMassScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.connectedMassScale ),
                x => m_InternalObject.connectedMassScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["currentForce"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.currentForce ),
                null );

            m_Properties["currentTorque"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.currentTorque ),
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
