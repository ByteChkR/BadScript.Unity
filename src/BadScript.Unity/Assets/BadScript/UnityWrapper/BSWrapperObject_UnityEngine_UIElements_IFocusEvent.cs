using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_IFocusEvent : BSWrapperObject < IFocusEvent >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_IFocusEvent( IFocusEvent obj ) : base( obj )
        {
            m_Properties["relatedTarget"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_Focusable( m_InternalObject.relatedTarget ),
                null );

            m_Properties["direction"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_FocusChangeDirection( m_InternalObject.direction ),
                null );

        }

        #endregion
    }

}
