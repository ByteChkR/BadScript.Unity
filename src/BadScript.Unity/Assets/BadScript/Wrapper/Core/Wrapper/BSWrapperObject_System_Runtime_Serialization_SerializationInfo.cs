using System;
using System.Runtime.Serialization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Runtime_Serialization_SerializationInfo : BSWrapperObject < SerializationInfo >

    {
        #region Public

        public BSWrapperObject_System_Runtime_Serialization_SerializationInfo( SerializationInfo obj ) : base( obj )
        {
            m_Properties["FullTypeName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.FullTypeName ),
                x => m_InternalObject.FullTypeName = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["AssemblyName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.AssemblyName ),
                x => m_InternalObject.AssemblyName = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["MemberCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MemberCount ),
                null );

            m_Properties["IsFullTypeNameSetExplicit"] = new BSReflectionReference(
                () => m_InternalObject.IsFullTypeNameSetExplicit ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsAssemblyNameSetExplicit"] = new BSReflectionReference(
                () => m_InternalObject.IsAssemblyNameSetExplicit ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["GetEnumerator"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEnumerator()",
                    a => new BSWrapperObject_System_Runtime_Serialization_SerializationInfoEnumerator(
                        m_InternalObject.GetEnumerator() ),
                    0 ) );

            m_Properties["AddValue"] = new BSFunctionReference(
                new BSFunction(
                    "function AddValue(name, value)",
                    a =>
                    {
                        m_InternalObject.AddValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddValue"] = new BSFunctionReference(
                new BSFunction(
                    "function AddValue(name, value)",
                    a =>
                    {
                        m_InternalObject.AddValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddValue"] = new BSFunctionReference(
                new BSFunction(
                    "function AddValue(name, value)",
                    a =>
                    {
                        m_InternalObject.AddValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < char >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddValue"] = new BSFunctionReference(
                new BSFunction(
                    "function AddValue(name, value)",
                    a =>
                    {
                        m_InternalObject.AddValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < sbyte >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddValue"] = new BSFunctionReference(
                new BSFunction(
                    "function AddValue(name, value)",
                    a =>
                    {
                        m_InternalObject.AddValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < byte >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddValue"] = new BSFunctionReference(
                new BSFunction(
                    "function AddValue(name, value)",
                    a =>
                    {
                        m_InternalObject.AddValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < short >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddValue"] = new BSFunctionReference(
                new BSFunction(
                    "function AddValue(name, value)",
                    a =>
                    {
                        m_InternalObject.AddValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < ushort >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddValue"] = new BSFunctionReference(
                new BSFunction(
                    "function AddValue(name, value)",
                    a =>
                    {
                        m_InternalObject.AddValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddValue"] = new BSFunctionReference(
                new BSFunction(
                    "function AddValue(name, value)",
                    a =>
                    {
                        m_InternalObject.AddValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddValue"] = new BSFunctionReference(
                new BSFunction(
                    "function AddValue(name, value)",
                    a =>
                    {
                        m_InternalObject.AddValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < long >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddValue"] = new BSFunctionReference(
                new BSFunction(
                    "function AddValue(name, value)",
                    a =>
                    {
                        m_InternalObject.AddValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < ulong >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddValue"] = new BSFunctionReference(
                new BSFunction(
                    "function AddValue(name, value)",
                    a =>
                    {
                        m_InternalObject.AddValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddValue"] = new BSFunctionReference(
                new BSFunction(
                    "function AddValue(name, value)",
                    a =>
                    {
                        m_InternalObject.AddValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < double >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddValue"] = new BSFunctionReference(
                new BSFunction(
                    "function AddValue(name, value)",
                    a =>
                    {
                        m_InternalObject.AddValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < decimal >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddValue"] = new BSFunctionReference(
                new BSFunction(
                    "function AddValue(name, value)",
                    a =>
                    {
                        m_InternalObject.AddValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < DateTime >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["GetBoolean"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBoolean(name)",
                    a => m_InternalObject.GetBoolean( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetChar"] = new BSFunctionReference(
                new BSFunction(
                    "function GetChar(name)",
                    a => new BSWrapperObject_System_Char(
                        m_InternalObject.GetChar( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetSByte"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSByte(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetSByte( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetByte"] = new BSFunctionReference(
                new BSFunction(
                    "function GetByte(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetByte( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetInt16"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt16(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInt16( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetUInt16"] = new BSFunctionReference(
                new BSFunction(
                    "function GetUInt16(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetUInt16( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetInt32"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt32(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInt32( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetUInt32"] = new BSFunctionReference(
                new BSFunction(
                    "function GetUInt32(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetUInt32( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetInt64"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt64(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInt64( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetUInt64"] = new BSFunctionReference(
                new BSFunction(
                    "function GetUInt64(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetUInt64( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetSingle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSingle(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetSingle( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetDouble"] = new BSFunctionReference(
                new BSFunction(
                    "function GetDouble(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetDouble( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetDecimal"] = new BSFunctionReference(
                new BSFunction(
                    "function GetDecimal(name)",
                    a => new BSObject( m_InternalObject.GetDecimal( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetDateTime"] = new BSFunctionReference(
                new BSFunction(
                    "function GetDateTime(name)",
                    a => new BSWrapperObject_System_DateTime(
                        m_InternalObject.GetDateTime( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetString(name)",
                    a => new BSObject( m_InternalObject.GetString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

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
