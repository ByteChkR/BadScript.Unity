using System.Globalization;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Globalization_CultureInfo : BSWrapperObject < CultureInfo >

    {
        #region Public

        public BSWrapperObject_System_Globalization_CultureInfo( CultureInfo obj ) : base( obj )
        {
            m_Properties["IetfLanguageTag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.IetfLanguageTag ),
                null );

            m_Properties["KeyboardLayoutId"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.KeyboardLayoutId ),
                null );

            m_Properties["LCID"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.LCID ),
                null );

            m_Properties["Name"] = new BSReflectionReference( () => new BSObject( m_InternalObject.Name ), null );

            m_Properties["NativeName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.NativeName ),
                null );

            m_Properties["Calendar"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_Calendar( m_InternalObject.Calendar ),
                null );

            m_Properties["Parent"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_CultureInfo( m_InternalObject.Parent ),
                null );

            m_Properties["TextInfo"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_TextInfo( m_InternalObject.TextInfo ),
                null );

            m_Properties["ThreeLetterISOLanguageName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.ThreeLetterISOLanguageName ),
                null );

            m_Properties["ThreeLetterWindowsLanguageName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.ThreeLetterWindowsLanguageName ),
                null );

            m_Properties["TwoLetterISOLanguageName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.TwoLetterISOLanguageName ),
                null );

            m_Properties["UseUserOverride"] = new BSReflectionReference(
                () => m_InternalObject.UseUserOverride ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["CompareInfo"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_CompareInfo( m_InternalObject.CompareInfo ),
                null );

            m_Properties["IsNeutralCulture"] = new BSReflectionReference(
                () => m_InternalObject.IsNeutralCulture ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["NumberFormat"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_NumberFormatInfo( m_InternalObject.NumberFormat ),
                x => m_InternalObject.NumberFormat = WrapperHelper.UnwrapObject < NumberFormatInfo >( x ) );

            m_Properties["DateTimeFormat"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Globalization_DateTimeFormatInfo( m_InternalObject.DateTimeFormat ),
                x => m_InternalObject.DateTimeFormat = WrapperHelper.UnwrapObject < DateTimeFormatInfo >( x ) );

            m_Properties["DisplayName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.DisplayName ),
                null );

            m_Properties["EnglishName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.EnglishName ),
                null );

            m_Properties["IsReadOnly"] = new BSReflectionReference(
                () => m_InternalObject.IsReadOnly ? BSObject.One : BSObject.Zero,
                null );

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
