using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Reflection_MethodBody : BSWrapperObject<System.Reflection.MethodBody>

    {
        public BSWrapperObject_System_Reflection_MethodBody(System.Reflection.MethodBody obj) : base(obj)
        {
            m_Properties["InitLocals"] = new BSReflectionReference(() => m_InternalObject.InitLocals ? BSObject.One : BSObject.Zero, null);
            m_Properties["LocalSignatureMetadataToken"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.LocalSignatureMetadataToken), null);
            m_Properties["MaxStackSize"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.MaxStackSize), null);
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}