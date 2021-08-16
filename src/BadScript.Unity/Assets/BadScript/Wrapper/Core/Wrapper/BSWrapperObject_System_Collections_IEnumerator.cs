using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Collections_IEnumerator : BSWrapperObject < IEnumerator >

    {
        #region Public

        public BSWrapperObject_System_Collections_IEnumerator( IEnumerator obj ) : base( obj )
        {
            m_Properties["Current"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.Current ),
                null );

            m_Properties["MoveNext"] = new BSFunctionReference(
                new BSFunction(
                    "function MoveNext()",
                    a => m_InternalObject.MoveNext() ? BSObject.One : BSObject.Zero,
                    0 ) );

            m_Properties["Reset"] = new BSFunctionReference(
                new BSFunction(
                    "function Reset()",
                    a =>
                    {
                        m_InternalObject.Reset();

                        return new BSObject( null );
                    },
                    0 ) );

        }

        #endregion
    }

}
