using System.Globalization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Globalization_TextInfo : BSWrapperObject < TextInfo >

    {
        #region Public

        public BSWrapperObject_System_Globalization_TextInfo( TextInfo obj ) : base( obj )
        {
            m_Properties["ANSICodePage"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.ANSICodePage ),
                null );

            m_Properties["OEMCodePage"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.OEMCodePage ),
                null );

            m_Properties["MacCodePage"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MacCodePage ),
                null );

            m_Properties["EBCDICCodePage"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.EBCDICCodePage ),
                null );

            m_Properties["LCID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.LCID ),
                null );

            m_Properties["CultureName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.CultureName ),
                null );

            m_Properties["IsReadOnly"] = new BSReflectionReference(
                () => m_InternalObject.IsReadOnly ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["ListSeparator"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.ListSeparator ),
                x => m_InternalObject.ListSeparator = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["IsRightToLeft"] = new BSReflectionReference(
                () => m_InternalObject.IsRightToLeft ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["Clone"] = new BSFunctionReference(
                new BSFunction(
                    "function Clone()",
                    a => new BSWrapperObject_System_Object( m_InternalObject.Clone() ),
                    0 ) );

            m_Properties["ToLower"] = new BSFunctionReference(
                new BSFunction(
                    "function ToLower(c)",
                    a => new BSWrapperObject_System_Char(
                        m_InternalObject.ToLower( WrapperHelper.UnwrapObject < char >( a[0] ) ) ),
                    1 ) );

            m_Properties["ToLower"] = new BSFunctionReference(
                new BSFunction(
                    "function ToLower(str)",
                    a => new BSObject( m_InternalObject.ToLower( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["ToUpper"] = new BSFunctionReference(
                new BSFunction(
                    "function ToUpper(c)",
                    a => new BSWrapperObject_System_Char(
                        m_InternalObject.ToUpper( WrapperHelper.UnwrapObject < char >( a[0] ) ) ),
                    1 ) );

            m_Properties["ToUpper"] = new BSFunctionReference(
                new BSFunction(
                    "function ToUpper(str)",
                    a => new BSObject( m_InternalObject.ToUpper( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

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

            m_Properties["ToTitleCase"] = new BSFunctionReference(
                new BSFunction(
                    "function ToTitleCase(str)",
                    a => new BSObject( m_InternalObject.ToTitleCase( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
