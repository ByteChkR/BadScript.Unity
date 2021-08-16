using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Version : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Version() : base(typeof(System.Version))
        {
            m_StaticProperties["Parse"] = new BSFunctionReference(new BSFunction("function Parse(input)", a => new BSWrapperObject_System_Version(System.Version.Parse(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));

        }
    }

}