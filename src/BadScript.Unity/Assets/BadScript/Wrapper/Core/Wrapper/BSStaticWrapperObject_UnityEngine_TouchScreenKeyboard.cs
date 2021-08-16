using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_TouchScreenKeyboard : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_TouchScreenKeyboard() : base(typeof(UnityEngine.TouchScreenKeyboard))
        {
            m_StaticProperties["isSupported"] = new BSReflectionReference(() => UnityEngine.TouchScreenKeyboard.isSupported ? BSObject.One : BSObject.Zero, null);
            m_StaticProperties["isInPlaceEditingAllowed"] = new BSReflectionReference(() => UnityEngine.TouchScreenKeyboard.isInPlaceEditingAllowed ? BSObject.One : BSObject.Zero, null);
            m_StaticProperties["hideInput"] = new BSReflectionReference(() => UnityEngine.TouchScreenKeyboard.hideInput ? BSObject.One : BSObject.Zero, x=> UnityEngine.TouchScreenKeyboard.hideInput = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["area"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Rect(UnityEngine.TouchScreenKeyboard.area), null);
            m_StaticProperties["visible"] = new BSReflectionReference(() => UnityEngine.TouchScreenKeyboard.visible ? BSObject.One : BSObject.Zero, null);
            m_StaticProperties["Open"] = new BSFunctionReference(new BSFunction("function Open(text)", a => new BSWrapperObject_UnityEngine_TouchScreenKeyboard(UnityEngine.TouchScreenKeyboard.Open(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));

        }
    }

}