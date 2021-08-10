using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_RuntimeMethodHandle : BSWrapperObject < RuntimeMethodHandle >

    {
        #region Public

        public BSWrapperObject_System_RuntimeMethodHandle( RuntimeMethodHandle obj ) : base( obj )
        {
            m_Properties["Value"] = new BSReflectionReference(
                () => new BSWrapperObject_System_IntPtr( m_InternalObject.Value ),
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(handle)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < RuntimeMethodHandle >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
