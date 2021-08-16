using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Security_SecurityElement : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Security_SecurityElement() : base(typeof(System.Security.SecurityElement))
        {
            m_StaticProperties["Escape"] = new BSFunctionReference(new BSFunction("function Escape(str)", a => new BSObject(System.Security.SecurityElement.Escape(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["FromString"] = new BSFunctionReference(new BSFunction("function FromString(xml)", a => new BSWrapperObject_System_Security_SecurityElement(System.Security.SecurityElement.FromString(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["IsValidAttributeName"] = new BSFunctionReference(new BSFunction("function IsValidAttributeName(name)", a => System.Security.SecurityElement.IsValidAttributeName(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsValidAttributeValue"] = new BSFunctionReference(new BSFunction("function IsValidAttributeValue(value)", a => System.Security.SecurityElement.IsValidAttributeValue(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsValidTag"] = new BSFunctionReference(new BSFunction("function IsValidTag(tag)", a => System.Security.SecurityElement.IsValidTag(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsValidText"] = new BSFunctionReference(new BSFunction("function IsValidText(text)", a => System.Security.SecurityElement.IsValidText(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));

        }
    }

}