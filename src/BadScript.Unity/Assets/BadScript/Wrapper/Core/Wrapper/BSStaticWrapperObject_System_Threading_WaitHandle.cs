using System;
using System.Threading;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Threading_WaitHandle : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Threading_WaitHandle() : base( typeof( WaitHandle ) )
        {
            m_StaticProperties["WaitTimeout"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) WaitHandle.WaitTimeout ),
                null );

            m_StaticProperties["SignalAndWait"] = new BSFunctionReference(
                new BSFunction(
                    "function SignalAndWait(toSignal, toWaitOn)",
                    a => WaitHandle.SignalAndWait(
                        WrapperHelper.UnwrapObject < WaitHandle >( a[0] ),
                        WrapperHelper.UnwrapObject < WaitHandle >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["SignalAndWait"] = new BSFunctionReference(
                new BSFunction(
                    "function SignalAndWait(toSignal, toWaitOn, timeout, exitContext)",
                    a => WaitHandle.SignalAndWait(
                        WrapperHelper.UnwrapObject < WaitHandle >( a[0] ),
                        WrapperHelper.UnwrapObject < WaitHandle >( a[1] ),
                        WrapperHelper.UnwrapObject < TimeSpan >( a[2] ),
                        WrapperHelper.UnwrapObject < bool >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["SignalAndWait"] = new BSFunctionReference(
                new BSFunction(
                    "function SignalAndWait(toSignal, toWaitOn, millisecondsTimeout, exitContext)",
                    a => WaitHandle.SignalAndWait(
                        WrapperHelper.UnwrapObject < WaitHandle >( a[0] ),
                        WrapperHelper.UnwrapObject < WaitHandle >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ),
                        WrapperHelper.UnwrapObject < bool >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

        }

        #endregion
    }

}
