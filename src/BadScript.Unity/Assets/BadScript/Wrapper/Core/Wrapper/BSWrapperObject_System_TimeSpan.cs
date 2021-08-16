using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_TimeSpan : BSWrapperObject < TimeSpan >

    {
        #region Public

        public BSWrapperObject_System_TimeSpan( TimeSpan obj ) : base( obj )
        {
            m_Properties["Ticks"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Ticks ),
                null );

            m_Properties["Days"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Days ),
                null );

            m_Properties["Hours"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Hours ),
                null );

            m_Properties["Milliseconds"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Milliseconds ),
                null );

            m_Properties["Minutes"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Minutes ),
                null );

            m_Properties["Seconds"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Seconds ),
                null );

            m_Properties["TotalDays"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.TotalDays ),
                null );

            m_Properties["TotalHours"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.TotalHours ),
                null );

            m_Properties["TotalMilliseconds"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.TotalMilliseconds ),
                null );

            m_Properties["TotalMinutes"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.TotalMinutes ),
                null );

            m_Properties["TotalSeconds"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.TotalSeconds ),
                null );

            m_Properties["Add"] = new BSFunctionReference(
                new BSFunction(
                    "function Add(ts)",
                    a => new BSWrapperObject_System_TimeSpan(
                        m_InternalObject.Add( WrapperHelper.UnwrapObject < TimeSpan >( a[0] ) ) ),
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
                        ( decimal ) m_InternalObject.CompareTo( WrapperHelper.UnwrapObject < TimeSpan >( a[0] ) ) ),
                    1 ) );

            m_Properties["Duration"] = new BSFunctionReference(
                new BSFunction(
                    "function Duration()",
                    a => new BSWrapperObject_System_TimeSpan( m_InternalObject.Duration() ),
                    0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(value)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < TimeSpan >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["Negate"] = new BSFunctionReference(
                new BSFunction(
                    "function Negate()",
                    a => new BSWrapperObject_System_TimeSpan( m_InternalObject.Negate() ),
                    0 ) );

            m_Properties["Subtract"] = new BSFunctionReference(
                new BSFunction(
                    "function Subtract(ts)",
                    a => new BSWrapperObject_System_TimeSpan(
                        m_InternalObject.Subtract( WrapperHelper.UnwrapObject < TimeSpan >( a[0] ) ) ),
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(format)",
                    a => new BSObject( m_InternalObject.ToString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(format, formatProvider)",
                    a => new BSObject(
                        m_InternalObject.ToString(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < IFormatProvider >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
