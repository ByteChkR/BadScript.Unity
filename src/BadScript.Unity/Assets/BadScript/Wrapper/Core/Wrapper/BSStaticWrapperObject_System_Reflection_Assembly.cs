using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Reflection_Assembly : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Reflection_Assembly() : base(typeof(System.Reflection.Assembly))
        {
            m_StaticProperties["CreateQualifiedName"] = new BSFunctionReference(new BSFunction("function CreateQualifiedName(assemblyName, typeName)", a => new BSObject(System.Reflection.Assembly.CreateQualifiedName(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]))), 2));
            m_StaticProperties["GetEntryAssembly"] = new BSFunctionReference(new BSFunction("function GetEntryAssembly()", a => new BSWrapperObject_System_Reflection_Assembly(System.Reflection.Assembly.GetEntryAssembly()), 0));
            m_StaticProperties["LoadFrom"] = new BSFunctionReference(new BSFunction("function LoadFrom(assemblyFile)", a => new BSWrapperObject_System_Reflection_Assembly(System.Reflection.Assembly.LoadFrom(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["UnsafeLoadFrom"] = new BSFunctionReference(new BSFunction("function UnsafeLoadFrom(assemblyFile)", a => new BSWrapperObject_System_Reflection_Assembly(System.Reflection.Assembly.UnsafeLoadFrom(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["LoadFile"] = new BSFunctionReference(new BSFunction("function LoadFile(path)", a => new BSWrapperObject_System_Reflection_Assembly(System.Reflection.Assembly.LoadFile(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["Load"] = new BSFunctionReference(new BSFunction("function Load(assemblyString)", a => new BSWrapperObject_System_Reflection_Assembly(System.Reflection.Assembly.Load(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["Load"] = new BSFunctionReference(new BSFunction("function Load(assemblyRef)", a => new BSWrapperObject_System_Reflection_Assembly(System.Reflection.Assembly.Load(WrapperHelper.UnwrapObject<System.Reflection.AssemblyName>(a[0]))), 1));
            m_StaticProperties["ReflectionOnlyLoad"] = new BSFunctionReference(new BSFunction("function ReflectionOnlyLoad(assemblyString)", a => new BSWrapperObject_System_Reflection_Assembly(System.Reflection.Assembly.ReflectionOnlyLoad(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["ReflectionOnlyLoadFrom"] = new BSFunctionReference(new BSFunction("function ReflectionOnlyLoadFrom(assemblyFile)", a => new BSWrapperObject_System_Reflection_Assembly(System.Reflection.Assembly.ReflectionOnlyLoadFrom(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["LoadWithPartialName"] = new BSFunctionReference(new BSFunction("function LoadWithPartialName(partialName)", a => new BSWrapperObject_System_Reflection_Assembly(System.Reflection.Assembly.LoadWithPartialName(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["GetExecutingAssembly"] = new BSFunctionReference(new BSFunction("function GetExecutingAssembly()", a => new BSWrapperObject_System_Reflection_Assembly(System.Reflection.Assembly.GetExecutingAssembly()), 0));
            m_StaticProperties["GetCallingAssembly"] = new BSFunctionReference(new BSFunction("function GetCallingAssembly()", a => new BSWrapperObject_System_Reflection_Assembly(System.Reflection.Assembly.GetCallingAssembly()), 0));

        }
    }

}