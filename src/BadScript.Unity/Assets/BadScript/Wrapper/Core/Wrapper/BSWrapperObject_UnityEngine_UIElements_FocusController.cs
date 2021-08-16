using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UIElements_FocusController : BSWrapperObject<UnityEngine.UIElements.FocusController>

    {
        public BSWrapperObject_UnityEngine_UIElements_FocusController(UnityEngine.UIElements.FocusController obj) : base(obj)
        {
            m_Properties["focusedElement"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_Focusable(m_InternalObject.focusedElement), null);
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}