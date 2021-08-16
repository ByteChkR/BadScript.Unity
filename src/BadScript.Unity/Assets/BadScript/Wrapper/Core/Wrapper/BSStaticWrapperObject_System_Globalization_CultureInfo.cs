using System.Globalization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Globalization_CultureInfo : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Globalization_CultureInfo() : base( typeof( CultureInfo ) )
        {
            m_StaticProperties["InvariantCulture"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_CultureInfo( CultureInfo.InvariantCulture ),
                null );

            m_StaticProperties["CurrentCulture"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_CultureInfo( CultureInfo.CurrentCulture ),
                x => CultureInfo.CurrentCulture = WrapperHelper.UnwrapObject < CultureInfo >( x ) );

            m_StaticProperties["CurrentUICulture"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_CultureInfo( CultureInfo.CurrentUICulture ),
                x => CultureInfo.CurrentUICulture = WrapperHelper.UnwrapObject < CultureInfo >( x ) );

            m_StaticProperties["InstalledUICulture"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_CultureInfo( CultureInfo.InstalledUICulture ),
                null );

            m_StaticProperties["DefaultThreadCurrentCulture"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_CultureInfo( CultureInfo.DefaultThreadCurrentCulture ),
                x => CultureInfo.DefaultThreadCurrentCulture = WrapperHelper.UnwrapObject < CultureInfo >( x ) );

            m_StaticProperties["DefaultThreadCurrentUICulture"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_CultureInfo( CultureInfo.DefaultThreadCurrentUICulture ),
                x => CultureInfo.DefaultThreadCurrentUICulture = WrapperHelper.UnwrapObject < CultureInfo >( x ) );

            m_StaticProperties["ReadOnly"] = new BSFunctionReference(
                new BSFunction(
                    "function ReadOnly(ci)",
                    a => new BSWrapperObject_System_Globalization_CultureInfo(
                        CultureInfo.ReadOnly( WrapperHelper.UnwrapObject < CultureInfo >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetCultureInfo"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCultureInfo(culture)",
                    a => new BSWrapperObject_System_Globalization_CultureInfo(
                        CultureInfo.GetCultureInfo( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetCultureInfo"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCultureInfo(name)",
                    a => new BSWrapperObject_System_Globalization_CultureInfo(
                        CultureInfo.GetCultureInfo( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetCultureInfo"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCultureInfo(name, altName)",
                    a => new BSWrapperObject_System_Globalization_CultureInfo(
                        CultureInfo.GetCultureInfo(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetCultureInfoByIetfLanguageTag"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCultureInfoByIetfLanguageTag(name)",
                    a => new BSWrapperObject_System_Globalization_CultureInfo(
                        CultureInfo.GetCultureInfoByIetfLanguageTag( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["CreateSpecificCulture"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateSpecificCulture(name)",
                    a => new BSWrapperObject_System_Globalization_CultureInfo(
                        CultureInfo.CreateSpecificCulture( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
