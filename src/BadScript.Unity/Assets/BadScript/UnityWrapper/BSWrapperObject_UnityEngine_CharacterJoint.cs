using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_CharacterJoint : BSWrapperObject < CharacterJoint >

    {
        #region Public

        public BSWrapperObject_UnityEngine_CharacterJoint( CharacterJoint obj ) : base( obj )
        {
            m_Properties["swingAxis"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.swingAxis ),
                x => m_InternalObject.swingAxis = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["twistLimitSpring"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SoftJointLimitSpring( m_InternalObject.twistLimitSpring ),
                x => m_InternalObject.twistLimitSpring = WrapperHelper.UnwrapObject < SoftJointLimitSpring >( x ) );

            m_Properties["swingLimitSpring"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SoftJointLimitSpring( m_InternalObject.swingLimitSpring ),
                x => m_InternalObject.swingLimitSpring = WrapperHelper.UnwrapObject < SoftJointLimitSpring >( x ) );

            m_Properties["lowTwistLimit"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SoftJointLimit( m_InternalObject.lowTwistLimit ),
                x => m_InternalObject.lowTwistLimit = WrapperHelper.UnwrapObject < SoftJointLimit >( x ) );

            m_Properties["highTwistLimit"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SoftJointLimit( m_InternalObject.highTwistLimit ),
                x => m_InternalObject.highTwistLimit = WrapperHelper.UnwrapObject < SoftJointLimit >( x ) );

            m_Properties["swing1Limit"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SoftJointLimit( m_InternalObject.swing1Limit ),
                x => m_InternalObject.swing1Limit = WrapperHelper.UnwrapObject < SoftJointLimit >( x ) );

            m_Properties["swing2Limit"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SoftJointLimit( m_InternalObject.swing2Limit ),
                x => m_InternalObject.swing2Limit = WrapperHelper.UnwrapObject < SoftJointLimit >( x ) );

            m_Properties["enableProjection"] = new BSReflectionReference(
                () => m_InternalObject.enableProjection ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enableProjection = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["projectionDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.projectionDistance ),
                x => m_InternalObject.projectionDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["projectionAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.projectionAngle ),
                x => m_InternalObject.projectionAngle = WrapperHelper.UnwrapObject < float >( x ) );

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

            m_Properties["rotationDrive"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_JointDrive( m_InternalObject.rotationDrive ),
                x => m_InternalObject.rotationDrive = WrapperHelper.UnwrapObject < JointDrive >( x ) );

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
