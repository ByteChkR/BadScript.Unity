using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Reflection_ParameterInfo : BSWrapperObject<System.Reflection.ParameterInfo>

    {
        public BSWrapperObject_System_Reflection_ParameterInfo(System.Reflection.ParameterInfo obj) : base(obj)
        {
            m_Properties["IsIn"] = new BSReflectionReference(() => m_InternalObject.IsIn ? BSObject.One : BSObject.Zero, null);
            m_Properties["IsLcid"] = new BSReflectionReference(() => m_InternalObject.IsLcid ? BSObject.One : BSObject.Zero, null);
            m_Properties["IsOptional"] = new BSReflectionReference(() => m_InternalObject.IsOptional ? BSObject.One : BSObject.Zero, null);
            m_Properties["IsOut"] = new BSReflectionReference(() => m_InternalObject.IsOut ? BSObject.One : BSObject.Zero, null);
            m_Properties["IsRetval"] = new BSReflectionReference(() => m_InternalObject.IsRetval ? BSObject.One : BSObject.Zero, null);
            m_Properties["Member"] = new BSReflectionReference(() => new BSWrapperObject_System_Reflection_MemberInfo(m_InternalObject.Member), null);
            m_Properties["Name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.Name), null);
            m_Properties["Position"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.Position), null);
            m_Properties["HasDefaultValue"] = new BSReflectionReference(() => m_InternalObject.HasDefaultValue ? BSObject.One : BSObject.Zero, null);
            m_Properties["DefaultValue"] = new BSReflectionReference(() => new BSWrapperObject_System_Object(m_InternalObject.DefaultValue), null);
            m_Properties["RawDefaultValue"] = new BSReflectionReference(() => new BSWrapperObject_System_Object(m_InternalObject.RawDefaultValue), null);
            m_Properties["MetadataToken"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.MetadataToken), null);
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["GetRealObject"] = new BSFunctionReference(new BSFunction("function GetRealObject(context)", a => new BSWrapperObject_System_Object(m_InternalObject.GetRealObject(WrapperHelper.UnwrapObject<System.Runtime.Serialization.StreamingContext>(a[0]))), 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));

        }
    }

}