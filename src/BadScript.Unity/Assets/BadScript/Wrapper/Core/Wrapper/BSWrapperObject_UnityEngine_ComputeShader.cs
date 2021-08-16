using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_ComputeShader : BSWrapperObject < ComputeShader >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ComputeShader( ComputeShader obj ) : base( obj )
        {
            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["FindKernel"] = new BSFunctionReference(
                new BSFunction(
                    "function FindKernel(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.FindKernel( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["HasKernel"] = new BSFunctionReference(
                new BSFunction(
                    "function HasKernel(name)",
                    a => m_InternalObject.HasKernel( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["SetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function SetFloat(nameID, val)",
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
                    "function SetInt(nameID, val)",
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
                    "function SetVector(nameID, val)",
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
                    "function SetMatrix(nameID, val)",
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
                    "function SetTexture(kernelIndex, nameID, texture, mipLevel)",
                    a =>
                    {
                        m_InternalObject.SetTexture(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Texture >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["SetTextureFromGlobal"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTextureFromGlobal(kernelIndex, nameID, globalTextureNameID)",
                    a =>
                    {
                        m_InternalObject.SetTextureFromGlobal(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetBuffer(kernelIndex, nameID, buffer)",
                    a =>
                    {
                        m_InternalObject.SetBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetBuffer(kernelIndex, nameID, buffer)",
                    a =>
                    {
                        m_InternalObject.SetBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["Dispatch"] = new BSFunctionReference(
                new BSFunction(
                    "function Dispatch(kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ)",
                    a =>
                    {
                        m_InternalObject.Dispatch(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

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

            m_Properties["SetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function SetFloat(name, val)",
                    a =>
                    {
                        m_InternalObject.SetFloat(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function SetInt(name, val)",
                    a =>
                    {
                        m_InternalObject.SetInt(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetVector"] = new BSFunctionReference(
                new BSFunction(
                    "function SetVector(name, val)",
                    a =>
                    {
                        m_InternalObject.SetVector(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function SetMatrix(name, val)",
                    a =>
                    {
                        m_InternalObject.SetMatrix(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetBool"] = new BSFunctionReference(
                new BSFunction(
                    "function SetBool(name, val)",
                    a =>
                    {
                        m_InternalObject.SetBool(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetBool"] = new BSFunctionReference(
                new BSFunction(
                    "function SetBool(nameID, val)",
                    a =>
                    {
                        m_InternalObject.SetBool(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTexture(kernelIndex, nameID, texture)",
                    a =>
                    {
                        m_InternalObject.SetTexture(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Texture >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTexture(kernelIndex, name, texture)",
                    a =>
                    {
                        m_InternalObject.SetTexture(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < Texture >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTexture(kernelIndex, name, texture, mipLevel)",
                    a =>
                    {
                        m_InternalObject.SetTexture(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < Texture >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["SetTextureFromGlobal"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTextureFromGlobal(kernelIndex, name, globalTextureName)",
                    a =>
                    {
                        m_InternalObject.SetTextureFromGlobal(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetBuffer(kernelIndex, name, buffer)",
                    a =>
                    {
                        m_InternalObject.SetBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetBuffer(kernelIndex, name, buffer)",
                    a =>
                    {
                        m_InternalObject.SetBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetConstantBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetConstantBuffer(nameID, buffer, offset, size)",
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
                    "function SetConstantBuffer(name, buffer, offset, size)",
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
                    "function SetConstantBuffer(nameID, buffer, offset, size)",
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

            m_Properties["SetConstantBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetConstantBuffer(name, buffer, offset, size)",
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

            m_Properties["DispatchIndirect"] = new BSFunctionReference(
                new BSFunction(
                    "function DispatchIndirect(kernelIndex, argsBuffer, argsOffset)",
                    a =>
                    {
                        m_InternalObject.DispatchIndirect(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["DispatchIndirect"] = new BSFunctionReference(
                new BSFunction(
                    "function DispatchIndirect(kernelIndex, argsBuffer)",
                    a =>
                    {
                        m_InternalObject.DispatchIndirect(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["DispatchIndirect"] = new BSFunctionReference(
                new BSFunction(
                    "function DispatchIndirect(kernelIndex, argsBuffer, argsOffset)",
                    a =>
                    {
                        m_InternalObject.DispatchIndirect(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["DispatchIndirect"] = new BSFunctionReference(
                new BSFunction(
                    "function DispatchIndirect(kernelIndex, argsBuffer)",
                    a =>
                    {
                        m_InternalObject.DispatchIndirect(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

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
