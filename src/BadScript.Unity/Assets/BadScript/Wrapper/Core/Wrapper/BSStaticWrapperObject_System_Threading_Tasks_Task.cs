using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Threading_Tasks_Task : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Threading_Tasks_Task() : base(typeof(System.Threading.Tasks.Task))
        {
            m_StaticProperties["Factory"] = new BSReflectionReference(() => new BSWrapperObject_System_Threading_Tasks_TaskFactory(System.Threading.Tasks.Task.Factory), null);
            m_StaticProperties["CompletedTask"] = new BSReflectionReference(() => new BSWrapperObject_System_Threading_Tasks_Task(System.Threading.Tasks.Task.CompletedTask), null);
            m_StaticProperties["Yield"] = new BSFunctionReference(new BSFunction("function Yield()", a => new BSWrapperObject_System_Runtime_CompilerServices_YieldAwaitable(System.Threading.Tasks.Task.Yield()), 0));
            m_StaticProperties["FromException"] = new BSFunctionReference(new BSFunction("function FromException(exception)", a => new BSWrapperObject_System_Threading_Tasks_Task(System.Threading.Tasks.Task.FromException(WrapperHelper.UnwrapObject<System.Exception>(a[0]))), 1));
            m_StaticProperties["FromCanceled"] = new BSFunctionReference(new BSFunction("function FromCanceled(cancellationToken)", a => new BSWrapperObject_System_Threading_Tasks_Task(System.Threading.Tasks.Task.FromCanceled(WrapperHelper.UnwrapObject<System.Threading.CancellationToken>(a[0]))), 1));
            m_StaticProperties["Run"] = new BSFunctionReference(new BSFunction("function Run(action)", a => new BSWrapperObject_System_Threading_Tasks_Task(System.Threading.Tasks.Task.Run(WrapperHelper.UnwrapObject<System.Action>(a[0]))), 1));
            m_StaticProperties["Run"] = new BSFunctionReference(new BSFunction("function Run(action, cancellationToken)", a => new BSWrapperObject_System_Threading_Tasks_Task(System.Threading.Tasks.Task.Run(WrapperHelper.UnwrapObject<System.Action>(a[0]), WrapperHelper.UnwrapObject<System.Threading.CancellationToken>(a[1]))), 2));
            m_StaticProperties["Delay"] = new BSFunctionReference(new BSFunction("function Delay(delay)", a => new BSWrapperObject_System_Threading_Tasks_Task(System.Threading.Tasks.Task.Delay(WrapperHelper.UnwrapObject<System.TimeSpan>(a[0]))), 1));
            m_StaticProperties["Delay"] = new BSFunctionReference(new BSFunction("function Delay(delay, cancellationToken)", a => new BSWrapperObject_System_Threading_Tasks_Task(System.Threading.Tasks.Task.Delay(WrapperHelper.UnwrapObject<System.TimeSpan>(a[0]), WrapperHelper.UnwrapObject<System.Threading.CancellationToken>(a[1]))), 2));
            m_StaticProperties["Delay"] = new BSFunctionReference(new BSFunction("function Delay(millisecondsDelay)", a => new BSWrapperObject_System_Threading_Tasks_Task(System.Threading.Tasks.Task.Delay(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_StaticProperties["Delay"] = new BSFunctionReference(new BSFunction("function Delay(millisecondsDelay, cancellationToken)", a => new BSWrapperObject_System_Threading_Tasks_Task(System.Threading.Tasks.Task.Delay(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Threading.CancellationToken>(a[1]))), 2));

        }
    }

}