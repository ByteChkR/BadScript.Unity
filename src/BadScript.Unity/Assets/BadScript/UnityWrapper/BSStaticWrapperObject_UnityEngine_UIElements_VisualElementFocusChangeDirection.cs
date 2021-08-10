using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_VisualElementFocusChangeDirection : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_VisualElementFocusChangeDirection() : base(
            typeof( VisualElementFocusChangeDirection ) )
        {
            m_StaticProperties["left"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_FocusChangeDirection(
                    VisualElementFocusChangeDirection.left ),
                null );

            m_StaticProperties["right"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_FocusChangeDirection(
                    VisualElementFocusChangeDirection.right ),
                null );

        }

        #endregion
    }

}
