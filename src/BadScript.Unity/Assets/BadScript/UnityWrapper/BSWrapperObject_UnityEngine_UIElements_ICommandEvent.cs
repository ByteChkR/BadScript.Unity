using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_ICommandEvent : BSWrapperObject < ICommandEvent >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_ICommandEvent( ICommandEvent obj ) : base( obj )
        {
            m_Properties["commandName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.commandName ),
                null );

        }

        #endregion
    }

}
