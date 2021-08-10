using System;
using System.Globalization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Globalization_NumberFormatInfo : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Globalization_NumberFormatInfo() : base( typeof( NumberFormatInfo ) )
        {
            m_StaticProperties["InvariantInfo"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_NumberFormatInfo( NumberFormatInfo.InvariantInfo ),
                null );

            m_StaticProperties["CurrentInfo"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_NumberFormatInfo( NumberFormatInfo.CurrentInfo ),
                null );

            m_StaticProperties["GetInstance"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInstance(formatProvider)",
                    a => new BSWrapperObject_System_Globalization_NumberFormatInfo(
                        NumberFormatInfo.GetInstance( WrapperHelper.UnwrapObject < IFormatProvider >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ReadOnly"] = new BSFunctionReference(
                new BSFunction(
                    "function ReadOnly(nfi)",
                    a => new BSWrapperObject_System_Globalization_NumberFormatInfo(
                        NumberFormatInfo.ReadOnly( WrapperHelper.UnwrapObject < NumberFormatInfo >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
