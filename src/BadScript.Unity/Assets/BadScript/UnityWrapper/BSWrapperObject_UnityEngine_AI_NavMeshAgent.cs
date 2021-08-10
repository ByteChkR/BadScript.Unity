using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.AI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AI_NavMeshAgent : BSWrapperObject < NavMeshAgent >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AI_NavMeshAgent( NavMeshAgent obj ) : base( obj )
        {
            m_Properties["destination"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.destination ),
                x => m_InternalObject.destination = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["stoppingDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.stoppingDistance ),
                x => m_InternalObject.stoppingDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["velocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.velocity ),
                x => m_InternalObject.velocity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["nextPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.nextPosition ),
                x => m_InternalObject.nextPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["steeringTarget"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.steeringTarget ),
                null );

            m_Properties["desiredVelocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.desiredVelocity ),
                null );

            m_Properties["remainingDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.remainingDistance ),
                null );

            m_Properties["baseOffset"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.baseOffset ),
                x => m_InternalObject.baseOffset = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["isOnOffMeshLink"] = new BSReflectionReference(
                () => m_InternalObject.isOnOffMeshLink ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["currentOffMeshLinkData"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AI_OffMeshLinkData( m_InternalObject.currentOffMeshLinkData ),
                null );

            m_Properties["nextOffMeshLinkData"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AI_OffMeshLinkData( m_InternalObject.nextOffMeshLinkData ),
                null );

            m_Properties["autoTraverseOffMeshLink"] = new BSReflectionReference(
                () => m_InternalObject.autoTraverseOffMeshLink ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.autoTraverseOffMeshLink = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["autoBraking"] = new BSReflectionReference(
                () => m_InternalObject.autoBraking ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.autoBraking = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["autoRepath"] = new BSReflectionReference(
                () => m_InternalObject.autoRepath ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.autoRepath = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["hasPath"] = new BSReflectionReference(
                () => m_InternalObject.hasPath ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["pathPending"] = new BSReflectionReference(
                () => m_InternalObject.pathPending ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isPathStale"] = new BSReflectionReference(
                () => m_InternalObject.isPathStale ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["pathEndPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.pathEndPosition ),
                null );

            m_Properties["isStopped"] = new BSReflectionReference(
                () => m_InternalObject.isStopped ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isStopped = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["path"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AI_NavMeshPath( m_InternalObject.path ),
                x => m_InternalObject.path = WrapperHelper.UnwrapObject < NavMeshPath >( x ) );

            m_Properties["navMeshOwner"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Object( m_InternalObject.navMeshOwner ),
                null );

            m_Properties["agentTypeID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.agentTypeID ),
                x => m_InternalObject.agentTypeID = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["walkableMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.walkableMask ),
                x => m_InternalObject.walkableMask = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["areaMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.areaMask ),
                x => m_InternalObject.areaMask = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["speed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.speed ),
                x => m_InternalObject.speed = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["angularSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.angularSpeed ),
                x => m_InternalObject.angularSpeed = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["acceleration"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.acceleration ),
                x => m_InternalObject.acceleration = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["updatePosition"] = new BSReflectionReference(
                () => m_InternalObject.updatePosition ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.updatePosition = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["updateRotation"] = new BSReflectionReference(
                () => m_InternalObject.updateRotation ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.updateRotation = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["updateUpAxis"] = new BSReflectionReference(
                () => m_InternalObject.updateUpAxis ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.updateUpAxis = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["radius"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.radius ),
                x => m_InternalObject.radius = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                x => m_InternalObject.height = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["avoidancePriority"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.avoidancePriority ),
                x => m_InternalObject.avoidancePriority = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["isOnNavMesh"] = new BSReflectionReference(
                () => m_InternalObject.isOnNavMesh ? BSObject.One : BSObject.Zero,
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

            m_Properties["SetDestination"] = new BSFunctionReference(
                new BSFunction(
                    "function SetDestination(target)",
                    a => m_InternalObject.SetDestination( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Warp"] = new BSFunctionReference(
                new BSFunction(
                    "function Warp(newPosition)",
                    a => m_InternalObject.Warp( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["SetPath"] = new BSFunctionReference(
                new BSFunction(
                    "function SetPath(path)",
                    a => m_InternalObject.SetPath( WrapperHelper.UnwrapObject < NavMeshPath >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["CalculatePath"] = new BSFunctionReference(
                new BSFunction(
                    "function CalculatePath(targetPosition, path)",
                    a => m_InternalObject.CalculatePath(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < NavMeshPath >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["GetLayerCost"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLayerCost(layer)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetLayerCost( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetAreaCost"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAreaCost(areaIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetAreaCost( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
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
