using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Runtime_Serialization_SerializationEntry : BSWrapperObject<System.Runtime.Serialization.SerializationEntry>

    {
        public BSWrapperObject_System_Runtime_Serialization_SerializationEntry(System.Runtime.Serialization.SerializationEntry obj) : base(obj)
        {
            m_Properties["Value"] = new BSReflectionReference(() => new BSWrapperObject_System_Object(m_InternalObject.Value), null);
            m_Properties["Name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.Name), null);
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}