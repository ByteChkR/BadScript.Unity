using System;
using System.Threading;
using System.Threading.Tasks;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Threading_Tasks_Task : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Threading_Tasks_Task() : base( typeof( Task ) )
        {
            m_StaticProperties["Factory"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Threading_Tasks_TaskFactory( Task.Factory ),
                null );

            m_StaticProperties["CompletedTask"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Threading_Tasks_Task( Task.CompletedTask ),
                null );

            m_StaticProperties["FromException"] = new BSFunctionReference(
                new BSFunction(
                    "function FromException(exception)",
                    a => new BSWrapperObject_System_Threading_Tasks_Task(
                        Task.FromException( WrapperHelper.UnwrapObject < Exception >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FromCanceled"] = new BSFunctionReference(
                new BSFunction(
                    "function FromCanceled(cancellationToken)",
                    a => new BSWrapperObject_System_Threading_Tasks_Task(
                        Task.FromCanceled( WrapperHelper.UnwrapObject < CancellationToken >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Run"] = new BSFunctionReference(
                new BSFunction(
                    "function Run(action)",
                    a => new BSWrapperObject_System_Threading_Tasks_Task(
                        Task.Run( WrapperHelper.UnwrapObject < Action >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Run"] = new BSFunctionReference(
                new BSFunction(
                    "function Run(action, cancellationToken)",
                    a => new BSWrapperObject_System_Threading_Tasks_Task(
                        Task.Run(
                            WrapperHelper.UnwrapObject < Action >( a[0] ),
                            WrapperHelper.UnwrapObject < CancellationToken >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Delay"] = new BSFunctionReference(
                new BSFunction(
                    "function Delay(delay)",
                    a => new BSWrapperObject_System_Threading_Tasks_Task(
                        Task.Delay( WrapperHelper.UnwrapObject < TimeSpan >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Delay"] = new BSFunctionReference(
                new BSFunction(
                    "function Delay(delay, cancellationToken)",
                    a => new BSWrapperObject_System_Threading_Tasks_Task(
                        Task.Delay(
                            WrapperHelper.UnwrapObject < TimeSpan >( a[0] ),
                            WrapperHelper.UnwrapObject < CancellationToken >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Delay"] = new BSFunctionReference(
                new BSFunction(
                    "function Delay(millisecondsDelay)",
                    a => new BSWrapperObject_System_Threading_Tasks_Task(
                        Task.Delay( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Delay"] = new BSFunctionReference(
                new BSFunction(
                    "function Delay(millisecondsDelay, cancellationToken)",
                    a => new BSWrapperObject_System_Threading_Tasks_Task(
                        Task.Delay(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < CancellationToken >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
