using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_Focusable : BSWrapperObject < Focusable >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_Focusable( Focusable obj ) : base( obj )
        {
            m_Properties["focusController"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_FocusController( m_InternalObject.focusController ),
                null );

            m_Properties["focusable"] = new BSReflectionReference(
                () => m_InternalObject.focusable ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.focusable = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["tabIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.tabIndex ),
                x => m_InternalObject.tabIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["delegatesFocus"] = new BSReflectionReference(
                () => m_InternalObject.delegatesFocus ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.delegatesFocus = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["canGrabFocus"] = new BSReflectionReference(
                () => m_InternalObject.canGrabFocus ? BSObject.One : BSObject.Zero,
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
