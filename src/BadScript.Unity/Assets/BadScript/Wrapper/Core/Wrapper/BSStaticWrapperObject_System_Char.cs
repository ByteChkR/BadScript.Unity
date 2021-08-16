using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Char : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Char() : base(typeof(System.Char))
        {
            m_StaticProperties["MaxValue"] = new BSReflectionReference(() => new BSWrapperObject_System_Char(System.Char.MaxValue), null);
            m_StaticProperties["MinValue"] = new BSReflectionReference(() => new BSWrapperObject_System_Char(System.Char.MinValue), null);
            m_StaticProperties["ToString"] = new BSFunctionReference(new BSFunction("function ToString(c)", a => new BSObject(System.Char.ToString(WrapperHelper.UnwrapObject<System.Char>(a[0]))), 1));
            m_StaticProperties["Parse"] = new BSFunctionReference(new BSFunction("function Parse(s)", a => new BSWrapperObject_System_Char(System.Char.Parse(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["IsDigit"] = new BSFunctionReference(new BSFunction("function IsDigit(c)", a => System.Char.IsDigit(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsLetter"] = new BSFunctionReference(new BSFunction("function IsLetter(c)", a => System.Char.IsLetter(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsWhiteSpace"] = new BSFunctionReference(new BSFunction("function IsWhiteSpace(c)", a => System.Char.IsWhiteSpace(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsUpper"] = new BSFunctionReference(new BSFunction("function IsUpper(c)", a => System.Char.IsUpper(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsLower"] = new BSFunctionReference(new BSFunction("function IsLower(c)", a => System.Char.IsLower(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsPunctuation"] = new BSFunctionReference(new BSFunction("function IsPunctuation(c)", a => System.Char.IsPunctuation(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsLetterOrDigit"] = new BSFunctionReference(new BSFunction("function IsLetterOrDigit(c)", a => System.Char.IsLetterOrDigit(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["ToUpper"] = new BSFunctionReference(new BSFunction("function ToUpper(c, culture)", a => new BSWrapperObject_System_Char(System.Char.ToUpper(WrapperHelper.UnwrapObject<System.Char>(a[0]), WrapperHelper.UnwrapObject<System.Globalization.CultureInfo>(a[1]))), 2));
            m_StaticProperties["ToUpper"] = new BSFunctionReference(new BSFunction("function ToUpper(c)", a => new BSWrapperObject_System_Char(System.Char.ToUpper(WrapperHelper.UnwrapObject<System.Char>(a[0]))), 1));
            m_StaticProperties["ToUpperInvariant"] = new BSFunctionReference(new BSFunction("function ToUpperInvariant(c)", a => new BSWrapperObject_System_Char(System.Char.ToUpperInvariant(WrapperHelper.UnwrapObject<System.Char>(a[0]))), 1));
            m_StaticProperties["ToLower"] = new BSFunctionReference(new BSFunction("function ToLower(c, culture)", a => new BSWrapperObject_System_Char(System.Char.ToLower(WrapperHelper.UnwrapObject<System.Char>(a[0]), WrapperHelper.UnwrapObject<System.Globalization.CultureInfo>(a[1]))), 2));
            m_StaticProperties["ToLower"] = new BSFunctionReference(new BSFunction("function ToLower(c)", a => new BSWrapperObject_System_Char(System.Char.ToLower(WrapperHelper.UnwrapObject<System.Char>(a[0]))), 1));
            m_StaticProperties["ToLowerInvariant"] = new BSFunctionReference(new BSFunction("function ToLowerInvariant(c)", a => new BSWrapperObject_System_Char(System.Char.ToLowerInvariant(WrapperHelper.UnwrapObject<System.Char>(a[0]))), 1));
            m_StaticProperties["IsControl"] = new BSFunctionReference(new BSFunction("function IsControl(c)", a => System.Char.IsControl(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsControl"] = new BSFunctionReference(new BSFunction("function IsControl(s, index)", a => System.Char.IsControl(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["IsDigit"] = new BSFunctionReference(new BSFunction("function IsDigit(s, index)", a => System.Char.IsDigit(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["IsLetter"] = new BSFunctionReference(new BSFunction("function IsLetter(s, index)", a => System.Char.IsLetter(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["IsLetterOrDigit"] = new BSFunctionReference(new BSFunction("function IsLetterOrDigit(s, index)", a => System.Char.IsLetterOrDigit(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["IsLower"] = new BSFunctionReference(new BSFunction("function IsLower(s, index)", a => System.Char.IsLower(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["IsNumber"] = new BSFunctionReference(new BSFunction("function IsNumber(c)", a => System.Char.IsNumber(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsNumber"] = new BSFunctionReference(new BSFunction("function IsNumber(s, index)", a => System.Char.IsNumber(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["IsPunctuation"] = new BSFunctionReference(new BSFunction("function IsPunctuation(s, index)", a => System.Char.IsPunctuation(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["IsSeparator"] = new BSFunctionReference(new BSFunction("function IsSeparator(c)", a => System.Char.IsSeparator(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsSeparator"] = new BSFunctionReference(new BSFunction("function IsSeparator(s, index)", a => System.Char.IsSeparator(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["IsSurrogate"] = new BSFunctionReference(new BSFunction("function IsSurrogate(c)", a => System.Char.IsSurrogate(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsSurrogate"] = new BSFunctionReference(new BSFunction("function IsSurrogate(s, index)", a => System.Char.IsSurrogate(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["IsSymbol"] = new BSFunctionReference(new BSFunction("function IsSymbol(c)", a => System.Char.IsSymbol(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsSymbol"] = new BSFunctionReference(new BSFunction("function IsSymbol(s, index)", a => System.Char.IsSymbol(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["IsUpper"] = new BSFunctionReference(new BSFunction("function IsUpper(s, index)", a => System.Char.IsUpper(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["IsWhiteSpace"] = new BSFunctionReference(new BSFunction("function IsWhiteSpace(s, index)", a => System.Char.IsWhiteSpace(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["GetNumericValue"] = new BSFunctionReference(new BSFunction("function GetNumericValue(c)", a => new BSObject((decimal)System.Char.GetNumericValue(WrapperHelper.UnwrapObject<System.Char>(a[0]))), 1));
            m_StaticProperties["GetNumericValue"] = new BSFunctionReference(new BSFunction("function GetNumericValue(s, index)", a => new BSObject((decimal)System.Char.GetNumericValue(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));
            m_StaticProperties["IsHighSurrogate"] = new BSFunctionReference(new BSFunction("function IsHighSurrogate(c)", a => System.Char.IsHighSurrogate(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsHighSurrogate"] = new BSFunctionReference(new BSFunction("function IsHighSurrogate(s, index)", a => System.Char.IsHighSurrogate(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["IsLowSurrogate"] = new BSFunctionReference(new BSFunction("function IsLowSurrogate(c)", a => System.Char.IsLowSurrogate(WrapperHelper.UnwrapObject<System.Char>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["IsLowSurrogate"] = new BSFunctionReference(new BSFunction("function IsLowSurrogate(s, index)", a => System.Char.IsLowSurrogate(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["IsSurrogatePair"] = new BSFunctionReference(new BSFunction("function IsSurrogatePair(s, index)", a => System.Char.IsSurrogatePair(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["IsSurrogatePair"] = new BSFunctionReference(new BSFunction("function IsSurrogatePair(highSurrogate, lowSurrogate)", a => System.Char.IsSurrogatePair(WrapperHelper.UnwrapObject<System.Char>(a[0]), WrapperHelper.UnwrapObject<System.Char>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["ConvertFromUtf32"] = new BSFunctionReference(new BSFunction("function ConvertFromUtf32(utf32)", a => new BSObject(System.Char.ConvertFromUtf32(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_StaticProperties["ConvertToUtf32"] = new BSFunctionReference(new BSFunction("function ConvertToUtf32(highSurrogate, lowSurrogate)", a => new BSObject((decimal)System.Char.ConvertToUtf32(WrapperHelper.UnwrapObject<System.Char>(a[0]), WrapperHelper.UnwrapObject<System.Char>(a[1]))), 2));
            m_StaticProperties["ConvertToUtf32"] = new BSFunctionReference(new BSFunction("function ConvertToUtf32(s, index)", a => new BSObject((decimal)System.Char.ConvertToUtf32(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]))), 2));

        }
    }

}