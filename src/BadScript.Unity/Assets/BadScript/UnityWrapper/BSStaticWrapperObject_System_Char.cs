using System.Globalization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Char : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Char() : base( typeof( char ) )
        {
            m_StaticProperties["MaxValue"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Char( char.MaxValue ),
                null );

            m_StaticProperties["MinValue"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Char( char.MinValue ),
                null );

            m_StaticProperties["ToString"] = new BSFunctionReference(
                new BSFunction(
                    "function ToString(c)",
                    a => new BSObject( char.ToString( WrapperHelper.UnwrapObject < char >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Parse"] = new BSFunctionReference(
                new BSFunction(
                    "function Parse(s)",
                    a => new BSWrapperObject_System_Char( char.Parse( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["IsDigit"] = new BSFunctionReference(
                new BSFunction(
                    "function IsDigit(c)",
                    a => char.IsDigit( WrapperHelper.UnwrapObject < char >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsLetter"] = new BSFunctionReference(
                new BSFunction(
                    "function IsLetter(c)",
                    a => char.IsLetter( WrapperHelper.UnwrapObject < char >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsWhiteSpace"] = new BSFunctionReference(
                new BSFunction(
                    "function IsWhiteSpace(c)",
                    a => char.IsWhiteSpace( WrapperHelper.UnwrapObject < char >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsUpper"] = new BSFunctionReference(
                new BSFunction(
                    "function IsUpper(c)",
                    a => char.IsUpper( WrapperHelper.UnwrapObject < char >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsLower"] = new BSFunctionReference(
                new BSFunction(
                    "function IsLower(c)",
                    a => char.IsLower( WrapperHelper.UnwrapObject < char >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsPunctuation"] = new BSFunctionReference(
                new BSFunction(
                    "function IsPunctuation(c)",
                    a => char.IsPunctuation( WrapperHelper.UnwrapObject < char >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsLetterOrDigit"] = new BSFunctionReference(
                new BSFunction(
                    "function IsLetterOrDigit(c)",
                    a => char.IsLetterOrDigit( WrapperHelper.UnwrapObject < char >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["ToUpper"] = new BSFunctionReference(
                new BSFunction(
                    "function ToUpper(c, culture)",
                    a => new BSWrapperObject_System_Char(
                        char.ToUpper(
                            WrapperHelper.UnwrapObject < char >( a[0] ),
                            WrapperHelper.UnwrapObject < CultureInfo >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["ToUpper"] = new BSFunctionReference(
                new BSFunction(
                    "function ToUpper(c)",
                    a => new BSWrapperObject_System_Char( char.ToUpper( WrapperHelper.UnwrapObject < char >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ToUpperInvariant"] = new BSFunctionReference(
                new BSFunction(
                    "function ToUpperInvariant(c)",
                    a => new BSWrapperObject_System_Char(
                        char.ToUpperInvariant( WrapperHelper.UnwrapObject < char >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ToLower"] = new BSFunctionReference(
                new BSFunction(
                    "function ToLower(c, culture)",
                    a => new BSWrapperObject_System_Char(
                        char.ToLower(
                            WrapperHelper.UnwrapObject < char >( a[0] ),
                            WrapperHelper.UnwrapObject < CultureInfo >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["ToLower"] = new BSFunctionReference(
                new BSFunction(
                    "function ToLower(c)",
                    a => new BSWrapperObject_System_Char( char.ToLower( WrapperHelper.UnwrapObject < char >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ToLowerInvariant"] = new BSFunctionReference(
                new BSFunction(
                    "function ToLowerInvariant(c)",
                    a => new BSWrapperObject_System_Char(
                        char.ToLowerInvariant( WrapperHelper.UnwrapObject < char >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["IsControl"] = new BSFunctionReference(
                new BSFunction(
                    "function IsControl(c)",
                    a => char.IsControl( WrapperHelper.UnwrapObject < char >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsControl"] = new BSFunctionReference(
                new BSFunction(
                    "function IsControl(s, index)",
                    a => char.IsControl(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsDigit"] = new BSFunctionReference(
                new BSFunction(
                    "function IsDigit(s, index)",
                    a => char.IsDigit(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsLetter"] = new BSFunctionReference(
                new BSFunction(
                    "function IsLetter(s, index)",
                    a => char.IsLetter(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsLetterOrDigit"] = new BSFunctionReference(
                new BSFunction(
                    "function IsLetterOrDigit(s, index)",
                    a => char.IsLetterOrDigit(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsLower"] = new BSFunctionReference(
                new BSFunction(
                    "function IsLower(s, index)",
                    a => char.IsLower(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsNumber"] = new BSFunctionReference(
                new BSFunction(
                    "function IsNumber(c)",
                    a => char.IsNumber( WrapperHelper.UnwrapObject < char >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsNumber"] = new BSFunctionReference(
                new BSFunction(
                    "function IsNumber(s, index)",
                    a => char.IsNumber(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsPunctuation"] = new BSFunctionReference(
                new BSFunction(
                    "function IsPunctuation(s, index)",
                    a => char.IsPunctuation(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsSeparator"] = new BSFunctionReference(
                new BSFunction(
                    "function IsSeparator(c)",
                    a => char.IsSeparator( WrapperHelper.UnwrapObject < char >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsSeparator"] = new BSFunctionReference(
                new BSFunction(
                    "function IsSeparator(s, index)",
                    a => char.IsSeparator(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsSurrogate"] = new BSFunctionReference(
                new BSFunction(
                    "function IsSurrogate(c)",
                    a => char.IsSurrogate( WrapperHelper.UnwrapObject < char >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsSurrogate"] = new BSFunctionReference(
                new BSFunction(
                    "function IsSurrogate(s, index)",
                    a => char.IsSurrogate(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsSymbol"] = new BSFunctionReference(
                new BSFunction(
                    "function IsSymbol(c)",
                    a => char.IsSymbol( WrapperHelper.UnwrapObject < char >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsSymbol"] = new BSFunctionReference(
                new BSFunction(
                    "function IsSymbol(s, index)",
                    a => char.IsSymbol(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsUpper"] = new BSFunctionReference(
                new BSFunction(
                    "function IsUpper(s, index)",
                    a => char.IsUpper(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsWhiteSpace"] = new BSFunctionReference(
                new BSFunction(
                    "function IsWhiteSpace(s, index)",
                    a => char.IsWhiteSpace(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["GetNumericValue"] = new BSFunctionReference(
                new BSFunction(
                    "function GetNumericValue(c)",
                    a => new BSObject(
                        ( decimal ) char.GetNumericValue( WrapperHelper.UnwrapObject < char >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetNumericValue"] = new BSFunctionReference(
                new BSFunction(
                    "function GetNumericValue(s, index)",
                    a => new BSObject(
                        ( decimal ) char.GetNumericValue(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["IsHighSurrogate"] = new BSFunctionReference(
                new BSFunction(
                    "function IsHighSurrogate(c)",
                    a => char.IsHighSurrogate( WrapperHelper.UnwrapObject < char >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsHighSurrogate"] = new BSFunctionReference(
                new BSFunction(
                    "function IsHighSurrogate(s, index)",
                    a => char.IsHighSurrogate(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsLowSurrogate"] = new BSFunctionReference(
                new BSFunction(
                    "function IsLowSurrogate(c)",
                    a => char.IsLowSurrogate( WrapperHelper.UnwrapObject < char >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsLowSurrogate"] = new BSFunctionReference(
                new BSFunction(
                    "function IsLowSurrogate(s, index)",
                    a => char.IsLowSurrogate(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsSurrogatePair"] = new BSFunctionReference(
                new BSFunction(
                    "function IsSurrogatePair(s, index)",
                    a => char.IsSurrogatePair(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsSurrogatePair"] = new BSFunctionReference(
                new BSFunction(
                    "function IsSurrogatePair(highSurrogate, lowSurrogate)",
                    a => char.IsSurrogatePair(
                        WrapperHelper.UnwrapObject < char >( a[0] ),
                        WrapperHelper.UnwrapObject < char >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["ConvertFromUtf32"] = new BSFunctionReference(
                new BSFunction(
                    "function ConvertFromUtf32(utf32)",
                    a => new BSObject( char.ConvertFromUtf32( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ConvertToUtf32"] = new BSFunctionReference(
                new BSFunction(
                    "function ConvertToUtf32(highSurrogate, lowSurrogate)",
                    a => new BSObject(
                        ( decimal ) char.ConvertToUtf32(
                            WrapperHelper.UnwrapObject < char >( a[0] ),
                            WrapperHelper.UnwrapObject < char >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["ConvertToUtf32"] = new BSFunctionReference(
                new BSFunction(
                    "function ConvertToUtf32(s, index)",
                    a => new BSObject(
                        ( decimal ) char.ConvertToUtf32(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
