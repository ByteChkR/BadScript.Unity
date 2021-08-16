using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_DateTime : BSWrapperObject < DateTime >

    {
        #region Public

        public BSWrapperObject_System_DateTime( DateTime obj ) : base( obj )
        {
            m_Properties["Date"] = new BSReflectionReference(
                () => new BSWrapperObject_System_DateTime( m_InternalObject.Date ),
                null );

            m_Properties["Day"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Day ),
                null );

            m_Properties["DayOfYear"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.DayOfYear ),
                null );

            m_Properties["Hour"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Hour ),
                null );

            m_Properties["Millisecond"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Millisecond ),
                null );

            m_Properties["Minute"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Minute ),
                null );

            m_Properties["Month"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Month ),
                null );

            m_Properties["Second"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Second ),
                null );

            m_Properties["Ticks"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Ticks ),
                null );

            m_Properties["TimeOfDay"] = new BSReflectionReference(
                () => new BSWrapperObject_System_TimeSpan( m_InternalObject.TimeOfDay ),
                null );

            m_Properties["Year"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Year ),
                null );

            m_Properties["Add"] = new BSFunctionReference(
                new BSFunction(
                    "function Add(value)",
                    a => new BSWrapperObject_System_DateTime(
                        m_InternalObject.Add( WrapperHelper.UnwrapObject < TimeSpan >( a[0] ) ) ),
                    1 ) );

            m_Properties["AddDays"] = new BSFunctionReference(
                new BSFunction(
                    "function AddDays(value)",
                    a => new BSWrapperObject_System_DateTime(
                        m_InternalObject.AddDays( WrapperHelper.UnwrapObject < double >( a[0] ) ) ),
                    1 ) );

            m_Properties["AddHours"] = new BSFunctionReference(
                new BSFunction(
                    "function AddHours(value)",
                    a => new BSWrapperObject_System_DateTime(
                        m_InternalObject.AddHours( WrapperHelper.UnwrapObject < double >( a[0] ) ) ),
                    1 ) );

            m_Properties["AddMilliseconds"] = new BSFunctionReference(
                new BSFunction(
                    "function AddMilliseconds(value)",
                    a => new BSWrapperObject_System_DateTime(
                        m_InternalObject.AddMilliseconds( WrapperHelper.UnwrapObject < double >( a[0] ) ) ),
                    1 ) );

            m_Properties["AddMinutes"] = new BSFunctionReference(
                new BSFunction(
                    "function AddMinutes(value)",
                    a => new BSWrapperObject_System_DateTime(
                        m_InternalObject.AddMinutes( WrapperHelper.UnwrapObject < double >( a[0] ) ) ),
                    1 ) );

            m_Properties["AddMonths"] = new BSFunctionReference(
                new BSFunction(
                    "function AddMonths(months)",
                    a => new BSWrapperObject_System_DateTime(
                        m_InternalObject.AddMonths( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["AddSeconds"] = new BSFunctionReference(
                new BSFunction(
                    "function AddSeconds(value)",
                    a => new BSWrapperObject_System_DateTime(
                        m_InternalObject.AddSeconds( WrapperHelper.UnwrapObject < double >( a[0] ) ) ),
                    1 ) );

            m_Properties["AddTicks"] = new BSFunctionReference(
                new BSFunction(
                    "function AddTicks(value)",
                    a => new BSWrapperObject_System_DateTime(
                        m_InternalObject.AddTicks( WrapperHelper.UnwrapObject < long >( a[0] ) ) ),
                    1 ) );

            m_Properties["AddYears"] = new BSFunctionReference(
                new BSFunction(
                    "function AddYears(value)",
                    a => new BSWrapperObject_System_DateTime(
                        m_InternalObject.AddYears( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["CompareTo"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTo(value)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.CompareTo( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

            m_Properties["CompareTo"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTo(value)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.CompareTo( WrapperHelper.UnwrapObject < DateTime >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(value)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(value)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < DateTime >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["IsDaylightSavingTime"] = new BSFunctionReference(
                new BSFunction(
                    "function IsDaylightSavingTime()",
                    a => m_InternalObject.IsDaylightSavingTime() ? BSObject.One : BSObject.Zero,
                    0 ) );

            m_Properties["ToBinary"] = new BSFunctionReference(
                new BSFunction(
                    "function ToBinary()",
                    a => new BSObject( ( decimal ) m_InternalObject.ToBinary() ),
                    0 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["Subtract"] = new BSFunctionReference(
                new BSFunction(
                    "function Subtract(value)",
                    a => new BSWrapperObject_System_TimeSpan(
                        m_InternalObject.Subtract( WrapperHelper.UnwrapObject < DateTime >( a[0] ) ) ),
                    1 ) );

            m_Properties["Subtract"] = new BSFunctionReference(
                new BSFunction(
                    "function Subtract(value)",
                    a => new BSWrapperObject_System_DateTime(
                        m_InternalObject.Subtract( WrapperHelper.UnwrapObject < TimeSpan >( a[0] ) ) ),
                    1 ) );

            m_Properties["ToOADate"] = new BSFunctionReference(
                new BSFunction(
                    "function ToOADate()",
                    a => new BSObject( ( decimal ) m_InternalObject.ToOADate() ),
                    0 ) );

            m_Properties["ToFileTime"] = new BSFunctionReference(
                new BSFunction(
                    "function ToFileTime()",
                    a => new BSObject( ( decimal ) m_InternalObject.ToFileTime() ),
                    0 ) );

            m_Properties["ToFileTimeUtc"] = new BSFunctionReference(
                new BSFunction(
                    "function ToFileTimeUtc()",
                    a => new BSObject( ( decimal ) m_InternalObject.ToFileTimeUtc() ),
                    0 ) );

            m_Properties["ToLocalTime"] = new BSFunctionReference(
                new BSFunction(
                    "function ToLocalTime()",
                    a => new BSWrapperObject_System_DateTime( m_InternalObject.ToLocalTime() ),
                    0 ) );

            m_Properties["ToLongDateString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToLongDateString()",
                    a => new BSObject( m_InternalObject.ToLongDateString() ),
                    0 ) );

            m_Properties["ToLongTimeString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToLongTimeString()",
                    a => new BSObject( m_InternalObject.ToLongTimeString() ),
                    0 ) );

            m_Properties["ToShortDateString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToShortDateString()",
                    a => new BSObject( m_InternalObject.ToShortDateString() ),
                    0 ) );

            m_Properties["ToShortTimeString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToShortTimeString()",
                    a => new BSObject( m_InternalObject.ToShortTimeString() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(format)",
                    a => new BSObject( m_InternalObject.ToString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(provider)",
                    a => new BSObject(
                        m_InternalObject.ToString( WrapperHelper.UnwrapObject < IFormatProvider >( a[0] ) ) ),
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(format, provider)",
                    a => new BSObject(
                        m_InternalObject.ToString(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < IFormatProvider >( a[1] ) ) ),
                    2 ) );

            m_Properties["ToUniversalTime"] = new BSFunctionReference(
                new BSFunction(
                    "function ToUniversalTime()",
                    a => new BSWrapperObject_System_DateTime( m_InternalObject.ToUniversalTime() ),
                    0 ) );

        }

        #endregion
    }

}
