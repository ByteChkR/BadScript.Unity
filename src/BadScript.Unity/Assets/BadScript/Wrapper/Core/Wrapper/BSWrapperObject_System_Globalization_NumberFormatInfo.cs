using System.Globalization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Globalization_NumberFormatInfo : BSWrapperObject < NumberFormatInfo >

    {
        #region Public

        public BSWrapperObject_System_Globalization_NumberFormatInfo( NumberFormatInfo obj ) : base( obj )
        {
            m_Properties["CurrencyDecimalDigits"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.CurrencyDecimalDigits ),
                x => m_InternalObject.CurrencyDecimalDigits = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["CurrencyDecimalSeparator"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.CurrencyDecimalSeparator ),
                x => m_InternalObject.CurrencyDecimalSeparator = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["IsReadOnly"] = new BSReflectionReference(
                () => m_InternalObject.IsReadOnly ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["CurrencyGroupSeparator"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.CurrencyGroupSeparator ),
                x => m_InternalObject.CurrencyGroupSeparator = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["CurrencySymbol"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.CurrencySymbol ),
                x => m_InternalObject.CurrencySymbol = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["NaNSymbol"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.NaNSymbol ),
                x => m_InternalObject.NaNSymbol = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["CurrencyNegativePattern"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.CurrencyNegativePattern ),
                x => m_InternalObject.CurrencyNegativePattern = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["NumberNegativePattern"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.NumberNegativePattern ),
                x => m_InternalObject.NumberNegativePattern = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["PercentPositivePattern"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.PercentPositivePattern ),
                x => m_InternalObject.PercentPositivePattern = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["PercentNegativePattern"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.PercentNegativePattern ),
                x => m_InternalObject.PercentNegativePattern = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["NegativeInfinitySymbol"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.NegativeInfinitySymbol ),
                x => m_InternalObject.NegativeInfinitySymbol = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["NegativeSign"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.NegativeSign ),
                x => m_InternalObject.NegativeSign = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["NumberDecimalDigits"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.NumberDecimalDigits ),
                x => m_InternalObject.NumberDecimalDigits = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["NumberDecimalSeparator"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.NumberDecimalSeparator ),
                x => m_InternalObject.NumberDecimalSeparator = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["NumberGroupSeparator"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.NumberGroupSeparator ),
                x => m_InternalObject.NumberGroupSeparator = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["CurrencyPositivePattern"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.CurrencyPositivePattern ),
                x => m_InternalObject.CurrencyPositivePattern = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["PositiveInfinitySymbol"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.PositiveInfinitySymbol ),
                x => m_InternalObject.PositiveInfinitySymbol = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["PositiveSign"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.PositiveSign ),
                x => m_InternalObject.PositiveSign = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["PercentDecimalDigits"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.PercentDecimalDigits ),
                x => m_InternalObject.PercentDecimalDigits = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["PercentDecimalSeparator"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.PercentDecimalSeparator ),
                x => m_InternalObject.PercentDecimalSeparator = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["PercentGroupSeparator"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.PercentGroupSeparator ),
                x => m_InternalObject.PercentGroupSeparator = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["PercentSymbol"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.PercentSymbol ),
                x => m_InternalObject.PercentSymbol = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["PerMilleSymbol"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.PerMilleSymbol ),
                x => m_InternalObject.PerMilleSymbol = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["Clone"] = new BSFunctionReference(
                new BSFunction(
                    "function Clone()",
                    a => new BSWrapperObject_System_Object( m_InternalObject.Clone() ),
                    0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}
