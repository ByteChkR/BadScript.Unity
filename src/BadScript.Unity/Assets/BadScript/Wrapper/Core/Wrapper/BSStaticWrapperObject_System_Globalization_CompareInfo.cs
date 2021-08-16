using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Globalization_CompareInfo : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Globalization_CompareInfo() : base(typeof(System.Globalization.CompareInfo))
        {
            m_StaticProperties["GetCompareInfo"] = new BSFunctionReference(new BSFunction("function GetCompareInfo(culture, assembly)", a => new BSWrapperObject_System_Globalization_CompareInfo(System.Globalization.CompareInfo.GetCompareInfo(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Reflection.Assembly>(a[1]))), 2));
            m_StaticProperties["GetCompareInfo"] = new BSFunctionReference(new BSFunction("function GetCompareInfo(name, assembly)", a => new BSWrapperObject_System_Globalization_CompareInfo(System.Globalization.CompareInfo.GetCompareInfo(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Reflection.Assembly>(a[1]))), 2));
            m_StaticProperties["GetCompareInfo"] = new BSFunctionReference(new BSFunction("function GetCompareInfo(culture)", a => new BSWrapperObject_System_Globalization_CompareInfo(System.Globalization.CompareInfo.GetCompareInfo(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_StaticProperties["GetCompareInfo"] = new BSFunctionReference(new BSFunction("function GetCompareInfo(name)", a => new BSWrapperObject_System_Globalization_CompareInfo(System.Globalization.CompareInfo.GetCompareInfo(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["IsSortable"] = new BSFunctionReference(new BSFunction("function IsSortable(ch)", a => System.Globalization.CompareInfo.IsSortable(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsSortable"] = new BSFunctionReference(new BSFunction("function IsSortable(text)", a => System.Globalization.CompareInfo.IsSortable(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));

        }
    }

}