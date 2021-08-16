using System.Security;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Security_SecurityElement : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Security_SecurityElement() : base( typeof( SecurityElement ) )
        {
            m_StaticProperties["Escape"] = new BSFunctionReference(
                new BSFunction(
                    "function Escape(str)",
                    a => new BSObject( SecurityElement.Escape( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FromString"] = new BSFunctionReference(
                new BSFunction(
                    "function FromString(xml)",
                    a => new BSWrapperObject_System_Security_SecurityElement(
                        SecurityElement.FromString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["IsValidAttributeName"] = new BSFunctionReference(
                new BSFunction(
                    "function IsValidAttributeName(name)",
                    a => SecurityElement.IsValidAttributeName( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsValidAttributeValue"] = new BSFunctionReference(
                new BSFunction(
                    "function IsValidAttributeValue(value)",
                    a => SecurityElement.IsValidAttributeValue( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsValidTag"] = new BSFunctionReference(
                new BSFunction(
                    "function IsValidTag(tag)",
                    a => SecurityElement.IsValidTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsValidText"] = new BSFunctionReference(
                new BSFunction(
                    "function IsValidText(text)",
                    a => SecurityElement.IsValidText( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
