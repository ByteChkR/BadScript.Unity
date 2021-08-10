using System.Text;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Text_Encoding : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Text_Encoding() : base( typeof( Encoding ) )
        {
            m_StaticProperties["ASCII"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Text_Encoding( Encoding.ASCII ),
                null );

            m_StaticProperties["Default"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Text_Encoding( Encoding.Default ),
                null );

            m_StaticProperties["Unicode"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Text_Encoding( Encoding.Unicode ),
                null );

            m_StaticProperties["BigEndianUnicode"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Text_Encoding( Encoding.BigEndianUnicode ),
                null );

            m_StaticProperties["UTF7"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Text_Encoding( Encoding.UTF7 ),
                null );

            m_StaticProperties["UTF8"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Text_Encoding( Encoding.UTF8 ),
                null );

            m_StaticProperties["UTF32"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Text_Encoding( Encoding.UTF32 ),
                null );

            m_StaticProperties["GetEncoding"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEncoding(codepage)",
                    a => new BSWrapperObject_System_Text_Encoding(
                        Encoding.GetEncoding( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetEncoding"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEncoding(codepage, encoderFallback, decoderFallback)",
                    a => new BSWrapperObject_System_Text_Encoding(
                        Encoding.GetEncoding(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < EncoderFallback >( a[1] ),
                            WrapperHelper.UnwrapObject < DecoderFallback >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["GetEncoding"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEncoding(name)",
                    a => new BSWrapperObject_System_Text_Encoding(
                        Encoding.GetEncoding( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetEncoding"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEncoding(name, encoderFallback, decoderFallback)",
                    a => new BSWrapperObject_System_Text_Encoding(
                        Encoding.GetEncoding(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < EncoderFallback >( a[1] ),
                            WrapperHelper.UnwrapObject < DecoderFallback >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}
