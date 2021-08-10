using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_PopupWindow : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_PopupWindow() : base( typeof( PopupWindow ) )
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(
                () => new BSObject( PopupWindow.ussClassName ),
                null );

            m_StaticProperties["contentUssClassName"] = new BSReflectionReference(
                () => new BSObject( PopupWindow.contentUssClassName ),
                null );

        }

        #endregion
    }

}
