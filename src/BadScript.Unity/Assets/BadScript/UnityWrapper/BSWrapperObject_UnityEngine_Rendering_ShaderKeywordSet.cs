using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_ShaderKeywordSet : BSWrapperObject < ShaderKeywordSet >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_ShaderKeywordSet( ShaderKeywordSet obj ) : base( obj )
        {
            m_Properties["IsEnabled"] = new BSFunctionReference(
                new BSFunction(
                    "function IsEnabled(keyword)",
                    a => m_InternalObject.IsEnabled( WrapperHelper.UnwrapObject < ShaderKeyword >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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
