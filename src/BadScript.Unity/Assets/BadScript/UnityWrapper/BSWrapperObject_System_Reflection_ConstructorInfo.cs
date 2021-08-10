using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Reflection_ConstructorInfo : BSWrapperObject < ConstructorInfo >

    {
        #region Public

        public BSWrapperObject_System_Reflection_ConstructorInfo( ConstructorInfo obj ) : base( obj )
        {
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

        }

        #endregion
    }

}
