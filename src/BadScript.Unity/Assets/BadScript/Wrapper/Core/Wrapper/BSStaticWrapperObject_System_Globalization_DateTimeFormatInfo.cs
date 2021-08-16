using System;
using System.Globalization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Globalization_DateTimeFormatInfo : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Globalization_DateTimeFormatInfo() : base( typeof( DateTimeFormatInfo ) )
        {
            m_StaticProperties["InvariantInfo"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_DateTimeFormatInfo( DateTimeFormatInfo.InvariantInfo ),
                null );

            m_StaticProperties["CurrentInfo"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_DateTimeFormatInfo( DateTimeFormatInfo.CurrentInfo ),
                null );

            m_StaticProperties["GetInstance"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInstance(provider)",
                    a => new BSWrapperObject_System_Globalization_DateTimeFormatInfo(
                        DateTimeFormatInfo.GetInstance( WrapperHelper.UnwrapObject < IFormatProvider >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ReadOnly"] = new BSFunctionReference(
                new BSFunction(
                    "function ReadOnly(dtfi)",
                    a => new BSWrapperObject_System_Globalization_DateTimeFormatInfo(
                        DateTimeFormatInfo.ReadOnly( WrapperHelper.UnwrapObject < DateTimeFormatInfo >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
