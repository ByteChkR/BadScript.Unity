using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Reflection_MethodBase : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Reflection_MethodBase() : base(typeof(System.Reflection.MethodBase))
        {
            m_StaticProperties["GetMethodFromHandle"] = new BSFunctionReference(new BSFunction("function GetMethodFromHandle(handle)", a => new BSWrapperObject_System_Reflection_MethodBase(System.Reflection.MethodBase.GetMethodFromHandle(WrapperHelper.UnwrapObject<System.RuntimeMethodHandle>(a[0]))), 1));
            m_StaticProperties["GetMethodFromHandle"] = new BSFunctionReference(new BSFunction("function GetMethodFromHandle(handle, declaringType)", a => new BSWrapperObject_System_Reflection_MethodBase(System.Reflection.MethodBase.GetMethodFromHandle(WrapperHelper.UnwrapObject<System.RuntimeMethodHandle>(a[0]), WrapperHelper.UnwrapObject<System.RuntimeTypeHandle>(a[1]))), 2));
            m_StaticProperties["GetCurrentMethod"] = new BSFunctionReference(new BSFunction("function GetCurrentMethod()", a => new BSWrapperObject_System_Reflection_MethodBase(System.Reflection.MethodBase.GetCurrentMethod()), 0));

        }
    }

}