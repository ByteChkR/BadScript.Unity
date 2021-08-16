using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_RepeatButton : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_UIElements_RepeatButton() : base(typeof(UnityEngine.UIElements.RepeatButton))
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.RepeatButton.ussClassName), null);

        }
    }

}