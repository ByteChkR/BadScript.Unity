using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Reflection_AssemblyName : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Reflection_AssemblyName() : base(typeof(System.Reflection.AssemblyName))
        {
            m_StaticProperties["ReferenceMatchesDefinition"] = new BSFunctionReference(new BSFunction("function ReferenceMatchesDefinition(reference, definition)", a => System.Reflection.AssemblyName.ReferenceMatchesDefinition(WrapperHelper.UnwrapObject<System.Reflection.AssemblyName>(a[0]), WrapperHelper.UnwrapObject<System.Reflection.AssemblyName>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["GetAssemblyName"] = new BSFunctionReference(new BSFunction("function GetAssemblyName(assemblyFile)", a => new BSWrapperObject_System_Reflection_AssemblyName(System.Reflection.AssemblyName.GetAssemblyName(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));

        }
    }

}