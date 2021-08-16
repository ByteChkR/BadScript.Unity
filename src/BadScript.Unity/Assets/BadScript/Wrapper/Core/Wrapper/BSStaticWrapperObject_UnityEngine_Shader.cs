using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Shader : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Shader() : base(typeof(UnityEngine.Shader))
        {
            m_StaticProperties["globalMaximumLOD"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Shader.globalMaximumLOD), x=> UnityEngine.Shader.globalMaximumLOD = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_StaticProperties["globalRenderPipeline"] = new BSReflectionReference(() => new BSObject(UnityEngine.Shader.globalRenderPipeline), x=> UnityEngine.Shader.globalRenderPipeline = WrapperHelper.UnwrapObject<System.String>(x));
            m_StaticProperties["Find"] = new BSFunctionReference(new BSFunction("function Find(name)", a => new BSWrapperObject_UnityEngine_Shader(UnityEngine.Shader.Find(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["EnableKeyword"] = new BSFunctionReference(new BSFunction("function EnableKeyword(keyword)", a => {
                UnityEngine.Shader.EnableKeyword(WrapperHelper.UnwrapObject<System.String>(a[0]));
                return new BSObject(null);
            }, 1));
            m_StaticProperties["DisableKeyword"] = new BSFunctionReference(new BSFunction("function DisableKeyword(keyword)", a => {
                UnityEngine.Shader.DisableKeyword(WrapperHelper.UnwrapObject<System.String>(a[0]));
                return new BSObject(null);
            }, 1));
            m_StaticProperties["IsKeywordEnabled"] = new BSFunctionReference(new BSFunction("function IsKeywordEnabled(keyword)", a => UnityEngine.Shader.IsKeywordEnabled(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["WarmupAllShaders"] = new BSFunctionReference(new BSFunction("function WarmupAllShaders()", a => {
                UnityEngine.Shader.WarmupAllShaders();
                return new BSObject(null);
            }, 0));
            m_StaticProperties["PropertyToID"] = new BSFunctionReference(new BSFunction("function PropertyToID(name)", a => new BSObject((decimal)UnityEngine.Shader.PropertyToID(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["SetGlobalFloat"] = new BSFunctionReference(new BSFunction("function SetGlobalFloat(name, value)", a => {
                UnityEngine.Shader.SetGlobalFloat(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalFloat"] = new BSFunctionReference(new BSFunction("function SetGlobalFloat(nameID, value)", a => {
                UnityEngine.Shader.SetGlobalFloat(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalInt"] = new BSFunctionReference(new BSFunction("function SetGlobalInt(name, value)", a => {
                UnityEngine.Shader.SetGlobalInt(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalInt"] = new BSFunctionReference(new BSFunction("function SetGlobalInt(nameID, value)", a => {
                UnityEngine.Shader.SetGlobalInt(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalVector"] = new BSFunctionReference(new BSFunction("function SetGlobalVector(name, value)", a => {
                UnityEngine.Shader.SetGlobalVector(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalVector"] = new BSFunctionReference(new BSFunction("function SetGlobalVector(nameID, value)", a => {
                UnityEngine.Shader.SetGlobalVector(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector4>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalColor"] = new BSFunctionReference(new BSFunction("function SetGlobalColor(name, value)", a => {
                UnityEngine.Shader.SetGlobalColor(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Color>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalColor"] = new BSFunctionReference(new BSFunction("function SetGlobalColor(nameID, value)", a => {
                UnityEngine.Shader.SetGlobalColor(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Color>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalMatrix"] = new BSFunctionReference(new BSFunction("function SetGlobalMatrix(name, value)", a => {
                UnityEngine.Shader.SetGlobalMatrix(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Matrix4x4>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalMatrix"] = new BSFunctionReference(new BSFunction("function SetGlobalMatrix(nameID, value)", a => {
                UnityEngine.Shader.SetGlobalMatrix(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Matrix4x4>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalTexture"] = new BSFunctionReference(new BSFunction("function SetGlobalTexture(name, value)", a => {
                UnityEngine.Shader.SetGlobalTexture(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Texture>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalTexture"] = new BSFunctionReference(new BSFunction("function SetGlobalTexture(nameID, value)", a => {
                UnityEngine.Shader.SetGlobalTexture(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Texture>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalBuffer"] = new BSFunctionReference(new BSFunction("function SetGlobalBuffer(name, value)", a => {
                UnityEngine.Shader.SetGlobalBuffer(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalBuffer"] = new BSFunctionReference(new BSFunction("function SetGlobalBuffer(nameID, value)", a => {
                UnityEngine.Shader.SetGlobalBuffer(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalBuffer"] = new BSFunctionReference(new BSFunction("function SetGlobalBuffer(name, value)", a => {
                UnityEngine.Shader.SetGlobalBuffer(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalBuffer"] = new BSFunctionReference(new BSFunction("function SetGlobalBuffer(nameID, value)", a => {
                UnityEngine.Shader.SetGlobalBuffer(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["SetGlobalConstantBuffer"] = new BSFunctionReference(new BSFunction("function SetGlobalConstantBuffer(name, value, offset, size)", a => {
                UnityEngine.Shader.SetGlobalConstantBuffer(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]));
                return new BSObject(null);
            }, 4));
            m_StaticProperties["SetGlobalConstantBuffer"] = new BSFunctionReference(new BSFunction("function SetGlobalConstantBuffer(nameID, value, offset, size)", a => {
                UnityEngine.Shader.SetGlobalConstantBuffer(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.ComputeBuffer>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]));
                return new BSObject(null);
            }, 4));
            m_StaticProperties["SetGlobalConstantBuffer"] = new BSFunctionReference(new BSFunction("function SetGlobalConstantBuffer(name, value, offset, size)", a => {
                UnityEngine.Shader.SetGlobalConstantBuffer(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]));
                return new BSObject(null);
            }, 4));
            m_StaticProperties["SetGlobalConstantBuffer"] = new BSFunctionReference(new BSFunction("function SetGlobalConstantBuffer(nameID, value, offset, size)", a => {
                UnityEngine.Shader.SetGlobalConstantBuffer(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.GraphicsBuffer>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]));
                return new BSObject(null);
            }, 4));
            m_StaticProperties["GetGlobalFloat"] = new BSFunctionReference(new BSFunction("function GetGlobalFloat(name)", a => new BSObject((decimal)UnityEngine.Shader.GetGlobalFloat(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["GetGlobalFloat"] = new BSFunctionReference(new BSFunction("function GetGlobalFloat(nameID)", a => new BSObject((decimal)UnityEngine.Shader.GetGlobalFloat(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_StaticProperties["GetGlobalInt"] = new BSFunctionReference(new BSFunction("function GetGlobalInt(name)", a => new BSObject((decimal)UnityEngine.Shader.GetGlobalInt(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["GetGlobalInt"] = new BSFunctionReference(new BSFunction("function GetGlobalInt(nameID)", a => new BSObject((decimal)UnityEngine.Shader.GetGlobalInt(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_StaticProperties["GetGlobalVector"] = new BSFunctionReference(new BSFunction("function GetGlobalVector(name)", a => new BSWrapperObject_UnityEngine_Vector4(UnityEngine.Shader.GetGlobalVector(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["GetGlobalVector"] = new BSFunctionReference(new BSFunction("function GetGlobalVector(nameID)", a => new BSWrapperObject_UnityEngine_Vector4(UnityEngine.Shader.GetGlobalVector(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_StaticProperties["GetGlobalColor"] = new BSFunctionReference(new BSFunction("function GetGlobalColor(name)", a => new BSWrapperObject_UnityEngine_Color(UnityEngine.Shader.GetGlobalColor(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["GetGlobalColor"] = new BSFunctionReference(new BSFunction("function GetGlobalColor(nameID)", a => new BSWrapperObject_UnityEngine_Color(UnityEngine.Shader.GetGlobalColor(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_StaticProperties["GetGlobalMatrix"] = new BSFunctionReference(new BSFunction("function GetGlobalMatrix(name)", a => new BSWrapperObject_UnityEngine_Matrix4x4(UnityEngine.Shader.GetGlobalMatrix(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["GetGlobalMatrix"] = new BSFunctionReference(new BSFunction("function GetGlobalMatrix(nameID)", a => new BSWrapperObject_UnityEngine_Matrix4x4(UnityEngine.Shader.GetGlobalMatrix(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_StaticProperties["GetGlobalTexture"] = new BSFunctionReference(new BSFunction("function GetGlobalTexture(name)", a => new BSWrapperObject_UnityEngine_Texture(UnityEngine.Shader.GetGlobalTexture(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_StaticProperties["GetGlobalTexture"] = new BSFunctionReference(new BSFunction("function GetGlobalTexture(nameID)", a => new BSWrapperObject_UnityEngine_Texture(UnityEngine.Shader.GetGlobalTexture(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));

        }
    }

}