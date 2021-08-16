using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Globalization_DateTimeFormatInfo : BSWrapperObject<System.Globalization.DateTimeFormatInfo>

    {
        public BSWrapperObject_System_Globalization_DateTimeFormatInfo(System.Globalization.DateTimeFormatInfo obj) : base(obj)
        {
            m_Properties["AMDesignator"] = new BSReflectionReference(() => new BSObject(m_InternalObject.AMDesignator), x=> m_InternalObject.AMDesignator = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["Calendar"] = new BSReflectionReference(() => new BSWrapperObject_System_Globalization_Calendar(m_InternalObject.Calendar), x=> m_InternalObject.Calendar = WrapperHelper.UnwrapObject<System.Globalization.Calendar>(x));
            m_Properties["DateSeparator"] = new BSReflectionReference(() => new BSObject(m_InternalObject.DateSeparator), x=> m_InternalObject.DateSeparator = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["FullDateTimePattern"] = new BSReflectionReference(() => new BSObject(m_InternalObject.FullDateTimePattern), x=> m_InternalObject.FullDateTimePattern = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["LongDatePattern"] = new BSReflectionReference(() => new BSObject(m_InternalObject.LongDatePattern), x=> m_InternalObject.LongDatePattern = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["LongTimePattern"] = new BSReflectionReference(() => new BSObject(m_InternalObject.LongTimePattern), x=> m_InternalObject.LongTimePattern = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["MonthDayPattern"] = new BSReflectionReference(() => new BSObject(m_InternalObject.MonthDayPattern), x=> m_InternalObject.MonthDayPattern = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["PMDesignator"] = new BSReflectionReference(() => new BSObject(m_InternalObject.PMDesignator), x=> m_InternalObject.PMDesignator = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["RFC1123Pattern"] = new BSReflectionReference(() => new BSObject(m_InternalObject.RFC1123Pattern), null);
            m_Properties["ShortDatePattern"] = new BSReflectionReference(() => new BSObject(m_InternalObject.ShortDatePattern), x=> m_InternalObject.ShortDatePattern = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["ShortTimePattern"] = new BSReflectionReference(() => new BSObject(m_InternalObject.ShortTimePattern), x=> m_InternalObject.ShortTimePattern = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["SortableDateTimePattern"] = new BSReflectionReference(() => new BSObject(m_InternalObject.SortableDateTimePattern), null);
            m_Properties["TimeSeparator"] = new BSReflectionReference(() => new BSObject(m_InternalObject.TimeSeparator), x=> m_InternalObject.TimeSeparator = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["UniversalSortableDateTimePattern"] = new BSReflectionReference(() => new BSObject(m_InternalObject.UniversalSortableDateTimePattern), null);
            m_Properties["YearMonthPattern"] = new BSReflectionReference(() => new BSObject(m_InternalObject.YearMonthPattern), x=> m_InternalObject.YearMonthPattern = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["IsReadOnly"] = new BSReflectionReference(() => m_InternalObject.IsReadOnly ? BSObject.One : BSObject.Zero, null);
            m_Properties["NativeCalendarName"] = new BSReflectionReference(() => new BSObject(m_InternalObject.NativeCalendarName), null);
            m_Properties["Clone"] = new BSFunctionReference(new BSFunction("function Clone()", a => new BSWrapperObject_System_Object(m_InternalObject.Clone()), 0));
            m_Properties["GetEra"] = new BSFunctionReference(new BSFunction("function GetEra(eraName)", a => new BSObject((decimal)m_InternalObject.GetEra(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["GetEraName"] = new BSFunctionReference(new BSFunction("function GetEraName(era)", a => new BSObject(m_InternalObject.GetEraName(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetAbbreviatedEraName"] = new BSFunctionReference(new BSFunction("function GetAbbreviatedEraName(era)", a => new BSObject(m_InternalObject.GetAbbreviatedEraName(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetAbbreviatedMonthName"] = new BSFunctionReference(new BSFunction("function GetAbbreviatedMonthName(month)", a => new BSObject(m_InternalObject.GetAbbreviatedMonthName(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetMonthName"] = new BSFunctionReference(new BSFunction("function GetMonthName(month)", a => new BSObject(m_InternalObject.GetMonthName(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}