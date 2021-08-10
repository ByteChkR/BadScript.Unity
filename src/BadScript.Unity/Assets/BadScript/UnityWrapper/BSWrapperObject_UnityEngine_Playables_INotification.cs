using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Playables_INotification : BSWrapperObject < INotification >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Playables_INotification( INotification obj ) : base( obj )
        {
            m_Properties["id"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_PropertyName( m_InternalObject.id ),
                null );

        }

        #endregion
    }

}
