using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Reflection_ManifestResourceInfo : BSWrapperObject < ManifestResourceInfo >

    {
        #region Public

        public BSWrapperObject_System_Reflection_ManifestResourceInfo( ManifestResourceInfo obj ) : base( obj )
        {
            m_Properties["ReferencedAssembly"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_Assembly( m_InternalObject.ReferencedAssembly ),
                null );

            m_Properties["FileName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.FileName ),
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
