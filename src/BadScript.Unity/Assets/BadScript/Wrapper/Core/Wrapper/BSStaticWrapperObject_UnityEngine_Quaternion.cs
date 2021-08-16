using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Quaternion : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Quaternion() : base(typeof(UnityEngine.Quaternion))
        {
            m_StaticProperties["identity"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.identity), null);
            m_StaticProperties["kEpsilon"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Quaternion.kEpsilon), null);
            m_StaticProperties["FromToRotation"] = new BSFunctionReference(new BSFunction("function FromToRotation(fromDirection, toDirection)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.FromToRotation(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));
            m_StaticProperties["Inverse"] = new BSFunctionReference(new BSFunction("function Inverse(rotation)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.Inverse(WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[0]))), 1));
            m_StaticProperties["Slerp"] = new BSFunctionReference(new BSFunction("function Slerp(a, b, t)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.Slerp(WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["SlerpUnclamped"] = new BSFunctionReference(new BSFunction("function SlerpUnclamped(a, b, t)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.SlerpUnclamped(WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["Lerp"] = new BSFunctionReference(new BSFunction("function Lerp(a, b, t)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.Lerp(WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["LerpUnclamped"] = new BSFunctionReference(new BSFunction("function LerpUnclamped(a, b, t)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.LerpUnclamped(WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["AngleAxis"] = new BSFunctionReference(new BSFunction("function AngleAxis(angle, axis)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.AngleAxis(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));
            m_StaticProperties["LookRotation"] = new BSFunctionReference(new BSFunction("function LookRotation(forward, upwards)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.LookRotation(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]))), 2));
            m_StaticProperties["LookRotation"] = new BSFunctionReference(new BSFunction("function LookRotation(forward)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.LookRotation(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_StaticProperties["Dot"] = new BSFunctionReference(new BSFunction("function Dot(a, b)", a => new BSObject((decimal)UnityEngine.Quaternion.Dot(WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[1]))), 2));
            m_StaticProperties["Angle"] = new BSFunctionReference(new BSFunction("function Angle(a, b)", a => new BSObject((decimal)UnityEngine.Quaternion.Angle(WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[1]))), 2));
            m_StaticProperties["Euler"] = new BSFunctionReference(new BSFunction("function Euler(x, y, z)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.Euler(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["Euler"] = new BSFunctionReference(new BSFunction("function Euler(euler)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.Euler(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_StaticProperties["RotateTowards"] = new BSFunctionReference(new BSFunction("function RotateTowards(from, to, maxDegreesDelta)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.RotateTowards(WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["Normalize"] = new BSFunctionReference(new BSFunction("function Normalize(q)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.Normalize(WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[0]))), 1));
            m_StaticProperties["EulerRotation"] = new BSFunctionReference(new BSFunction("function EulerRotation(x, y, z)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.EulerRotation(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["EulerRotation"] = new BSFunctionReference(new BSFunction("function EulerRotation(euler)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.EulerRotation(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_StaticProperties["EulerAngles"] = new BSFunctionReference(new BSFunction("function EulerAngles(x, y, z)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.EulerAngles(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_StaticProperties["EulerAngles"] = new BSFunctionReference(new BSFunction("function EulerAngles(euler)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.EulerAngles(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_StaticProperties["ToEulerAngles"] = new BSFunctionReference(new BSFunction("function ToEulerAngles(rotation)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Quaternion.ToEulerAngles(WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[0]))), 1));
            m_StaticProperties["AxisAngle"] = new BSFunctionReference(new BSFunction("function AxisAngle(axis, angle)", a => new BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion.AxisAngle(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]))), 2));

        }
    }

}