using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Vector4 : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Vector4() : base(typeof(UnityEngine.Vector4))
        {
            m_StaticProperties["zero"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector4(UnityEngine.Vector4.zero), null);
            m_StaticProperties["one"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector4(UnityEngine.Vector4.one), null);
            m_StaticProperties["positiveInfinity"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector4(UnityEngine.Vector4.positiveInfinity), null);
            m_StaticProperties["negativeInfinity"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector4(UnityEngine.Vector4.negativeInfinity), null);
            m_StaticProperties["kEpsilon"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Vector4.kEpsilon), null);
            m_StaticProperties["Lerp"] = new BSFunctionReference(new BSFunction("function Lerp(a, b, t)", a => new BSWrapperObject_UnityEngine_Vector4(UnityEngine.Vector4.Lerp(WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["LerpUnclamped"] = new BSFunctionReference(new BSFunction("function LerpUnclamped(a, b, t)", a => new BSWrapperObject_UnityEngine_Vector4(UnityEngine.Vector4.LerpUnclamped(WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["MoveTowards"] = new BSFunctionReference(new BSFunction("function MoveTowards(current, target, maxDistanceDelta)", a => new BSWrapperObject_UnityEngine_Vector4(UnityEngine.Vector4.MoveTowards(WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["Scale"] = new BSFunctionReference(new BSFunction("function Scale(a, b)", a => new BSWrapperObject_UnityEngine_Vector4(UnityEngine.Vector4.Scale(WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[1]))), 2));
            m_StaticProperties["Normalize"] = new BSFunctionReference(new BSFunction("function Normalize(a)", a => new BSWrapperObject_UnityEngine_Vector4(UnityEngine.Vector4.Normalize(WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[0]))), 1));
            m_StaticProperties["Dot"] = new BSFunctionReference(new BSFunction("function Dot(a, b)", a => new BSObject((decimal)UnityEngine.Vector4.Dot(WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[1]))), 2));
            m_StaticProperties["Project"] = new BSFunctionReference(new BSFunction("function Project(a, b)", a => new BSWrapperObject_UnityEngine_Vector4(UnityEngine.Vector4.Project(WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[1]))), 2));
            m_StaticProperties["Distance"] = new BSFunctionReference(new BSFunction("function Distance(a, b)", a => new BSObject((decimal)UnityEngine.Vector4.Distance(WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[1]))), 2));
            m_StaticProperties["Magnitude"] = new BSFunctionReference(new BSFunction("function Magnitude(a)", a => new BSObject((decimal)UnityEngine.Vector4.Magnitude(WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[0]))), 1));
            m_StaticProperties["Min"] = new BSFunctionReference(new BSFunction("function Min(lhs, rhs)", a => new BSWrapperObject_UnityEngine_Vector4(UnityEngine.Vector4.Min(WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[1]))), 2));
            m_StaticProperties["Max"] = new BSFunctionReference(new BSFunction("function Max(lhs, rhs)", a => new BSWrapperObject_UnityEngine_Vector4(UnityEngine.Vector4.Max(WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[1]))), 2));
            m_StaticProperties["SqrMagnitude"] = new BSFunctionReference(new BSFunction("function SqrMagnitude(a)", a => new BSObject((decimal)UnityEngine.Vector4.SqrMagnitude(WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[0]))), 1));

        }
    }

}