using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_FocusChangeDirection : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_FocusChangeDirection() : base(
            typeof( FocusChangeDirection ) )
        {
            m_StaticProperties["unspecified"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_FocusChangeDirection(
                    FocusChangeDirection.unspecified ),
                null );

            m_StaticProperties["none"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_FocusChangeDirection( FocusChangeDirection.none ),
                null );

        }

        #endregion
    }

}
