using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UIElements_StyleCursor : BSWrapperObject<UnityEngine.UIElements.StyleCursor>

    {
        public BSWrapperObject_UnityEngine_UIElements_StyleCursor(UnityEngine.UIElements.StyleCursor obj) : base(obj)
        {
            m_Properties["value"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_Cursor(m_InternalObject.value), x=> m_InternalObject.value = WrapperHelper.UnwrapObject<UnityEngine.UIElements.Cursor>(x));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.UIElements.StyleCursor>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}