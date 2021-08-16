using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Globalization_SortKey : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Globalization_SortKey() : base(typeof(System.Globalization.SortKey))
        {
            m_StaticProperties["Compare"] = new BSFunctionReference(new BSFunction("function Compare(sortkey1, sortkey2)", a => new BSObject((decimal)System.Globalization.SortKey.Compare(WrapperHelper.UnwrapObject<System.Globalization.SortKey>(a[0]), WrapperHelper.UnwrapObject<System.Globalization.SortKey>(a[1]))), 2));

        }
    }

}