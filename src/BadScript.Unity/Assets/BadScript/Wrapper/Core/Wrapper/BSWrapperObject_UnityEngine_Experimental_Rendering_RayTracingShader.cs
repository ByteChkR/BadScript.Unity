using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Experimental_Rendering_RayTracingShader : BSWrapperObject<UnityEngine.Experimental.Rendering.RayTracingShader>

    {
        public BSWrapperObject_UnityEngine_Experimental_Rendering_RayTracingShader(UnityEngine.Experimental.Rendering.RayTracingShader obj) : base(obj)
        {
            m_Properties["maxRecursionDepth"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.maxRecursionDepth), null);
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["SetFloat"] = new BSFunctionReference(new BSFunction("function SetFloat(nameID, val)", a => {
                m_InternalObject.SetFloat(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetInt"] = new BSFunctionReference(new BSFunction("function SetInt(nameID, val)", a => {
                m_InternalObject.SetInt(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetVector"] = new BSFunctionReference(new BSFunction("function SetVector(nameID, val)", a => {
                m_InternalObject.SetVector(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetMatrix"] = new BSFunctionReference(new BSFunction("function SetMatrix(nameID, val)", a => {
                m_InternalObject.SetMatrix(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Matrix4x4>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetTexture"] = new BSFunctionReference(new BSFunction("function SetTexture(nameID, texture)", a => {
                m_InternalObject.SetTexture(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Texture>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetBuffer"] = new BSFunctionReference(new BSFunction("function SetBuffer(nameID, buffer)", a => {
                m_InternalObject.SetBuffer(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetAccelerationStructure"] = new BSFunctionReference(new BSFunction("function SetAccelerationStructure(nameID, accelerationStructure)", a => {
                m_InternalObject.SetAccelerationStructure(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetShaderPass"] = new BSFunctionReference(new BSFunction("function SetShaderPass(passName)", a => {
                m_InternalObject.SetShaderPass(WrapperHelper.UnwrapObject<System.String>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["SetTextureFromGlobal"] = new BSFunctionReference(new BSFunction("function SetTextureFromGlobal(nameID, globalTextureNameID)", a => {
                m_InternalObject.SetTextureFromGlobal(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Dispatch"] = new BSFunctionReference(new BSFunction("function Dispatch(rayGenFunctionName, width, height, depth, camera)", a => {
                m_InternalObject.Dispatch(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]), WrapperHelper.UnwrapObject<UnityEngine.Camera>(a[4]));
                return new BSObject(null);
            }, 5));
            m_Properties["SetBuffer"] = new BSFunctionReference(new BSFunction("function SetBuffer(nameID, buffer)", a => {
                m_InternalObject.SetBuffer(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetFloat"] = new BSFunctionReference(new BSFunction("function SetFloat(name, val)", a => {
                m_InternalObject.SetFloat(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetInt"] = new BSFunctionReference(new BSFunction("function SetInt(name, val)", a => {
                m_InternalObject.SetInt(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetVector"] = new BSFunctionReference(new BSFunction("function SetVector(name, val)", a => {
                m_InternalObject.SetVector(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetMatrix"] = new BSFunctionReference(new BSFunction("function SetMatrix(name, val)", a => {
                m_InternalObject.SetMatrix(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Matrix4x4>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetBool"] = new BSFunctionReference(new BSFunction("function SetBool(name, val)", a => {
                m_InternalObject.SetBool(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Boolean>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetBool"] = new BSFunctionReference(new BSFunction("function SetBool(nameID, val)", a => {
                m_InternalObject.SetBool(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Boolean>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetTexture"] = new BSFunctionReference(new BSFunction("function SetTexture(name, texture)", a => {
                m_InternalObject.SetTexture(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Texture>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetBuffer"] = new BSFunctionReference(new BSFunction("function SetBuffer(name, buffer)", a => {
                m_InternalObject.SetBuffer(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetBuffer"] = new BSFunctionReference(new BSFunction("function SetBuffer(name, buffer)", a => {
                m_InternalObject.SetBuffer(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetConstantBuffer"] = new BSFunctionReference(new BSFunction("function SetConstantBuffer(nameID, buffer, offset, size)", a => {
                m_InternalObject.SetConstantBuffer(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]));
                return new BSObject(null);
            }, 4));
            m_Properties["SetConstantBuffer"] = new BSFunctionReference(new BSFunction("function SetConstantBuffer(name, buffer, offset, size)", a => {
                m_InternalObject.SetConstantBuffer(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]));
                return new BSObject(null);
            }, 4));
            m_Properties["SetConstantBuffer"] = new BSFunctionReference(new BSFunction("function SetConstantBuffer(nameID, buffer, offset, size)", a => {
                m_InternalObject.SetConstantBuffer(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]));
                return new BSObject(null);
            }, 4));
            m_Properties["SetConstantBuffer"] = new BSFunctionReference(new BSFunction("function SetConstantBuffer(name, buffer, offset, size)", a => {
                m_InternalObject.SetConstantBuffer(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]));
                return new BSObject(null);
            }, 4));
            m_Properties["SetAccelerationStructure"] = new BSFunctionReference(new BSFunction("function SetAccelerationStructure(name, accelerationStructure)", a => {
                m_InternalObject.SetAccelerationStructure(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetTextureFromGlobal"] = new BSFunctionReference(new BSFunction("function SetTextureFromGlobal(name, globalTextureName)", a => {
                m_InternalObject.SetTextureFromGlobal(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["GetInstanceID"] = new BSFunctionReference(new BSFunction("function GetInstanceID()", a => new BSObject((decimal)m_InternalObject.GetInstanceID()), 0));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}