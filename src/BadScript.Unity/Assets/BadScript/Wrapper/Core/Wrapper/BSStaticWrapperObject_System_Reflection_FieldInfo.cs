using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Reflection_FieldInfo : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Reflection_FieldInfo() : base(typeof(System.Reflection.FieldInfo))
        {
            m_StaticProperties["GetFieldFromHandle"] = new BSFunctionReference(new BSFunction("function GetFieldFromHandle(handle)", a => new BSWrapperObject_System_Reflection_FieldInfo(System.Reflection.FieldInfo.GetFieldFromHandle(WrapperHelper.UnwrapObject<System.RuntimeFieldHandle>(a[0]))), 1));
            m_StaticProperties["GetFieldFromHandle"] = new BSFunctionReference(new BSFunction("function GetFieldFromHandle(handle, declaringType)", a => new BSWrapperObject_System_Reflection_FieldInfo(System.Reflection.FieldInfo.GetFieldFromHandle(WrapperHelper.UnwrapObject<System.RuntimeFieldHandle>(a[0]), WrapperHelper.UnwrapObject<System.RuntimeTypeHandle>(a[1]))), 2));

        }
    }

}