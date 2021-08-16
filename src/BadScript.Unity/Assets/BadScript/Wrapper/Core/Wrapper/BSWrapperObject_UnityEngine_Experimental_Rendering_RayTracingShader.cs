using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class
        BSWrapperObject_UnityEngine_Experimental_Rendering_RayTracingShader : BSWrapperObject < RayTracingShader >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Experimental_Rendering_RayTracingShader( RayTracingShader obj ) : base( obj )
        {
            m_Properties["maxRecursionDepth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxRecursionDepth ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

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
                    "function SetTexture(nameID, texture)",
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
                    "function SetBuffer(nameID, buffer)",
                    a =>
                    {
                        m_InternalObject.SetBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetAccelerationStructure"] = new BSFunctionReference(
                new BSFunction(
                    "function SetAccelerationStructure(nameID, accelerationStructure)",
                    a =>
                    {
                        m_InternalObject.SetAccelerationStructure(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < RayTracingAccelerationStructure >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetShaderPass"] = new BSFunctionReference(
                new BSFunction(
                    "function SetShaderPass(passName)",
                    a =>
                    {
                        m_InternalObject.SetShaderPass( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetTextureFromGlobal"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTextureFromGlobal(nameID, globalTextureNameID)",
                    a =>
                    {
                        m_InternalObject.SetTextureFromGlobal(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["Dispatch"] = new BSFunctionReference(
                new BSFunction(
                    "function Dispatch(rayGenFunctionName, width, height, depth, camera)",
                    a =>
                    {
                        m_InternalObject.Dispatch(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < Camera >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["SetBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetBuffer(nameID, buffer)",
                    a =>
                    {
                        m_InternalObject.SetBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

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
                    "function SetTexture(name, texture)",
                    a =>
                    {
                        m_InternalObject.SetTexture(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Texture >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetBuffer(name, buffer)",
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
                    "function SetBuffer(name, buffer)",
                    a =>
                    {
                        m_InternalObject.SetBuffer(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

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

            m_Properties["SetAccelerationStructure"] = new BSFunctionReference(
                new BSFunction(
                    "function SetAccelerationStructure(name, accelerationStructure)",
                    a =>
                    {
                        m_InternalObject.SetAccelerationStructure(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < RayTracingAccelerationStructure >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetTextureFromGlobal"] = new BSFunctionReference(
                new BSFunction(
                    "function SetTextureFromGlobal(name, globalTextureName)",
                    a =>
                    {
                        m_InternalObject.SetTextureFromGlobal(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) );

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
