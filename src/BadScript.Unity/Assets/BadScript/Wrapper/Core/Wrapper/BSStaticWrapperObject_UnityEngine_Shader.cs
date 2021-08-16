using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
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

            m_StaticProperties["EnableKeyword"] = new BSFunctionReference(
                new BSFunction(
                    "function EnableKeyword(keyword)",
                    a =>
                    {
                        Shader.EnableKeyword( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["DisableKeyword"] = new BSFunctionReference(
                new BSFunction(
                    "function DisableKeyword(keyword)",
                    a =>
                    {
                        Shader.DisableKeyword( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["IsKeywordEnabled"] = new BSFunctionReference(
                new BSFunction(
                    "function IsKeywordEnabled(keyword)",
                    a => Shader.IsKeywordEnabled( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["WarmupAllShaders"] = new BSFunctionReference(
                new BSFunction(
                    "function WarmupAllShaders()",
                    a =>
                    {
                        Shader.WarmupAllShaders();

                        return new BSObject( null );
                    },
                    0 ) );

            m_StaticProperties["PropertyToID"] = new BSFunctionReference(
                new BSFunction(
                    "function PropertyToID(name)",
                    a => new BSObject(
                        ( decimal ) Shader.PropertyToID( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["SetGlobalFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalFloat(name, value)",
                    a =>
                    {
                        Shader.SetGlobalFloat(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalFloat(nameID, value)",
                    a =>
                    {
                        Shader.SetGlobalFloat(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalInt"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalInt(name, value)",
                    a =>
                    {
                        Shader.SetGlobalInt(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalInt"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalInt(nameID, value)",
                    a =>
                    {
                        Shader.SetGlobalInt(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalVector"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalVector(name, value)",
                    a =>
                    {
                        Shader.SetGlobalVector(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalVector"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalVector(nameID, value)",
                    a =>
                    {
                        Shader.SetGlobalVector(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalColor"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalColor(name, value)",
                    a =>
                    {
                        Shader.SetGlobalColor(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Color >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalColor"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalColor(nameID, value)",
                    a =>
                    {
                        Shader.SetGlobalColor(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Color >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalMatrix(name, value)",
                    a =>
                    {
                        Shader.SetGlobalMatrix(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalMatrix(nameID, value)",
                    a =>
                    {
                        Shader.SetGlobalMatrix(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalTexture(name, value)",
                    a =>
                    {
                        Shader.SetGlobalTexture(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Texture >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalTexture(nameID, value)",
                    a =>
                    {
                        Shader.SetGlobalTexture(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Texture >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalBuffer(name, value)",
                    a =>
                    {
                        Shader.SetGlobalBuffer(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalBuffer(nameID, value)",
                    a =>
                    {
                        Shader.SetGlobalBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalBuffer(name, value)",
                    a =>
                    {
                        Shader.SetGlobalBuffer(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalBuffer(nameID, value)",
                    a =>
                    {
                        Shader.SetGlobalBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["SetGlobalConstantBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalConstantBuffer(name, value, offset, size)",
                    a =>
                    {
                        Shader.SetGlobalConstantBuffer(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_StaticProperties["SetGlobalConstantBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalConstantBuffer(nameID, value, offset, size)",
                    a =>
                    {
                        Shader.SetGlobalConstantBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_StaticProperties["SetGlobalConstantBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalConstantBuffer(name, value, offset, size)",
                    a =>
                    {
                        Shader.SetGlobalConstantBuffer(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_StaticProperties["SetGlobalConstantBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalConstantBuffer(nameID, value, offset, size)",
                    a =>
                    {
                        Shader.SetGlobalConstantBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

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
