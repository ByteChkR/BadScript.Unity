using System;
using System.Threading;
using System.Threading.Tasks;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Threading_Tasks_TaskFactory : BSWrapperObject < TaskFactory >

    {
        #region Public

        public BSWrapperObject_System_Threading_Tasks_TaskFactory( TaskFactory obj ) : base( obj )
        {
            m_Properties["CancellationToken"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Threading_CancellationToken( m_InternalObject.CancellationToken ),
                null );

            m_Properties["Scheduler"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Threading_Tasks_TaskScheduler( m_InternalObject.Scheduler ),
                null );

            m_Properties["StartNew"] = new BSFunctionReference(
                new BSFunction(
                    "function StartNew(action)",
                    a => new BSWrapperObject_System_Threading_Tasks_Task(
                        m_InternalObject.StartNew( WrapperHelper.UnwrapObject < Action >( a[0] ) ) ),
                    1 ) );

            m_Properties["StartNew"] = new BSFunctionReference(
                new BSFunction(
                    "function StartNew(action, cancellationToken)",
                    a => new BSWrapperObject_System_Threading_Tasks_Task(
                        m_InternalObject.StartNew(
                            WrapperHelper.UnwrapObject < Action >( a[0] ),
                            WrapperHelper.UnwrapObject < CancellationToken >( a[1] ) ) ),
                    2 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}
