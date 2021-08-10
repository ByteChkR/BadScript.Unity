using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_IPanel : BSWrapperObject < IPanel >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_IPanel( IPanel obj ) : base( obj )
        {
            m_Properties["visualTree"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_VisualElement( m_InternalObject.visualTree ),
                null );

            m_Properties["dispatcher"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_EventDispatcher( m_InternalObject.dispatcher ),
                null );

            m_Properties["focusController"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_FocusController( m_InternalObject.focusController ),
                null );

            m_Properties["contextualMenuManager"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_ContextualMenuManager(
                    m_InternalObject.contextualMenuManager ),
                null );

            m_Properties["Pick"] = new BSFunctionReference(
                new BSFunction(
                    "function Pick(point)",
                    a => new BSWrapperObject_UnityEngine_UIElements_VisualElement(
                        m_InternalObject.Pick( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
