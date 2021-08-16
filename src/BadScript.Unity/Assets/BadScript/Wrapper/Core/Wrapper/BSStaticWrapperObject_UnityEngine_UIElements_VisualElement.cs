using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_VisualElement : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_UIElements_VisualElement() : base(typeof(UnityEngine.UIElements.VisualElement))
        {
            m_StaticProperties["disabledUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.VisualElement.disabledUssClassName), null);

        }
    }

}