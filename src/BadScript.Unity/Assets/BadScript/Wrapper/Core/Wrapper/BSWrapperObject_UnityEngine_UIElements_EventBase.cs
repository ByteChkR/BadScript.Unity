using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UIElements_EventBase : BSWrapperObject<UnityEngine.UIElements.EventBase>

    {
        public BSWrapperObject_UnityEngine_UIElements_EventBase(UnityEngine.UIElements.EventBase obj) : base(obj)
        {
            m_Properties["eventTypeId"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.eventTypeId), null);
            m_Properties["timestamp"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.timestamp), null);
            m_Properties["bubbles"] = new BSReflectionReference(() => m_InternalObject.bubbles ? BSObject.One : BSObject.Zero, null);
            m_Properties["tricklesDown"] = new BSReflectionReference(() => m_InternalObject.tricklesDown ? BSObject.One : BSObject.Zero, null);
            m_Properties["target"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_IEventHandler(m_InternalObject.target), x=> m_InternalObject.target = WrapperHelper.UnwrapObject<UnityEngine.UIElements.IEventHandler>(x));
            m_Properties["isPropagationStopped"] = new BSReflectionReference(() => m_InternalObject.isPropagationStopped ? BSObject.One : BSObject.Zero, null);
            m_Properties["isImmediatePropagationStopped"] = new BSReflectionReference(() => m_InternalObject.isImmediatePropagationStopped ? BSObject.One : BSObject.Zero, null);
            m_Properties["isDefaultPrevented"] = new BSReflectionReference(() => m_InternalObject.isDefaultPrevented ? BSObject.One : BSObject.Zero, null);
            m_Properties["currentTarget"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_IEventHandler(m_InternalObject.currentTarget), null);
            m_Properties["dispatch"] = new BSReflectionReference(() => m_InternalObject.dispatch ? BSObject.One : BSObject.Zero, null);
            m_Properties["imguiEvent"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Event(m_InternalObject.imguiEvent), null);
            m_Properties["originalMousePosition"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.originalMousePosition), null);
            m_Properties["StopPropagation"] = new BSFunctionReference(new BSFunction("function StopPropagation()", a => {
                m_InternalObject.StopPropagation();
                return new BSObject(null);
            }, 0));
            m_Properties["StopImmediatePropagation"] = new BSFunctionReference(new BSFunction("function StopImmediatePropagation()", a => {
                m_InternalObject.StopImmediatePropagation();
                return new BSObject(null);
            }, 0));
            m_Properties["PreventDefault"] = new BSFunctionReference(new BSFunction("function PreventDefault()", a => {
                m_InternalObject.PreventDefault();
                return new BSObject(null);
            }, 0));
            m_Properties["Dispose"] = new BSFunctionReference(new BSFunction("function Dispose()", a => {
                m_InternalObject.Dispose();
                return new BSObject(null);
            }, 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}