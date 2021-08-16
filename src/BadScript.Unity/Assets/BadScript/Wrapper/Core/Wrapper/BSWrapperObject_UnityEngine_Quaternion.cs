using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Quaternion : BSWrapperObject<UnityEngine.Quaternion>

    {
        public BSWrapperObject_UnityEngine_Quaternion(UnityEngine.Quaternion obj) : base(obj)
        {
            m_Properties["eulerAngles"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.eulerAngles), x=> m_InternalObject.eulerAngles = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["normalized"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Quaternion(m_InternalObject.normalized), null);
            m_Properties["x"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.x), x=> m_InternalObject.x = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["y"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.y), x=> m_InternalObject.y = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["z"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.z), x=> m_InternalObject.z = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["w"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.w), x=> m_InternalObject.w = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["Set"] = new BSFunctionReference(new BSFunction("function Set(newX, newY, newZ, newW)", a => {
                m_InternalObject.Set(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]), WrapperHelper.UnwrapObject<System.Single>(a[3]));
                return new BSObject(null);
            }, 4));
            m_Properties["SetLookRotation"] = new BSFunctionReference(new BSFunction("function SetLookRotation(view)", a => {
                m_InternalObject.SetLookRotation(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["SetLookRotation"] = new BSFunctionReference(new BSFunction("function SetLookRotation(view, up)", a => {
                m_InternalObject.SetLookRotation(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetFromToRotation"] = new BSFunctionReference(new BSFunction("function SetFromToRotation(fromDirection, toDirection)", a => {
                m_InternalObject.SetFromToRotation(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Normalize"] = new BSFunctionReference(new BSFunction("function Normalize()", a => {
                m_InternalObject.Normalize();
                return new BSObject(null);
            }, 0));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format, formatProvider)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.IFormatProvider>(a[1]))), 2));
            m_Properties["SetEulerRotation"] = new BSFunctionReference(new BSFunction("function SetEulerRotation(x, y, z)", a => {
                m_InternalObject.SetEulerRotation(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["SetEulerRotation"] = new BSFunctionReference(new BSFunction("function SetEulerRotation(euler)", a => {
                m_InternalObject.SetEulerRotation(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["ToEuler"] = new BSFunctionReference(new BSFunction("function ToEuler()", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.ToEuler()), 0));
            m_Properties["SetEulerAngles"] = new BSFunctionReference(new BSFunction("function SetEulerAngles(x, y, z)", a => {
                m_InternalObject.SetEulerAngles(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["SetEulerAngles"] = new BSFunctionReference(new BSFunction("function SetEulerAngles(euler)", a => {
                m_InternalObject.SetEulerAngles(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["ToEulerAngles"] = new BSFunctionReference(new BSFunction("function ToEulerAngles()", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.ToEulerAngles()), 0));
            m_Properties["SetAxisAngle"] = new BSFunctionReference(new BSFunction("function SetAxisAngle(axis, angle)", a => {
                m_InternalObject.SetAxisAngle(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]));
                return new BSObject(null);
            }, 2));

        }
    }

}