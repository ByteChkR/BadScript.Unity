using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Threading_Tasks_Task : BSWrapperObject<System.Threading.Tasks.Task>

    {
        public BSWrapperObject_System_Threading_Tasks_Task(System.Threading.Tasks.Task obj) : base(obj)
        {
            m_Properties["Id"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.Id), null);
            m_Properties["Exception"] = new BSReflectionReference(() => new BSWrapperObject_System_AggregateException(m_InternalObject.Exception), null);
            m_Properties["IsCanceled"] = new BSReflectionReference(() => m_InternalObject.IsCanceled ? BSObject.One : BSObject.Zero, null);
            m_Properties["IsCompleted"] = new BSReflectionReference(() => m_InternalObject.IsCompleted ? BSObject.One : BSObject.Zero, null);
            m_Properties["AsyncState"] = new BSReflectionReference(() => new BSWrapperObject_System_Object(m_InternalObject.AsyncState), null);
            m_Properties["IsFaulted"] = new BSReflectionReference(() => m_InternalObject.IsFaulted ? BSObject.One : BSObject.Zero, null);
            m_Properties["Start"] = new BSFunctionReference(new BSFunction("function Start()", a => {
                m_InternalObject.Start();
                return new BSObject(null);
            }, 0));
            m_Properties["Start"] = new BSFunctionReference(new BSFunction("function Start(scheduler)", a => {
                m_InternalObject.Start(WrapperHelper.UnwrapObject<System.Threading.Tasks.TaskScheduler>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["RunSynchronously"] = new BSFunctionReference(new BSFunction("function RunSynchronously()", a => {
                m_InternalObject.RunSynchronously();
                return new BSObject(null);
            }, 0));
            m_Properties["RunSynchronously"] = new BSFunctionReference(new BSFunction("function RunSynchronously(scheduler)", a => {
                m_InternalObject.RunSynchronously(WrapperHelper.UnwrapObject<System.Threading.Tasks.TaskScheduler>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Dispose"] = new BSFunctionReference(new BSFunction("function Dispose()", a => {
                m_InternalObject.Dispose();
                return new BSObject(null);
            }, 0));
            m_Properties["GetAwaiter"] = new BSFunctionReference(new BSFunction("function GetAwaiter()", a => new BSWrapperObject_System_Runtime_CompilerServices_TaskAwaiter(m_InternalObject.GetAwaiter()), 0));
            m_Properties["ConfigureAwait"] = new BSFunctionReference(new BSFunction("function ConfigureAwait(continueOnCapturedContext)", a => new BSWrapperObject_System_Runtime_CompilerServices_ConfiguredTaskAwaitable(m_InternalObject.ConfigureAwait(WrapperHelper.UnwrapObject<System.Boolean>(a[0]))), 1));
            m_Properties["Wait"] = new BSFunctionReference(new BSFunction("function Wait()", a => {
                m_InternalObject.Wait();
                return new BSObject(null);
            }, 0));
            m_Properties["Wait"] = new BSFunctionReference(new BSFunction("function Wait(timeout)", a => m_InternalObject.Wait(WrapperHelper.UnwrapObject<System.TimeSpan>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Wait"] = new BSFunctionReference(new BSFunction("function Wait(cancellationToken)", a => {
                m_InternalObject.Wait(WrapperHelper.UnwrapObject<System.Threading.CancellationToken>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Wait"] = new BSFunctionReference(new BSFunction("function Wait(millisecondsTimeout)", a => m_InternalObject.Wait(WrapperHelper.UnwrapObject<System.Int32>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Wait"] = new BSFunctionReference(new BSFunction("function Wait(millisecondsTimeout, cancellationToken)", a => m_InternalObject.Wait(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Threading.CancellationToken>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}