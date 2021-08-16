using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UIElements_Focusable : BSWrapperObject<UnityEngine.UIElements.Focusable>

    {
        public BSWrapperObject_UnityEngine_UIElements_Focusable(UnityEngine.UIElements.Focusable obj) : base(obj)
        {
            m_Properties["focusController"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_FocusController(m_InternalObject.focusController), null);
            m_Properties["focusable"] = new BSReflectionReference(() => m_InternalObject.focusable ? BSObject.One : BSObject.Zero, x=> m_InternalObject.focusable = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["tabIndex"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.tabIndex), x=> m_InternalObject.tabIndex = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["delegatesFocus"] = new BSReflectionReference(() => m_InternalObject.delegatesFocus ? BSObject.One : BSObject.Zero, x=> m_InternalObject.delegatesFocus = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["canGrabFocus"] = new BSReflectionReference(() => m_InternalObject.canGrabFocus ? BSObject.One : BSObject.Zero, null);
            m_Properties["Focus"] = new BSFunctionReference(new BSFunction("function Focus()", a => {
                m_InternalObject.Focus();
                return new BSObject(null);
            }, 0));
            m_Properties["Blur"] = new BSFunctionReference(new BSFunction("function Blur()", a => {
                m_InternalObject.Blur();
                return new BSObject(null);
            }, 0));
            m_Properties["SendEvent"] = new BSFunctionReference(new BSFunction("function SendEvent(e)", a => {
                m_InternalObject.SendEvent(WrapperHelper.UnwrapObject<UnityEngine.UIElements.EventBase>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["HandleEvent"] = new BSFunctionReference(new BSFunction("function HandleEvent(evt)", a => {
                m_InternalObject.HandleEvent(WrapperHelper.UnwrapObject<UnityEngine.UIElements.EventBase>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["HasTrickleDownHandlers"] = new BSFunctionReference(new BSFunction("function HasTrickleDownHandlers()", a => m_InternalObject.HasTrickleDownHandlers() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["HasBubbleUpHandlers"] = new BSFunctionReference(new BSFunction("function HasBubbleUpHandlers()", a => m_InternalObject.HasBubbleUpHandlers() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}