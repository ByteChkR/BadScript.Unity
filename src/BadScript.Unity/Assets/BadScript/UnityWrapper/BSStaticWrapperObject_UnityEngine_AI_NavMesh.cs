using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.AI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_AI_NavMesh : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_AI_NavMesh() : base( typeof( NavMesh ) )
        {
            m_StaticProperties["avoidancePredictionTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) NavMesh.avoidancePredictionTime ),
                x => NavMesh.avoidancePredictionTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["pathfindingIterationsPerFrame"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) NavMesh.pathfindingIterationsPerFrame ),
                x => NavMesh.pathfindingIterationsPerFrame = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["AllAreas"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) NavMesh.AllAreas ),
                null );

            m_StaticProperties["CalculatePath"] = new BSFunctionReference(
                new BSFunction(
                    "function CalculatePath(sourcePosition, targetPosition, areaMask, path)",
                    a => NavMesh.CalculatePath(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ),
                        WrapperHelper.UnwrapObject < NavMeshPath >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["GetLayerCost"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLayerCost(layer)",
                    a => new BSObject( ( decimal ) NavMesh.GetLayerCost( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetNavMeshLayerFromName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetNavMeshLayerFromName(layerName)",
                    a => new BSObject(
                        ( decimal ) NavMesh.GetNavMeshLayerFromName( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetAreaCost"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAreaCost(areaIndex)",
                    a => new BSObject( ( decimal ) NavMesh.GetAreaCost( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetAreaFromName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAreaFromName(areaName)",
                    a => new BSObject(
                        ( decimal ) NavMesh.GetAreaFromName( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["AddNavMeshData"] = new BSFunctionReference(
                new BSFunction(
                    "function AddNavMeshData(navMeshData)",
                    a => new BSWrapperObject_UnityEngine_AI_NavMeshDataInstance(
                        NavMesh.AddNavMeshData( WrapperHelper.UnwrapObject < NavMeshData >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["AddNavMeshData"] = new BSFunctionReference(
                new BSFunction(
                    "function AddNavMeshData(navMeshData, position, rotation)",
                    a => new BSWrapperObject_UnityEngine_AI_NavMeshDataInstance(
                        NavMesh.AddNavMeshData(
                            WrapperHelper.UnwrapObject < NavMeshData >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["AddLink"] = new BSFunctionReference(
                new BSFunction(
                    "function AddLink(link)",
                    a => new BSWrapperObject_UnityEngine_AI_NavMeshLinkInstance(
                        NavMesh.AddLink( WrapperHelper.UnwrapObject < NavMeshLinkData >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["AddLink"] = new BSFunctionReference(
                new BSFunction(
                    "function AddLink(link, position, rotation)",
                    a => new BSWrapperObject_UnityEngine_AI_NavMeshLinkInstance(
                        NavMesh.AddLink(
                            WrapperHelper.UnwrapObject < NavMeshLinkData >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["CalculatePath"] = new BSFunctionReference(
                new BSFunction(
                    "function CalculatePath(sourcePosition, targetPosition, filter, path)",
                    a => NavMesh.CalculatePath(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < NavMeshQueryFilter >( a[2] ),
                        WrapperHelper.UnwrapObject < NavMeshPath >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["GetSettingsByID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSettingsByID(agentTypeID)",
                    a => new BSWrapperObject_UnityEngine_AI_NavMeshBuildSettings(
                        NavMesh.GetSettingsByID( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetSettingsByIndex"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSettingsByIndex(index)",
                    a => new BSWrapperObject_UnityEngine_AI_NavMeshBuildSettings(
                        NavMesh.GetSettingsByIndex( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetSettingsNameFromID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSettingsNameFromID(agentTypeID)",
                    a => new BSObject( NavMesh.GetSettingsNameFromID( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
