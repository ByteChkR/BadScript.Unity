using System.Globalization;
using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Globalization_CompareInfo : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Globalization_CompareInfo() : base( typeof( CompareInfo ) )
        {
            m_StaticProperties["GetCompareInfo"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCompareInfo(culture, assembly)",
                    a => new BSWrapperObject_System_Globalization_CompareInfo(
                        CompareInfo.GetCompareInfo(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Assembly >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetCompareInfo"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCompareInfo(name, assembly)",
                    a => new BSWrapperObject_System_Globalization_CompareInfo(
                        CompareInfo.GetCompareInfo(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Assembly >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetCompareInfo"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCompareInfo(culture)",
                    a => new BSWrapperObject_System_Globalization_CompareInfo(
                        CompareInfo.GetCompareInfo( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetCompareInfo"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCompareInfo(name)",
                    a => new BSWrapperObject_System_Globalization_CompareInfo(
                        CompareInfo.GetCompareInfo( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["IsSortable"] = new BSFunctionReference(
                new BSFunction(
                    "function IsSortable(ch)",
                    a => CompareInfo.IsSortable( WrapperHelper.UnwrapObject < char >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsSortable"] = new BSFunctionReference(
                new BSFunction(
                    "function IsSortable(text)",
                    a => CompareInfo.IsSortable( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
