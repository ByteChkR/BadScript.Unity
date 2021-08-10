using System;
using System.Threading;
using System.Threading.Tasks;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Threading_Tasks_Task : BSWrapperObject < Task >

    {
        #region Public

        public BSWrapperObject_System_Threading_Tasks_Task( Task obj ) : base( obj )
        {
            m_Properties["Id"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Id ),
                null );

            m_Properties["Exception"] = new BSReflectionReference(
                () => new BSWrapperObject_System_AggregateException( m_InternalObject.Exception ),
                null );

            m_Properties["IsCanceled"] = new BSReflectionReference(
                () => m_InternalObject.IsCanceled ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsCompleted"] = new BSReflectionReference(
                () => m_InternalObject.IsCompleted ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["AsyncState"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.AsyncState ),
                null );

            m_Properties["IsFaulted"] = new BSReflectionReference(
                () => m_InternalObject.IsFaulted ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["ConfigureAwait"] = new BSFunctionReference(
                new BSFunction(
                    "function ConfigureAwait(continueOnCapturedContext)",
                    a => new BSWrapperObject_System_Runtime_CompilerServices_ConfiguredTaskAwaitable(
                        m_InternalObject.ConfigureAwait( WrapperHelper.UnwrapObject < bool >( a[0] ) ) ),
                    1 ) );

            m_Properties["Wait"] = new BSFunctionReference(
                new BSFunction(
                    "function Wait(timeout)",
                    a => m_InternalObject.Wait( WrapperHelper.UnwrapObject < TimeSpan >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Wait"] = new BSFunctionReference(
                new BSFunction(
                    "function Wait(millisecondsTimeout)",
                    a => m_InternalObject.Wait( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Wait"] = new BSFunctionReference(
                new BSFunction(
                    "function Wait(millisecondsTimeout, cancellationToken)",
                    a => m_InternalObject.Wait(
                        WrapperHelper.UnwrapObject < int >( a[0] ),
                        WrapperHelper.UnwrapObject < CancellationToken >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

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
