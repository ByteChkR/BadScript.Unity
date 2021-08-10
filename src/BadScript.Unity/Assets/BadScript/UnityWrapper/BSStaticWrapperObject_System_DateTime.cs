using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_DateTime : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_DateTime() : base( typeof( DateTime ) )
        {
            m_StaticProperties["Now"] = new BSReflectionReference(
                () => new BSWrapperObject_System_DateTime( DateTime.Now ),
                null );

            m_StaticProperties["UtcNow"] = new BSReflectionReference(
                () => new BSWrapperObject_System_DateTime( DateTime.UtcNow ),
                null );

            m_StaticProperties["Today"] = new BSReflectionReference(
                () => new BSWrapperObject_System_DateTime( DateTime.Today ),
                null );

            m_StaticProperties["MinValue"] = new BSReflectionReference(
                () => new BSWrapperObject_System_DateTime( DateTime.MinValue ),
                null );

            m_StaticProperties["MaxValue"] = new BSReflectionReference(
                () => new BSWrapperObject_System_DateTime( DateTime.MaxValue ),
                null );

            m_StaticProperties["Compare"] = new BSFunctionReference(
                new BSFunction(
                    "function Compare(t1, t2)",
                    a => new BSObject(
                        ( decimal ) DateTime.Compare(
                            WrapperHelper.UnwrapObject < DateTime >( a[0] ),
                            WrapperHelper.UnwrapObject < DateTime >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["DaysInMonth"] = new BSFunctionReference(
                new BSFunction(
                    "function DaysInMonth(year, month)",
                    a => new BSObject(
                        ( decimal ) DateTime.DaysInMonth(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(t1, t2)",
                    a => DateTime.Equals(
                        WrapperHelper.UnwrapObject < DateTime >( a[0] ),
                        WrapperHelper.UnwrapObject < DateTime >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["FromBinary"] = new BSFunctionReference(
                new BSFunction(
                    "function FromBinary(dateData)",
                    a => new BSWrapperObject_System_DateTime(
                        DateTime.FromBinary( WrapperHelper.UnwrapObject < long >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FromFileTime"] = new BSFunctionReference(
                new BSFunction(
                    "function FromFileTime(fileTime)",
                    a => new BSWrapperObject_System_DateTime(
                        DateTime.FromFileTime( WrapperHelper.UnwrapObject < long >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FromFileTimeUtc"] = new BSFunctionReference(
                new BSFunction(
                    "function FromFileTimeUtc(fileTime)",
                    a => new BSWrapperObject_System_DateTime(
                        DateTime.FromFileTimeUtc( WrapperHelper.UnwrapObject < long >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FromOADate"] = new BSFunctionReference(
                new BSFunction(
                    "function FromOADate(d)",
                    a => new BSWrapperObject_System_DateTime(
                        DateTime.FromOADate( WrapperHelper.UnwrapObject < double >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["IsLeapYear"] = new BSFunctionReference(
                new BSFunction(
                    "function IsLeapYear(year)",
                    a => DateTime.IsLeapYear( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["Parse"] = new BSFunctionReference(
                new BSFunction(
                    "function Parse(s)",
                    a => new BSWrapperObject_System_DateTime(
                        DateTime.Parse( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Parse"] = new BSFunctionReference(
                new BSFunction(
                    "function Parse(s, provider)",
                    a => new BSWrapperObject_System_DateTime(
                        DateTime.Parse(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < IFormatProvider >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["ParseExact"] = new BSFunctionReference(
                new BSFunction(
                    "function ParseExact(s, format, provider)",
                    a => new BSWrapperObject_System_DateTime(
                        DateTime.ParseExact(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < IFormatProvider >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}
