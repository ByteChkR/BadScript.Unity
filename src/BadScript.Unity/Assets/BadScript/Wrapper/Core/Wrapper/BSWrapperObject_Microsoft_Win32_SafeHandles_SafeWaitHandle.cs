using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using Microsoft.Win32.SafeHandles;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_Microsoft_Win32_SafeHandles_SafeWaitHandle : BSWrapperObject < SafeWaitHandle >

    {
        #region Public

        public BSWrapperObject_Microsoft_Win32_SafeHandles_SafeWaitHandle( SafeWaitHandle obj ) : base( obj )
        {
            m_Properties["IsInvalid"] = new BSReflectionReference(
                () => m_InternalObject.IsInvalid ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsClosed"] = new BSReflectionReference(
                () => m_InternalObject.IsClosed ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["DangerousGetHandle"] = new BSFunctionReference(
                new BSFunction(
                    "function DangerousGetHandle()",
                    a => new BSWrapperObject_System_IntPtr( m_InternalObject.DangerousGetHandle() ),
                    0 ) );

            m_Properties["Close"] = new BSFunctionReference(
                new BSFunction(
                    "function Close()",
                    a =>
                    {
                        m_InternalObject.Close();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Dispose"] = new BSFunctionReference(
                new BSFunction(
                    "function Dispose()",
                    a =>
                    {
                        m_InternalObject.Dispose();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["SetHandleAsInvalid"] = new BSFunctionReference(
                new BSFunction(
                    "function SetHandleAsInvalid()",
                    a =>
                    {
                        m_InternalObject.SetHandleAsInvalid();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["DangerousRelease"] = new BSFunctionReference(
                new BSFunction(
                    "function DangerousRelease()",
                    a =>
                    {
                        m_InternalObject.DangerousRelease();

                        return new BSObject( null );
                    },
                    0 ) );

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
