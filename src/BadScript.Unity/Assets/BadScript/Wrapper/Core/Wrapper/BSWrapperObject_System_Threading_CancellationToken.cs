using System;
using System.Threading;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Threading_CancellationToken : BSWrapperObject < CancellationToken >

    {
        #region Public

        public BSWrapperObject_System_Threading_CancellationToken( CancellationToken obj ) : base( obj )
        {
            m_Properties["IsCancellationRequested"] = new BSReflectionReference(
                () => m_InternalObject.IsCancellationRequested ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["CanBeCanceled"] = new BSReflectionReference(
                () => m_InternalObject.CanBeCanceled ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["WaitHandle"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Threading_WaitHandle( m_InternalObject.WaitHandle ),
                null );

            m_Properties["Register"] = new BSFunctionReference(
                new BSFunction(
                    "function Register(callback)",
                    a => new BSWrapperObject_System_Threading_CancellationTokenRegistration(
                        m_InternalObject.Register( WrapperHelper.UnwrapObject < Action >( a[0] ) ) ),
                    1 ) );

            m_Properties["Register"] = new BSFunctionReference(
                new BSFunction(
                    "function Register(callback, useSynchronizationContext)",
                    a => new BSWrapperObject_System_Threading_CancellationTokenRegistration(
                        m_InternalObject.Register(
                            WrapperHelper.UnwrapObject < Action >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < CancellationToken >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["ThrowIfCancellationRequested"] = new BSFunctionReference(
                new BSFunction(
                    "function ThrowIfCancellationRequested()",
                    a =>
                    {
                        m_InternalObject.ThrowIfCancellationRequested();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}
