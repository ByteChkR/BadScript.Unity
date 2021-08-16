using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Vector2Int : BSWrapperObject<UnityEngine.Vector2Int>

    {
        public BSWrapperObject_UnityEngine_Vector2Int(UnityEngine.Vector2Int obj) : base(obj)
        {
            m_Properties["x"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.x), x=> m_InternalObject.x = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["y"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.y), x=> m_InternalObject.y = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["magnitude"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.magnitude), null);
            m_Properties["sqrMagnitude"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.sqrMagnitude), null);
            m_Properties["Set"] = new BSFunctionReference(new BSFunction("function Set(x, y)", a => {
                m_InternalObject.Set(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Scale"] = new BSFunctionReference(new BSFunction("function Scale(scale)", a => {
                m_InternalObject.Scale(WrapperHelper.UnwrapObject<UnityEngine.Vector2Int>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Clamp"] = new BSFunctionReference(new BSFunction("function Clamp(min, max)", a => {
                m_InternalObject.Clamp(WrapperHelper.UnwrapObject<UnityEngine.Vector2Int>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector2Int>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.Vector2Int>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(format, formatProvider)", a => new BSObject(m_InternalObject.ToString(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.IFormatProvider>(a[1]))), 2));

        }
    }

}