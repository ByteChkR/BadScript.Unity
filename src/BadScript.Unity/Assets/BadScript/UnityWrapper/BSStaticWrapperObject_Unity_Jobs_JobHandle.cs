using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using Unity.Jobs;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_Unity_Jobs_JobHandle : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_Unity_Jobs_JobHandle() : base( typeof( JobHandle ) )
        {
            m_StaticProperties["CombineDependencies"] = new BSFunctionReference(
                new BSFunction(
                    "function CombineDependencies(job0, job1)",
                    a => new BSWrapperObject_Unity_Jobs_JobHandle(
                        JobHandle.CombineDependencies(
                            WrapperHelper.UnwrapObject < JobHandle >( a[0] ),
                            WrapperHelper.UnwrapObject < JobHandle >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["CombineDependencies"] = new BSFunctionReference(
                new BSFunction(
                    "function CombineDependencies(job0, job1, job2)",
                    a => new BSWrapperObject_Unity_Jobs_JobHandle(
                        JobHandle.CombineDependencies(
                            WrapperHelper.UnwrapObject < JobHandle >( a[0] ),
                            WrapperHelper.UnwrapObject < JobHandle >( a[1] ),
                            WrapperHelper.UnwrapObject < JobHandle >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["CheckFenceIsDependencyOrDidSyncFence"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckFenceIsDependencyOrDidSyncFence(jobHandle, dependsOn)",
                    a => JobHandle.CheckFenceIsDependencyOrDidSyncFence(
                        WrapperHelper.UnwrapObject < JobHandle >( a[0] ),
                        WrapperHelper.UnwrapObject < JobHandle >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

        }

        #endregion
    }

}
