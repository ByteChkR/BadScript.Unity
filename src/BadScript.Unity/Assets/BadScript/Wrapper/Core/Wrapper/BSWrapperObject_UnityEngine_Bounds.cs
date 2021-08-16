using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Bounds : BSWrapperObject<UnityEngine.Bounds>

    {
        public BSWrapperObject_UnityEngine_Bounds(UnityEngine.Bounds obj) : base(obj)
        {
            m_Properties["center"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.center), x=> m_InternalObject.center = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["size"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.size), x=> m_InternalObject.size = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["extents"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.extents), x=> m_InternalObject.extents = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["min"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.min), x=> m_InternalObject.min = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["max"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.max), x=> m_InternalObject.max = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.Bounds>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["SetMinMax"] = new BSFunctionReference(new BSFunction("function SetMinMax(min, max)", a => {
                m_InternalObject.SetMinMax(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Encapsulate"] = new BSFunctionReference(new BSFunction("function Encapsulate(point)", a => {
                m_InternalObject.Encapsulate(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Encapsulate"] = new BSFunctionReference(new BSFunction("function Encapsulate(bounds)", a => {
                m_InternalObject.Encapsulate(WrapperHelper.UnwrapObject<UnityEngine.Bounds>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Expand"] = new BSFunctionReference(new BSFunction("function Expand(amount)", a => {
                m_InternalObject.Expand(WrapperHelper.UnwrapObject<System.Single>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Expand"] = new BSFunctionReference(new BSFunction("function Expand(amount)", a => {
                m_InternalObject.Expand(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Intersects"] = new BSFunctionReference(new BSFunction("function Intersects(bounds)", a => m_InternalObject.Intersects(WrapperHelper.UnwrapObject<UnityEngine.Bounds>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["IntersectRay"] = new BSFunctionReference(new BSFunction("function IntersectRay(ray)", a => m_InternalObject.IntersectRay(WrapperHelper.UnwrapObject<UnityEngine.Ray>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format, formatProvider)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.IFormatProvider>(a[1]))), 2));
            m_Properties["Contains"] = new BSFunctionReference(new BSFunction("function Contains(point)", a => m_InternalObject.Contains(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["SqrDistance"] = new BSFunctionReference(new BSFunction("function SqrDistance(point)", a => new BSObject((decimal)m_InternalObject.SqrDistance(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_Properties["ClosestPoint"] = new BSFunctionReference(new BSFunction("function ClosestPoint(point)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.ClosestPoint(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));

        }
    }

}