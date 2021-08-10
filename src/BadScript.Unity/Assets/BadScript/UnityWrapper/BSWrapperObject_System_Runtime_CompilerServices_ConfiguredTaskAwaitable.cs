using System.Runtime.CompilerServices;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_System_Runtime_CompilerServices_ConfiguredTaskAwaitable : BSWrapperObject <
            ConfiguredTaskAwaitable >

    {
        #region Public

        public BSWrapperObject_System_Runtime_CompilerServices_ConfiguredTaskAwaitable( ConfiguredTaskAwaitable obj ) :
            base( obj )
        {
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
