using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_EventSystems_BaseInputModule : BSWrapperObject<UnityEngine.EventSystems.BaseInputModule>

    {
        public BSWrapperObject_UnityEngine_EventSystems_BaseInputModule(UnityEngine.EventSystems.BaseInputModule obj) : base(obj)
        {
            m_Properties["input"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_EventSystems_BaseInput(m_InternalObject.input), null);
            m_Properties["inputOverride"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_EventSystems_BaseInput(m_InternalObject.inputOverride), x=> m_InternalObject.inputOverride = WrapperHelper.UnwrapObject<UnityEngine.EventSystems.BaseInput>(x));
            m_Properties["useGUILayout"] = new BSReflectionReference(() => m_InternalObject.useGUILayout ? BSObject.One : BSObject.Zero, x=> m_InternalObject.useGUILayout = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["runInEditMode"] = new BSReflectionReference(() => m_InternalObject.runInEditMode ? BSObject.One : BSObject.Zero, x=> m_InternalObject.runInEditMode = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["enabled"] = new BSReflectionReference(() => m_InternalObject.enabled ? BSObject.One : BSObject.Zero, x=> m_InternalObject.enabled = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["isActiveAndEnabled"] = new BSReflectionReference(() => m_InternalObject.isActiveAndEnabled ? BSObject.One : BSObject.Zero, null);
            m_Properties["transform"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Transform(m_InternalObject.transform), null);
            m_Properties["gameObject"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_GameObject(m_InternalObject.gameObject), null);
            m_Properties["tag"] = new BSReflectionReference(() => new BSObject(m_InternalObject.tag), x=> m_InternalObject.tag = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["Process"] = new BSFunctionReference(new BSFunction("function Process()", a => {
                m_InternalObject.Process();
                return new BSObject(null);
            }, 0));
            m_Properties["IsPointerOverGameObject"] = new BSFunctionReference(new BSFunction("function IsPointerOverGameObject(pointerId)", a => m_InternalObject.IsPointerOverGameObject(WrapperHelper.UnwrapObject<System.Int32>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ShouldActivateModule"] = new BSFunctionReference(new BSFunction("function ShouldActivateModule()", a => m_InternalObject.ShouldActivateModule() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["DeactivateModule"] = new BSFunctionReference(new BSFunction("function DeactivateModule()", a => {
                m_InternalObject.DeactivateModule();
                return new BSObject(null);
            }, 0));
            m_Properties["ActivateModule"] = new BSFunctionReference(new BSFunction("function ActivateModule()", a => {
                m_InternalObject.ActivateModule();
                return new BSObject(null);
            }, 0));
            m_Properties["UpdateModule"] = new BSFunctionReference(new BSFunction("function UpdateModule()", a => {
                m_InternalObject.UpdateModule();
                return new BSObject(null);
            }, 0));
            m_Properties["IsModuleSupported"] = new BSFunctionReference(new BSFunction("function IsModuleSupported()", a => m_InternalObject.IsModuleSupported() ? BSObject.One : BSObject.Zero, 0));
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