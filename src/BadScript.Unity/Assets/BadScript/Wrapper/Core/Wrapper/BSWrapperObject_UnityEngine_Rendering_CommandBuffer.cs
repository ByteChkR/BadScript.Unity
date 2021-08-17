using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Profiling;
using UnityEngine.Rendering;
#pragma warning disable 618

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Rendering_CommandBuffer : BSWrapperObject < CommandBuffer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_CommandBuffer( CommandBuffer obj ) : base( obj )
        {
            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["sizeInBytes"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sizeInBytes ),
                null );

            m_Properties["ConvertTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function ConvertTexture(src, dst)",
                    a =>
                    {
                        m_InternalObject.ConvertTexture(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["ConvertTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function ConvertTexture(src, srcElement, dst, dstElement)",
                    a =>
                    {
                        m_InternalObject.ConvertTexture(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["WaitAllAsyncReadbackRequests"] = new BSFunctionReference(
                new BSFunction(
                    "function WaitAllAsyncReadbackRequests()",
                    a =>
                    {
                        m_InternalObject.WaitAllAsyncReadbackRequests();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["SetInvertCulling"] = new BSFunctionReference(
                new BSFunction(
                    "function SetInvertCulling(invertCulling)",
                    a =>
                    {
                        m_InternalObject.SetInvertCulling( WrapperHelper.UnwrapObject < bool >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetComputeFloatParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeFloatParam(computeShader, nameID, val)",
                    a =>
                    {
                        m_InternalObject.SetComputeFloatParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetComputeIntParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeIntParam(computeShader, nameID, val)",
                    a =>
                    {
                        m_InternalObject.SetComputeIntParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetComputeVectorParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeVectorParam(computeShader, nameID, val)",
                    a =>
                    {
                        m_InternalObject.SetComputeVectorParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetComputeMatrixParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeMatrixParam(computeShader, nameID, val)",
                    a =>
                    {
                        m_InternalObject.SetComputeMatrixParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRayTracingShaderPass"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingShaderPass(rayTracingShader, passName)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingShaderPass(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ) );

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

            m_Properties["ClearRandomWriteTargets"] = new BSFunctionReference(
                new BSFunction(
                    "function ClearRandomWriteTargets()",
                    a =>
                    {
                        m_InternalObject.ClearRandomWriteTargets();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["SetViewport"] = new BSFunctionReference(
                new BSFunction(
                    "function SetViewport(pixelRect)",
                    a =>
                    {
                        m_InternalObject.SetViewport( WrapperHelper.UnwrapObject < Rect >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["EnableScissorRect"] = new BSFunctionReference(
                new BSFunction(
                    "function EnableScissorRect(scissor)",
                    a =>
                    {
                        m_InternalObject.EnableScissorRect( WrapperHelper.UnwrapObject < Rect >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["DisableScissorRect"] = new BSFunctionReference(
                new BSFunction(
                    "function DisableScissorRect()",
                    a =>
                    {
                        m_InternalObject.DisableScissorRect();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["GetTemporaryRT"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTemporaryRT(nameID, width, height, depthBuffer)",
                    a =>
                    {
                        m_InternalObject.GetTemporaryRT(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["GetTemporaryRT"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTemporaryRT(nameID, width, height)",
                    a =>
                    {
                        m_InternalObject.GetTemporaryRT(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["GetTemporaryRT"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTemporaryRT(nameID, desc)",
                    a =>
                    {
                        m_InternalObject.GetTemporaryRT(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTextureDescriptor >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["GetTemporaryRTArray"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTemporaryRTArray(nameID, width, height, slices, depthBuffer)",
                    a =>
                    {
                        m_InternalObject.GetTemporaryRTArray(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["GetTemporaryRTArray"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTemporaryRTArray(nameID, width, height, slices)",
                    a =>
                    {
                        m_InternalObject.GetTemporaryRTArray(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["ReleaseTemporaryRT"] = new BSFunctionReference(
                new BSFunction(
                    "function ReleaseTemporaryRT(nameID)",
                    a =>
                    {
                        m_InternalObject.ReleaseTemporaryRT( WrapperHelper.UnwrapObject < int >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["ClearRenderTarget"] = new BSFunctionReference(
                new BSFunction(
                    "function ClearRenderTarget(clearDepth, clearColor, backgroundColor, depth)",
                    a =>
                    {
                        m_InternalObject.ClearRenderTarget(
                            WrapperHelper.UnwrapObject < bool >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ),
                            WrapperHelper.UnwrapObject < Color >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["ClearRenderTarget"] = new BSFunctionReference(
                new BSFunction(
                    "function ClearRenderTarget(clearDepth, clearColor, backgroundColor)",
                    a =>
                    {
                        m_InternalObject.ClearRenderTarget(
                            WrapperHelper.UnwrapObject < bool >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ),
                            WrapperHelper.UnwrapObject < Color >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetGlobalFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalFloat(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalFloat(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalInt"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalInt(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalInt(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalVector"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalVector(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalVector(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalColor"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalColor(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalColor(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Color >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalMatrix(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalMatrix(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["EnableShaderKeyword"] = new BSFunctionReference(
                new BSFunction(
                    "function EnableShaderKeyword(keyword)",
                    a =>
                    {
                        m_InternalObject.EnableShaderKeyword( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["DisableShaderKeyword"] = new BSFunctionReference(
                new BSFunction(
                    "function DisableShaderKeyword(keyword)",
                    a =>
                    {
                        m_InternalObject.DisableShaderKeyword( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetViewMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function SetViewMatrix(view)",
                    a =>
                    {
                        m_InternalObject.SetViewMatrix( WrapperHelper.UnwrapObject < Matrix4x4 >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetProjectionMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function SetProjectionMatrix(proj)",
                    a =>
                    {
                        m_InternalObject.SetProjectionMatrix( WrapperHelper.UnwrapObject < Matrix4x4 >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetViewProjectionMatrices"] = new BSFunctionReference(
                new BSFunction(
                    "function SetViewProjectionMatrices(view, proj)",
                    a =>
                    {
                        m_InternalObject.SetViewProjectionMatrices(
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[0] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalDepthBias"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalDepthBias(bias, slopeBias)",
                    a =>
                    {
                        m_InternalObject.SetGlobalDepthBias(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["BeginSample"] = new BSFunctionReference(
                new BSFunction(
                    "function BeginSample(name)",
                    a =>
                    {
                        m_InternalObject.BeginSample( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["EndSample"] = new BSFunctionReference(
                new BSFunction(
                    "function EndSample(name)",
                    a =>
                    {
                        m_InternalObject.EndSample( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["BeginSample"] = new BSFunctionReference(
                new BSFunction(
                    "function BeginSample(sampler)",
                    a =>
                    {
                        m_InternalObject.BeginSample( WrapperHelper.UnwrapObject < CustomSampler >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["EndSample"] = new BSFunctionReference(
                new BSFunction(
                    "function EndSample(sampler)",
                    a =>
                    {
                        m_InternalObject.EndSample( WrapperHelper.UnwrapObject < CustomSampler >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["IncrementUpdateCount"] = new BSFunctionReference(
                new BSFunction(
                    "function IncrementUpdateCount(dest)",
                    a =>
                    {
                        m_InternalObject.IncrementUpdateCount(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetInstanceMultiplier"] = new BSFunctionReference(
                new BSFunction(
                    "function SetInstanceMultiplier(multiplier)",
                    a =>
                    {
                        m_InternalObject.SetInstanceMultiplier( WrapperHelper.UnwrapObject < uint >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetRenderTarget"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRenderTarget(rt)",
                    a =>
                    {
                        m_InternalObject.SetRenderTarget(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetRenderTarget"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRenderTarget(rt, mipLevel)",
                    a =>
                    {
                        m_InternalObject.SetRenderTarget(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetRenderTarget"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRenderTarget(color, depth)",
                    a =>
                    {
                        m_InternalObject.SetRenderTarget(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetRenderTarget"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRenderTarget(color, depth, mipLevel)",
                    a =>
                    {
                        m_InternalObject.SetRenderTarget(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRenderTarget"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRenderTarget(binding)",
                    a =>
                    {
                        m_InternalObject.SetRenderTarget( WrapperHelper.UnwrapObject < RenderTargetBinding >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetComputeBufferData"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeBufferData(buffer, data)",
                    a =>
                    {
                        m_InternalObject.SetComputeBufferData(
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[0] ),
                            WrapperHelper.UnwrapObject < Array >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetComputeBufferData"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeBufferData(buffer, data, managedBufferStartIndex, graphicsBufferStartIndex, count)",
                    a =>
                    {
                        m_InternalObject.SetComputeBufferData(
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[0] ),
                            WrapperHelper.UnwrapObject < Array >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["SetComputeBufferCounterValue"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeBufferCounterValue(buffer, counterValue)",
                    a =>
                    {
                        m_InternalObject.SetComputeBufferCounterValue(
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["Dispose"] = new BSFunctionReference(
                new BSFunction(
                    "function Dispose()",
                    a =>
                    {
                        m_InternalObject.Dispose();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Release"] = new BSFunctionReference(
                new BSFunction(
                    "function Release()",
                    a =>
                    {
                        m_InternalObject.Release();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["CreateAsyncGraphicsFence"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateAsyncGraphicsFence()",
                    a => new BSWrapperObject_UnityEngine_Rendering_GraphicsFence(
                        m_InternalObject.CreateAsyncGraphicsFence() ),
                    0 ) );

            m_Properties["WaitOnAsyncGraphicsFence"] = new BSFunctionReference(
                new BSFunction(
                    "function WaitOnAsyncGraphicsFence(fence)",
                    a =>
                    {
                        m_InternalObject.WaitOnAsyncGraphicsFence(
                            WrapperHelper.UnwrapObject < GraphicsFence >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetComputeFloatParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeFloatParam(computeShader, name, val)",
                    a =>
                    {
                        m_InternalObject.SetComputeFloatParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetComputeIntParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeIntParam(computeShader, name, val)",
                    a =>
                    {
                        m_InternalObject.SetComputeIntParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetComputeVectorParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeVectorParam(computeShader, name, val)",
                    a =>
                    {
                        m_InternalObject.SetComputeVectorParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetComputeMatrixParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeMatrixParam(computeShader, name, val)",
                    a =>
                    {
                        m_InternalObject.SetComputeMatrixParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetComputeTextureParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeTextureParam(computeShader, kernelIndex, name, rt)",
                    a =>
                    {
                        m_InternalObject.SetComputeTextureParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["SetComputeTextureParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeTextureParam(computeShader, kernelIndex, nameID, rt)",
                    a =>
                    {
                        m_InternalObject.SetComputeTextureParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["SetComputeTextureParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeTextureParam(computeShader, kernelIndex, name, rt, mipLevel)",
                    a =>
                    {
                        m_InternalObject.SetComputeTextureParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["SetComputeTextureParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeTextureParam(computeShader, kernelIndex, nameID, rt, mipLevel)",
                    a =>
                    {
                        m_InternalObject.SetComputeTextureParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["SetComputeBufferParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeBufferParam(computeShader, kernelIndex, nameID, buffer)",
                    a =>
                    {
                        m_InternalObject.SetComputeBufferParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["SetComputeBufferParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeBufferParam(computeShader, kernelIndex, name, buffer)",
                    a =>
                    {
                        m_InternalObject.SetComputeBufferParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["SetComputeBufferParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeBufferParam(computeShader, kernelIndex, nameID, buffer)",
                    a =>
                    {
                        m_InternalObject.SetComputeBufferParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["SetComputeBufferParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeBufferParam(computeShader, kernelIndex, name, buffer)",
                    a =>
                    {
                        m_InternalObject.SetComputeBufferParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["SetComputeConstantBufferParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeConstantBufferParam(computeShader, nameID, buffer, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetComputeConstantBufferParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["SetComputeConstantBufferParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeConstantBufferParam(computeShader, name, buffer, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetComputeConstantBufferParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["SetComputeConstantBufferParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeConstantBufferParam(computeShader, nameID, buffer, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetComputeConstantBufferParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["SetComputeConstantBufferParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetComputeConstantBufferParam(computeShader, name, buffer, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetComputeConstantBufferParam(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["DispatchCompute"] = new BSFunctionReference(
                new BSFunction(
                    "function DispatchCompute(computeShader, kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ)",
                    a =>
                    {
                        m_InternalObject.DispatchCompute(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["DispatchCompute"] = new BSFunctionReference(
                new BSFunction(
                    "function DispatchCompute(computeShader, kernelIndex, indirectBuffer, argsOffset)",
                    a =>
                    {
                        m_InternalObject.DispatchCompute(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[2] ),
                            WrapperHelper.UnwrapObject < uint >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["DispatchCompute"] = new BSFunctionReference(
                new BSFunction(
                    "function DispatchCompute(computeShader, kernelIndex, indirectBuffer, argsOffset)",
                    a =>
                    {
                        m_InternalObject.DispatchCompute(
                            WrapperHelper.UnwrapObject < ComputeShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[2] ),
                            WrapperHelper.UnwrapObject < uint >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["BuildRayTracingAccelerationStructure"] = new BSFunctionReference(
                new BSFunction(
                    "function BuildRayTracingAccelerationStructure(accelerationStructure)",
                    a =>
                    {
                        m_InternalObject.BuildRayTracingAccelerationStructure(
                            WrapperHelper.UnwrapObject < RayTracingAccelerationStructure >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["BuildRayTracingAccelerationStructure"] = new BSFunctionReference(
                new BSFunction(
                    "function BuildRayTracingAccelerationStructure(accelerationStructure, relativeOrigin)",
                    a =>
                    {
                        m_InternalObject.BuildRayTracingAccelerationStructure(
                            WrapperHelper.UnwrapObject < RayTracingAccelerationStructure >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetRayTracingAccelerationStructure"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingAccelerationStructure(rayTracingShader, name, rayTracingAccelerationStructure)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingAccelerationStructure(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < RayTracingAccelerationStructure >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRayTracingAccelerationStructure"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingAccelerationStructure(rayTracingShader, nameID, rayTracingAccelerationStructure)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingAccelerationStructure(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < RayTracingAccelerationStructure >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRayTracingBufferParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingBufferParam(rayTracingShader, name, buffer)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingBufferParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRayTracingBufferParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingBufferParam(rayTracingShader, nameID, buffer)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingBufferParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRayTracingConstantBufferParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingConstantBufferParam(rayTracingShader, nameID, buffer, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingConstantBufferParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["SetRayTracingConstantBufferParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingConstantBufferParam(rayTracingShader, name, buffer, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingConstantBufferParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["SetRayTracingConstantBufferParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingConstantBufferParam(rayTracingShader, nameID, buffer, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingConstantBufferParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["SetRayTracingConstantBufferParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingConstantBufferParam(rayTracingShader, name, buffer, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingConstantBufferParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["SetRayTracingTextureParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingTextureParam(rayTracingShader, name, rt)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingTextureParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRayTracingTextureParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingTextureParam(rayTracingShader, nameID, rt)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingTextureParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRayTracingFloatParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingFloatParam(rayTracingShader, name, val)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingFloatParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRayTracingFloatParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingFloatParam(rayTracingShader, nameID, val)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingFloatParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRayTracingIntParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingIntParam(rayTracingShader, name, val)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingIntParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRayTracingIntParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingIntParam(rayTracingShader, nameID, val)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingIntParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRayTracingVectorParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingVectorParam(rayTracingShader, name, val)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingVectorParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRayTracingVectorParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingVectorParam(rayTracingShader, nameID, val)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingVectorParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRayTracingMatrixParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingMatrixParam(rayTracingShader, name, val)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingMatrixParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRayTracingMatrixParam"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRayTracingMatrixParam(rayTracingShader, nameID, val)",
                    a =>
                    {
                        m_InternalObject.SetRayTracingMatrixParam(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["DispatchRays"] = new BSFunctionReference(
                new BSFunction(
                    "function DispatchRays(rayTracingShader, rayGenName, width, height, depth, camera)",
                    a =>
                    {
                        m_InternalObject.DispatchRays(
                            WrapperHelper.UnwrapObject < RayTracingShader >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ),
                            WrapperHelper.UnwrapObject < uint >( a[3] ),
                            WrapperHelper.UnwrapObject < uint >( a[4] ),
                            WrapperHelper.UnwrapObject < Camera >( a[5] ) );

                        return new BSObject( null );
                    },
                    6 ) );

            m_Properties["GenerateMips"] = new BSFunctionReference(
                new BSFunction(
                    "function GenerateMips(rt)",
                    a =>
                    {
                        m_InternalObject.GenerateMips( WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["GenerateMips"] = new BSFunctionReference(
                new BSFunction(
                    "function GenerateMips(rt)",
                    a =>
                    {
                        m_InternalObject.GenerateMips( WrapperHelper.UnwrapObject < RenderTexture >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["ResolveAntiAliasedSurface"] = new BSFunctionReference(
                new BSFunction(
                    "function ResolveAntiAliasedSurface(rt, target)",
                    a =>
                    {
                        m_InternalObject.ResolveAntiAliasedSurface(
                            WrapperHelper.UnwrapObject < RenderTexture >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTexture >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["DrawMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawMesh(mesh, matrix, material, submeshIndex, shaderPass, properties)",
                    a =>
                    {
                        m_InternalObject.DrawMesh(
                            WrapperHelper.UnwrapObject < Mesh >( a[0] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < MaterialPropertyBlock >( a[5] ) );

                        return new BSObject( null );
                    },
                    6 ) );

            m_Properties["DrawMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawMesh(mesh, matrix, material, submeshIndex, shaderPass)",
                    a =>
                    {
                        m_InternalObject.DrawMesh(
                            WrapperHelper.UnwrapObject < Mesh >( a[0] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["DrawMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawMesh(mesh, matrix, material, submeshIndex)",
                    a =>
                    {
                        m_InternalObject.DrawMesh(
                            WrapperHelper.UnwrapObject < Mesh >( a[0] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["DrawMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawMesh(mesh, matrix, material)",
                    a =>
                    {
                        m_InternalObject.DrawMesh(
                            WrapperHelper.UnwrapObject < Mesh >( a[0] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["DrawRenderer"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawRenderer(renderer, material, submeshIndex, shaderPass)",
                    a =>
                    {
                        m_InternalObject.DrawRenderer(
                            WrapperHelper.UnwrapObject < Renderer >( a[0] ),
                            WrapperHelper.UnwrapObject < Material >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["DrawRenderer"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawRenderer(renderer, material, submeshIndex)",
                    a =>
                    {
                        m_InternalObject.DrawRenderer(
                            WrapperHelper.UnwrapObject < Renderer >( a[0] ),
                            WrapperHelper.UnwrapObject < Material >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["DrawRenderer"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawRenderer(renderer, material)",
                    a =>
                    {
                        m_InternalObject.DrawRenderer(
                            WrapperHelper.UnwrapObject < Renderer >( a[0] ),
                            WrapperHelper.UnwrapObject < Material >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["DrawMeshInstancedProcedural"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawMeshInstancedProcedural(mesh, submeshIndex, material, shaderPass, count, properties)",
                    a =>
                    {
                        m_InternalObject.DrawMeshInstancedProcedural(
                            WrapperHelper.UnwrapObject < Mesh >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < MaterialPropertyBlock >( a[5] ) );

                        return new BSObject( null );
                    },
                    6 ) );

            m_Properties["DrawMeshInstancedIndirect"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties)",
                    a =>
                    {
                        m_InternalObject.DrawMeshInstancedIndirect(
                            WrapperHelper.UnwrapObject < Mesh >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < MaterialPropertyBlock >( a[6] ) );

                        return new BSObject( null );
                    },
                    7 ) );

            m_Properties["DrawMeshInstancedIndirect"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset)",
                    a =>
                    {
                        m_InternalObject.DrawMeshInstancedIndirect(
                            WrapperHelper.UnwrapObject < Mesh >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ) );

                        return new BSObject( null );
                    },
                    6 ) );

            m_Properties["DrawMeshInstancedIndirect"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs)",
                    a =>
                    {
                        m_InternalObject.DrawMeshInstancedIndirect(
                            WrapperHelper.UnwrapObject < Mesh >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["DrawMeshInstancedIndirect"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties)",
                    a =>
                    {
                        m_InternalObject.DrawMeshInstancedIndirect(
                            WrapperHelper.UnwrapObject < Mesh >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < MaterialPropertyBlock >( a[6] ) );

                        return new BSObject( null );
                    },
                    7 ) );

            m_Properties["DrawMeshInstancedIndirect"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset)",
                    a =>
                    {
                        m_InternalObject.DrawMeshInstancedIndirect(
                            WrapperHelper.UnwrapObject < Mesh >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ) );

                        return new BSObject( null );
                    },
                    6 ) );

            m_Properties["DrawMeshInstancedIndirect"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs)",
                    a =>
                    {
                        m_InternalObject.DrawMeshInstancedIndirect(
                            WrapperHelper.UnwrapObject < Mesh >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["DrawOcclusionMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function DrawOcclusionMesh(normalizedCamViewport)",
                    a =>
                    {
                        m_InternalObject.DrawOcclusionMesh( WrapperHelper.UnwrapObject < RectInt >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetRandomWriteTarget"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRandomWriteTarget(index, rt)",
                    a =>
                    {
                        m_InternalObject.SetRandomWriteTarget(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetRandomWriteTarget"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRandomWriteTarget(index, buffer, preserveCounterValue)",
                    a =>
                    {
                        m_InternalObject.SetRandomWriteTarget(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < bool >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRandomWriteTarget"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRandomWriteTarget(index, buffer)",
                    a =>
                    {
                        m_InternalObject.SetRandomWriteTarget(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetRandomWriteTarget"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRandomWriteTarget(index, buffer, preserveCounterValue)",
                    a =>
                    {
                        m_InternalObject.SetRandomWriteTarget(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < bool >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetRandomWriteTarget"] = new BSFunctionReference(
                new BSFunction(
                    "function SetRandomWriteTarget(index, buffer)",
                    a =>
                    {
                        m_InternalObject.SetRandomWriteTarget(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["CopyCounterValue"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyCounterValue(src, dst, dstOffsetBytes)",
                    a =>
                    {
                        m_InternalObject.CopyCounterValue(
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["CopyCounterValue"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyCounterValue(src, dst, dstOffsetBytes)",
                    a =>
                    {
                        m_InternalObject.CopyCounterValue(
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["CopyCounterValue"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyCounterValue(src, dst, dstOffsetBytes)",
                    a =>
                    {
                        m_InternalObject.CopyCounterValue(
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["CopyCounterValue"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyCounterValue(src, dst, dstOffsetBytes)",
                    a =>
                    {
                        m_InternalObject.CopyCounterValue(
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["CopyTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyTexture(src, dst)",
                    a =>
                    {
                        m_InternalObject.CopyTexture(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["CopyTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyTexture(src, srcElement, dst, dstElement)",
                    a =>
                    {
                        m_InternalObject.CopyTexture(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["CopyTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyTexture(src, srcElement, srcMip, dst, dstElement, dstMip)",
                    a =>
                    {
                        m_InternalObject.CopyTexture(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ) );

                        return new BSObject( null );
                    },
                    6 ) );

            m_Properties["CopyTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function CopyTexture(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY)",
                    a =>
                    {
                        m_InternalObject.CopyTexture(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[7] ),
                            WrapperHelper.UnwrapObject < int >( a[8] ),
                            WrapperHelper.UnwrapObject < int >( a[9] ),
                            WrapperHelper.UnwrapObject < int >( a[10] ),
                            WrapperHelper.UnwrapObject < int >( a[11] ) );

                        return new BSObject( null );
                    },
                    12 ) );

            m_Properties["Blit"] = new BSFunctionReference(
                new BSFunction(
                    "function Blit(source, dest)",
                    a =>
                    {
                        m_InternalObject.Blit(
                            WrapperHelper.UnwrapObject < Texture >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["Blit"] = new BSFunctionReference(
                new BSFunction(
                    "function Blit(source, dest, scale, offset)",
                    a =>
                    {
                        m_InternalObject.Blit(
                            WrapperHelper.UnwrapObject < Texture >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["Blit"] = new BSFunctionReference(
                new BSFunction(
                    "function Blit(source, dest, mat)",
                    a =>
                    {
                        m_InternalObject.Blit(
                            WrapperHelper.UnwrapObject < Texture >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["Blit"] = new BSFunctionReference(
                new BSFunction(
                    "function Blit(source, dest, mat, pass)",
                    a =>
                    {
                        m_InternalObject.Blit(
                            WrapperHelper.UnwrapObject < Texture >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["Blit"] = new BSFunctionReference(
                new BSFunction(
                    "function Blit(source, dest)",
                    a =>
                    {
                        m_InternalObject.Blit(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["Blit"] = new BSFunctionReference(
                new BSFunction(
                    "function Blit(source, dest, scale, offset)",
                    a =>
                    {
                        m_InternalObject.Blit(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["Blit"] = new BSFunctionReference(
                new BSFunction(
                    "function Blit(source, dest, mat)",
                    a =>
                    {
                        m_InternalObject.Blit(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["Blit"] = new BSFunctionReference(
                new BSFunction(
                    "function Blit(source, dest, mat, pass)",
                    a =>
                    {
                        m_InternalObject.Blit(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["Blit"] = new BSFunctionReference(
                new BSFunction(
                    "function Blit(source, dest, sourceDepthSlice, destDepthSlice)",
                    a =>
                    {
                        m_InternalObject.Blit(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["Blit"] = new BSFunctionReference(
                new BSFunction(
                    "function Blit(source, dest, scale, offset, sourceDepthSlice, destDepthSlice)",
                    a =>
                    {
                        m_InternalObject.Blit(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ) );

                        return new BSObject( null );
                    },
                    6 ) );

            m_Properties["Blit"] = new BSFunctionReference(
                new BSFunction(
                    "function Blit(source, dest, mat, pass, destDepthSlice)",
                    a =>
                    {
                        m_InternalObject.Blit(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ),
                            WrapperHelper.UnwrapObject < Material >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) );

                        return new BSObject( null );
                    },
                    5 ) );

            m_Properties["SetGlobalFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalFloat(name, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalFloat(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalInt"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalInt(name, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalInt(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalVector"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalVector(name, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalVector(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalColor"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalColor(name, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalColor(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Color >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalMatrix(name, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalMatrix(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalTexture(name, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalTexture(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalTexture(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalTexture(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalBuffer(name, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalBuffer(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalBuffer(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalBuffer(name, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalBuffer(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalBuffer(nameID, value)",
                    a =>
                    {
                        m_InternalObject.SetGlobalBuffer(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["SetGlobalConstantBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalConstantBuffer(buffer, nameID, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetGlobalConstantBuffer(
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["SetGlobalConstantBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalConstantBuffer(buffer, name, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetGlobalConstantBuffer(
                            WrapperHelper.UnwrapObject < ComputeBuffer >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["SetGlobalConstantBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalConstantBuffer(buffer, nameID, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetGlobalConstantBuffer(
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["SetGlobalConstantBuffer"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalConstantBuffer(buffer, name, offset, size)",
                    a =>
                    {
                        m_InternalObject.SetGlobalConstantBuffer(
                            WrapperHelper.UnwrapObject < GraphicsBuffer >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["IssuePluginEvent"] = new BSFunctionReference(
                new BSFunction(
                    "function IssuePluginEvent(callback, eventID)",
                    a =>
                    {
                        m_InternalObject.IssuePluginEvent(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["IssuePluginEventAndData"] = new BSFunctionReference(
                new BSFunction(
                    "function IssuePluginEventAndData(callback, eventID, data)",
                    a =>
                    {
                        m_InternalObject.IssuePluginEventAndData(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["IssuePluginCustomBlit"] = new BSFunctionReference(
                new BSFunction(
                    "function IssuePluginCustomBlit(callback, command, source, dest, commandParam, commandFlags)",
                    a =>
                    {
                        m_InternalObject.IssuePluginCustomBlit(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < uint >( a[1] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[2] ),
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[3] ),
                            WrapperHelper.UnwrapObject < uint >( a[4] ),
                            WrapperHelper.UnwrapObject < uint >( a[5] ) );

                        return new BSObject( null );
                    },
                    6 ) );

            m_Properties["IssuePluginCustomTextureUpdate"] = new BSFunctionReference(
                new BSFunction(
                    "function IssuePluginCustomTextureUpdate(callback, targetTexture, userData)",
                    a =>
                    {
                        m_InternalObject.IssuePluginCustomTextureUpdate(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < Texture >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["IssuePluginCustomTextureUpdateV1"] = new BSFunctionReference(
                new BSFunction(
                    "function IssuePluginCustomTextureUpdateV1(callback, targetTexture, userData)",
                    a =>
                    {
                        m_InternalObject.IssuePluginCustomTextureUpdateV1(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < Texture >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["IssuePluginCustomTextureUpdateV2"] = new BSFunctionReference(
                new BSFunction(
                    "function IssuePluginCustomTextureUpdateV2(callback, targetTexture, userData)",
                    a =>
                    {
                        m_InternalObject.IssuePluginCustomTextureUpdateV2(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < Texture >( a[1] ),
                            WrapperHelper.UnwrapObject < uint >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["ProcessVTFeedback"] = new BSFunctionReference(
                new BSFunction(
                    "function ProcessVTFeedback(rt, resolver, slice, x, width, y, height, mip)",
                    a =>
                    {
                        m_InternalObject.ProcessVTFeedback(
                            WrapperHelper.UnwrapObject < RenderTargetIdentifier >( a[0] ),
                            WrapperHelper.UnwrapObject < IntPtr >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < int >( a[6] ),
                            WrapperHelper.UnwrapObject < int >( a[7] ) );

                        return new BSObject( null );
                    },
                    8 ) );

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
