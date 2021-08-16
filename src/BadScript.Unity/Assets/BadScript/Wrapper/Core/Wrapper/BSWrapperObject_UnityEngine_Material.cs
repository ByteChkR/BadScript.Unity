using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Material : BSWrapperObject < Material >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Material( Material obj ) : base( obj )
        {
            m_Properties["shader"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Shader( m_InternalObject.shader ),
                x => m_InternalObject.shader = WrapperHelper.UnwrapObject < Shader >( x ) );

            m_Properties["color"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.color ),
                x => m_InternalObject.color = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["mainTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture( m_InternalObject.mainTexture ),
                x => m_InternalObject.mainTexture = WrapperHelper.UnwrapObject < Texture >( x ) );

            m_Properties["mainTextureOffset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.mainTextureOffset ),
                x => m_InternalObject.mainTextureOffset = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["mainTextureScale"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.mainTextureScale ),
                x => m_InternalObject.mainTextureScale = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["renderQueue"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.renderQueue ),
                x => m_InternalObject.renderQueue = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["doubleSidedGI"] = new BSReflectionReference(
                () => m_InternalObject.doubleSidedGI ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.doubleSidedGI = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["enableInstancing"] = new BSReflectionReference(
                () => m_InternalObject.enableInstancing ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enableInstancing = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["passCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.passCount ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["HasProperty"] = new BSFunctionReference(
                new BSFunction(
                    "function HasProperty(nameID)",
                    a => m_InternalObject.HasProperty( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["HasProperty"] = new BSFunctionReference(
                new BSFunction(
                    "function HasProperty(name)",
                    a => m_InternalObject.HasProperty( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["EnableKeyword"] = new BSFunctionReference(
                new BSFunction(
                    "function EnableKeyword(keyword)",
                    a =>
                    {
                        m_InternalObject.EnableKeyword( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["DisableKeyword"] = new BSFunctionReference(
                new BSFunction(
                    "function DisableKeyword(keyword)",
                    a =>
                    {
                        m_InternalObject.DisableKeyword( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["IsKeywordEnabled"] = new BSFunctionReference(
                new BSFunction(
                    "function IsKeywordEnabled(keyword)",
                    a => m_InternalObject.IsKeywordEnabled( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["SetShaderPassEnabled"] = new BSFunctionReference(
                new BSFunction(
                    "function SetShaderPassEnabled(passName, enabled)",
                    a =>
                    {
                        m_InternalObject.SetShaderPassEnabled(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["GetShaderPassEnabled"] = new BSFunctionReference(
                new BSFunction(
                    "function GetShaderPassEnabled(passName)",
                    a => m_InternalObject.GetShaderPassEnabled( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetPassName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPassName(pass)",
                    a => new BSObject( m_InternalObject.GetPassName( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["FindPass"] = new BSFunctionReference(
                new BSFunction(
                    "function FindPass(passName)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.FindPass( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["SetOverrideTag"] = new BSFunctionReference(
                new BSFunction(
                    "function SetOverrideTag(tag, val)",
                    a =>
                    {
                        m_InternalObject.SetOverrideTag(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["GetTag"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTag(tag, searchFallbacks, defaultValue)",
                    a => new BSObject(
                        m_InternalObject.GetTag(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ) ) ),
                    3 ) );

            m_Properties["GetTag"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTag(tag, searchFallbacks)",
                    a => new BSObject(
                        m_InternalObject.GetTag(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

            m_Properties["Lerp"] = new BSFunctionReference(
                new BSFunction(
                    "function Lerp(start, end, t)",
                    a =>
                    {
                        m_InternalObject.Lerp(
                            WrapperHelper.UnwrapObject < Material >( a[0] ),
                            WrapperHelper.UnwrapObject < Material >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetPass"] = new BSFunctionReference(
                new BSFunction(
                    "function SetPass(pass)",
                    a => m_InternalObject.SetPass( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["CopyPropertiesFromMaterial"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyPropertiesFromMaterial(mat)",
                    a =>
                    {
                        m_InternalObject.CopyPropertiesFromMaterial( WrapperHelper.UnwrapObject < Material >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["ComputeCRC"] = new BSFunctionReference(
                new BSFunction(
                    "function ComputeCRC()",
                    a => new BSObject( ( decimal ) m_InternalObject.ComputeCRC() ),
                    0 ) );

            m_Properties["SetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function SetFloat(name, value)",
                    a =>
                    {
                        m_InternalObject.SetFloat(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function SetFloat(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetFloat(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function SetInt(name, value)",
                    a =>
                    {
                        m_InternalObject.SetInt(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function SetInt(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetInt(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetColor"] = new BSFunctionReference(
                new BSFunction(
                    "function SetColor(name, value)",
                    a =>
                    {
                        m_InternalObject.SetColor(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Color >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetColor"] = new BSFunctionReference(
                new BSFunction(
                    "function SetColor(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetColor(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Color >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetVector"] = new BSFunctionReference(
                new BSFunction(
                    "function SetVector(name, value)",
                    a =>
                    {
                        m_InternalObject.SetVector(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetVector"] = new BSFunctionReference(
                new BSFunction(
                    "function SetVector(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetVector(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function SetMatrix(name, value)",
                    a =>
                    {
                        m_InternalObject.SetMatrix(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function SetMatrix(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetMatrix(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTexture(name, value)",
                    a =>
                    {
                        m_InternalObject.SetTexture(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Texture >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTexture(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetTexture(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Texture >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetBuffer(name, value)",
                    a =>
                    {
                        m_InternalObject.SetBuffer(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetBuffer(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetBuffer(name, value)",
                    a =>
                    {
                        m_InternalObject.SetBuffer(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetBuffer(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetConstantBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetConstantBuffer(name, value, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetConstantBuffer(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["SetConstantBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetConstantBuffer(nameID, value, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetConstantBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["SetConstantBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetConstantBuffer(name, value, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetConstantBuffer(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["SetConstantBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetConstantBuffer(nameID, value, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetConstantBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetFloat( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(nameID)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetFloat( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInt( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt(nameID)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInt( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetColor"] = new BSFunctionReference(
                new BSFunction(
                    "function GetColor(name)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        m_InternalObject.GetColor( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetColor"] = new BSFunctionReference(
                new BSFunction(
                    "function GetColor(nameID)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        m_InternalObject.GetColor( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector(name)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        m_InternalObject.GetVector( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector(nameID)",
                    a => new BSWrapperObject_UnityEngine_Vector4(
                        m_InternalObject.GetVector( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMatrix(name)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        m_InternalObject.GetMatrix( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMatrix(nameID)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        m_InternalObject.GetMatrix( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTexture(name)",
                    a => new BSWrapperObject_UnityEngine_Texture(
                        m_InternalObject.GetTexture( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTexture(nameID)",
                    a => new BSWrapperObject_UnityEngine_Texture(
                        m_InternalObject.GetTexture( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["SetTextureOffset"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTextureOffset(name, value)",
                    a =>
                    {
                        m_InternalObject.SetTextureOffset(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetTextureOffset"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTextureOffset(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetTextureOffset(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetTextureScale"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTextureScale(name, value)",
                    a =>
                    {
                        m_InternalObject.SetTextureScale(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetTextureScale"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTextureScale(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetTextureScale(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["GetTextureOffset"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTextureOffset(name)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetTextureOffset( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTextureOffset"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTextureOffset(nameID)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetTextureOffset( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTextureScale"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTextureScale(name)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetTextureScale( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetTextureScale"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTextureScale(nameID)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.GetTextureScale( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetInstanceID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInstanceID()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetInstanceID() ),
                    0 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}
