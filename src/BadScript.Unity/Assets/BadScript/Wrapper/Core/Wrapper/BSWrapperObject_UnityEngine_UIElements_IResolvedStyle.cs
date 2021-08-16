using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UIElements_IResolvedStyle : BSWrapperObject<UnityEngine.UIElements.IResolvedStyle>

    {
        public BSWrapperObject_UnityEngine_UIElements_IResolvedStyle(UnityEngine.UIElements.IResolvedStyle obj) : base(obj)
        {
            m_Properties["backgroundColor"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.backgroundColor), null);
            m_Properties["backgroundImage"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_Background(m_InternalObject.backgroundImage), null);
            m_Properties["borderBottomColor"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.borderBottomColor), null);
            m_Properties["borderBottomLeftRadius"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.borderBottomLeftRadius), null);
            m_Properties["borderBottomRightRadius"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.borderBottomRightRadius), null);
            m_Properties["borderBottomWidth"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.borderBottomWidth), null);
            m_Properties["borderLeftColor"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.borderLeftColor), null);
            m_Properties["borderLeftWidth"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.borderLeftWidth), null);
            m_Properties["borderRightColor"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.borderRightColor), null);
            m_Properties["borderRightWidth"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.borderRightWidth), null);
            m_Properties["borderTopColor"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.borderTopColor), null);
            m_Properties["borderTopLeftRadius"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.borderTopLeftRadius), null);
            m_Properties["borderTopRightRadius"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.borderTopRightRadius), null);
            m_Properties["borderTopWidth"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.borderTopWidth), null);
            m_Properties["bottom"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.bottom), null);
            m_Properties["color"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.color), null);
            m_Properties["flexBasis"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_StyleFloat(m_InternalObject.flexBasis), null);
            m_Properties["flexGrow"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.flexGrow), null);
            m_Properties["flexShrink"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.flexShrink), null);
            m_Properties["fontSize"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.fontSize), null);
            m_Properties["height"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.height), null);
            m_Properties["left"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.left), null);
            m_Properties["marginBottom"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.marginBottom), null);
            m_Properties["marginLeft"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.marginLeft), null);
            m_Properties["marginRight"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.marginRight), null);
            m_Properties["marginTop"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.marginTop), null);
            m_Properties["maxHeight"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_StyleFloat(m_InternalObject.maxHeight), null);
            m_Properties["maxWidth"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_StyleFloat(m_InternalObject.maxWidth), null);
            m_Properties["minHeight"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_StyleFloat(m_InternalObject.minHeight), null);
            m_Properties["minWidth"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_StyleFloat(m_InternalObject.minWidth), null);
            m_Properties["opacity"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.opacity), null);
            m_Properties["paddingBottom"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.paddingBottom), null);
            m_Properties["paddingLeft"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.paddingLeft), null);
            m_Properties["paddingRight"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.paddingRight), null);
            m_Properties["paddingTop"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.paddingTop), null);
            m_Properties["right"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.right), null);
            m_Properties["top"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.top), null);
            m_Properties["unityBackgroundImageTintColor"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.unityBackgroundImageTintColor), null);
            m_Properties["unityFont"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Font(m_InternalObject.unityFont), null);
            m_Properties["unitySliceBottom"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.unitySliceBottom), null);
            m_Properties["unitySliceLeft"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.unitySliceLeft), null);
            m_Properties["unitySliceRight"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.unitySliceRight), null);
            m_Properties["unitySliceTop"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.unitySliceTop), null);
            m_Properties["width"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.width), null);

        }
    }

}