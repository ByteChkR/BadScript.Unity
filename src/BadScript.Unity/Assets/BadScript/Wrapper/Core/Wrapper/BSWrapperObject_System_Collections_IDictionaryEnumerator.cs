using System.Collections;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Collections_IDictionaryEnumerator : BSWrapperObject < IDictionaryEnumerator >

    {
        #region Public

        public BSWrapperObject_System_Collections_IDictionaryEnumerator( IDictionaryEnumerator obj ) : base( obj )
        {
            m_Properties["Key"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.Key ),
                null );

            m_Properties["Value"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.Value ),
                null );

            m_Properties["Entry"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Collections_DictionaryEntry( m_InternalObject.Entry ),
                null );

        }

        #endregion
    }

}
