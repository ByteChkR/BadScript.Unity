using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Globalization_NumberFormatInfo : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Globalization_NumberFormatInfo() : base(typeof(System.Globalization.NumberFormatInfo))
        {
            m_StaticProperties["InvariantInfo"] = new BSReflectionReference(() => new BSWrapperObject_System_Globalization_NumberFormatInfo(System.Globalization.NumberFormatInfo.InvariantInfo), null);
            m_StaticProperties["CurrentInfo"] = new BSReflectionReference(() => new BSWrapperObject_System_Globalization_NumberFormatInfo(System.Globalization.NumberFormatInfo.CurrentInfo), null);
            m_StaticProperties["GetInstance"] = new BSFunctionReference(new BSFunction("function GetInstance(formatProvider)", a => new BSWrapperObject_System_Globalization_NumberFormatInfo(System.Globalization.NumberFormatInfo.GetInstance(WrapperHelper.UnwrapObject<System.IFormatProvider>(a[0]))), 1));
            m_StaticProperties["ReadOnly"] = new BSFunctionReference(new BSFunction("function ReadOnly(nfi)", a => new BSWrapperObject_System_Globalization_NumberFormatInfo(System.Globalization.NumberFormatInfo.ReadOnly(WrapperHelper.UnwrapObject<System.Globalization.NumberFormatInfo>(a[0]))), 1));

        }
    }

}