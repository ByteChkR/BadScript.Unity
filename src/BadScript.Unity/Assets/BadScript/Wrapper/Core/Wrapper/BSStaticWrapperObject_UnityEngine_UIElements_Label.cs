using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_Label : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_UIElements_Label() : base(typeof(UnityEngine.UIElements.Label))
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(() => new BSObject(UnityEngine.UIElements.Label.ussClassName), null);

        }
    }

}