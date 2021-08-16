using System;
using System.Runtime.Serialization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_RuntimeTypeHandle : BSWrapperObject < RuntimeTypeHandle >

    {
        #region Public

        public BSWrapperObject_System_RuntimeTypeHandle( RuntimeTypeHandle obj ) : base( obj )
        {
            m_Properties["Value"] = new BSReflectionReference(
                () => new BSWrapperObject_System_IntPtr( m_InternalObject.Value ),
                null );

            m_Properties["GetObjectData"] = new BSFunctionReference(
                new BSFunction(
                    "function GetObjectData(info, context)",
                    a =>
                    {
                        m_InternalObject.GetObjectData(
                            WrapperHelper.UnwrapObject < SerializationInfo >( a[0] ),
                            WrapperHelper.UnwrapObject < StreamingContext >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

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
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < RuntimeTypeHandle >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["GetModuleHandle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetModuleHandle()",
                    a => new BSWrapperObject_System_ModuleHandle( m_InternalObject.GetModuleHandle() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}
