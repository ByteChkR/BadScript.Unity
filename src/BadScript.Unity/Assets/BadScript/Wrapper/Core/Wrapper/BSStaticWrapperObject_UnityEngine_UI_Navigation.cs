using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UI_Navigation : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_UI_Navigation() : base(typeof(UnityEngine.UI.Navigation))
        {
            m_StaticProperties["defaultNavigation"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UI_Navigation(UnityEngine.UI.Navigation.defaultNavigation), null);

        }
    }

}