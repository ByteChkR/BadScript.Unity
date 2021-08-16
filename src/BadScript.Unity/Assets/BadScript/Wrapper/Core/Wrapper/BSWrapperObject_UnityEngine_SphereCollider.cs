using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_SphereCollider : BSWrapperObject<UnityEngine.SphereCollider>

    {
        public BSWrapperObject_UnityEngine_SphereCollider(UnityEngine.SphereCollider obj) : base(obj)
        {
            m_Properties["center"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.center), x=> m_InternalObject.center = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["radius"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.radius), x=> m_InternalObject.radius = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["enabled"] = new BSReflectionReference(() => m_InternalObject.enabled ? BSObject.One : BSObject.Zero, x=> m_InternalObject.enabled = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["attachedRigidbody"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Rigidbody(m_InternalObject.attachedRigidbody), null);
            m_Properties["attachedArticulationBody"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_ArticulationBody(m_InternalObject.attachedArticulationBody), null);
            m_Properties["isTrigger"] = new BSReflectionReference(() => m_InternalObject.isTrigger ? BSObject.One : BSObject.Zero, x=> m_InternalObject.isTrigger = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["contactOffset"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.contactOffset), x=> m_InternalObject.contactOffset = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["bounds"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Bounds(m_InternalObject.bounds), null);
            m_Properties["sharedMaterial"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_PhysicMaterial(m_InternalObject.sharedMaterial), x=> m_InternalObject.sharedMaterial = WrapperHelper.UnwrapObject<UnityEngine.PhysicMaterial>(x));
            m_Properties["material"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_PhysicMaterial(m_InternalObject.material), x=> m_InternalObject.material = WrapperHelper.UnwrapObject<UnityEngine.PhysicMaterial>(x));
            m_Properties["transform"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Transform(m_InternalObject.transform), null);
            m_Properties["gameObject"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_GameObject(m_InternalObject.gameObject), null);
            m_Properties["tag"] = new BSReflectionReference(() => new BSObject(m_InternalObject.tag), x=> m_InternalObject.tag = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["ClosestPoint"] = new BSFunctionReference(new BSFunction("function ClosestPoint(position)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.ClosestPoint(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_Properties["ClosestPointOnBounds"] = new BSFunctionReference(new BSFunction("function ClosestPointOnBounds(position)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.ClosestPointOnBounds(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
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