using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_ComputeShader : BSWrapperObject<UnityEngine.ComputeShader>

    {
        public BSWrapperObject_UnityEngine_ComputeShader(UnityEngine.ComputeShader obj) : base(obj)
        {
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["FindKernel"] = new BSFunctionReference(new BSFunction("function FindKernel(name)", a => new BSObject((decimal)m_InternalObject.FindKernel(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["HasKernel"] = new BSFunctionReference(new BSFunction("function HasKernel(name)", a => m_InternalObject.HasKernel(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
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
            m_Properties["SetTexture"] = new BSFunctionReference(new BSFunction("function SetTexture(kernelIndex, nameID, texture, mipLevel)", a => {
                m_InternalObject.SetTexture(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Texture>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]));
                return new BSObject(null);
            }, 4));
            m_Properties["SetTextureFromGlobal"] = new BSFunctionReference(new BSFunction("function SetTextureFromGlobal(kernelIndex, nameID, globalTextureNameID)", a => {
                m_InternalObject.SetTextureFromGlobal(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["SetBuffer"] = new BSFunctionReference(new BSFunction("function SetBuffer(kernelIndex, nameID, buffer)", a => {
                m_InternalObject.SetBuffer(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["SetBuffer"] = new BSFunctionReference(new BSFunction("function SetBuffer(kernelIndex, nameID, buffer)", a => {
                m_InternalObject.SetBuffer(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["Dispatch"] = new BSFunctionReference(new BSFunction("function Dispatch(kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ)", a => {
                m_InternalObject.Dispatch(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]));
                return new BSObject(null);
            }, 4));
            m_Properties["EnableKeyword"] = new BSFunctionReference(new BSFunction("function EnableKeyword(keyword)", a => {
                m_InternalObject.EnableKeyword(WrapperHelper.UnwrapObject<System.String>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["DisableKeyword"] = new BSFunctionReference(new BSFunction("function DisableKeyword(keyword)", a => {
                m_InternalObject.DisableKeyword(WrapperHelper.UnwrapObject<System.String>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["IsKeywordEnabled"] = new BSFunctionReference(new BSFunction("function IsKeywordEnabled(keyword)", a => m_InternalObject.IsKeywordEnabled(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
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
            m_Properties["SetTexture"] = new BSFunctionReference(new BSFunction("function SetTexture(kernelIndex, nameID, texture)", a => {
                m_InternalObject.SetTexture(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Texture>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["SetTexture"] = new BSFunctionReference(new BSFunction("function SetTexture(kernelIndex, name, texture)", a => {
                m_InternalObject.SetTexture(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Texture>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["SetTexture"] = new BSFunctionReference(new BSFunction("function SetTexture(kernelIndex, name, texture, mipLevel)", a => {
                m_InternalObject.SetTexture(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Texture>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]));
                return new BSObject(null);
            }, 4));
            m_Properties["SetTextureFromGlobal"] = new BSFunctionReference(new BSFunction("function SetTextureFromGlobal(kernelIndex, name, globalTextureName)", a => {
                m_InternalObject.SetTextureFromGlobal(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]), WrapperHelper.UnwrapObject<System.String>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["SetBuffer"] = new BSFunctionReference(new BSFunction("function SetBuffer(kernelIndex, name, buffer)", a => {
                m_InternalObject.SetBuffer(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["SetBuffer"] = new BSFunctionReference(new BSFunction("function SetBuffer(kernelIndex, name, buffer)", a => {
                m_InternalObject.SetBuffer(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.String>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[2]));
                return new BSObject(null);
            }, 3));
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
            m_Properties["DispatchIndirect"] = new BSFunctionReference(new BSFunction("function DispatchIndirect(kernelIndex, argsBuffer, argsOffset)", a => {
                m_InternalObject.DispatchIndirect(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[1]), WrapperHelper.UnwrapObject<System.UInt32>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["DispatchIndirect"] = new BSFunctionReference(new BSFunction("function DispatchIndirect(kernelIndex, argsBuffer)", a => {
                m_InternalObject.DispatchIndirect(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["DispatchIndirect"] = new BSFunctionReference(new BSFunction("function DispatchIndirect(kernelIndex, argsBuffer, argsOffset)", a => {
                m_InternalObject.DispatchIndirect(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[1]), WrapperHelper.UnwrapObject<System.UInt32>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["DispatchIndirect"] = new BSFunctionReference(new BSFunction("function DispatchIndirect(kernelIndex, argsBuffer)", a => {
                m_InternalObject.DispatchIndirect(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["GetInstanceID"] = new BSFunctionReference(new BSFunction("function GetInstanceID()", a => new BSObject((decimal)m_InternalObject.GetInstanceID()), 0));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}