using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Globalization_CultureInfo : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Globalization_CultureInfo() : base(typeof(System.Globalization.CultureInfo))
        {
            m_StaticProperties["InvariantCulture"] = new BSReflectionReference(() => new BSWrapperObject_System_Globalization_CultureInfo(System.Globalization.CultureInfo.InvariantCulture), null);
            m_StaticProperties["CurrentCulture"] = new BSReflectionReference(() => new BSWrapperObject_System_Globalization_CultureInfo(System.Globalization.CultureInfo.CurrentCulture), x=> System.Globalization.CultureInfo.CurrentCulture = WrapperHelper.UnwrapObject<System.Globalization.CultureInfo>(x));
            m_StaticProperties["CurrentUICulture"] = new BSReflectionReference(() => new BSWrapperObject_System_Globalization_CultureInfo(System.Globalization.CultureInfo.CurrentUICulture), x=> System.Globalization.CultureInfo.CurrentUICulture = WrapperHelper.UnwrapObject<System.Globalization.CultureInfo>(x));
            m_StaticProperties["InstalledUICulture"] = new BSReflectionReference(() => new BSWrapperObject_System_Globalization_CultureInfo(System.Globalization.CultureInfo.InstalledUICulture), null);
            m_StaticProperties["DefaultThreadCurrentCulture"] = new BSReflectionReference(() => new BSWrapperObject_System_Globalization_CultureInfo(System.Globalization.CultureInfo.DefaultThreadCurrentCulture), x=> System.Globalization.CultureInfo.DefaultThreadCurrentCulture = WrapperHelper.UnwrapObject<System.Globalization.CultureInfo>(x));
            m_StaticProperties["DefaultThreadCurrentUICulture"] = new BSReflectionReference(() => new BSWrapperObject_System_Globalization_CultureInfo(System.Globalization.CultureInfo.DefaultThreadCurrentUICulture), x=> System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = WrapperHelper.UnwrapObject<System.Globalization.CultureInfo>(x));
            m_StaticProperties["ReadOnly"] = new BSFunctionReference(new BSFunction("function ReadOnly(ci)", a => new BSWrapperObject_System_Globalization_CultureInfo(System.Globalization.CultureInfo.ReadOnly(WrapperHelper.UnwrapObject<System.Globalization.CultureInfo>(a[0]))), 1));
            m_StaticProperties["GetCultureInfo"] = new BSFunctionReference(new BSFunction("function GetCultureInfo(culture)", a => new BSWrapperObject_System_Globalization_CultureInfo(System.Globalization.CultureInfo.GetCultureInfo(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_StaticProperties["GetCultureInfo"] = new BSFunctionReference(new BSFunction("function GetCultureInfo(name)", a => new BSWrapperObject_System_Globalization_CultureInfo(System.Globalization.CultureInfo.GetCultureInfo(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["GetCultureInfo"] = new BSFunctionReference(new BSFunction("function GetCultureInfo(name, altName)", a => new BSWrapperObject_System_Globalization_CultureInfo(System.Globalization.CultureInfo.GetCultureInfo(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]))), 2));
            m_StaticProperties["GetCultureInfoByIetfLanguageTag"] = new BSFunctionReference(new BSFunction("function GetCultureInfoByIetfLanguageTag(name)", a => new BSWrapperObject_System_Globalization_CultureInfo(System.Globalization.CultureInfo.GetCultureInfoByIetfLanguageTag(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["CreateSpecificCulture"] = new BSFunctionReference(new BSFunction("function CreateSpecificCulture(name)", a => new BSWrapperObject_System_Globalization_CultureInfo(System.Globalization.CultureInfo.CreateSpecificCulture(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));

        }
    }

}