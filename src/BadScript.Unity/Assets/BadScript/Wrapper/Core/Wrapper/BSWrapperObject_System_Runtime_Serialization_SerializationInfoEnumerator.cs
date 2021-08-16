using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Runtime_Serialization_SerializationInfoEnumerator : BSWrapperObject<System.Runtime.Serialization.SerializationInfoEnumerator>

    {
        public BSWrapperObject_System_Runtime_Serialization_SerializationInfoEnumerator(System.Runtime.Serialization.SerializationInfoEnumerator obj) : base(obj)
        {
            m_Properties["Current"] = new BSReflectionReference(() => new BSWrapperObject_System_Runtime_Serialization_SerializationEntry(m_InternalObject.Current), null);
            m_Properties["Name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.Name), null);
            m_Properties["Value"] = new BSReflectionReference(() => new BSWrapperObject_System_Object(m_InternalObject.Value), null);
            m_Properties["MoveNext"] = new BSFunctionReference(new BSFunction("function MoveNext()", a => m_InternalObject.MoveNext() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["Reset"] = new BSFunctionReference(new BSFunction("function Reset()", a => {
                m_InternalObject.Reset();
                return new BSObject(null);
            }, 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}