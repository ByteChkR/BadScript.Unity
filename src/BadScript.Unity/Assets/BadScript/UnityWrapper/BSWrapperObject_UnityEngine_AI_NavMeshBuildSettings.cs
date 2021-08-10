using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.AI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AI_NavMeshBuildSettings : BSWrapperObject < NavMeshBuildSettings >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AI_NavMeshBuildSettings( NavMeshBuildSettings obj ) : base( obj )
        {
            m_Properties["agentTypeID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.agentTypeID ),
                x => m_InternalObject.agentTypeID = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["agentRadius"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.agentRadius ),
                x => m_InternalObject.agentRadius = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["agentHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.agentHeight ),
                x => m_InternalObject.agentHeight = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["agentSlope"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.agentSlope ),
                x => m_InternalObject.agentSlope = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["agentClimb"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.agentClimb ),
                x => m_InternalObject.agentClimb = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["minRegionArea"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minRegionArea ),
                x => m_InternalObject.minRegionArea = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["overrideVoxelSize"] = new BSReflectionReference(
                () => m_InternalObject.overrideVoxelSize ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.overrideVoxelSize = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["voxelSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.voxelSize ),
                x => m_InternalObject.voxelSize = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["overrideTileSize"] = new BSReflectionReference(
                () => m_InternalObject.overrideTileSize ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.overrideTileSize = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["tileSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.tileSize ),
                x => m_InternalObject.tileSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["maxJobWorkers"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxJobWorkers ),
                x => m_InternalObject.maxJobWorkers = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["preserveTilesOutsideBounds"] = new BSReflectionReference(
                () => m_InternalObject.preserveTilesOutsideBounds ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.preserveTilesOutsideBounds = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["debug"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AI_NavMeshBuildDebugSettings( m_InternalObject.debug ),
                x => m_InternalObject.debug = WrapperHelper.UnwrapObject < NavMeshBuildDebugSettings >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
