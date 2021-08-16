using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_Scroller : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_UIElements_Scroller() : base(typeof(UnityEngine.UIElements.Scroller))
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.Scroller.ussClassName), null);
            m_StaticProperties["horizontalVariantUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.Scroller.horizontalVariantUssClassName), null);
            m_StaticProperties["verticalVariantUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.Scroller.verticalVariantUssClassName), null);
            m_StaticProperties["sliderUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.Scroller.sliderUssClassName), null);
            m_StaticProperties["lowButtonUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.Scroller.lowButtonUssClassName), null);
            m_StaticProperties["highButtonUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.Scroller.highButtonUssClassName), null);

        }
    }

}