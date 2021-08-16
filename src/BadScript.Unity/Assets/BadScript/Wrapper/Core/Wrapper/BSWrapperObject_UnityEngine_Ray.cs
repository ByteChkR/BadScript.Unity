using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Ray : BSWrapperObject<UnityEngine.Ray>

    {
        public BSWrapperObject_UnityEngine_Ray(UnityEngine.Ray obj) : base(obj)
        {
            m_Properties["origin"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.origin), x=> m_InternalObject.origin = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["direction"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.direction), x=> m_InternalObject.direction = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["GetPoint"] = new BSFunctionReference(new BSFunction("function GetPoint(distance)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.GetPoint(WrapperHelper.UnwrapObject<System.Single>(a[0]))), 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format, formatProvider)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.IFormatProvider>(a[1]))), 2));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));

        }
    }

}