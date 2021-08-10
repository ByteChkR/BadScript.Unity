using System;
using System.Threading;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using Microsoft.Win32.SafeHandles;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Threading_WaitHandle : BSWrapperObject < WaitHandle >

    {
        #region Public

        public BSWrapperObject_System_Threading_WaitHandle( WaitHandle obj ) : base( obj )
        {
            m_Properties["Handle"] = new BSReflectionReference(
                () => new BSWrapperObject_System_IntPtr( m_InternalObject.Handle ),
                x => m_InternalObject.Handle = WrapperHelper.UnwrapObject < IntPtr >( x ) );

            m_Properties["SafeWaitHandle"] = new BSReflectionReference(
                () => new BSWrapperObject_Microsoft_Win32_SafeHandles_SafeWaitHandle( m_InternalObject.SafeWaitHandle ),
                x => m_InternalObject.SafeWaitHandle = WrapperHelper.UnwrapObject < SafeWaitHandle >( x ) );

            m_Properties["WaitOne"] = new BSFunctionReference(
                new BSFunction(
                    "function WaitOne(millisecondsTimeout, exitContext)",
                    a => m_InternalObject.WaitOne(
                        WrapperHelper.UnwrapObject < int >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["WaitOne"] = new BSFunctionReference(
                new BSFunction(
                    "function WaitOne(timeout, exitContext)",
                    a => m_InternalObject.WaitOne(
                        WrapperHelper.UnwrapObject < TimeSpan >( a[0] ),
                        WrapperHelper.UnwrapObject < bool >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["WaitOne"] = new BSFunctionReference(
                new BSFunction(
                    "function WaitOne(millisecondsTimeout)",
                    a => m_InternalObject.WaitOne( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["WaitOne"] = new BSFunctionReference(
                new BSFunction(
                    "function WaitOne(timeout)",
                    a => m_InternalObject.WaitOne( WrapperHelper.UnwrapObject < TimeSpan >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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
