using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Vector3 : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Vector3() : base(typeof(UnityEngine.Vector3))
        {
            m_StaticProperties["zero"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.zero), null);
            m_StaticProperties["one"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.one), null);
            m_StaticProperties["forward"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.forward), null);
            m_StaticProperties["back"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.back), null);
            m_StaticProperties["up"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.up), null);
            m_StaticProperties["down"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.down), null);
            m_StaticProperties["left"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.left), null);
            m_StaticProperties["right"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.right), null);
            m_StaticProperties["positiveInfinity"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.positiveInfinity), null);
            m_StaticProperties["negativeInfinity"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.negativeInfinity), null);
            m_StaticProperties["fwd"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.fwd), null);
            m_StaticProperties["kEpsilon"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Vector3.kEpsilon), null);
            m_StaticProperties["kEpsilonNormalSqrt"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Vector3.kEpsilonNormalSqrt), null);
            m_StaticProperties["Slerp"] = new BSFunctionReference(new BSFunction("function Slerp(a, b, t)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.Slerp(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["SlerpUnclamped"] = new BSFunctionReference(new BSFunction("function SlerpUnclamped(a, b, t)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.SlerpUnclamped(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["RotateTowards"] = new BSFunctionReference(new BSFunction("function RotateTowards(current, target, maxRadiansDelta, maxMagnitudeDelta)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.RotateTowards(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]), WrapperHelper.UnwrapObject<System.Single>(a[3]))), 4));
            m_StaticProperties["Lerp"] = new BSFunctionReference(new BSFunction("function Lerp(a, b, t)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.Lerp(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["LerpUnclamped"] = new BSFunctionReference(new BSFunction("function LerpUnclamped(a, b, t)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.LerpUnclamped(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["MoveTowards"] = new BSFunctionReference(new BSFunction("function MoveTowards(current, target, maxDistanceDelta)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.MoveTowards(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["Scale"] = new BSFunctionReference(new BSFunction("function Scale(a, b)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.Scale(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));
            m_StaticProperties["Cross"] = new BSFunctionReference(new BSFunction("function Cross(lhs, rhs)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.Cross(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));
            m_StaticProperties["Reflect"] = new BSFunctionReference(new BSFunction("function Reflect(inDirection, inNormal)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.Reflect(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));
            m_StaticProperties["Normalize"] = new BSFunctionReference(new BSFunction("function Normalize(value)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.Normalize(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_StaticProperties["Dot"] = new BSFunctionReference(new BSFunction("function Dot(lhs, rhs)", a => new BSObject((decimal)UnityEngine.Vector3.Dot(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));
            m_StaticProperties["Project"] = new BSFunctionReference(new BSFunction("function Project(vector, onNormal)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.Project(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));
            m_StaticProperties["ProjectOnPlane"] = new BSFunctionReference(new BSFunction("function ProjectOnPlane(vector, planeNormal)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.ProjectOnPlane(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));
            m_StaticProperties["Angle"] = new BSFunctionReference(new BSFunction("function Angle(from, to)", a => new BSObject((decimal)UnityEngine.Vector3.Angle(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));
            m_StaticProperties["SignedAngle"] = new BSFunctionReference(new BSFunction("function SignedAngle(from, to, axis)", a => new BSObject((decimal)UnityEngine.Vector3.SignedAngle(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[2]))), 3));
            m_StaticProperties["Distance"] = new BSFunctionReference(new BSFunction("function Distance(a, b)", a => new BSObject((decimal)UnityEngine.Vector3.Distance(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));
            m_StaticProperties["ClampMagnitude"] = new BSFunctionReference(new BSFunction("function ClampMagnitude(vector, maxLength)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.ClampMagnitude(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]))), 2));
            m_StaticProperties["Magnitude"] = new BSFunctionReference(new BSFunction("function Magnitude(vector)", a => new BSObject((decimal)UnityEngine.Vector3.Magnitude(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_StaticProperties["SqrMagnitude"] = new BSFunctionReference(new BSFunction("function SqrMagnitude(vector)", a => new BSObject((decimal)UnityEngine.Vector3.SqrMagnitude(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_StaticProperties["Min"] = new BSFunctionReference(new BSFunction("function Min(lhs, rhs)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.Min(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));
            m_StaticProperties["Max"] = new BSFunctionReference(new BSFunction("function Max(lhs, rhs)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.Max(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));
            m_StaticProperties["AngleBetween"] = new BSFunctionReference(new BSFunction("function AngleBetween(from, to)", a => new BSObject((decimal)UnityEngine.Vector3.AngleBetween(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));
            m_StaticProperties["Exclude"] = new BSFunctionReference(new BSFunction("function Exclude(excludeThis, fromThat)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3.Exclude(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));

        }
    }

}