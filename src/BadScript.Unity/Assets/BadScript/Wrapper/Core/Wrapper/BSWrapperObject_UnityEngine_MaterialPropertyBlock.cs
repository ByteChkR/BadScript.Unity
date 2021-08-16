using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_MaterialPropertyBlock : BSWrapperObject < MaterialPropertyBlock >

    {
        #region Public

        public BSWrapperObject_UnityEngine_MaterialPropertyBlock( MaterialPropertyBlock obj ) : base( obj )
        {
            m_Properties["isEmpty"] = new BSReflectionReference(
                () => m_InternalObject.isEmpty ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["AddFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function AddFloat(name, value)",
                    a =>
                    {
                        m_InternalObject.SetFloat(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function AddFloat(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetFloat(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddVector"] = new BSFunctionReference(
                new BSFunction(
                    "function AddVector(name, value)",
                    a =>
                    {
                        m_InternalObject.SetVector(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddVector"] = new BSFunctionReference(
                new BSFunction(
                    "function AddVector(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetVector(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddColor"] = new BSFunctionReference(
                new BSFunction(
                    "function AddColor(name, value)",
                    a =>
                    {
                        m_InternalObject.SetColor(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Color >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddColor"] = new BSFunctionReference(
                new BSFunction(
                    "function AddColor(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetColor(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Color >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function AddMatrix(name, value)",
                    a =>
                    {
                        m_InternalObject.SetMatrix(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function AddMatrix(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetMatrix(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function AddTexture(name, value)",
                    a =>
                    {
                        m_InternalObject.SetTexture(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Texture >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["AddTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function AddTexture(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetTexture(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Texture >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["Clear"] = new BSFunctionReference(
                new BSFunction(
                    "function Clear()",
                    a =>
                    {
                        m_InternalObject.Clear();

                        return new BSObject( null );
                    },
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

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}
