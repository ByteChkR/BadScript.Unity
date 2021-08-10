using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_IMouseEvent : BSWrapperObject < IMouseEvent >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_IMouseEvent( IMouseEvent obj ) : base( obj )
        {
            m_Properties["mousePosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.mousePosition ),
                null );

            m_Properties["localMousePosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.localMousePosition ),
                null );

            m_Properties["mouseDelta"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.mouseDelta ),
                null );

            m_Properties["clickCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.clickCount ),
                null );

            m_Properties["button"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.button ),
                null );

            m_Properties["pressedButtons"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pressedButtons ),
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
