using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Plane : BSWrapperObject<UnityEngine.Plane>

    {
        public BSWrapperObject_UnityEngine_Plane(UnityEngine.Plane obj) : base(obj)
        {
            m_Properties["normal"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.normal), x=> m_InternalObject.normal = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["distance"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.distance), x=> m_InternalObject.distance = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["flipped"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Plane(m_InternalObject.flipped), null);
            m_Properties["SetNormalAndPosition"] = new BSFunctionReference(new BSFunction("function SetNormalAndPosition(inNormal, inPoint)", a => {
                m_InternalObject.SetNormalAndPosition(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Set3Points"] = new BSFunctionReference(new BSFunction("function Set3Points(a, b, c)", a => {
                m_InternalObject.Set3Points(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["Flip"] = new BSFunctionReference(new BSFunction("function Flip()", a => {
                m_InternalObject.Flip();
                return new BSObject(null);
            }, 0));
            m_Properties["Translate"] = new BSFunctionReference(new BSFunction("function Translate(translation)", a => {
                m_InternalObject.Translate(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["ClosestPointOnPlane"] = new BSFunctionReference(new BSFunction("function ClosestPointOnPlane(point)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.ClosestPointOnPlane(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_Properties["GetDistanceToPoint"] = new BSFunctionReference(new BSFunction("function GetDistanceToPoint(point)", a => new BSObject((decimal)m_InternalObject.GetDistanceToPoint(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_Properties["GetSide"] = new BSFunctionReference(new BSFunction("function GetSide(point)", a => m_InternalObject.GetSide(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["SameSide"] = new BSFunctionReference(new BSFunction("function SameSide(inPt0, inPt1)", a => m_InternalObject.SameSide(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format, formatProvider)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.IFormatProvider>(a[1]))), 2));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));

        }
    }

}