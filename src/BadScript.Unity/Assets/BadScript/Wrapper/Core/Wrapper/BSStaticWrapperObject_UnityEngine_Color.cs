using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Color : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Color() : base(typeof(UnityEngine.Color))
        {
            m_StaticProperties["red"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(UnityEngine.Color.red), null);
            m_StaticProperties["green"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(UnityEngine.Color.green), null);
            m_StaticProperties["blue"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(UnityEngine.Color.blue), null);
            m_StaticProperties["white"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(UnityEngine.Color.white), null);
            m_StaticProperties["black"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(UnityEngine.Color.black), null);
            m_StaticProperties["yellow"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(UnityEngine.Color.yellow), null);
            m_StaticProperties["cyan"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(UnityEngine.Color.cyan), null);
            m_StaticProperties["magenta"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(UnityEngine.Color.magenta), null);
            m_StaticProperties["gray"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(UnityEngine.Color.gray), null);
            m_StaticProperties["grey"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(UnityEngine.Color.grey), null);
            m_StaticProperties["clear"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(UnityEngine.Color.clear), null);
            m_StaticProperties["Lerp"] = new BSFunctionReference(new BSFunction("function Lerp(a, b, t)", a => new BSWrapperObject_UnityEngine_Color(UnityEngine.Color.Lerp(WrapperHelper.UnwrapObject<UnityEngine.Color>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Color>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["LerpUnclamped"] = new BSFunctionReference(new BSFunction("function LerpUnclamped(a, b, t)", a => new BSWrapperObject_UnityEngine_Color(UnityEngine.Color.LerpUnclamped(WrapperHelper.UnwrapObject<UnityEngine.Color>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Color>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["HSVToRGB"] = new BSFunctionReference(new BSFunction("function HSVToRGB(H, S, V)", a => new BSWrapperObject_UnityEngine_Color(UnityEngine.Color.HSVToRGB(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["HSVToRGB"] = new BSFunctionReference(new BSFunction("function HSVToRGB(H, S, V, hdr)", a => new BSWrapperObject_UnityEngine_Color(UnityEngine.Color.HSVToRGB(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]), WrapperHelper.UnwrapObject<System.Boolean>(a[3]))), 4));

        }
    }

}