using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_ShaderKeyword : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_ShaderKeyword() : base( typeof( ShaderKeyword ) )
        {
            m_StaticProperties["GetGlobalKeywordName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGlobalKeywordName(index)",
                    a => new BSObject(
                        ShaderKeyword.GetGlobalKeywordName( WrapperHelper.UnwrapObject < ShaderKeyword >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["IsKeywordLocal"] = new BSFunctionReference(
                new BSFunction(
                    "function IsKeywordLocal(index)",
                    a => ShaderKeyword.IsKeywordLocal( WrapperHelper.UnwrapObject < ShaderKeyword >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetKeywordName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetKeywordName(shader, index)",
                    a => new BSObject(
                        ShaderKeyword.GetKeywordName(
                            WrapperHelper.UnwrapObject < Shader >( a[0] ),
                            WrapperHelper.UnwrapObject < ShaderKeyword >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetKeywordName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetKeywordName(shader, index)",
                    a => new BSObject(
                        ShaderKeyword.GetKeywordName(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < ShaderKeyword >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
