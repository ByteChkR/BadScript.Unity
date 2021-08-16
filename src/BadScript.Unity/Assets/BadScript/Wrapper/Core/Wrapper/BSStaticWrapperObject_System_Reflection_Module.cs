using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Reflection_Module : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Reflection_Module() : base(typeof(System.Reflection.Module))
        {
            m_StaticProperties["FilterTypeName"] = new BSReflectionReference(() => new BSWrapperObject_System_Reflection_TypeFilter(System.Reflection.Module.FilterTypeName), null);
            m_StaticProperties["FilterTypeNameIgnoreCase"] = new BSReflectionReference(() => new BSWrapperObject_System_Reflection_TypeFilter(System.Reflection.Module.FilterTypeNameIgnoreCase), null);

        }
    }

}