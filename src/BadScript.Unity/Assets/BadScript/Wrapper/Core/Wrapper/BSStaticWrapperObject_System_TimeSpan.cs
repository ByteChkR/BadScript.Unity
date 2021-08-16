using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_TimeSpan : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_TimeSpan() : base(typeof(System.TimeSpan))
        {
            m_StaticProperties["TicksPerMillisecond"] = new BSReflectionReference(() => new BSObject((decimal)System.TimeSpan.TicksPerMillisecond), null);
            m_StaticProperties["TicksPerSecond"] = new BSReflectionReference(() => new BSObject((decimal)System.TimeSpan.TicksPerSecond), null);
            m_StaticProperties["TicksPerMinute"] = new BSReflectionReference(() => new BSObject((decimal)System.TimeSpan.TicksPerMinute), null);
            m_StaticProperties["TicksPerHour"] = new BSReflectionReference(() => new BSObject((decimal)System.TimeSpan.TicksPerHour), null);
            m_StaticProperties["TicksPerDay"] = new BSReflectionReference(() => new BSObject((decimal)System.TimeSpan.TicksPerDay), null);
            m_StaticProperties["Zero"] = new BSReflectionReference(() => new BSWrapperObject_System_TimeSpan(System.TimeSpan.Zero), null);
            m_StaticProperties["MaxValue"] = new BSReflectionReference(() => new BSWrapperObject_System_TimeSpan(System.TimeSpan.MaxValue), null);
            m_StaticProperties["MinValue"] = new BSReflectionReference(() => new BSWrapperObject_System_TimeSpan(System.TimeSpan.MinValue), null);
            m_StaticProperties["Compare"] = new BSFunctionReference(new BSFunction("function Compare(t1, t2)", a => new BSObject((decimal)System.TimeSpan.Compare(WrapperHelper.UnwrapObject<System.TimeSpan>(a[0]), WrapperHelper.UnwrapObject<System.TimeSpan>(a[1]))), 2));
            m_StaticProperties["FromDays"] = new BSFunctionReference(new BSFunction("function FromDays(value)", a => new BSWrapperObject_System_TimeSpan(System.TimeSpan.FromDays(WrapperHelper.UnwrapObject<System.Double>(a[0]))), 1));
            m_StaticProperties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(t1, t2)", a => System.TimeSpan.Equals(WrapperHelper.UnwrapObject<System.TimeSpan>(a[0]), WrapperHelper.UnwrapObject<System.TimeSpan>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["FromHours"] = new BSFunctionReference(new BSFunction("function FromHours(value)", a => new BSWrapperObject_System_TimeSpan(System.TimeSpan.FromHours(WrapperHelper.UnwrapObject<System.Double>(a[0]))), 1));
            m_StaticProperties["FromMilliseconds"] = new BSFunctionReference(new BSFunction("function FromMilliseconds(value)", a => new BSWrapperObject_System_TimeSpan(System.TimeSpan.FromMilliseconds(WrapperHelper.UnwrapObject<System.Double>(a[0]))), 1));
            m_StaticProperties["FromMinutes"] = new BSFunctionReference(new BSFunction("function FromMinutes(value)", a => new BSWrapperObject_System_TimeSpan(System.TimeSpan.FromMinutes(WrapperHelper.UnwrapObject<System.Double>(a[0]))), 1));
            m_StaticProperties["FromSeconds"] = new BSFunctionReference(new BSFunction("function FromSeconds(value)", a => new BSWrapperObject_System_TimeSpan(System.TimeSpan.FromSeconds(WrapperHelper.UnwrapObject<System.Double>(a[0]))), 1));
            m_StaticProperties["FromTicks"] = new BSFunctionReference(new BSFunction("function FromTicks(value)", a => new BSWrapperObject_System_TimeSpan(System.TimeSpan.FromTicks(WrapperHelper.UnwrapObject<System.Int64>(a[0]))), 1));
            m_StaticProperties["Parse"] = new BSFunctionReference(new BSFunction("function Parse(s)", a => new BSWrapperObject_System_TimeSpan(System.TimeSpan.Parse(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["Parse"] = new BSFunctionReference(new BSFunction("function Parse(input, formatProvider)", a => new BSWrapperObject_System_TimeSpan(System.TimeSpan.Parse(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.IFormatProvider>(a[1]))), 2));
            m_StaticProperties["ParseExact"] = new BSFunctionReference(new BSFunction("function ParseExact(input, format, formatProvider)", a => new BSWrapperObject_System_TimeSpan(System.TimeSpan.ParseExact(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]), WrapperHelper.UnwrapObject<System.IFormatProvider>(a[2]))), 3));

        }
    }

}