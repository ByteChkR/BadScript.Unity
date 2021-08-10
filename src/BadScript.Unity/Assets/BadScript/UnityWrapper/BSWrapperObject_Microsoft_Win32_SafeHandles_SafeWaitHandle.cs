using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using Microsoft.Win32.SafeHandles;

namespace BSWrapperObjects.Internal.UnityWrapper
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
