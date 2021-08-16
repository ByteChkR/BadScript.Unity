using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UIElements_VisualElementStyleSheetSet : BSWrapperObject<UnityEngine.UIElements.VisualElementStyleSheetSet>

    {
        public BSWrapperObject_UnityEngine_UIElements_VisualElementStyleSheetSet(UnityEngine.UIElements.VisualElementStyleSheetSet obj) : base(obj)
        {
            m_Properties["count"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.count), null);
            m_Properties["Add"] = new BSFunctionReference(new BSFunction("function Add(styleSheet)", a => {
                m_InternalObject.Add(WrapperHelper.UnwrapObject<UnityEngine.UIElements.StyleSheet>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Clear"] = new BSFunctionReference(new BSFunction("function Clear()", a => {
                m_InternalObject.Clear();
                return new BSObject(null);
            }, 0));
            m_Properties["Remove"] = new BSFunctionReference(new BSFunction("function Remove(styleSheet)", a => m_InternalObject.Remove(WrapperHelper.UnwrapObject<UnityEngine.UIElements.StyleSheet>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Contains"] = new BSFunctionReference(new BSFunction("function Contains(styleSheet)", a => m_InternalObject.Contains(WrapperHelper.UnwrapObject<UnityEngine.UIElements.StyleSheet>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.UIElements.VisualElementStyleSheetSet>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}