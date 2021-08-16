using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Threading_WaitHandle : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Threading_WaitHandle() : base(typeof(System.Threading.WaitHandle))
        {
            m_StaticProperties["WaitTimeout"] = new BSReflectionReference(() => new BSObject((decimal)System.Threading.WaitHandle.WaitTimeout), null);
            m_StaticProperties["SignalAndWait"] = new BSFunctionReference(new BSFunction("function SignalAndWait(toSignal, toWaitOn)", a => System.Threading.WaitHandle.SignalAndWait(WrapperHelper.UnwrapObject<System.Threading.WaitHandle>(a[0]), WrapperHelper.UnwrapObject<System.Threading.WaitHandle>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["SignalAndWait"] = new BSFunctionReference(new BSFunction("function SignalAndWait(toSignal, toWaitOn, timeout, exitContext)", a => System.Threading.WaitHandle.SignalAndWait(WrapperHelper.UnwrapObject<System.Threading.WaitHandle>(a[0]), WrapperHelper.UnwrapObject<System.Threading.WaitHandle>(a[1]), WrapperHelper.UnwrapObject<System.TimeSpan>(a[2]), WrapperHelper.UnwrapObject<System.Boolean>(a[3])) ? BSObject.One : BSObject.Zero, 4));
            m_StaticProperties["SignalAndWait"] = new BSFunctionReference(new BSFunction("function SignalAndWait(toSignal, toWaitOn, millisecondsTimeout, exitContext)", a => System.Threading.WaitHandle.SignalAndWait(WrapperHelper.UnwrapObject<System.Threading.WaitHandle>(a[0]), WrapperHelper.UnwrapObject<System.Threading.WaitHandle>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Boolean>(a[3])) ? BSObject.One : BSObject.Zero, 4));

        }
    }

}