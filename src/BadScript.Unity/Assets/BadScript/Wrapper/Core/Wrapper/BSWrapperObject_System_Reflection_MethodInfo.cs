using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_System_Reflection_MethodInfo : BSWrapperObject < MethodInfo >

    {
        #region Public

        public BSWrapperObject_System_Reflection_MethodInfo( MethodInfo obj ) : base( obj )
        {
            m_Properties["ReturnParameter"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_ParameterInfo( m_InternalObject.ReturnParameter ),
                null );

            m_Properties["ReturnTypeCustomAttributes"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_ICustomAttributeProvider(
                    m_InternalObject.ReturnTypeCustomAttributes ),
                null );

            m_Properties["MethodHandle"] = new BSReflectionReference(
                () => new BSWrapperObject_System_RuntimeMethodHandle( m_InternalObject.MethodHandle ),
                null );

            m_Properties["IsGenericMethodDefinition"] = new BSReflectionReference(
                () => m_InternalObject.IsGenericMethodDefinition ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["ContainsGenericParameters"] = new BSReflectionReference(
                () => m_InternalObject.ContainsGenericParameters ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsGenericMethod"] = new BSReflectionReference(
                () => m_InternalObject.IsGenericMethod ? BSObject.One : BSObject.Zero,
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

            m_Properties["IsStatic"] = new BSReflectionReference(
                () => m_InternalObject.IsStatic ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsFinal"] = new BSReflectionReference(
                () => m_InternalObject.IsFinal ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsVirtual"] = new BSReflectionReference(
                () => m_InternalObject.IsVirtual ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsHideBySig"] = new BSReflectionReference(
                () => m_InternalObject.IsHideBySig ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsAbstract"] = new BSReflectionReference(
                () => m_InternalObject.IsAbstract ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsSpecialName"] = new BSReflectionReference(
                () => m_InternalObject.IsSpecialName ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsConstructor"] = new BSReflectionReference(
                () => m_InternalObject.IsConstructor ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["Name"] = new BSReflectionReference( () => new BSObject( m_InternalObject.Name ), null );

            m_Properties["MetadataToken"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MetadataToken ),
                null );

            m_Properties["Module"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_Module( m_InternalObject.Module ),
                null );

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

            m_Properties["GetBaseDefinition"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBaseDefinition()",
                    a => new BSWrapperObject_System_Reflection_MethodInfo( m_InternalObject.GetBaseDefinition() ),
                    0 ) );

            m_Properties["GetGenericMethodDefinition"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGenericMethodDefinition()",
                    a => new BSWrapperObject_System_Reflection_MethodInfo(
                        m_InternalObject.GetGenericMethodDefinition() ),
                    0 ) );

            m_Properties["GetMethodBody"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMethodBody()",
                    a => new BSWrapperObject_System_Reflection_MethodBody( m_InternalObject.GetMethodBody() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}
