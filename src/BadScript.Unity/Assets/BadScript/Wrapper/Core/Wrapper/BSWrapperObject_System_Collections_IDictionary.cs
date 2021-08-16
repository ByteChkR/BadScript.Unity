using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Collections_IDictionary : BSWrapperObject < IDictionary >

    {
        #region Public

        public BSWrapperObject_System_Collections_IDictionary( IDictionary obj ) : base( obj )
        {
            m_Properties["Keys"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Collections_ICollection( m_InternalObject.Keys ),
                null );

            m_Properties["Values"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Collections_ICollection( m_InternalObject.Values ),
                null );

            m_Properties["IsReadOnly"] = new BSReflectionReference(
                () => m_InternalObject.IsReadOnly ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsFixedSize"] = new BSReflectionReference(
                () => m_InternalObject.IsFixedSize ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(key)",
                    a => m_InternalObject.Contains( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Add"] = new BSFunctionReference(
                new BSFunction(
                    "function Add(key, value)",
                    a =>
                    {
                        m_InternalObject.Add(
                            WrapperHelper.UnwrapObject < object >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["Clear"] = new BSFunctionReference(
                new BSFunction(
                    "function Clear()",
                    a =>
                    {
                        m_InternalObject.Clear();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["GetEnumerator"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEnumerator()",
                    a => new BSWrapperObject_System_Collections_IDictionaryEnumerator(
                        m_InternalObject.GetEnumerator() ),
                    0 ) );

            m_Properties["Remove"] = new BSFunctionReference(
                new BSFunction(
                    "function Remove(key)",
                    a =>
                    {
                        m_InternalObject.Remove( WrapperHelper.UnwrapObject < object >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

        }

        #endregion
    }

}
