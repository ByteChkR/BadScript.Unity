using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Globalization_DateTimeFormatInfo : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Globalization_DateTimeFormatInfo() : base(typeof(System.Globalization.DateTimeFormatInfo))
        {
            m_StaticProperties["InvariantInfo"] = new BSReflectionReference(() => new BSWrapperObject_System_Globalization_DateTimeFormatInfo(System.Globalization.DateTimeFormatInfo.InvariantInfo), null);
            m_StaticProperties["CurrentInfo"] = new BSReflectionReference(() => new BSWrapperObject_System_Globalization_DateTimeFormatInfo(System.Globalization.DateTimeFormatInfo.CurrentInfo), null);
            m_StaticProperties["GetInstance"] = new BSFunctionReference(new BSFunction("function GetInstance(provider)", a => new BSWrapperObject_System_Globalization_DateTimeFormatInfo(System.Globalization.DateTimeFormatInfo.GetInstance(WrapperHelper.UnwrapObject<System.IFormatProvider>(a[0]))), 1));
            m_StaticProperties["ReadOnly"] = new BSFunctionReference(new BSFunction("function ReadOnly(dtfi)", a => new BSWrapperObject_System_Globalization_DateTimeFormatInfo(System.Globalization.DateTimeFormatInfo.ReadOnly(WrapperHelper.UnwrapObject<System.Globalization.DateTimeFormatInfo>(a[0]))), 1));

        }
    }

}