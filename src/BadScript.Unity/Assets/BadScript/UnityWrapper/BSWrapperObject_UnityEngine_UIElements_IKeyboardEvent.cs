using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_IKeyboardEvent : BSWrapperObject < IKeyboardEvent >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_IKeyboardEvent( IKeyboardEvent obj ) : base( obj )
        {
            m_Properties["character"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Char( m_InternalObject.character ),
                null );

            m_Properties["shiftKey"] = new BSReflectionReference(
                () => m_InternalObject.shiftKey ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["ctrlKey"] = new BSReflectionReference(
                () => m_InternalObject.ctrlKey ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["commandKey"] = new BSReflectionReference(
                () => m_InternalObject.commandKey ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["altKey"] = new BSReflectionReference(
                () => m_InternalObject.altKey ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["actionKey"] = new BSReflectionReference(
                () => m_InternalObject.actionKey ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}
