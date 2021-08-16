using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_ScrollView : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_UIElements_ScrollView() : base(typeof(UnityEngine.UIElements.ScrollView))
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.ScrollView.ussClassName), null);
            m_StaticProperties["viewportUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.ScrollView.viewportUssClassName), null);
            m_StaticProperties["contentUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.ScrollView.contentUssClassName), null);
            m_StaticProperties["hScrollerUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.ScrollView.hScrollerUssClassName), null);
            m_StaticProperties["vScrollerUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.ScrollView.vScrollerUssClassName), null);
            m_StaticProperties["horizontalVariantUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.ScrollView.horizontalVariantUssClassName), null);
            m_StaticProperties["verticalVariantUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.ScrollView.verticalVariantUssClassName), null);
            m_StaticProperties["verticalHorizontalVariantUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.ScrollView.verticalHorizontalVariantUssClassName), null);
            m_StaticProperties["scrollVariantUssClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.ScrollView.scrollVariantUssClassName), null);

        }
    }

}