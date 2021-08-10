using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Cloth : BSWrapperObject < Cloth >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Cloth( Cloth obj ) : base( obj )
        {
            m_Properties["sleepThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sleepThreshold ),
                x => m_InternalObject.sleepThreshold = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bendingStiffness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bendingStiffness ),
                x => m_InternalObject.bendingStiffness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["stretchingStiffness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.stretchingStiffness ),
                x => m_InternalObject.stretchingStiffness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["damping"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.damping ),
                x => m_InternalObject.damping = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["externalAcceleration"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.externalAcceleration ),
                x => m_InternalObject.externalAcceleration = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["randomAcceleration"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.randomAcceleration ),
                x => m_InternalObject.randomAcceleration = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["useGravity"] = new BSReflectionReference(
                () => m_InternalObject.useGravity ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useGravity = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["friction"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.friction ),
                x => m_InternalObject.friction = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["collisionMassScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.collisionMassScale ),
                x => m_InternalObject.collisionMassScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["enableContinuousCollision"] = new BSReflectionReference(
                () => m_InternalObject.enableContinuousCollision ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enableContinuousCollision = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useVirtualParticles"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.useVirtualParticles ),
                x => m_InternalObject.useVirtualParticles = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["worldVelocityScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.worldVelocityScale ),
                x => m_InternalObject.worldVelocityScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["worldAccelerationScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.worldAccelerationScale ),
                x => m_InternalObject.worldAccelerationScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["clothSolverFrequency"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.clothSolverFrequency ),
                x => m_InternalObject.clothSolverFrequency = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["solverFrequency"] = new BSReflectionReference(
                () => m_InternalObject.solverFrequency ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.solverFrequency = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useTethers"] = new BSReflectionReference(
                () => m_InternalObject.useTethers ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useTethers = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["stiffnessFrequency"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.stiffnessFrequency ),
                x => m_InternalObject.stiffnessFrequency = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["selfCollisionDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.selfCollisionDistance ),
                x => m_InternalObject.selfCollisionDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["selfCollisionStiffness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.selfCollisionStiffness ),
                x => m_InternalObject.selfCollisionStiffness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["useContinuousCollision"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.useContinuousCollision ),
                x => m_InternalObject.useContinuousCollision = WrapperHelper.UnwrapObject < float >( x ) );

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
