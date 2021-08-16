using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Vector3 : BSWrapperObject<UnityEngine.Vector3>

    {
        public BSWrapperObject_UnityEngine_Vector3(UnityEngine.Vector3 obj) : base(obj)
        {
            m_Properties["normalized"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.normalized), null);
            m_Properties["magnitude"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.magnitude), null);
            m_Properties["sqrMagnitude"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.sqrMagnitude), null);
            m_Properties["x"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.x), x=> m_InternalObject.x = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["y"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.y), x=> m_InternalObject.y = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["z"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.z), x=> m_InternalObject.z = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["Set"] = new BSFunctionReference(new BSFunction("function Set(newX, newY, newZ)", a => {
                m_InternalObject.Set(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["Scale"] = new BSFunctionReference(new BSFunction("function Scale(scale)", a => {
                m_InternalObject.Scale(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Normalize"] = new BSFunctionReference(new BSFunction("function Normalize()", a => {
                m_InternalObject.Normalize();
                return new BSObject(null);
            }, 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format, formatProvider)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.IFormatProvider>(a[1]))), 2));

        }
    }

}