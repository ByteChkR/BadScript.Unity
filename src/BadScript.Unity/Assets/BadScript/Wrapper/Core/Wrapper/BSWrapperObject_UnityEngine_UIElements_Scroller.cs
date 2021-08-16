using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UIElements_Scroller : BSWrapperObject<UnityEngine.UIElements.Scroller>

    {
        public BSWrapperObject_UnityEngine_UIElements_Scroller(UnityEngine.UIElements.Scroller obj) : base(obj)
        {
            m_Properties["slider"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_Slider(m_InternalObject.slider), null);
            m_Properties["lowButton"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_RepeatButton(m_InternalObject.lowButton), null);
            m_Properties["highButton"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_RepeatButton(m_InternalObject.highButton), null);
            m_Properties["value"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.value), x=> m_InternalObject.value = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["lowValue"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.lowValue), x=> m_InternalObject.lowValue = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["highValue"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.highValue), x=> m_InternalObject.highValue = WrapperHelper.UnwrapObject<System.Single>(x));
            m_Properties["viewDataKey"] = new BSReflectionReference(() => new BSObject(m_InternalObject.viewDataKey), x=> m_InternalObject.viewDataKey = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["userData"] = new BSReflectionReference(() => new BSWrapperObject_System_Object(m_InternalObject.userData), x=> m_InternalObject.userData = WrapperHelper.UnwrapObject<System.Object>(x));
            m_Properties["canGrabFocus"] = new BSReflectionReference(() => m_InternalObject.canGrabFocus ? BSObject.One : BSObject.Zero, null);
            m_Properties["focusController"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_FocusController(m_InternalObject.focusController), null);
            m_Properties["transform"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_ITransform(m_InternalObject.transform), null);
            m_Properties["layout"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Rect(m_InternalObject.layout), null);
            m_Properties["contentRect"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Rect(m_InternalObject.contentRect), null);
            m_Properties["worldBound"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Rect(m_InternalObject.worldBound), null);
            m_Properties["localBound"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Rect(m_InternalObject.localBound), null);
            m_Properties["worldTransform"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Matrix4x4(m_InternalObject.worldTransform), null);
            m_Properties["name"] = new BSReflectionReference(() => new BSObject(m_InternalObject.name), x=> m_InternalObject.name = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["enabledInHierarchy"] = new BSReflectionReference(() => m_InternalObject.enabledInHierarchy ? BSObject.One : BSObject.Zero, null);
            m_Properties["enabledSelf"] = new BSReflectionReference(() => m_InternalObject.enabledSelf ? BSObject.One : BSObject.Zero, null);
            m_Properties["visible"] = new BSReflectionReference(() => m_InternalObject.visible ? BSObject.One : BSObject.Zero, x=> m_InternalObject.visible = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["experimental"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_IExperimentalFeatures(m_InternalObject.experimental), null);
            m_Properties["cacheAsBitmap"] = new BSReflectionReference(() => m_InternalObject.cacheAsBitmap ? BSObject.One : BSObject.Zero, x=> m_InternalObject.cacheAsBitmap = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["parent"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_VisualElement(m_InternalObject.parent), null);
            m_Properties["panel"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_IPanel(m_InternalObject.panel), null);
            m_Properties["contentContainer"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_VisualElement(m_InternalObject.contentContainer), null);
            m_Properties["childCount"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.childCount), null);
            m_Properties["schedule"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_IVisualElementScheduler(m_InternalObject.schedule), null);
            m_Properties["style"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_IStyle(m_InternalObject.style), null);
            m_Properties["customStyle"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_ICustomStyle(m_InternalObject.customStyle), null);
            m_Properties["styleSheets"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_VisualElementStyleSheetSet(m_InternalObject.styleSheets), null);
            m_Properties["tooltip"] = new BSReflectionReference(() => new BSObject(m_InternalObject.tooltip), x=> m_InternalObject.tooltip = WrapperHelper.UnwrapObject<System.String>(x));
            m_Properties["resolvedStyle"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UIElements_IResolvedStyle(m_InternalObject.resolvedStyle), null);
            m_Properties["focusable"] = new BSReflectionReference(() => m_InternalObject.focusable ? BSObject.One : BSObject.Zero, x=> m_InternalObject.focusable = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["tabIndex"] = new BSReflectionReference(() => new BSObject((decimal)m_InternalObject.tabIndex), x=> m_InternalObject.tabIndex = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_Properties["delegatesFocus"] = new BSReflectionReference(() => m_InternalObject.delegatesFocus ? BSObject.One : BSObject.Zero, x=> m_InternalObject.delegatesFocus = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_Properties["Adjust"] = new BSFunctionReference(new BSFunction("function Adjust(factor)", a => {
                m_InternalObject.Adjust(WrapperHelper.UnwrapObject<System.Single>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["ScrollPageUp"] = new BSFunctionReference(new BSFunction("function ScrollPageUp()", a => {
                m_InternalObject.ScrollPageUp();
                return new BSObject(null);
            }, 0));
            m_Properties["ScrollPageDown"] = new BSFunctionReference(new BSFunction("function ScrollPageDown()", a => {
                m_InternalObject.ScrollPageDown();
                return new BSObject(null);
            }, 0));
            m_Properties["ScrollPageUp"] = new BSFunctionReference(new BSFunction("function ScrollPageUp(factor)", a => {
                m_InternalObject.ScrollPageUp(WrapperHelper.UnwrapObject<System.Single>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["ScrollPageDown"] = new BSFunctionReference(new BSFunction("function ScrollPageDown(factor)", a => {
                m_InternalObject.ScrollPageDown(WrapperHelper.UnwrapObject<System.Single>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Focus"] = new BSFunctionReference(new BSFunction("function Focus()", a => {
                m_InternalObject.Focus();
                return new BSObject(null);
            }, 0));
            m_Properties["SendEvent"] = new BSFunctionReference(new BSFunction("function SendEvent(e)", a => {
                m_InternalObject.SendEvent(WrapperHelper.UnwrapObject<UnityEngine.UIElements.EventBase>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["SetEnabled"] = new BSFunctionReference(new BSFunction("function SetEnabled(value)", a => {
                m_InternalObject.SetEnabled(WrapperHelper.UnwrapObject<System.Boolean>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["MarkDirtyRepaint"] = new BSFunctionReference(new BSFunction("function MarkDirtyRepaint()", a => {
                m_InternalObject.MarkDirtyRepaint();
                return new BSObject(null);
            }, 0));
            m_Properties["ContainsPoint"] = new BSFunctionReference(new BSFunction("function ContainsPoint(localPoint)", a => m_InternalObject.ContainsPoint(WrapperHelper.UnwrapObject<UnityEngine.Vector2>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["Overlaps"] = new BSFunctionReference(new BSFunction("function Overlaps(rectangle)", a => m_InternalObject.Overlaps(WrapperHelper.UnwrapObject<UnityEngine.Rect>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));
            m_Properties["ClearClassList"] = new BSFunctionReference(new BSFunction("function ClearClassList()", a => {
                m_InternalObject.ClearClassList();
                return new BSObject(null);
            }, 0));
            m_Properties["AddToClassList"] = new BSFunctionReference(new BSFunction("function AddToClassList(className)", a => {
                m_InternalObject.AddToClassList(WrapperHelper.UnwrapObject<System.String>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["RemoveFromClassList"] = new BSFunctionReference(new BSFunction("function RemoveFromClassList(className)", a => {
                m_InternalObject.RemoveFromClassList(WrapperHelper.UnwrapObject<System.String>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["ToggleInClassList"] = new BSFunctionReference(new BSFunction("function ToggleInClassList(className)", a => {
                m_InternalObject.ToggleInClassList(WrapperHelper.UnwrapObject<System.String>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["EnableInClassList"] = new BSFunctionReference(new BSFunction("function EnableInClassList(className, enable)", a => {
                m_InternalObject.EnableInClassList(WrapperHelper.UnwrapObject<System.String>(a[0]), WrapperHelper.UnwrapObject<System.Boolean>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["ClassListContains"] = new BSFunctionReference(new BSFunction("function ClassListContains(cls)", a => m_InternalObject.ClassListContains(WrapperHelper.UnwrapObject<System.String>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["FindAncestorUserData"] = new BSFunctionReference(new BSFunction("function FindAncestorUserData()", a => new BSWrapperObject_System_Object(m_InternalObject.FindAncestorUserData()), 0));
            m_Properties["Add"] = new BSFunctionReference(new BSFunction("function Add(child)", a => {
                m_InternalObject.Add(WrapperHelper.UnwrapObject<UnityEngine.UIElements.VisualElement>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Insert"] = new BSFunctionReference(new BSFunction("function Insert(index, element)", a => {
                m_InternalObject.Insert(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.UIElements.VisualElement>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Remove"] = new BSFunctionReference(new BSFunction("function Remove(element)", a => {
                m_InternalObject.Remove(WrapperHelper.UnwrapObject<UnityEngine.UIElements.VisualElement>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["RemoveAt"] = new BSFunctionReference(new BSFunction("function RemoveAt(index)", a => {
                m_InternalObject.RemoveAt(WrapperHelper.UnwrapObject<System.Int32>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Clear"] = new BSFunctionReference(new BSFunction("function Clear()", a => {
                m_InternalObject.Clear();
                return new BSObject(null);
            }, 0));
            m_Properties["ElementAt"] = new BSFunctionReference(new BSFunction("function ElementAt(index)", a => new BSWrapperObject_UnityEngine_UIElements_VisualElement(m_InternalObject.ElementAt(WrapperHelper.UnwrapObject<System.Int32>(a[0]))), 1));
            m_Properties["IndexOf"] = new BSFunctionReference(new BSFunction("function IndexOf(element)", a => new BSObject((decimal)m_InternalObject.IndexOf(WrapperHelper.UnwrapObject<UnityEngine.UIElements.VisualElement>(a[0]))), 1));
            m_Properties["BringToFront"] = new BSFunctionReference(new BSFunction("function BringToFront()", a => {
                m_InternalObject.BringToFront();
                return new BSObject(null);
            }, 0));
            m_Properties["SendToBack"] = new BSFunctionReference(new BSFunction("function SendToBack()", a => {
                m_InternalObject.SendToBack();
                return new BSObject(null);
            }, 0));
            m_Properties["PlaceBehind"] = new BSFunctionReference(new BSFunction("function PlaceBehind(sibling)", a => {
                m_InternalObject.PlaceBehind(WrapperHelper.UnwrapObject<UnityEngine.UIElements.VisualElement>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["PlaceInFront"] = new BSFunctionReference(new BSFunction("function PlaceInFront(sibling)", a => {
                m_InternalObject.PlaceInFront(WrapperHelper.UnwrapObject<UnityEngine.UIElements.VisualElement>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["RemoveFromHierarchy"] = new BSFunctionReference(new BSFunction("function RemoveFromHierarchy()", a => {
                m_InternalObject.RemoveFromHierarchy();
                return new BSObject(null);
            }, 0));
            m_Properties["Contains"] = new BSFunctionReference(new BSFunction("function Contains(child)", a => m_InternalObject.Contains(WrapperHelper.UnwrapObject<UnityEngine.UIElements.VisualElement>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["FindCommonAncestor"] = new BSFunctionReference(new BSFunction("function FindCommonAncestor(other)", a => new BSWrapperObject_UnityEngine_UIElements_VisualElement(m_InternalObject.FindCommonAncestor(WrapperHelper.UnwrapObject<UnityEngine.UIElements.VisualElement>(a[0]))), 1));
            m_Properties["Blur"] = new BSFunctionReference(new BSFunction("function Blur()", a => {
                m_InternalObject.Blur();
                return new BSObject(null);
            }, 0));
            m_Properties["HandleEvent"] = new BSFunctionReference(new BSFunction("function HandleEvent(evt)", a => {
                m_InternalObject.HandleEvent(WrapperHelper.UnwrapObject<UnityEngine.UIElements.EventBase>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["HasTrickleDownHandlers"] = new BSFunctionReference(new BSFunction("function HasTrickleDownHandlers()", a => m_InternalObject.HasTrickleDownHandlers() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["HasBubbleUpHandlers"] = new BSFunctionReference(new BSFunction("function HasBubbleUpHandlers()", a => m_InternalObject.HasBubbleUpHandlers() ? BSObject.One : BSObject.Zero, 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));

        }
    }

}