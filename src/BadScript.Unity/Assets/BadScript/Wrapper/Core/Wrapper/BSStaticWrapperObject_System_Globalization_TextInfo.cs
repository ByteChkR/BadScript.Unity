using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Globalization_TextInfo : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Globalization_TextInfo() : base(typeof(System.Globalization.TextInfo))
        {
            m_StaticProperties["ReadOnly"] = new BSFunctionReference(new BSFunction("function ReadOnly(textInfo)", a => new BSWrapperObject_System_Globalization_TextInfo(System.Globalization.TextInfo.ReadOnly(WrapperHelper.UnwrapObject<System.Globalization.TextInfo>(a[0]))), 1));

        }
    }

}