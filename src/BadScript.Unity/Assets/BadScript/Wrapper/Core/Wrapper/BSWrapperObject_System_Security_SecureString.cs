using System.Security;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Security_SecureString : BSWrapperObject < SecureString >

    {
        #region Public

        public BSWrapperObject_System_Security_SecureString( SecureString obj ) : base( obj )
        {
            m_Properties["Length"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Length ),
                null );

            m_Properties["AppendChar"] = new BSFunctionReference(
                new BSFunction(
                    "function AppendChar(c)",
                    a =>
                    {
                        m_InternalObject.AppendChar( WrapperHelper.UnwrapObject < char >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["Clear"] = new BSFunctionReference(
                new BSFunction(
                    "function Clear()",
                    a =>
                    {
                        m_InternalObject.Clear();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Copy"] = new BSFunctionReference(
                new BSFunction(
                    "function Copy()",
                    a => new BSWrapperObject_System_Security_SecureString( m_InternalObject.Copy() ),
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

            m_Properties["InsertAt"] = new BSFunctionReference(
                new BSFunction(
                    "function InsertAt(index, c)",
                    a =>
                    {
                        m_InternalObject.InsertAt(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < char >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["IsReadOnly"] = new BSFunctionReference(
                new BSFunction(
                    "function IsReadOnly()",
                    a => m_InternalObject.IsReadOnly() ? BSObject.One : BSObject.Zero,
                    0 ) );

            m_Properties["MakeReadOnly"] = new BSFunctionReference(
                new BSFunction(
                    "function MakeReadOnly()",
                    a =>
                    {
                        m_InternalObject.MakeReadOnly();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["RemoveAt"] = new BSFunctionReference(
                new BSFunction(
                    "function RemoveAt(index)",
                    a =>
                    {
                        m_InternalObject.RemoveAt( WrapperHelper.UnwrapObject < int >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetAt"] = new BSFunctionReference(
                new BSFunction(
                    "function SetAt(index, c)",
                    a =>
                    {
                        m_InternalObject.SetAt(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < char >( a[1] ) );

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
