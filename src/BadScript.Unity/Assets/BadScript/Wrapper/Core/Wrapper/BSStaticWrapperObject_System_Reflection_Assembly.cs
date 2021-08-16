using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Reflection_Assembly : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Reflection_Assembly() : base( typeof( Assembly ) )
        {
            m_StaticProperties["CreateQualifiedName"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateQualifiedName(assemblyName, typeName)",
                    a => new BSObject(
                        Assembly.CreateQualifiedName(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetEntryAssembly"] = new BSFunctionReference(
                new BSFunction(
                    "function GetEntryAssembly()",
                    a => new BSWrapperObject_System_Reflection_Assembly( Assembly.GetEntryAssembly() ),
                    0 ) );

            m_StaticProperties["LoadFrom"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFrom(assemblyFile)",
                    a => new BSWrapperObject_System_Reflection_Assembly(
                        Assembly.LoadFrom( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["UnsafeLoadFrom"] = new BSFunctionReference(
                new BSFunction(
                    "function UnsafeLoadFrom(assemblyFile)",
                    a => new BSWrapperObject_System_Reflection_Assembly(
                        Assembly.UnsafeLoadFrom( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadFile"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadFile(path)",
                    a => new BSWrapperObject_System_Reflection_Assembly(
                        Assembly.LoadFile( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Load"] = new BSFunctionReference(
                new BSFunction(
                    "function Load(assemblyString)",
                    a => new BSWrapperObject_System_Reflection_Assembly(
                        Assembly.Load( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Load"] = new BSFunctionReference(
                new BSFunction(
                    "function Load(assemblyRef)",
                    a => new BSWrapperObject_System_Reflection_Assembly(
                        Assembly.Load( WrapperHelper.UnwrapObject < AssemblyName >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ReflectionOnlyLoad"] = new BSFunctionReference(
                new BSFunction(
                    "function ReflectionOnlyLoad(assemblyString)",
                    a => new BSWrapperObject_System_Reflection_Assembly(
                        Assembly.ReflectionOnlyLoad( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ReflectionOnlyLoadFrom"] = new BSFunctionReference(
                new BSFunction(
                    "function ReflectionOnlyLoadFrom(assemblyFile)",
                    a => new BSWrapperObject_System_Reflection_Assembly(
                        Assembly.ReflectionOnlyLoadFrom( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadWithPartialName"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadWithPartialName(partialName)",
                    a => new BSWrapperObject_System_Reflection_Assembly(
                        Assembly.LoadWithPartialName( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetExecutingAssembly"] = new BSFunctionReference(
                new BSFunction(
                    "function GetExecutingAssembly()",
                    a => new BSWrapperObject_System_Reflection_Assembly( Assembly.GetExecutingAssembly() ),
                    0 ) );

            m_StaticProperties["GetCallingAssembly"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCallingAssembly()",
                    a => new BSWrapperObject_System_Reflection_Assembly( Assembly.GetCallingAssembly() ),
                    0 ) );

        }

        #endregion
    }

}
