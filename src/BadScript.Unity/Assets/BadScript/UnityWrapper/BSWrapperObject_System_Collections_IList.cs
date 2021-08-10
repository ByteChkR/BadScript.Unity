using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Collections_IList : BSWrapperObject < IList >

    {
        #region Public

        public BSWrapperObject_System_Collections_IList( IList obj ) : base( obj )
        {
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

            m_Properties["IndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IndexOf(value)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.IndexOf( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
