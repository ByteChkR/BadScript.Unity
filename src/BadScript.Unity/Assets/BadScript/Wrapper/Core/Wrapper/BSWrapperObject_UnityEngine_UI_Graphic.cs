using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UI_Graphic : BSWrapperObject<UnityEngine.UI.Graphic>

    {
        public BSWrapperObject_UnityEngine_UI_Graphic(UnityEngine.UI.Graphic obj) : base(obj)
        {
            m_Properties["color"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Color(m_InternalObject.color), x=> m_InternalObject.color = WrapperHelper.UnwrapObject<UnityEngine.Color>(x));
            m_Properties["raycastTarget"] = new BSReflectionReference(() => m_InternalObject.raycastTarget ? BSObject.One : BSObject.Zero, x=> m_InternalObject.raycastTarget = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["raycastPadding"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector4(m_InternalObject.raycastPadding), x=> m_InternalObject.raycastPadding = WrapperHelper.UnwrapObject<UnityEngine.Vector4>(x));
            m_Properties["depth"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.depth), null);
            m_Properties["rectTransform"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_RectTransform(m_InternalObject.rectTransform), null);
            m_Properties["canvas"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Canvas(m_InternalObject.canvas), null);
            m_Properties["canvasRenderer"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_CanvasRenderer(m_InternalObject.canvasRenderer), null);
            m_Properties["defaultMaterial"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Material(m_InternalObject.defaultMaterial), null);
            m_Properties["material"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Material(m_InternalObject.material), x=> m_InternalObject.material = WrapperHelper.UnwrapObject<UnityEngine.Material>(x));
            m_Properties["materialForRendering"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Material(m_InternalObject.materialForRendering), null);
            m_Properties["mainTexture"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Texture(m_InternalObject.mainTexture), null);
            m_Properties["useGUILayout"] = new BSReflectionReference(() => m_InternalObject.useGUILayout ? BSObject.One : BSObject.Zero, x=> m_InternalObject.useGUILayout = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["runInEditMode"] = new BSReflectionReference(() => m_InternalObject.runInEditMode ? BSObject.One : BSObject.Zero, x=> m_InternalObject.runInEditMode = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["enabled"] = new BSReflectionReference(() => m_InternalObject.enabled ? BSObject.One : BSObject.Zero, x=> m_InternalObject.enabled = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["isActiveAndEnabled"] = new BSReflectionReference(() => m_InternalObject.isActiveAndEnabled ? BSObject.One : BSObject.Zero, null);
            m_Properties["transform"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Transform(m_InternalObject.transform), null);
            m_Properties["gameObject"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_GameObject(m_InternalObject.gameObject), null);
            m_Properties["tag"] = new BSReflectionReference(() => new BSObject(m_InternalObject.tag), x=> m_InternalObject.tag = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["SetAllDirty"] = new BSFunctionReference(new BSFunction("function SetAllDirty()", a => {
                m_InternalObject.SetAllDirty();
                return new BSObject(null);
            }, 0));
            m_Properties["SetLayoutDirty"] = new BSFunctionReference(new BSFunction("function SetLayoutDirty()", a => {
                m_InternalObject.SetLayoutDirty();
                return new BSObject(null);
            }, 0));
            m_Properties["SetVerticesDirty"] = new BSFunctionReference(new BSFunction("function SetVerticesDirty()", a => {
                m_InternalObject.SetVerticesDirty();
                return new BSObject(null);
            }, 0));
            m_Properties["SetMaterialDirty"] = new BSFunctionReference(new BSFunction("function SetMaterialDirty()", a => {
                m_InternalObject.SetMaterialDirty();
                return new BSObject(null);
            }, 0));
            m_Properties["OnCullingChanged"] = new BSFunctionReference(new BSFunction("function OnCullingChanged()", a => {
                m_InternalObject.OnCullingChanged();
                return new BSObject(null);
            }, 0));
            m_Properties["LayoutComplete"] = new BSFunctionReference(new BSFunction("function LayoutComplete()", a => {
                m_InternalObject.LayoutComplete();
                return new BSObject(null);
            }, 0));
            m_Properties["GraphicUpdateComplete"] = new BSFunctionReference(new BSFunction("function GraphicUpdateComplete()", a => {
                m_InternalObject.GraphicUpdateComplete();
                return new BSObject(null);
            }, 0));
            m_Properties["OnRebuildRequested"] = new BSFunctionReference(new BSFunction("function OnRebuildRequested()", a => {
                m_InternalObject.OnRebuildRequested();
                return new BSObject(null);
            }, 0));
            m_Properties["SetNativeSize"] = new BSFunctionReference(new BSFunction("function SetNativeSize()", a => {
                m_InternalObject.SetNativeSize();
                return new BSObject(null);
            }, 0));
            m_Properties["Raycast"] = new BSFunctionReference(new BSFunction("function Raycast(sp, eventCamera)", a => m_InternalObject.Raycast(WrapperHelper.UnwrapObject<UnityEngine.Vector2>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Camera>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_Properties["PixelAdjustPoint"] = new BSFunctionReference(new BSFunction("function PixelAdjustPoint(point)", a => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.PixelAdjustPoint(WrapperHelper.UnwrapObject<UnityEngine.Vector2>(a[0]))), 1));
            m_Properties["GetPixelAdjustedRect"] = new BSFunctionReference(new BSFunction("function GetPixelAdjustedRect()", a => new BSWrapperObject_UnityEngine_Rect(m_InternalObject.GetPixelAdjustedRect()), 0));
            m_Properties["CrossFadeColor"] = new BSFunctionReference(new BSFunction("function CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha)", a => {
                m_InternalObject.CrossFadeColor(WrapperHelper.UnwrapObject<UnityEngine.Color>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Boolean>(a[2]), WrapperHelper.UnwrapObject<System.Boolean>(a[3]));
                return new BSObject(null);
            }, 4));
            m_Properties["CrossFadeColor"] = new BSFunctionReference(new BSFunction("function CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB)", a => {
                m_InternalObject.CrossFadeColor(WrapperHelper.UnwrapObject<UnityEngine.Color>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Boolean>(a[2]), WrapperHelper.UnwrapObject<System.Boolean>(a[3]), WrapperHelper.UnwrapObject<System.Boolean>(a[4]));
                return new BSObject(null);
            }, 5));
            m_Properties["CrossFadeAlpha"] = new BSFunctionReference(new BSFunction("function CrossFadeAlpha(alpha, duration, ignoreTimeScale)", a => {
                m_InternalObject.CrossFadeAlpha(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Boolean>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["RegisterDirtyLayoutCallback"] = new BSFunctionReference(new BSFunction("function RegisterDirtyLayoutCallback(action)", a => {
                m_InternalObject.RegisterDirtyLayoutCallback(WrapperHelper.UnwrapObject<UnityEngine.Events.UnityAction>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["UnregisterDirtyLayoutCallback"] = new BSFunctionReference(new BSFunction("function UnregisterDirtyLayoutCallback(action)", a => {
                m_InternalObject.UnregisterDirtyLayoutCallback(WrapperHelper.UnwrapObject<UnityEngine.Events.UnityAction>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["RegisterDirtyVerticesCallback"] = new BSFunctionReference(new BSFunction("function RegisterDirtyVerticesCallback(action)", a => {
                m_InternalObject.RegisterDirtyVerticesCallback(WrapperHelper.UnwrapObject<UnityEngine.Events.UnityAction>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["UnregisterDirtyVerticesCallback"] = new BSFunctionReference(new BSFunction("function UnregisterDirtyVerticesCallback(action)", a => {
                m_InternalObject.UnregisterDirtyVerticesCallback(WrapperHelper.UnwrapObject<UnityEngine.Events.UnityAction>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["RegisterDirtyMaterialCallback"] = new BSFunctionReference(new BSFunction("function RegisterDirtyMaterialCallback(action)", a => {
                m_InternalObject.RegisterDirtyMaterialCallback(WrapperHelper.UnwrapObject<UnityEngine.Events.UnityAction>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["UnregisterDirtyMaterialCallback"] = new BSFunctionReference(new BSFunction("function UnregisterDirtyMaterialCallback(action)", a => {
                m_InternalObject.UnregisterDirtyMaterialCallback(WrapperHelper.UnwrapObject<UnityEngine.Events.UnityAction>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["IsActive"] = new BSFunctionReference(new BSFunction("function IsActive()", a => m_InternalObject.IsActive() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["IsDestroyed"] = new BSFunctionReference(new BSFunction("function IsDestroyed()", a => m_InternalObject.IsDestroyed() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["IsInvoking"] = new BSFunctionReference(new BSFunction("function IsInvoking()", a => m_InternalObject.IsInvoking() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["CancelInvoke"] = new BSFunctionReference(new BSFunction("function CancelInvoke()", a => {
                m_InternalObject.CancelInvoke();
                return new BSObject(null);
            }, 0));
            m_Properties["Invoke"] = new BSFunctionReference(new BSFunction("function Invoke(methodName, time)", a => {
                m_InternalObject.Invoke(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["InvokeRepeating"] = new BSFunctionReference(new BSFunction("function InvokeRepeating(methodName, time, repeatRate)", a => {
                m_InternalObject.InvokeRepeating(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["CancelInvoke"] = new BSFunctionReference(new BSFunction("function CancelInvoke(methodName)", a => {
                m_InternalObject.CancelInvoke(WrapperHelper.UnwrapObject<System.String>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["IsInvoking"] = new BSFunctionReference(new BSFunction("function IsInvoking(methodName)", a => m_InternalObject.IsInvoking(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["StartCoroutine"] = new BSFunctionReference(new BSFunction("function StartCoroutine(methodName)", a => new BSWrapperObject_UnityEngine_Coroutine(m_InternalObject.StartCoroutine(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["StartCoroutine"] = new BSFunctionReference(new BSFunction("function StartCoroutine(methodName, value)", a => new BSWrapperObject_UnityEngine_Coroutine(m_InternalObject.StartCoroutine(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]))), 2));
            m_Properties["StartCoroutine"] = new BSFunctionReference(new BSFunction("function StartCoroutine(routine)", a => new BSWrapperObject_UnityEngine_Coroutine(m_InternalObject.StartCoroutine(WrapperHelper.UnwrapObject<System.Collections.IEnumerator>(a[0]))), 1));
            m_Properties["StartCoroutine_Auto"] = new BSFunctionReference(new BSFunction("function StartCoroutine_Auto(routine)", a => new BSWrapperObject_UnityEngine_Coroutine(m_InternalObject.StartCoroutine(WrapperHelper.UnwrapObject<System.Collections.IEnumerator>(a[0]))), 1));
            m_Properties["StopCoroutine"] = new BSFunctionReference(new BSFunction("function StopCoroutine(routine)", a => {
                m_InternalObject.StopCoroutine(WrapperHelper.UnwrapObject<System.Collections.IEnumerator>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["StopCoroutine"] = new BSFunctionReference(new BSFunction("function StopCoroutine(routine)", a => {
                m_InternalObject.StopCoroutine(WrapperHelper.UnwrapObject<UnityEngine.Coroutine>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["StopCoroutine"] = new BSFunctionReference(new BSFunction("function StopCoroutine(methodName)", a => {
                m_InternalObject.StopCoroutine(WrapperHelper.UnwrapObject<System.String>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["StopAllCoroutines"] = new BSFunctionReference(new BSFunction("function StopAllCoroutines()", a => {
                m_InternalObject.StopAllCoroutines();
                return new BSObject(null);
            }, 0));
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