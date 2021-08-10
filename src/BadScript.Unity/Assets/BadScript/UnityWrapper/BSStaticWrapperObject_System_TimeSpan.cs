using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_TimeSpan : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_TimeSpan() : base( typeof( TimeSpan ) )
        {
            m_StaticProperties["TicksPerMillisecond"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) TimeSpan.TicksPerMillisecond ),
                null );

            m_StaticProperties["TicksPerSecond"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) TimeSpan.TicksPerSecond ),
                null );

            m_StaticProperties["TicksPerMinute"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) TimeSpan.TicksPerMinute ),
                null );

            m_StaticProperties["TicksPerHour"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) TimeSpan.TicksPerHour ),
                null );

            m_StaticProperties["TicksPerDay"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) TimeSpan.TicksPerDay ),
                null );

            m_StaticProperties["Zero"] = new BSReflectionReference(
                () => new BSWrapperObject_System_TimeSpan( TimeSpan.Zero ),
                null );

            m_StaticProperties["MaxValue"] = new BSReflectionReference(
                () => new BSWrapperObject_System_TimeSpan( TimeSpan.MaxValue ),
                null );

            m_StaticProperties["MinValue"] = new BSReflectionReference(
                () => new BSWrapperObject_System_TimeSpan( TimeSpan.MinValue ),
                null );

            m_StaticProperties["Compare"] = new BSFunctionReference(
                new BSFunction(
                    "function Compare(t1, t2)",
                    a => new BSObject(
                        ( decimal ) TimeSpan.Compare(
                            WrapperHelper.UnwrapObject < TimeSpan >( a[0] ),
                            WrapperHelper.UnwrapObject < TimeSpan >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["FromDays"] = new BSFunctionReference(
                new BSFunction(
                    "function FromDays(value)",
                    a => new BSWrapperObject_System_TimeSpan(
                        TimeSpan.FromDays( WrapperHelper.UnwrapObject < double >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(t1, t2)",
                    a => TimeSpan.Equals(
                        WrapperHelper.UnwrapObject < TimeSpan >( a[0] ),
                        WrapperHelper.UnwrapObject < TimeSpan >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["FromHours"] = new BSFunctionReference(
                new BSFunction(
                    "function FromHours(value)",
                    a => new BSWrapperObject_System_TimeSpan(
                        TimeSpan.FromHours( WrapperHelper.UnwrapObject < double >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FromMilliseconds"] = new BSFunctionReference(
                new BSFunction(
                    "function FromMilliseconds(value)",
                    a => new BSWrapperObject_System_TimeSpan(
                        TimeSpan.FromMilliseconds( WrapperHelper.UnwrapObject < double >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FromMinutes"] = new BSFunctionReference(
                new BSFunction(
                    "function FromMinutes(value)",
                    a => new BSWrapperObject_System_TimeSpan(
                        TimeSpan.FromMinutes( WrapperHelper.UnwrapObject < double >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FromSeconds"] = new BSFunctionReference(
                new BSFunction(
                    "function FromSeconds(value)",
                    a => new BSWrapperObject_System_TimeSpan(
                        TimeSpan.FromSeconds( WrapperHelper.UnwrapObject < double >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FromTicks"] = new BSFunctionReference(
                new BSFunction(
                    "function FromTicks(value)",
                    a => new BSWrapperObject_System_TimeSpan(
                        TimeSpan.FromTicks( WrapperHelper.UnwrapObject < long >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Parse"] = new BSFunctionReference(
                new BSFunction(
                    "function Parse(s)",
                    a => new BSWrapperObject_System_TimeSpan(
                        TimeSpan.Parse( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Parse"] = new BSFunctionReference(
                new BSFunction(
                    "function Parse(input, formatProvider)",
                    a => new BSWrapperObject_System_TimeSpan(
                        TimeSpan.Parse(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < IFormatProvider >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["ParseExact"] = new BSFunctionReference(
                new BSFunction(
                    "function ParseExact(input, format, formatProvider)",
                    a => new BSWrapperObject_System_TimeSpan(
                        TimeSpan.ParseExact(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < IFormatProvider >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}
