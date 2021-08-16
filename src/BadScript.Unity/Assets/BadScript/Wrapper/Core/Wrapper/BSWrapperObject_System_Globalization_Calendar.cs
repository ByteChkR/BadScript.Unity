using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Globalization_Calendar : BSWrapperObject<System.Globalization.Calendar>

    {
        public BSWrapperObject_System_Globalization_Calendar(System.Globalization.Calendar obj) : base(obj)
        {
            m_Properties["MinSupportedDateTime"] = new BSReflectionReference(() => new BSWrapperObject_System_DateTime(m_InternalObject.MinSupportedDateTime), null);
            m_Properties["MaxSupportedDateTime"] = new BSReflectionReference(() => new BSWrapperObject_System_DateTime(m_InternalObject.MaxSupportedDateTime), null);
            m_Properties["IsReadOnly"] = new BSReflectionReference(() => m_InternalObject.IsReadOnly ? BSObject.One : BSObject.Zero, null);
            m_Properties["TwoDigitYearMax"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.TwoDigitYearMax), x=> m_InternalObject.TwoDigitYearMax = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["Clone"] = new BSFunctionReference(new BSFunction("function Clone()", a => new BSWrapperObject_System_Object(m_InternalObject.Clone()), 0));
            m_Properties["AddMilliseconds"] = new BSFunctionReference(new BSFunction("function AddMilliseconds(time, milliseconds)", a => new BSWrapperObject_System_DateTime(m_InternalObject.AddMilliseconds(WrapperHelper.UnwrapObject<System.DateTime>(a[0]), WrapperHelper.UnwrapObject<System.Double>(a[1]))), 2));
            m_Properties["AddDays"] = new BSFunctionReference(new BSFunction("function AddDays(time, days)", a => new BSWrapperObject_System_DateTime(m_InternalObject.AddDays(WrapperHelper.UnwrapObject<System.DateTime>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_Properties["AddHours"] = new BSFunctionReference(new BSFunction("function AddHours(time, hours)", a => new BSWrapperObject_System_DateTime(m_InternalObject.AddHours(WrapperHelper.UnwrapObject<System.DateTime>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_Properties["AddMinutes"] = new BSFunctionReference(new BSFunction("function AddMinutes(time, minutes)", a => new BSWrapperObject_System_DateTime(m_InternalObject.AddMinutes(WrapperHelper.UnwrapObject<System.DateTime>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_Properties["AddMonths"] = new BSFunctionReference(new BSFunction("function AddMonths(time, months)", a => new BSWrapperObject_System_DateTime(m_InternalObject.AddMonths(WrapperHelper.UnwrapObject<System.DateTime>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_Properties["AddSeconds"] = new BSFunctionReference(new BSFunction("function AddSeconds(time, seconds)", a => new BSWrapperObject_System_DateTime(m_InternalObject.AddSeconds(WrapperHelper.UnwrapObject<System.DateTime>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_Properties["AddWeeks"] = new BSFunctionReference(new BSFunction("function AddWeeks(time, weeks)", a => new BSWrapperObject_System_DateTime(m_InternalObject.AddWeeks(WrapperHelper.UnwrapObject<System.DateTime>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_Properties["AddYears"] = new BSFunctionReference(new BSFunction("function AddYears(time, years)", a => new BSWrapperObject_System_DateTime(m_InternalObject.AddYears(WrapperHelper.UnwrapObject<System.DateTime>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_Properties["GetDayOfMonth"] = new BSFunctionReference(new BSFunction("function GetDayOfMonth(time)", a => new BSObject((decimal)m_InternalObject.GetDayOfMonth(WrapperHelper.UnwrapObject<System.DateTime>(a[0]))), 1));
            m_Properties["GetDayOfYear"] = new BSFunctionReference(new BSFunction("function GetDayOfYear(time)", a => new BSObject((decimal)m_InternalObject.GetDayOfYear(WrapperHelper.UnwrapObject<System.DateTime>(a[0]))), 1));
            m_Properties["GetDaysInMonth"] = new BSFunctionReference(new BSFunction("function GetDaysInMonth(year, month)", a => new BSObject((decimal)m_InternalObject.GetDaysInMonth(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_Properties["GetDaysInMonth"] = new BSFunctionReference(new BSFunction("function GetDaysInMonth(year, month, era)", a => new BSObject((decimal)m_InternalObject.GetDaysInMonth(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]))), 3));
            m_Properties["GetDaysInYear"] = new BSFunctionReference(new BSFunction("function GetDaysInYear(year)", a => new BSObject((decimal)m_InternalObject.GetDaysInYear(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetDaysInYear"] = new BSFunctionReference(new BSFunction("function GetDaysInYear(year, era)", a => new BSObject((decimal)m_InternalObject.GetDaysInYear(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_Properties["GetEra"] = new BSFunctionReference(new BSFunction("function GetEra(time)", a => new BSObject((decimal)m_InternalObject.GetEra(WrapperHelper.UnwrapObject<System.DateTime>(a[0]))), 1));
            m_Properties["GetHour"] = new BSFunctionReference(new BSFunction("function GetHour(time)", a => new BSObject((decimal)m_InternalObject.GetHour(WrapperHelper.UnwrapObject<System.DateTime>(a[0]))), 1));
            m_Properties["GetMilliseconds"] = new BSFunctionReference(new BSFunction("function GetMilliseconds(time)", a => new BSObject((decimal)m_InternalObject.GetMilliseconds(WrapperHelper.UnwrapObject<System.DateTime>(a[0]))), 1));
            m_Properties["GetMinute"] = new BSFunctionReference(new BSFunction("function GetMinute(time)", a => new BSObject((decimal)m_InternalObject.GetMinute(WrapperHelper.UnwrapObject<System.DateTime>(a[0]))), 1));
            m_Properties["GetMonth"] = new BSFunctionReference(new BSFunction("function GetMonth(time)", a => new BSObject((decimal)m_InternalObject.GetMonth(WrapperHelper.UnwrapObject<System.DateTime>(a[0]))), 1));
            m_Properties["GetMonthsInYear"] = new BSFunctionReference(new BSFunction("function GetMonthsInYear(year)", a => new BSObject((decimal)m_InternalObject.GetMonthsInYear(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetMonthsInYear"] = new BSFunctionReference(new BSFunction("function GetMonthsInYear(year, era)", a => new BSObject((decimal)m_InternalObject.GetMonthsInYear(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_Properties["GetSecond"] = new BSFunctionReference(new BSFunction("function GetSecond(time)", a => new BSObject((decimal)m_InternalObject.GetSecond(WrapperHelper.UnwrapObject<System.DateTime>(a[0]))), 1));
            m_Properties["GetYear"] = new BSFunctionReference(new BSFunction("function GetYear(time)", a => new BSObject((decimal)m_InternalObject.GetYear(WrapperHelper.UnwrapObject<System.DateTime>(a[0]))), 1));
            m_Properties["IsLeapDay"] = new BSFunctionReference(new BSFunction("function IsLeapDay(year, month, day)", a => m_InternalObject.IsLeapDay(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2])) ? BSObject.One : BSObject.Zero, 3));
            m_Properties["IsLeapDay"] = new BSFunctionReference(new BSFunction("function IsLeapDay(year, month, day, era)", a => m_InternalObject.IsLeapDay(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3])) ? BSObject.One : BSObject.Zero, 4));
            m_Properties["IsLeapMonth"] = new BSFunctionReference(new BSFunction("function IsLeapMonth(year, month)", a => m_InternalObject.IsLeapMonth(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_Properties["IsLeapMonth"] = new BSFunctionReference(new BSFunction("function IsLeapMonth(year, month, era)", a => m_InternalObject.IsLeapMonth(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2])) ? BSObject.One : BSObject.Zero, 3));
            m_Properties["GetLeapMonth"] = new BSFunctionReference(new BSFunction("function GetLeapMonth(year)", a => new BSObject((decimal)m_InternalObject.GetLeapMonth(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetLeapMonth"] = new BSFunctionReference(new BSFunction("function GetLeapMonth(year, era)", a => new BSObject((decimal)m_InternalObject.GetLeapMonth(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_Properties["IsLeapYear"] = new BSFunctionReference(new BSFunction("function IsLeapYear(year)", a => m_InternalObject.IsLeapYear(WrapperHelper.UnwrapObject<System.Int32>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["IsLeapYear"] = new BSFunctionReference(new BSFunction("function IsLeapYear(year, era)", a => m_InternalObject.IsLeapYear(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_Properties["ToDateTime"] = new BSFunctionReference(new BSFunction("function ToDateTime(year, month, day, hour, minute, second, millisecond)", a => new BSWrapperObject_System_DateTime(m_InternalObject.ToDateTime(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]), WrapperHelper.UnwrapObject<System.Int32>(a[4]), WrapperHelper.UnwrapObject<System.Int32>(a[5]), WrapperHelper.UnwrapObject<System.Int32>(a[6]))), 7));
            m_Properties["ToDateTime"] = new BSFunctionReference(new BSFunction("function ToDateTime(year, month, day, hour, minute, second, millisecond, era)", a => new BSWrapperObject_System_DateTime(m_InternalObject.ToDateTime(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]), WrapperHelper.UnwrapObject<System.Int32>(a[4]), WrapperHelper.UnwrapObject<System.Int32>(a[5]), WrapperHelper.UnwrapObject<System.Int32>(a[6]), WrapperHelper.UnwrapObject<System.Int32>(a[7]))), 8));
            m_Properties["ToFourDigitYear"] = new BSFunctionReference(new BSFunction("function ToFourDigitYear(year)", a => new BSObject((decimal)m_InternalObject.ToFourDigitYear(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}