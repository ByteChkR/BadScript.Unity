using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Uri : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Uri() : base( typeof( Uri ) )
        {
            m_StaticProperties["UriSchemeFile"] = new BSReflectionReference(
                () => new BSObject( Uri.UriSchemeFile ),
                null );

            m_StaticProperties["UriSchemeFtp"] =
                new BSReflectionReference( () => new BSObject( Uri.UriSchemeFtp ), null );

            m_StaticProperties["UriSchemeGopher"] = new BSReflectionReference(
                () => new BSObject( Uri.UriSchemeGopher ),
                null );

            m_StaticProperties["UriSchemeHttp"] = new BSReflectionReference(
                () => new BSObject( Uri.UriSchemeHttp ),
                null );

            m_StaticProperties["UriSchemeHttps"] = new BSReflectionReference(
                () => new BSObject( Uri.UriSchemeHttps ),
                null );

            m_StaticProperties["UriSchemeMailto"] = new BSReflectionReference(
                () => new BSObject( Uri.UriSchemeMailto ),
                null );

            m_StaticProperties["UriSchemeNews"] = new BSReflectionReference(
                () => new BSObject( Uri.UriSchemeNews ),
                null );

            m_StaticProperties["UriSchemeNntp"] = new BSReflectionReference(
                () => new BSObject( Uri.UriSchemeNntp ),
                null );

            m_StaticProperties["UriSchemeNetTcp"] = new BSReflectionReference(
                () => new BSObject( Uri.UriSchemeNetTcp ),
                null );

            m_StaticProperties["UriSchemeNetPipe"] = new BSReflectionReference(
                () => new BSObject( Uri.UriSchemeNetPipe ),
                null );

            m_StaticProperties["SchemeDelimiter"] = new BSReflectionReference(
                () => new BSObject( Uri.SchemeDelimiter ),
                null );

            m_StaticProperties["HexEscape"] = new BSFunctionReference(
                new BSFunction(
                    "function HexEscape(character)",
                    a => new BSObject( Uri.HexEscape( WrapperHelper.UnwrapObject < char >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["IsHexEncoding"] = new BSFunctionReference(
                new BSFunction(
                    "function IsHexEncoding(pattern, index)",
                    a => Uri.IsHexEncoding(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["CheckSchemeName"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckSchemeName(schemeName)",
                    a => Uri.CheckSchemeName( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsHexDigit"] = new BSFunctionReference(
                new BSFunction(
                    "function IsHexDigit(character)",
                    a => Uri.IsHexDigit( WrapperHelper.UnwrapObject < char >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["FromHex"] = new BSFunctionReference(
                new BSFunction(
                    "function FromHex(digit)",
                    a => new BSObject( ( decimal ) Uri.FromHex( WrapperHelper.UnwrapObject < char >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["UnescapeDataString"] = new BSFunctionReference(
                new BSFunction(
                    "function UnescapeDataString(stringToUnescape)",
                    a => new BSObject( Uri.UnescapeDataString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["EscapeUriString"] = new BSFunctionReference(
                new BSFunction(
                    "function EscapeUriString(stringToEscape)",
                    a => new BSObject( Uri.EscapeUriString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["EscapeDataString"] = new BSFunctionReference(
                new BSFunction(
                    "function EscapeDataString(stringToEscape)",
                    a => new BSObject( Uri.EscapeDataString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
