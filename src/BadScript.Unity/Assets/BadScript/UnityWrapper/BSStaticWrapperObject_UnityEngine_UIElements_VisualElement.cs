using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_VisualElement : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_VisualElement() : base( typeof( VisualElement ) )
        {
            m_StaticProperties["disabledUssClassName"] = new BSReflectionReference(
                () => new BSObject( VisualElement.disabledUssClassName ),
                null );

        }

        #endregion
    }

}
