using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Canvas : BSWrapperObject<UnityEngine.Canvas>

    {
        public BSWrapperObject_UnityEngine_Canvas(UnityEngine.Canvas obj) : base(obj)
        {
            m_Properties["isRootCanvas"] = new BSReflectionReference(() => m_InternalObject.isRootCanvas ? BSObject.One : BSObject.Zero, null);
            m_Properties["pixelRect"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Rect(m_InternalObject.pixelRect), null);
            m_Properties["scaleFactor"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.scaleFactor), x=> m_InternalObject.scaleFactor = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["referencePixelsPerUnit"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.referencePixelsPerUnit), x=> m_InternalObject.referencePixelsPerUnit = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["overridePixelPerfect"] = new BSReflectionReference(() => m_InternalObject.overridePixelPerfect ? BSObject.One : BSObject.Zero, x=> m_InternalObject.overridePixelPerfect = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["pixelPerfect"] = new BSReflectionReference(() => m_InternalObject.pixelPerfect ? BSObject.One : BSObject.Zero, x=> m_InternalObject.pixelPerfect = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["planeDistance"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.planeDistance), x=> m_InternalObject.planeDistance = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["renderOrder"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.renderOrder), null);
            m_Properties["overrideSorting"] = new BSReflectionReference(() => m_InternalObject.overrideSorting ? BSObject.One : BSObject.Zero, x=> m_InternalObject.overrideSorting = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["sortingOrder"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.sortingOrder), x=> m_InternalObject.sortingOrder = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["targetDisplay"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.targetDisplay), x=> m_InternalObject.targetDisplay = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["sortingLayerID"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.sortingLayerID), x=> m_InternalObject.sortingLayerID = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["cachedSortingLayerValue"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.cachedSortingLayerValue), null);
            m_Properties["sortingLayerName"] = new BSReflectionReference(() => new BSObject(m_InternalObject.sortingLayerName), x=> m_InternalObject.sortingLayerName = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["rootCanvas"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Canvas(m_InternalObject.rootCanvas), null);
            m_Properties["renderingDisplaySize"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector2(m_InternalObject.renderingDisplaySize), null);
            m_Properties["worldCamera"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Camera(m_InternalObject.worldCamera), x=> m_InternalObject.worldCamera = WrapperHelper.UnwrapObject<UnityEngine.Camera>(x));
            m_Properties["normalizedSortingGridSize"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.normalizedSortingGridSize), x=> m_InternalObject.normalizedSortingGridSize = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["sortingGridNormalizedSize"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.sortingGridNormalizedSize), x=> m_InternalObject.sortingGridNormalizedSize = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["enabled"] = new BSReflectionReference(() => m_InternalObject.enabled ? BSObject.One : BSObject.Zero, x=> m_InternalObject.enabled = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["isActiveAndEnabled"] = new BSReflectionReference(() => m_InternalObject.isActiveAndEnabled ? BSObject.One : BSObject.Zero, null);
            m_Properties["transform"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Transform(m_InternalObject.transform), null);
            m_Properties["gameObject"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_GameObject(m_InternalObject.gameObject), null);
            m_Properties["tag"] = new BSReflectionReference(() => new BSObject(m_InternalObject.tag), x=> m_InternalObject.tag = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
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