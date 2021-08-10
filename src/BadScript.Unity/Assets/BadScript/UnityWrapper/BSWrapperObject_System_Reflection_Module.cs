using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Reflection_Module : BSWrapperObject < Module >

    {
        #region Public

        public BSWrapperObject_System_Reflection_Module( Module obj ) : base( obj )
        {
            m_Properties["ModuleHandle"] = new BSReflectionReference(
                () => new BSWrapperObject_System_ModuleHandle( m_InternalObject.ModuleHandle ),
                null );

            m_Properties["Assembly"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_Assembly( m_InternalObject.Assembly ),
                null );

            m_Properties["Name"] = new BSReflectionReference( () => new BSObject( m_InternalObject.Name ), null );

            m_Properties["ScopeName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.ScopeName ),
                null );

            m_Properties["MDStreamVersion"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MDStreamVersion ),
                null );

            m_Properties["ModuleVersionId"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Guid( m_InternalObject.ModuleVersionId ),
                null );

            m_Properties["FullyQualifiedName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.FullyQualifiedName ),
                null );

            m_Properties["MetadataToken"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MetadataToken ),
                null );

            m_Properties["GetField"] = new BSFunctionReference(
                new BSFunction(
                    "function GetField(name)",
                    a => new BSWrapperObject_System_Reflection_FieldInfo(
                        m_InternalObject.GetField( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetMethod"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMethod(name)",
                    a => new BSWrapperObject_System_Reflection_MethodInfo(
                        m_InternalObject.GetMethod( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["ResolveField"] = new BSFunctionReference(
                new BSFunction(
                    "function ResolveField(metadataToken)",
                    a => new BSWrapperObject_System_Reflection_FieldInfo(
                        m_InternalObject.ResolveField( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["ResolveMember"] = new BSFunctionReference(
                new BSFunction(
                    "function ResolveMember(metadataToken)",
                    a => new BSWrapperObject_System_Reflection_MemberInfo(
                        m_InternalObject.ResolveMember( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["ResolveMethod"] = new BSFunctionReference(
                new BSFunction(
                    "function ResolveMethod(metadataToken)",
                    a => new BSWrapperObject_System_Reflection_MethodBase(
                        m_InternalObject.ResolveMethod( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(o)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ResolveString"] = new BSFunctionReference(
                new BSFunction(
                    "function ResolveString(metadataToken)",
                    a => new BSObject( m_InternalObject.ResolveString( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}