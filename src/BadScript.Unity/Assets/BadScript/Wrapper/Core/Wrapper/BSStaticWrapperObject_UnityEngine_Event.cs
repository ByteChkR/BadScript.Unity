using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Event : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Event() : base(typeof(UnityEngine.Event))
        {
            m_StaticProperties["current"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Event(UnityEngine.Event.current), x=> UnityEngine.Event.current = WrapperHelper.UnwrapObject<UnityEngine.Event>(x));
            m_StaticProperties["PopEvent"] = new BSFunctionReference(new BSFunction("function PopEvent(outEvent)", a => UnityEngine.Event.PopEvent(WrapperHelper.UnwrapObject<UnityEngine.Event>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["GetEventCount"] = new BSFunctionReference(new BSFunction("function GetEventCount()", a => new BSObject((decimal)UnityEngine.Event.GetEventCount()), 0));
            m_StaticProperties["KeyboardEvent"] = new BSFunctionReference(new BSFunction("function KeyboardEvent(key)", a => new BSWrapperObject_UnityEngine_Event(UnityEngine.Event.KeyboardEvent(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));

        }
    }

}