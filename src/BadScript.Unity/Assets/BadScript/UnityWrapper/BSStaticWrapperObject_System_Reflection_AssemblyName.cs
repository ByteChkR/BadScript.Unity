using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_System_Reflection_AssemblyName : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Reflection_AssemblyName() : base( typeof( AssemblyName ) )
        {
            m_StaticProperties["ReferenceMatchesDefinition"] = new BSFunctionReference(
                new BSFunction(
                    "function ReferenceMatchesDefinition(reference, definition)",
                    a => AssemblyName.ReferenceMatchesDefinition(
                        WrapperHelper.UnwrapObject < AssemblyName >( a[0] ),
                        WrapperHelper.UnwrapObject < AssemblyName >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["GetAssemblyName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAssemblyName(assemblyFile)",
                    a => new BSWrapperObject_System_Reflection_AssemblyName(
                        AssemblyName.GetAssemblyName( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
