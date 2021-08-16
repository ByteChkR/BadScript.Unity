using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UIElements_IEventHandler : BSWrapperObject<UnityEngine.UIElements.IEventHandler>

    {
        public BSWrapperObject_UnityEngine_UIElements_IEventHandler(UnityEngine.UIElements.IEventHandler obj) : base(obj)
        {
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

        }
    }

}