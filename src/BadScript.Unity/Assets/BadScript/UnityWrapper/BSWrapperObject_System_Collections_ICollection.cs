using System.Collections;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Collections_ICollection : BSWrapperObject < ICollection >

    {
        #region Public

        public BSWrapperObject_System_Collections_ICollection( ICollection obj ) : base( obj )
        {
            m_Properties["Count"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Count ),
                null );

            m_Properties["SyncRoot"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.SyncRoot ),
                null );

            m_Properties["IsSynchronized"] = new BSReflectionReference(
                () => m_InternalObject.IsSynchronized ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}
