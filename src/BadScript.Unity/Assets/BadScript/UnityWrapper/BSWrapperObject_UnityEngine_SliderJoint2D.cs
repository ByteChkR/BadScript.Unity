using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_SliderJoint2D : BSWrapperObject < SliderJoint2D >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SliderJoint2D( SliderJoint2D obj ) : base( obj )
        {
            m_Properties["autoConfigureAngle"] = new BSReflectionReference(
                () => m_InternalObject.autoConfigureAngle ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.autoConfigureAngle = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["angle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.angle ),
                x => m_InternalObject.angle = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["useMotor"] = new BSReflectionReference(
                () => m_InternalObject.useMotor ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useMotor = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useLimits"] = new BSReflectionReference(
                () => m_InternalObject.useLimits ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useLimits = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["motor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_JointMotor2D( m_InternalObject.motor ),
                x => m_InternalObject.motor = WrapperHelper.UnwrapObject < JointMotor2D >( x ) );

            m_Properties["limits"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_JointTranslationLimits2D( m_InternalObject.limits ),
                x => m_InternalObject.limits = WrapperHelper.UnwrapObject < JointTranslationLimits2D >( x ) );

            m_Properties["referenceAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.referenceAngle ),
                null );

            m_Properties["jointTranslation"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.jointTranslation ),
                null );

            m_Properties["jointSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.jointSpeed ),
                null );

            m_Properties["anchor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.anchor ),
                x => m_InternalObject.anchor = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["connectedAnchor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.connectedAnchor ),
                x => m_InternalObject.connectedAnchor = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["autoConfigureConnectedAnchor"] = new BSReflectionReference(
                () => m_InternalObject.autoConfigureConnectedAnchor ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.autoConfigureConnectedAnchor = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["attachedRigidbody"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rigidbody2D( m_InternalObject.attachedRigidbody ),
                null );

            m_Properties["connectedBody"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rigidbody2D( m_InternalObject.connectedBody ),
                x => m_InternalObject.connectedBody = WrapperHelper.UnwrapObject < Rigidbody2D >( x ) );

            m_Properties["enableCollision"] = new BSReflectionReference(
                () => m_InternalObject.enableCollision ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enableCollision = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["breakForce"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.breakForce ),
                x => m_InternalObject.breakForce = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["breakTorque"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.breakTorque ),
                x => m_InternalObject.breakTorque = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["reactionForce"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.reactionForce ),
                null );

            m_Properties["reactionTorque"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.reactionTorque ),
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

            m_Properties["GetMotorForce"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMotorForce(timeStep)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetMotorForce( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetReactionForce"] = new BSFunctionReference(
                new BSFunction(
                    "function GetReactionForce(timeStep)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetReactionForce( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetReactionTorque"] = new BSFunctionReference(
                new BSFunction(
                    "function GetReactionTorque(timeStep)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetReactionTorque(
                            WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
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
