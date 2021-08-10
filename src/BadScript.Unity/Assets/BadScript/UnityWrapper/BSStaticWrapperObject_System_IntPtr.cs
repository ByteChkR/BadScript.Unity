using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_IntPtr : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_IntPtr() : base( typeof( IntPtr ) )
        {
            m_StaticProperties["Size"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) IntPtr.Size ),
                null );

            m_StaticProperties["Zero"] = new BSReflectionReference(
                () => new BSWrapperObject_System_IntPtr( IntPtr.Zero ),
                null );

            m_StaticProperties["Add"] = new BSFunctionReference(
                new BSFunction(
                    "function Add(pointer, offset)",
                    a => new BSWrapperObject_System_IntPtr(
                        IntPtr.Add(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Subtract"] = new BSFunctionReference(
                new BSFunction(
                    "function Subtract(pointer, offset)",
                    a => new BSWrapperObject_System_IntPtr(
                        IntPtr.Subtract(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
