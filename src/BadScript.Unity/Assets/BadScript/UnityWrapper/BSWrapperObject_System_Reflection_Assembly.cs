using System;
using System.Globalization;
using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Reflection_Assembly : BSWrapperObject < Assembly >

    {
        #region Public

        public BSWrapperObject_System_Reflection_Assembly( Assembly obj ) : base( obj )
        {
            m_Properties["CodeBase"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.CodeBase ),
                null );

            m_Properties["EscapedCodeBase"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.EscapedCodeBase ),
                null );

            m_Properties["FullName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.FullName ),
                null );

            m_Properties["EntryPoint"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_MethodInfo( m_InternalObject.EntryPoint ),
                null );

            m_Properties["Location"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.Location ),
                null );

            m_Properties["ImageRuntimeVersion"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.ImageRuntimeVersion ),
                null );

            m_Properties["HostContext"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.HostContext ),
                null );

            m_Properties["ReflectionOnly"] = new BSReflectionReference(
                () => m_InternalObject.ReflectionOnly ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsFullyTrusted"] = new BSReflectionReference(
                () => m_InternalObject.IsFullyTrusted ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["ManifestModule"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_Module( m_InternalObject.ManifestModule ),
                null );

            m_Properties["GlobalAssemblyCache"] = new BSReflectionReference(
                () => m_InternalObject.GlobalAssemblyCache ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["IsDynamic"] = new BSReflectionReference(
                () => m_InternalObject.IsDynamic ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["GetFile"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFile(name)",
                    a => new BSWrapperObject_System_IO_FileStream(
                        m_InternalObject.GetFile( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetManifestResourceStream"] = new BSFunctionReference(
                new BSFunction(
                    "function GetManifestResourceStream(name)",
                    a => new BSWrapperObject_System_IO_Stream(
                        m_InternalObject.GetManifestResourceStream( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetName(copiedName)",
                    a => new BSWrapperObject_System_Reflection_AssemblyName(
                        m_InternalObject.GetName( WrapperHelper.UnwrapObject < bool >( a[0] ) ) ),
                    1 ) );

            m_Properties["CreateInstance"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateInstance(typeName)",
                    a => new BSWrapperObject_System_Object(
                        m_InternalObject.CreateInstance( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["CreateInstance"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateInstance(typeName, ignoreCase)",
                    a => new BSWrapperObject_System_Object(
                        m_InternalObject.CreateInstance(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetManifestResourceInfo"] = new BSFunctionReference(
                new BSFunction(
                    "function GetManifestResourceInfo(resourceName)",
                    a => new BSWrapperObject_System_Reflection_ManifestResourceInfo(
                        m_InternalObject.GetManifestResourceInfo( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(o)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetModule"] = new BSFunctionReference(
                new BSFunction(
                    "function GetModule(name)",
                    a => new BSWrapperObject_System_Reflection_Module(
                        m_InternalObject.GetModule( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetSatelliteAssembly"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSatelliteAssembly(culture)",
                    a => new BSWrapperObject_System_Reflection_Assembly(
                        m_InternalObject.GetSatelliteAssembly( WrapperHelper.UnwrapObject < CultureInfo >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetSatelliteAssembly"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSatelliteAssembly(culture, version)",
                    a => new BSWrapperObject_System_Reflection_Assembly(
                        m_InternalObject.GetSatelliteAssembly(
                            WrapperHelper.UnwrapObject < CultureInfo >( a[0] ),
                            WrapperHelper.UnwrapObject < Version >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
