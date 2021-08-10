using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_FocusController : BSWrapperObject < FocusController >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_FocusController( FocusController obj ) : base( obj )
        {
            m_Properties["focusedElement"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_Focusable( m_InternalObject.focusedElement ),
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
