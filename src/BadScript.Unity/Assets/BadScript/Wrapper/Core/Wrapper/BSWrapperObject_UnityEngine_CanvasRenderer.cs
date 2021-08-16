using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_CanvasRenderer : BSWrapperObject<UnityEngine.CanvasRenderer>

    {
        public BSWrapperObject_UnityEngine_CanvasRenderer(UnityEngine.CanvasRenderer obj) : base(obj)
        {
            m_Properties["hasPopInstruction"] = new BSReflectionReference(() => m_InternalObject.hasPopInstruction ? BSObject.One : BSObject.Zero, x=> m_InternalObject.hasPopInstruction = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["materialCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.materialCount), x=> m_InternalObject.materialCount = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["popMaterialCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.popMaterialCount), x=> m_InternalObject.popMaterialCount = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["absoluteDepth"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.absoluteDepth), null);
            m_Properties["hasMoved"] = new BSReflectionReference(() => m_InternalObject.hasMoved ? BSObject.One : BSObject.Zero, null);
            m_Properties["cullTransparentMesh"] = new BSReflectionReference(() => m_InternalObject.cullTransparentMesh ? BSObject.One : BSObject.Zero, x=> m_InternalObject.cullTransparentMesh = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["hasRectClipping"] = new BSReflectionReference(() => m_InternalObject.hasRectClipping ? BSObject.One : BSObject.Zero, null);
            m_Properties["relativeDepth"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.relativeDepth), null);
            m_Properties["cull"] = new BSReflectionReference(() => m_InternalObject.cull ? BSObject.One : BSObject.Zero, x=> m_InternalObject.cull = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["isMask"] = new BSReflectionReference(() => m_InternalObject.isMask ? BSObject.One : BSObject.Zero, x=> m_InternalObject.isMask = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["clippingSoftness"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.clippingSoftness), x=> m_InternalObject.clippingSoftness = WrapperHelper.UnwrapObject<UnityEngine.Vector2>(x));
            m_Properties["transform"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Transform(m_InternalObject.transform), null);
            m_Properties["gameObject"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_GameObject(m_InternalObject.gameObject), null);
            m_Properties["tag"] = new BSReflectionReference(() => new BSObject(m_InternalObject.tag), x=> m_InternalObject.tag = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["SetColor"] = new BSFunctionReference(new BSFunction("function SetColor(color)", a => {
                m_InternalObject.SetColor(WrapperHelper.UnwrapObject<UnityEngine.Color>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["GetColor"] = new BSFunctionReference(new BSFunction("function GetColor()", a => new BSWrapperObject_UnityEngine_Color(m_InternalObject.GetColor()), 0));
            m_Properties["EnableRectClipping"] = new BSFunctionReference(new BSFunction("function EnableRectClipping(rect)", a => {
                m_InternalObject.EnableRectClipping(WrapperHelper.UnwrapObject<UnityEngine.Rect>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["DisableRectClipping"] = new BSFunctionReference(new BSFunction("function DisableRectClipping()", a => {
                m_InternalObject.DisableRectClipping();
                return new BSObject(null);
            }, 0));
            m_Properties["SetMaterial"] = new BSFunctionReference(new BSFunction("function SetMaterial(material, index)", a => {
                m_InternalObject.SetMaterial(WrapperHelper.UnwrapObject<UnityEngine.Material>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["GetMaterial"] = new BSFunctionReference(new BSFunction("function GetMaterial(index)", a => new BSWrapperObject_UnityEngine_Material(m_InternalObject.GetMaterial(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["SetPopMaterial"] = new BSFunctionReference(new BSFunction("function SetPopMaterial(material, index)", a => {
                m_InternalObject.SetPopMaterial(WrapperHelper.UnwrapObject<UnityEngine.Material>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["GetPopMaterial"] = new BSFunctionReference(new BSFunction("function GetPopMaterial(index)", a => new BSWrapperObject_UnityEngine_Material(m_InternalObject.GetPopMaterial(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["SetTexture"] = new BSFunctionReference(new BSFunction("function SetTexture(texture)", a => {
                m_InternalObject.SetTexture(WrapperHelper.UnwrapObject<UnityEngine.Texture>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["SetAlphaTexture"] = new BSFunctionReference(new BSFunction("function SetAlphaTexture(texture)", a => {
                m_InternalObject.SetAlphaTexture(WrapperHelper.UnwrapObject<UnityEngine.Texture>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["SetMesh"] = new BSFunctionReference(new BSFunction("function SetMesh(mesh)", a => {
                m_InternalObject.SetMesh(WrapperHelper.UnwrapObject<UnityEngine.Mesh>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Clear"] = new BSFunctionReference(new BSFunction("function Clear()", a => {
                m_InternalObject.Clear();
                return new BSObject(null);
            }, 0));
            m_Properties["GetAlpha"] = new BSFunctionReference(new BSFunction("function GetAlpha()", a => new BSObject((decimal)m_InternalObject.GetAlpha()), 0));
            m_Properties["SetAlpha"] = new BSFunctionReference(new BSFunction("function SetAlpha(alpha)", a => {
                m_InternalObject.SetAlpha(WrapperHelper.UnwrapObject<System.Single>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["GetInheritedAlpha"] = new BSFunctionReference(new BSFunction("function GetInheritedAlpha()", a => new BSObject((decimal)m_InternalObject.GetInheritedAlpha()), 0));
            m_Properties["SetMaterial"] = new BSFunctionReference(new BSFunction("function SetMaterial(material, texture)", a => {
                m_InternalObject.SetMaterial(WrapperHelper.UnwrapObject<UnityEngine.Material>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Texture>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["GetMaterial"] = new BSFunctionReference(new BSFunction("function GetMaterial()", a => new BSWrapperObject_UnityEngine_Material(m_InternalObject.GetMaterial()), 0));
            m_Properties["GetComponent"] = new BSFunctionReference(new BSFunction("function GetComponent(type)", a => new BSWrapperObject_UnityEngine_Component(m_InternalObject.GetComponent(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["CompareTag"] = new BSFunctionReference(new BSFunction("function CompareTag(tag)", a => m_InternalObject.CompareTag(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["SendMessageUpwards"] = new BSFunctionReference(new BSFunction("function SendMessageUpwards(methodName, value)", a => {
                m_InternalObject.SendMessageUpwards(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SendMessageUpwards"] = new BSFunctionReference(new BSFunction("function SendMessageUpwards(methodName)", a => {
                m_InternalObject.SendMessageUpwards(WrapperHelper.UnwrapObject<System.String>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["SendMessage"] = new BSFunctionReference(new BSFunction("function SendMessage(methodName, value)", a => {
                m_InternalObject.SendMessage(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SendMessage"] = new BSFunctionReference(new BSFunction("function SendMessage(methodName)", a => {
                m_InternalObject.SendMessage(WrapperHelper.UnwrapObject<System.String>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["BroadcastMessage"] = new BSFunctionReference(new BSFunction("function BroadcastMessage(methodName, parameter)", a => {
                m_InternalObject.BroadcastMessage(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["BroadcastMessage"] = new BSFunctionReference(new BSFunction("function BroadcastMessage(methodName)", a => {
                m_InternalObject.BroadcastMessage(WrapperHelper.UnwrapObject<System.String>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["GetInstanceID"] = new BSFunctionReference(new BSFunction("function GetInstanceID()", a => new BSObject((decimal)m_InternalObject.GetInstanceID()), 0));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(other)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}