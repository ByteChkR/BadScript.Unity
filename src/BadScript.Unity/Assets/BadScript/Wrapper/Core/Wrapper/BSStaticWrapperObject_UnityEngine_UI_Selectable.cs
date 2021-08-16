using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UI_Selectable : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_UI_Selectable() : base(typeof(UnityEngine.UI.Selectable))
        {
            m_StaticProperties["allSelectableCount"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.UI.Selectable.allSelectableCount), null);

        }
    }

}