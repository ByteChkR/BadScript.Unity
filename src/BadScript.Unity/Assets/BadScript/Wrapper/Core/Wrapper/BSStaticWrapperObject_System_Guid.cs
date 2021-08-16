using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Guid : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Guid() : base(typeof(System.Guid))
        {
            m_StaticProperties["Empty"] = new BSReflectionReference(() => new BSWrapperObject_System_Guid(System.Guid.Empty), null);
            m_StaticProperties["Parse"] = new BSFunctionReference(new BSFunction("function Parse(input)", a => new BSWrapperObject_System_Guid(System.Guid.Parse(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["ParseExact"] = new BSFunctionReference(new BSFunction("function ParseExact(input, format)", a => new BSWrapperObject_System_Guid(System.Guid.ParseExact(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]))), 2));
            m_StaticProperties["NewGuid"] = new BSFunctionReference(new BSFunction("function NewGuid()", a => new BSWrapperObject_System_Guid(System.Guid.NewGuid()), 0));

        }
    }

}