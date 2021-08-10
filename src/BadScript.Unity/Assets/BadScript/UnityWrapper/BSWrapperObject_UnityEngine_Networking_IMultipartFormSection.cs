using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Networking_IMultipartFormSection : BSWrapperObject < IMultipartFormSection >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Networking_IMultipartFormSection( IMultipartFormSection obj ) : base( obj )
        {
            m_Properties["sectionName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.sectionName ),
                null );

            m_Properties["fileName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.fileName ),
                null );

            m_Properties["contentType"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.contentType ),
                null );

        }

        #endregion
    }

}
