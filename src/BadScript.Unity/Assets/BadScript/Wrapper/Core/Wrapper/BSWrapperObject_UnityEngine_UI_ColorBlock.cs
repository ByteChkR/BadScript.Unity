using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UI_ColorBlock : BSWrapperObject<UnityEngine.UI.ColorBlock>

    {
        public BSWrapperObject_UnityEngine_UI_ColorBlock(UnityEngine.UI.ColorBlock obj) : base(obj)
        {
            m_Properties["normalColor"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.normalColor), x=> m_InternalObject.normalColor = WrapperHelper.UnwrapObject<UnityEngine.Color>(x));
            m_Properties["highlightedColor"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.highlightedColor), x=> m_InternalObject.highlightedColor = WrapperHelper.UnwrapObject<UnityEngine.Color>(x));
            m_Properties["pressedColor"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.pressedColor), x=> m_InternalObject.pressedColor = WrapperHelper.UnwrapObject<UnityEngine.Color>(x));
            m_Properties["selectedColor"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.selectedColor), x=> m_InternalObject.selectedColor = WrapperHelper.UnwrapObject<UnityEngine.Color>(x));
            m_Properties["disabledColor"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.disabledColor), x=> m_InternalObject.disabledColor = WrapperHelper.UnwrapObject<UnityEngine.Color>(x));
            m_Properties["colorMultiplier"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.colorMultiplier), x=> m_InternalObject.colorMultiplier = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["fadeDuration"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.fadeDuration), x=> m_InternalObject.fadeDuration = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.UI.ColorBlock>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}