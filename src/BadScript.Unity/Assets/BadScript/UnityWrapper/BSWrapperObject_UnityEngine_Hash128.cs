using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Hash128 : BSWrapperObject < Hash128 >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Hash128( Hash128 obj ) : base( obj )
        {
            m_Properties["isValid"] = new BSReflectionReference(
                () => m_InternalObject.isValid ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["CompareTo"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTo(rhs)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.CompareTo( WrapperHelper.UnwrapObject < Hash128 >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < Hash128 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["CompareTo"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTo(obj)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.CompareTo( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
