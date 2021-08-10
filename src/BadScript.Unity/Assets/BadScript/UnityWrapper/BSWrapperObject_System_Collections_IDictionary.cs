using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
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

        }

        #endregion
    }

}
