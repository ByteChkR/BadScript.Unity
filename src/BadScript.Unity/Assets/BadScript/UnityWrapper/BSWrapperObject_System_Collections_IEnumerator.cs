using System.Collections;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Collections_IEnumerator : BSWrapperObject < IEnumerator >

    {
        #region Public

        public BSWrapperObject_System_Collections_IEnumerator( IEnumerator obj ) : base( obj )
        {
            m_Properties["Current"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.Current ),
                null );

        }

        #endregion
    }

}
