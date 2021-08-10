using System.Text;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Text_Encoding : BSWrapperObject < Encoding >

    {
        #region Public

        public BSWrapperObject_System_Text_Encoding( Encoding obj ) : base( obj )
        {
            m_Properties["BodyName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.BodyName ),
                null );

            m_Properties["EncodingName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.EncodingName ),
                null );

            m_Properties["HeaderName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.HeaderName ),
                null );

            m_Properties["WebName"] = new BSReflectionReference( () => new BSObject( m_InternalObject.WebName ), null );

            m_Properties["WindowsCodePage"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.WindowsCodePage ),
                null );

            m_Properties["IsBrowserDisplay"] = new BSReflectionReference(
                () => m_InternalObject.IsBrowserDisplay ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsBrowserSave"] = new BSReflectionReference(
                () => m_InternalObject.IsBrowserSave ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsMailNewsDisplay"] = new BSReflectionReference(
                () => m_InternalObject.IsMailNewsDisplay ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsMailNewsSave"] = new BSReflectionReference(
                () => m_InternalObject.IsMailNewsSave ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsSingleByte"] = new BSReflectionReference(
                () => m_InternalObject.IsSingleByte ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["EncoderFallback"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Text_EncoderFallback( m_InternalObject.EncoderFallback ),
                x => m_InternalObject.EncoderFallback = WrapperHelper.UnwrapObject < EncoderFallback >( x ) );

            m_Properties["DecoderFallback"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Text_DecoderFallback( m_InternalObject.DecoderFallback ),
                x => m_InternalObject.DecoderFallback = WrapperHelper.UnwrapObject < DecoderFallback >( x ) );

            m_Properties["IsReadOnly"] = new BSReflectionReference(
                () => m_InternalObject.IsReadOnly ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["CodePage"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.CodePage ),
                null );

            m_Properties["GetByteCount"] = new BSFunctionReference(
                new BSFunction(
                    "function GetByteCount(s)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetByteCount( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetMaxByteCount"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMaxByteCount(charCount)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetMaxByteCount( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetMaxCharCount"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMaxCharCount(byteCount)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetMaxCharCount( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(value)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
