using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_DateTime : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_DateTime() : base(typeof(System.DateTime))
        {
            m_StaticProperties["Now"] = new BSReflectionReference(() => new BSWrapperObject_System_DateTime(System.DateTime.Now), null);
            m_StaticProperties["UtcNow"] = new BSReflectionReference(() => new BSWrapperObject_System_DateTime(System.DateTime.UtcNow), null);
            m_StaticProperties["Today"] = new BSReflectionReference(() => new BSWrapperObject_System_DateTime(System.DateTime.Today), null);
            m_StaticProperties["MinValue"] = new BSReflectionReference(() => new BSWrapperObject_System_DateTime(System.DateTime.MinValue), null);
            m_StaticProperties["MaxValue"] = new BSReflectionReference(() => new BSWrapperObject_System_DateTime(System.DateTime.MaxValue), null);
            m_StaticProperties["Compare"] = new BSFunctionReference(new BSFunction("function Compare(t1, t2)", a => new BSObject((decimal)System.DateTime.Compare(WrapperHelper.UnwrapObject<System.DateTime>(a[0]), WrapperHelper.UnwrapObject<System.DateTime>(a[1]))), 2));
            m_StaticProperties["DaysInMonth"] = new BSFunctionReference(new BSFunction("function DaysInMonth(year, month)", a => new BSObject((decimal)System.DateTime.DaysInMonth(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_StaticProperties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(t1, t2)", a => System.DateTime.Equals(WrapperHelper.UnwrapObject<System.DateTime>(a[0]), WrapperHelper.UnwrapObject<System.DateTime>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["FromBinary"] = new BSFunctionReference(new BSFunction("function FromBinary(dateData)", a => new BSWrapperObject_System_DateTime(System.DateTime.FromBinary(WrapperHelper.UnwrapObject<System.Int64>(a[0]))), 1));
            m_StaticProperties["FromFileTime"] = new BSFunctionReference(new BSFunction("function FromFileTime(fileTime)", a => new BSWrapperObject_System_DateTime(System.DateTime.FromFileTime(WrapperHelper.UnwrapObject<System.Int64>(a[0]))), 1));
            m_StaticProperties["FromFileTimeUtc"] = new BSFunctionReference(new BSFunction("function FromFileTimeUtc(fileTime)", a => new BSWrapperObject_System_DateTime(System.DateTime.FromFileTimeUtc(WrapperHelper.UnwrapObject<System.Int64>(a[0]))), 1));
            m_StaticProperties["FromOADate"] = new BSFunctionReference(new BSFunction("function FromOADate(d)", a => new BSWrapperObject_System_DateTime(System.DateTime.FromOADate(WrapperHelper.UnwrapObject<System.Double>(a[0]))), 1));
            m_StaticProperties["IsLeapYear"] = new BSFunctionReference(new BSFunction("function IsLeapYear(year)", a => System.DateTime.IsLeapYear(WrapperHelper.UnwrapObject<System.Int32>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["Parse"] = new BSFunctionReference(new BSFunction("function Parse(s)", a => new BSWrapperObject_System_DateTime(System.DateTime.Parse(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["Parse"] = new BSFunctionReference(new BSFunction("function Parse(s, provider)", a => new BSWrapperObject_System_DateTime(System.DateTime.Parse(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.IFormatProvider>(a[1]))), 2));
            m_StaticProperties["ParseExact"] = new BSFunctionReference(new BSFunction("function ParseExact(s, format, provider)", a => new BSWrapperObject_System_DateTime(System.DateTime.ParseExact(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]), WrapperHelper.UnwrapObject<System.IFormatProvider>(a[2]))), 3));

        }
    }

}