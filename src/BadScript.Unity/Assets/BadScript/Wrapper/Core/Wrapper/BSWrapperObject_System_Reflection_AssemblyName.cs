using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Reflection_AssemblyName : BSWrapperObject<System.Reflection.AssemblyName>

    {
        public BSWrapperObject_System_Reflection_AssemblyName(System.Reflection.AssemblyName obj) : base(obj)
        {
            m_Properties["Name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.Name), x=> m_InternalObject.Name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["CodeBase"] = new BSReflectionReference(() => new BSObject(m_InternalObject.CodeBase), x=> m_InternalObject.CodeBase = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["EscapedCodeBase"] = new BSReflectionReference(() => new BSObject(m_InternalObject.EscapedCodeBase), null);
            m_Properties["CultureInfo"] = new BSReflectionReference(() => new BSWrapperObject_System_Globalization_CultureInfo(m_InternalObject.CultureInfo), x=> m_InternalObject.CultureInfo = WrapperHelper.UnwrapObject<System.Globalization.CultureInfo>(x));
            m_Properties["FullName"] = new BSReflectionReference(() => new BSObject(m_InternalObject.FullName), null);
            m_Properties["KeyPair"] = new BSReflectionReference(() => new BSWrapperObject_System_Reflection_StrongNameKeyPair(m_InternalObject.KeyPair), x=> m_InternalObject.KeyPair = WrapperHelper.UnwrapObject<System.Reflection.StrongNameKeyPair>(x));
            m_Properties["Version"] = new BSReflectionReference(() => new BSWrapperObject_System_Version(m_InternalObject.Version), x=> m_InternalObject.Version = WrapperHelper.UnwrapObject<System.Version>(x));
            m_Properties["CultureName"] = new BSReflectionReference(() => new BSObject(m_InternalObject.CultureName), x=> m_InternalObject.CultureName = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["GetObjectData"] = new BSFunctionReference(new BSFunction("function GetObjectData(info, context)", a => {
                m_InternalObject.GetObjectData(WrapperHelper.UnwrapObject<System.Runtime.Serialization.SerializationInfo>(a[0]), WrapperHelper.UnwrapObject<System.Runtime.Serialization.StreamingContext>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Clone"] = new BSFunctionReference(new BSFunction("function Clone()", a => new BSWrapperObject_System_Object(m_InternalObject.Clone()), 0));
            m_Properties["OnDeserialization"] = new BSFunctionReference(new BSFunction("function OnDeserialization(sender)", a => {
                m_InternalObject.OnDeserialization(WrapperHelper.UnwrapObject<System.Object>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));

        }
    }

}