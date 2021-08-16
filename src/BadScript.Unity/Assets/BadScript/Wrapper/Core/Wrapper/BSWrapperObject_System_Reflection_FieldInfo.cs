using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Reflection_FieldInfo : BSWrapperObject < FieldInfo >

    {
        #region Public

        public BSWrapperObject_System_Reflection_FieldInfo( FieldInfo obj ) : base( obj )
        {
            m_Properties["FieldHandle"] = new BSReflectionReference(
                () => new BSWrapperObject_System_RuntimeFieldHandle( m_InternalObject.FieldHandle ),
                null );

            m_Properties["IsLiteral"] = new BSReflectionReference(
                () => m_InternalObject.IsLiteral ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsStatic"] = new BSReflectionReference(
                () => m_InternalObject.IsStatic ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsInitOnly"] = new BSReflectionReference(
                () => m_InternalObject.IsInitOnly ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsPublic"] = new BSReflectionReference(
                () => m_InternalObject.IsPublic ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsPrivate"] = new BSReflectionReference(
                () => m_InternalObject.IsPrivate ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsFamily"] = new BSReflectionReference(
                () => m_InternalObject.IsFamily ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsAssembly"] = new BSReflectionReference(
                () => m_InternalObject.IsAssembly ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsFamilyAndAssembly"] = new BSReflectionReference(
                () => m_InternalObject.IsFamilyAndAssembly ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsFamilyOrAssembly"] = new BSReflectionReference(
                () => m_InternalObject.IsFamilyOrAssembly ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsPinvokeImpl"] = new BSReflectionReference(
                () => m_InternalObject.IsPinvokeImpl ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsSpecialName"] = new BSReflectionReference(
                () => m_InternalObject.IsSpecialName ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsNotSerialized"] = new BSReflectionReference(
                () => m_InternalObject.IsNotSerialized ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsSecurityCritical"] = new BSReflectionReference(
                () => m_InternalObject.IsSecurityCritical ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsSecuritySafeCritical"] = new BSReflectionReference(
                () => m_InternalObject.IsSecuritySafeCritical ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsSecurityTransparent"] = new BSReflectionReference(
                () => m_InternalObject.IsSecurityTransparent ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["Name"] = new BSReflectionReference( () => new BSObject( m_InternalObject.Name ), null );

            m_Properties["MetadataToken"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MetadataToken ),
                null );

            m_Properties["Module"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_Module( m_InternalObject.Module ),
                null );

            m_Properties["GetValue"] = new BSFunctionReference(
                new BSFunction(
                    "function GetValue(obj)",
                    a => new BSWrapperObject_System_Object(
                        m_InternalObject.GetValue( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

            m_Properties["SetValue"] = new BSFunctionReference(
                new BSFunction(
                    "function SetValue(obj, value)",
                    a =>
                    {
                        m_InternalObject.SetValue(
                            WrapperHelper.UnwrapObject < object >( a[0] ),
                            WrapperHelper.UnwrapObject < object >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["GetRawConstantValue"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRawConstantValue()",
                    a => new BSWrapperObject_System_Object( m_InternalObject.GetRawConstantValue() ),
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
