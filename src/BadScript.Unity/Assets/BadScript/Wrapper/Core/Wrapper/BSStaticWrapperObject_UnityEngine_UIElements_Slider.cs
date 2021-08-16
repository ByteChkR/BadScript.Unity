using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_Slider : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_UIElements_Slider() : base(typeof(UnityEngine.UIElements.Slider))
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.Slider.ussClassName), null);
            m_StaticProperties["labelUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.Slider.labelUssClassName), null);
            m_StaticProperties["inputUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.Slider.inputUssClassName), null);

        }
    }

}