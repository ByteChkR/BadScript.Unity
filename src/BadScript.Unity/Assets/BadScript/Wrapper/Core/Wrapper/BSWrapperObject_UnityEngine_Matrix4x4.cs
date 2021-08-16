using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Matrix4x4 : BSWrapperObject<UnityEngine.Matrix4x4>

    {
        public BSWrapperObject_UnityEngine_Matrix4x4(UnityEngine.Matrix4x4 obj) : base(obj)
        {
            m_Properties["rotation"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Quaternion(m_InternalObject.rotation), null);
            m_Properties["lossyScale"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.lossyScale), null);
            m_Properties["isIdentity"] = new BSReflectionReference(() => m_InternalObject.isIdentity ? BSObject.One : BSObject.Zero, null);
            m_Properties["determinant"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.determinant), null);
            m_Properties["decomposeProjection"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_FrustumPlanes(m_InternalObject.decomposeProjection), null);
            m_Properties["inverse"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Matrix4x4(m_InternalObject.inverse), null);
            m_Properties["transpose"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Matrix4x4(m_InternalObject.transpose), null);
            m_Properties["m00"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m00), x=> m_InternalObject.m00 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["m10"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m10), x=> m_InternalObject.m10 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["m20"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m20), x=> m_InternalObject.m20 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["m30"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m30), x=> m_InternalObject.m30 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["m01"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m01), x=> m_InternalObject.m01 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["m11"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m11), x=> m_InternalObject.m11 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["m21"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m21), x=> m_InternalObject.m21 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["m31"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m31), x=> m_InternalObject.m31 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["m02"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m02), x=> m_InternalObject.m02 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["m12"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m12), x=> m_InternalObject.m12 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["m22"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m22), x=> m_InternalObject.m22 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["m32"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m32), x=> m_InternalObject.m32 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["m03"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m03), x=> m_InternalObject.m03 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["m13"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m13), x=> m_InternalObject.m13 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["m23"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m23), x=> m_InternalObject.m23 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["m33"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.m33), x=> m_InternalObject.m33 = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["ValidTRS"] = new BSFunctionReference(new BSFunction("function ValidTRS()", a => m_InternalObject.ValidTRS() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["SetTRS"] = new BSFunctionReference(new BSFunction("function SetTRS(pos, q, s)", a => {
                m_InternalObject.SetTRS(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.Matrix4x4>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetColumn"] = new BSFunctionReference(new BSFunction("function GetColumn(index)", a => new BSWrapperObject_UnityEngine_Vector4(m_InternalObject.GetColumn(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetRow"] = new BSFunctionReference(new BSFunction("function GetRow(index)", a => new BSWrapperObject_UnityEngine_Vector4(m_InternalObject.GetRow(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["SetColumn"] = new BSFunctionReference(new BSFunction("function SetColumn(index, column)", a => {
                m_InternalObject.SetColumn(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetRow"] = new BSFunctionReference(new BSFunction("function SetRow(index, row)", a => {
                m_InternalObject.SetRow(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["MultiplyPoint"] = new BSFunctionReference(new BSFunction("function MultiplyPoint(point)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.MultiplyPoint(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_Properties["MultiplyPoint3x4"] = new BSFunctionReference(new BSFunction("function MultiplyPoint3x4(point)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.MultiplyPoint3x4(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_Properties["MultiplyVector"] = new BSFunctionReference(new BSFunction("function MultiplyVector(vector)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.MultiplyVector(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_Properties["TransformPlane"] = new BSFunctionReference(new BSFunction("function TransformPlane(plane)", a => new BSWrapperObject_UnityEngine_Plane(m_InternalObject.TransformPlane(WrapperHelper.UnwrapObject<UnityEngine.Plane>(a[0]))), 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format, formatProvider)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.IFormatProvider>(a[1]))), 2));

        }
    }

}