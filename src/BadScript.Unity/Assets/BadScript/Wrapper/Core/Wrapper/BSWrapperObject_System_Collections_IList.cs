using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Collections_IList : BSWrapperObject < IList >

    {
        #region Public

        public BSWrapperObject_System_Collections_IList( IList obj ) : base( obj )
        {
            m_Properties["get_Item"] = new BSFunctionReference(
                new BSFunction(
                    "function get_Item(index)",
                    a => new BSWrapperObject_System_Object(
                        m_InternalObject[WrapperHelper.UnwrapObject < int >( a[0] )] ),
                    1 ) );

            m_Properties["set_Item"] = new BSFunctionReference(
                new BSFunction(
                    "function set_Item(index, value)",
                    a =>
                    {
                        m_InternalObject[WrapperHelper.UnwrapObject < int >( a[0] )] =
                            WrapperHelper.UnwrapObject < object >( a[1] );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["IsReadOnly"] = new BSReflectionReference(
                () => m_InternalObject.IsReadOnly ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsFixedSize"] = new BSReflectionReference(
                () => m_InternalObject.IsFixedSize ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["Add"] = new BSFunctionReference(
                new BSFunction(
                    "function Add(value)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.Add( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(value)",
                    a => m_InternalObject.Contains( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
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

            m_Properties["IndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IndexOf(value)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.IndexOf( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

            m_Properties["Insert"] = new BSFunctionReference(
                new BSFunction(
                    "function Insert(index, value)",
                    a =>
                    {
                        m_InternalObject.Insert(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["Remove"] = new BSFunctionReference(
                new BSFunction(
                    "function Remove(value)",
                    a =>
                    {
                        m_InternalObject.Remove( WrapperHelper.UnwrapObject < object >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["RemoveAt"] = new BSFunctionReference(
                new BSFunction(
                    "function RemoveAt(index)",
                    a =>
                    {
                        m_InternalObject.RemoveAt( WrapperHelper.UnwrapObject < int >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

        }

        #endregion
    }

}
