using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_EventSystems_PointerEventData : BSWrapperObject<UnityEngine.EventSystems.PointerEventData>

    {
        public BSWrapperObject_UnityEngine_EventSystems_PointerEventData(UnityEngine.EventSystems.PointerEventData obj) : base(obj)
        {
            m_Properties["pointerEnter"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_GameObject(m_InternalObject.pointerEnter), x=> m_InternalObject.pointerEnter = WrapperHelper.UnwrapObject<UnityEngine.GameObject>(x));
            m_Properties["lastPress"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_GameObject(m_InternalObject.lastPress), null);
            m_Properties["rawPointerPress"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_GameObject(m_InternalObject.rawPointerPress), x=> m_InternalObject.rawPointerPress = WrapperHelper.UnwrapObject<UnityEngine.GameObject>(x));
            m_Properties["pointerDrag"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_GameObject(m_InternalObject.pointerDrag), x=> m_InternalObject.pointerDrag = WrapperHelper.UnwrapObject<UnityEngine.GameObject>(x));
            m_Properties["pointerClick"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_GameObject(m_InternalObject.pointerClick), x=> m_InternalObject.pointerClick = WrapperHelper.UnwrapObject<UnityEngine.GameObject>(x));
            m_Properties["pointerCurrentRaycast"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_EventSystems_RaycastResult(m_InternalObject.pointerCurrentRaycast), x=> m_InternalObject.pointerCurrentRaycast = WrapperHelper.UnwrapObject<UnityEngine.EventSystems.RaycastResult>(x));
            m_Properties["pointerPressRaycast"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_EventSystems_RaycastResult(m_InternalObject.pointerPressRaycast), x=> m_InternalObject.pointerPressRaycast = WrapperHelper.UnwrapObject<UnityEngine.EventSystems.RaycastResult>(x));
            m_Properties["eligibleForClick"] = new BSReflectionReference(() => m_InternalObject.eligibleForClick ? BSObject.One : BSObject.Zero, x=> m_InternalObject.eligibleForClick = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["pointerId"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.pointerId), x=> m_InternalObject.pointerId = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["position"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.position), x=> m_InternalObject.position = WrapperHelper.UnwrapObject<UnityEngine.Vector2>(x));
            m_Properties["delta"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.delta), x=> m_InternalObject.delta = WrapperHelper.UnwrapObject<UnityEngine.Vector2>(x));
            m_Properties["pressPosition"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.pressPosition), x=> m_InternalObject.pressPosition = WrapperHelper.UnwrapObject<UnityEngine.Vector2>(x));
            m_Properties["worldPosition"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.worldPosition), x=> m_InternalObject.worldPosition = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["worldNormal"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(m_InternalObject.worldNormal), x=> m_InternalObject.worldNormal = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_Properties["clickTime"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.clickTime), x=> m_InternalObject.clickTime = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["clickCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.clickCount), x=> m_InternalObject.clickCount = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["scrollDelta"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.scrollDelta), x=> m_InternalObject.scrollDelta = WrapperHelper.UnwrapObject<UnityEngine.Vector2>(x));
            m_Properties["useDragThreshold"] = new BSReflectionReference(() => m_InternalObject.useDragThreshold ? BSObject.One : BSObject.Zero, x=> m_InternalObject.useDragThreshold = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["dragging"] = new BSReflectionReference(() => m_InternalObject.dragging ? BSObject.One : BSObject.Zero, x=> m_InternalObject.dragging = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["enterEventCamera"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Camera(m_InternalObject.enterEventCamera), null);
            m_Properties["pressEventCamera"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Camera(m_InternalObject.pressEventCamera), null);
            m_Properties["pointerPress"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_GameObject(m_InternalObject.pointerPress), x=> m_InternalObject.pointerPress = WrapperHelper.UnwrapObject<UnityEngine.GameObject>(x));
            m_Properties["currentInputModule"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_EventSystems_BaseInputModule(m_InternalObject.currentInputModule), null);
            m_Properties["selectedObject"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_GameObject(m_InternalObject.selectedObject), x=> m_InternalObject.selectedObject = WrapperHelper.UnwrapObject<UnityEngine.GameObject>(x));
            m_Properties["used"] = new BSReflectionReference(() => m_InternalObject.used ? BSObject.One : BSObject.Zero, null);
            m_Properties["IsPointerMoving"] = new BSFunctionReference(new BSFunction("function IsPointerMoving()", a => m_InternalObject.IsPointerMoving() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["IsScrolling"] = new BSFunctionReference(new BSFunction("function IsScrolling()", a => m_InternalObject.IsScrolling() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["Reset"] = new BSFunctionReference(new BSFunction("function Reset()", a => {
                m_InternalObject.Reset();
                return new BSObject(null);
            }, 0));
            m_Properties["Use"] = new BSFunctionReference(new BSFunction("function Use()", a => {
                m_InternalObject.Use();
                return new BSObject(null);
            }, 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));

        }
    }

}