using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_FocusOutEvent : BSWrapperObject < FocusOutEvent >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_FocusOutEvent( FocusOutEvent obj ) : base( obj )
        {
            m_Properties["relatedTarget"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_Focusable( m_InternalObject.relatedTarget ),
                null );

            m_Properties["direction"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_FocusChangeDirection( m_InternalObject.direction ),
                null );

            m_Properties["eventTypeId"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.eventTypeId ),
                null );

            m_Properties["timestamp"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.timestamp ),
                null );

            m_Properties["bubbles"] = new BSReflectionReference(
                () => m_InternalObject.bubbles ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["tricklesDown"] = new BSReflectionReference(
                () => m_InternalObject.tricklesDown ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["target"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_IEventHandler( m_InternalObject.target ),
                x => m_InternalObject.target = WrapperHelper.UnwrapObject < IEventHandler >( x ) );

            m_Properties["isPropagationStopped"] = new BSReflectionReference(
                () => m_InternalObject.isPropagationStopped ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isImmediatePropagationStopped"] = new BSReflectionReference(
                () => m_InternalObject.isImmediatePropagationStopped ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isDefaultPrevented"] = new BSReflectionReference(
                () => m_InternalObject.isDefaultPrevented ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["currentTarget"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_IEventHandler( m_InternalObject.currentTarget ),
                null );

            m_Properties["dispatch"] = new BSReflectionReference(
                () => m_InternalObject.dispatch ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["imguiEvent"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Event( m_InternalObject.imguiEvent ),
                null );

            m_Properties["originalMousePosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.originalMousePosition ),
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
