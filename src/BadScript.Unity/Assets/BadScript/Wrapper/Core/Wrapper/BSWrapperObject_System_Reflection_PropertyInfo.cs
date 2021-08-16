using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Reflection_PropertyInfo : BSWrapperObject<System.Reflection.PropertyInfo>

    {
        public BSWrapperObject_System_Reflection_PropertyInfo(System.Reflection.PropertyInfo obj) : base(obj)
        {
            m_Properties["CanRead"] = new BSReflectionReference(() => m_InternalObject.CanRead ? BSObject.One : BSObject.Zero, null);
            m_Properties["CanWrite"] = new BSReflectionReference(() => m_InternalObject.CanWrite ? BSObject.One : BSObject.Zero, null);
            m_Properties["GetMethod"] = new BSReflectionReference(() => new BSWrapperObject_System_Reflection_MethodInfo(m_InternalObject.GetMethod), null);
            m_Properties["SetMethod"] = new BSReflectionReference(() => new BSWrapperObject_System_Reflection_MethodInfo(m_InternalObject.SetMethod), null);
            m_Properties["IsSpecialName"] = new BSReflectionReference(() => m_InternalObject.IsSpecialName ? BSObject.One : BSObject.Zero, null);
            m_Properties["Name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.Name), null);
            m_Properties["MetadataToken"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.MetadataToken), null);
            m_Properties["Module"] = new BSReflectionReference(() => new BSWrapperObject_System_Reflection_Module(m_InternalObject.Module), null);
            m_Properties["GetGetMethod"] = new BSFunctionReference(new BSFunction("function GetGetMethod()", a => new BSWrapperObject_System_Reflection_MethodInfo(m_InternalObject.GetGetMethod()), 0));
            m_Properties["GetGetMethod"] = new BSFunctionReference(new BSFunction("function GetGetMethod(nonPublic)", a => new BSWrapperObject_System_Reflection_MethodInfo(m_InternalObject.GetGetMethod(WrapperHelper.UnwrapObject<System.Boolean>(a[0]))), 1));
            m_Properties["GetSetMethod"] = new BSFunctionReference(new BSFunction("function GetSetMethod()", a => new BSWrapperObject_System_Reflection_MethodInfo(m_InternalObject.GetSetMethod()), 0));
            m_Properties["GetSetMethod"] = new BSFunctionReference(new BSFunction("function GetSetMethod(nonPublic)", a => new BSWrapperObject_System_Reflection_MethodInfo(m_InternalObject.GetSetMethod(WrapperHelper.UnwrapObject<System.Boolean>(a[0]))), 1));
            m_Properties["GetValue"] = new BSFunctionReference(new BSFunction("function GetValue(obj)", a => new BSWrapperObject_System_Object(m_InternalObject.GetValue(WrapperHelper.UnwrapObject<System.Object>(a[0]))), 1));
            m_Properties["SetValue"] = new BSFunctionReference(new BSFunction("function SetValue(obj, value)", a => {
                m_InternalObject.SetValue(WrapperHelper.UnwrapObject<System.Object>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["GetConstantValue"] = new BSFunctionReference(new BSFunction("function GetConstantValue()", a => new BSWrapperObject_System_Object(m_InternalObject.GetConstantValue()), 0));
            m_Properties["GetRawConstantValue"] = new BSFunctionReference(new BSFunction("function GetRawConstantValue()", a => new BSWrapperObject_System_Object(m_InternalObject.GetRawConstantValue()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}