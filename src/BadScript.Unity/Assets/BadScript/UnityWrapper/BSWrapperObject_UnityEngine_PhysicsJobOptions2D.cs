using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_PhysicsJobOptions2D : BSWrapperObject < PhysicsJobOptions2D >

    {
        #region Public

        public BSWrapperObject_UnityEngine_PhysicsJobOptions2D( PhysicsJobOptions2D obj ) : base( obj )
        {
            m_Properties["useMultithreading"] = new BSReflectionReference(
                () => m_InternalObject.useMultithreading ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useMultithreading = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useConsistencySorting"] = new BSReflectionReference(
                () => m_InternalObject.useConsistencySorting ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useConsistencySorting = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["interpolationPosesPerJob"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.interpolationPosesPerJob ),
                x => m_InternalObject.interpolationPosesPerJob = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["newContactsPerJob"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.newContactsPerJob ),
                x => m_InternalObject.newContactsPerJob = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["collideContactsPerJob"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.collideContactsPerJob ),
                x => m_InternalObject.collideContactsPerJob = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["clearFlagsPerJob"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.clearFlagsPerJob ),
                x => m_InternalObject.clearFlagsPerJob = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["clearBodyForcesPerJob"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.clearBodyForcesPerJob ),
                x => m_InternalObject.clearBodyForcesPerJob = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["syncDiscreteFixturesPerJob"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.syncDiscreteFixturesPerJob ),
                x => m_InternalObject.syncDiscreteFixturesPerJob = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["syncContinuousFixturesPerJob"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.syncContinuousFixturesPerJob ),
                x => m_InternalObject.syncContinuousFixturesPerJob = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["findNearestContactsPerJob"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.findNearestContactsPerJob ),
                x => m_InternalObject.findNearestContactsPerJob = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["updateTriggerContactsPerJob"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.updateTriggerContactsPerJob ),
                x => m_InternalObject.updateTriggerContactsPerJob = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["islandSolverCostThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.islandSolverCostThreshold ),
                x => m_InternalObject.islandSolverCostThreshold = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["islandSolverBodyCostScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.islandSolverBodyCostScale ),
                x => m_InternalObject.islandSolverBodyCostScale = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["islandSolverContactCostScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.islandSolverContactCostScale ),
                x => m_InternalObject.islandSolverContactCostScale = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["islandSolverJointCostScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.islandSolverJointCostScale ),
                x => m_InternalObject.islandSolverJointCostScale = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["islandSolverBodiesPerJob"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.islandSolverBodiesPerJob ),
                x => m_InternalObject.islandSolverBodiesPerJob = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["islandSolverContactsPerJob"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.islandSolverContactsPerJob ),
                x => m_InternalObject.islandSolverContactsPerJob = WrapperHelper.UnwrapObject < int >( x ) );

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
