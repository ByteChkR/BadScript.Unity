using System;
using System.Globalization;
using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Reflection_AssemblyName : BSWrapperObject < AssemblyName >

    {
        #region Public

        public BSWrapperObject_System_Reflection_AssemblyName( AssemblyName obj ) : base( obj )
        {
            m_Properties["Name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.Name ),
                x => m_InternalObject.Name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["CodeBase"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.CodeBase ),
                x => m_InternalObject.CodeBase = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["EscapedCodeBase"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.EscapedCodeBase ),
                null );

            m_Properties["CultureInfo"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_CultureInfo( m_InternalObject.CultureInfo ),
                x => m_InternalObject.CultureInfo = WrapperHelper.UnwrapObject < CultureInfo >( x ) );

            m_Properties["FullName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.FullName ),
                null );

            m_Properties["KeyPair"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_StrongNameKeyPair( m_InternalObject.KeyPair ),
                x => m_InternalObject.KeyPair = WrapperHelper.UnwrapObject < StrongNameKeyPair >( x ) );

            m_Properties["Version"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Version( m_InternalObject.Version ),
                x => m_InternalObject.Version = WrapperHelper.UnwrapObject < Version >( x ) );

            m_Properties["CultureName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.CultureName ),
                x => m_InternalObject.CultureName = WrapperHelper.UnwrapObject < string >( x ) );

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
