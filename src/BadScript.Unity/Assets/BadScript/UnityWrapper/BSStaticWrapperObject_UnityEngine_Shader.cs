using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Shader : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Shader() : base( typeof( Shader ) )
        {
            m_StaticProperties["globalMaximumLOD"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Shader.globalMaximumLOD ),
                x => Shader.globalMaximumLOD = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["globalRenderPipeline"] = new BSReflectionReference(
                () => new BSObject( Shader.globalRenderPipeline ),
                x => Shader.globalRenderPipeline = WrapperHelper.UnwrapObject < string >( x ) );

            m_StaticProperties["Find"] = new BSFunctionReference(
                new BSFunction(
                    "function Find(name)",
                    a => new BSWrapperObject_UnityEngine_Shader(
                        Shader.Find( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["IsKeywordEnabled"] = new BSFunctionReference(
                new BSFunction(
                    "function IsKeywordEnabled(keyword)",
                    a => Shader.IsKeywordEnabled( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["PropertyToID"] = new BSFunctionReference(
                new BSFunction(
                    "function PropertyToID(name)",
                    a => new BSObject(
                        ( decimal ) Shader.PropertyToID( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetGlobalFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGlobalFloat(name)",
                    a => new BSObject(
                        ( decimal ) Shader.GetGlobalFloat( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetGlobalFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGlobalFloat(nameID)",
                    a => new BSObject(
                        ( decimal ) Shader.GetGlobalFloat( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetGlobalInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGlobalInt(name)",
                    a => new BSObject(
                        ( decimal ) Shader.GetGlobalInt( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetGlobalInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGlobalInt(nameID)",
                    a => new BSObject( ( decimal ) Shader.GetGlobalInt( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetGlobalVector"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGlobalVector(name)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        Shader.GetGlobalVector( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetGlobalVector"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGlobalVector(nameID)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        Shader.GetGlobalVector( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetGlobalColor"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGlobalColor(name)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        Shader.GetGlobalColor( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetGlobalColor"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGlobalColor(nameID)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        Shader.GetGlobalColor( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetGlobalMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGlobalMatrix(name)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        Shader.GetGlobalMatrix( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetGlobalMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGlobalMatrix(nameID)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        Shader.GetGlobalMatrix( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetGlobalTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGlobalTexture(name)",
                    a => new BSWrapperObject_UnityEngine_Texture(
                        Shader.GetGlobalTexture( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetGlobalTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGlobalTexture(nameID)",
                    a => new BSWrapperObject_UnityEngine_Texture(
                        Shader.GetGlobalTexture( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
