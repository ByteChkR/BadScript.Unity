using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Transform : BSWrapperObject<UnityEngine.Transform>

    {
        public BSWrapperObject_UnityEngine_Transform(UnityEngine.Transform obj) : base(obj)
        {
            m_Properties["position"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.position), x=> m_InternalObject.position = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["localPosition"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.localPosition), x=> m_InternalObject.localPosition = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["eulerAngles"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.eulerAngles), x=> m_InternalObject.eulerAngles = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["localEulerAngles"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.localEulerAngles), x=> m_InternalObject.localEulerAngles = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["right"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.right), x=> m_InternalObject.right = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["up"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.up), x=> m_InternalObject.up = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["forward"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.forward), x=> m_InternalObject.forward = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["rotation"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Quaternion(m_InternalObject.rotation), x=> m_InternalObject.rotation = WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(x));
            m_Properties["localRotation"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Quaternion(m_InternalObject.localRotation), x=> m_InternalObject.localRotation = WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(x));
            m_Properties["localScale"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.localScale), x=> m_InternalObject.localScale = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["parent"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Transform(m_InternalObject.parent), x=> m_InternalObject.parent = WrapperHelper.UnwrapObject<UnityEngine.Transform>(x));
            m_Properties["worldToLocalMatrix"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Matrix4x4(m_InternalObject.worldToLocalMatrix), null);
            m_Properties["localToWorldMatrix"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Matrix4x4(m_InternalObject.localToWorldMatrix), null);
            m_Properties["root"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Transform(m_InternalObject.root), null);
            m_Properties["childCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.childCount), null);
            m_Properties["lossyScale"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.lossyScale), null);
            m_Properties["hasChanged"] = new BSReflectionReference(() => m_InternalObject.hasChanged ? BSObject.One : BSObject.Zero, x=> m_InternalObject.hasChanged = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["hierarchyCapacity"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.hierarchyCapacity), x=> m_InternalObject.hierarchyCapacity = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["hierarchyCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.hierarchyCount), null);
            m_Properties["transform"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Transform(m_InternalObject.transform), null);
            m_Properties["gameObject"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_GameObject(m_InternalObject.gameObject), null);
            m_Properties["tag"] = new BSReflectionReference(() => new BSObject(m_InternalObject.tag), x=> m_InternalObject.tag = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["SetParent"] = new BSFunctionReference(new BSFunction("function SetParent(p)", a => {
                m_InternalObject.SetParent(WrapperHelper.UnwrapObject<UnityEngine.Transform>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["SetParent"] = new BSFunctionReference(new BSFunction("function SetParent(parent, worldPositionStays)", a => {
                m_InternalObject.SetParent(WrapperHelper.UnwrapObject<UnityEngine.Transform>(a[0]), WrapperHelper.UnwrapObject<System.Boolean>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["SetPositionAndRotation"] = new BSFunctionReference(new BSFunction("function SetPositionAndRotation(position, rotation)", a => {
                m_InternalObject.SetPositionAndRotation(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Translate"] = new BSFunctionReference(new BSFunction("function Translate(translation)", a => {
                m_InternalObject.Translate(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Translate"] = new BSFunctionReference(new BSFunction("function Translate(x, y, z)", a => {
                m_InternalObject.Translate(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["Translate"] = new BSFunctionReference(new BSFunction("function Translate(translation, relativeTo)", a => {
                m_InternalObject.Translate(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Transform>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Translate"] = new BSFunctionReference(new BSFunction("function Translate(x, y, z, relativeTo)", a => {
                m_InternalObject.Translate(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]), WrapperHelper.UnwrapObject<UnityEngine.Transform>(a[3]));
                return new BSObject(null);
            }, 4));
            m_Properties["Rotate"] = new BSFunctionReference(new BSFunction("function Rotate(eulers)", a => {
                m_InternalObject.Rotate(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Rotate"] = new BSFunctionReference(new BSFunction("function Rotate(xAngle, yAngle, zAngle)", a => {
                m_InternalObject.Rotate(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["Rotate"] = new BSFunctionReference(new BSFunction("function Rotate(axis, angle)", a => {
                m_InternalObject.Rotate(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["RotateAround"] = new BSFunctionReference(new BSFunction("function RotateAround(point, axis, angle)", a => {
                m_InternalObject.RotateAround(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]));
                return new BSObject(null);
            }, 3));
            m_Properties["LookAt"] = new BSFunctionReference(new BSFunction("function LookAt(target, worldUp)", a => {
                m_InternalObject.LookAt(WrapperHelper.UnwrapObject<UnityEngine.Transform>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["LookAt"] = new BSFunctionReference(new BSFunction("function LookAt(target)", a => {
                m_InternalObject.LookAt(WrapperHelper.UnwrapObject<UnityEngine.Transform>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["LookAt"] = new BSFunctionReference(new BSFunction("function LookAt(worldPosition, worldUp)", a => {
                m_InternalObject.LookAt(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["LookAt"] = new BSFunctionReference(new BSFunction("function LookAt(worldPosition)", a => {
                m_InternalObject.LookAt(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["TransformDirection"] = new BSFunctionReference(new BSFunction("function TransformDirection(direction)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.TransformDirection(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_Properties["TransformDirection"] = new BSFunctionReference(new BSFunction("function TransformDirection(x, y, z)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.TransformDirection(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_Properties["InverseTransformDirection"] = new BSFunctionReference(new BSFunction("function InverseTransformDirection(direction)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.InverseTransformDirection(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_Properties["InverseTransformDirection"] = new BSFunctionReference(new BSFunction("function InverseTransformDirection(x, y, z)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.InverseTransformDirection(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_Properties["TransformVector"] = new BSFunctionReference(new BSFunction("function TransformVector(vector)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.TransformVector(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_Properties["TransformVector"] = new BSFunctionReference(new BSFunction("function TransformVector(x, y, z)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.TransformVector(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_Properties["InverseTransformVector"] = new BSFunctionReference(new BSFunction("function InverseTransformVector(vector)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.InverseTransformVector(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_Properties["InverseTransformVector"] = new BSFunctionReference(new BSFunction("function InverseTransformVector(x, y, z)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.InverseTransformVector(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_Properties["TransformPoint"] = new BSFunctionReference(new BSFunction("function TransformPoint(position)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.TransformPoint(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_Properties["TransformPoint"] = new BSFunctionReference(new BSFunction("function TransformPoint(x, y, z)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.TransformPoint(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_Properties["InverseTransformPoint"] = new BSFunctionReference(new BSFunction("function InverseTransformPoint(position)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.InverseTransformPoint(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]))), 1));
            m_Properties["InverseTransformPoint"] = new BSFunctionReference(new BSFunction("function InverseTransformPoint(x, y, z)", a => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.InverseTransformPoint(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]))), 3));
            m_Properties["DetachChildren"] = new BSFunctionReference(new BSFunction("function DetachChildren()", a => {
                m_InternalObject.DetachChildren();
                return new BSObject(null);
            }, 0));
            m_Properties["SetAsFirstSibling"] = new BSFunctionReference(new BSFunction("function SetAsFirstSibling()", a => {
                m_InternalObject.SetAsFirstSibling();
                return new BSObject(null);
            }, 0));
            m_Properties["SetAsLastSibling"] = new BSFunctionReference(new BSFunction("function SetAsLastSibling()", a => {
                m_InternalObject.SetAsLastSibling();
                return new BSObject(null);
            }, 0));
            m_Properties["SetSiblingIndex"] = new BSFunctionReference(new BSFunction("function SetSiblingIndex(index)", a => {
                m_InternalObject.SetSiblingIndex(WrapperHelper.UnwrapObject<System.Int32>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["GetSiblingIndex"] = new BSFunctionReference(new BSFunction("function GetSiblingIndex()", a => new BSObject((decimal)m_InternalObject.GetSiblingIndex()), 0));
            m_Properties["Find"] = new BSFunctionReference(new BSFunction("function Find(n)", a => new BSWrapperObject_UnityEngine_Transform(m_InternalObject.Find(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["IsChildOf"] = new BSFunctionReference(new BSFunction("function IsChildOf(parent)", a => m_InternalObject.IsChildOf(WrapperHelper.UnwrapObject<UnityEngine.Transform>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["FindChild"] = new BSFunctionReference(new BSFunction("function FindChild(n)", a => new BSWrapperObject_UnityEngine_Transform(m_InternalObject.Find(WrapperHelper.UnwrapObject<System.String>(a[0]))), 1));
            m_Properties["GetEnumerator"] = new BSFunctionReference(new BSFunction("function GetEnumerator()", a => new BSWrapperObject_System_Collections_IEnumerator(m_InternalObject.GetEnumerator()), 0));
            m_Properties["RotateAround"] = new BSFunctionReference(new BSFunction("function RotateAround(axis, angle)", a => {
                m_InternalObject.RotateAround(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["RotateAroundLocal"] = new BSFunctionReference(new BSFunction("function RotateAroundLocal(axis, angle)", a => {
                m_InternalObject.RotateAroundLocal(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["GetChild"] = new BSFunctionReference(new BSFunction("function GetChild(index)", a => new BSWrapperObject_UnityEngine_Transform(m_InternalObject.GetChild(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["GetChildCount"] = new BSFunctionReference(new BSFunction("function GetChildCount()", a => new BSObject((decimal)m_InternalObject.childCount), 0));
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