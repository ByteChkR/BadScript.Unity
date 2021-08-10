using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Windows;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Windows_File : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Windows_File() : base( typeof( File ) )
        {
            m_StaticProperties["Exists"] = new BSFunctionReference(
                new BSFunction(
                    "function Exists(path)",
                    a => File.Exists( WrapperHelper.UnwrapObject < string >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
