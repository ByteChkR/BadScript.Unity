using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Hash128 : BSWrapperObject<UnityEngine.Hash128>

    {
        public BSWrapperObject_UnityEngine_Hash128(UnityEngine.Hash128 obj) : base(obj)
        {
            m_Properties["isValid"] = new BSReflectionReference(() => m_InternalObject.isValid ? BSObject.One : BSObject.Zero, null);
            m_Properties["CompareTo"] = new BSFunctionReference(new BSFunction("function CompareTo(rhs)", a => new BSObject((decimal)m_InternalObject.CompareTo(WrapperHelper.UnwrapObject<UnityEngine.Hash128>(a[0]))), 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["Append"] = new BSFunctionReference(new BSFunction("function Append(data)", a => {
                m_InternalObject.Append(WrapperHelper.UnwrapObject<System.String>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Append"] = new BSFunctionReference(new BSFunction("function Append(val)", a => {
                m_InternalObject.Append(WrapperHelper.UnwrapObject<System.Int32>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Append"] = new BSFunctionReference(new BSFunction("function Append(val)", a => {
                m_InternalObject.Append(WrapperHelper.UnwrapObject<System.Single>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<UnityEngine.Hash128>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["CompareTo"] = new BSFunctionReference(new BSFunction("function CompareTo(obj)", a => new BSObject((decimal)m_InternalObject.CompareTo(WrapperHelper.UnwrapObject<System.Object>(a[0]))), 1));

        }
    }

}