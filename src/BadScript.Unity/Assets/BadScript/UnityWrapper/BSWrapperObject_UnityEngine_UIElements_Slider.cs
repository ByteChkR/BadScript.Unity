using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_Slider : BSWrapperObject < Slider >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_Slider( Slider obj ) : base( obj )
        {
            m_Properties["lowValue"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lowValue ),
                x => m_InternalObject.lowValue = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["highValue"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.highValue ),
                x => m_InternalObject.highValue = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["range"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.range ),
                null );

            m_Properties["pageSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pageSize ),
                x => m_InternalObject.pageSize = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["showInputField"] = new BSReflectionReference(
                () => m_InternalObject.showInputField ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.showInputField = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["value"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.value ),
                x => m_InternalObject.value = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["labelElement"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_Label( m_InternalObject.labelElement ),
                null );

            m_Properties["label"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.label ),
                x => m_InternalObject.label = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["binding"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_IBinding( m_InternalObject.binding ),
                x => m_InternalObject.binding = WrapperHelper.UnwrapObject < IBinding >( x ) );

            m_Properties["bindingPath"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.bindingPath ),
                x => m_InternalObject.bindingPath = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["viewDataKey"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.viewDataKey ),
                x => m_InternalObject.viewDataKey = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["userData"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.userData ),
                x => m_InternalObject.userData = WrapperHelper.UnwrapObject < object >( x ) );

            m_Properties["canGrabFocus"] = new BSReflectionReference(
                () => m_InternalObject.canGrabFocus ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["focusController"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_FocusController( m_InternalObject.focusController ),
                null );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_ITransform( m_InternalObject.transform ),
                null );

            m_Properties["layout"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( m_InternalObject.layout ),
                null );

            m_Properties["contentRect"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( m_InternalObject.contentRect ),
                null );

            m_Properties["worldBound"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( m_InternalObject.worldBound ),
                null );

            m_Properties["localBound"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( m_InternalObject.localBound ),
                null );

            m_Properties["worldTransform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( m_InternalObject.worldTransform ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["enabledInHierarchy"] = new BSReflectionReference(
                () => m_InternalObject.enabledInHierarchy ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["enabledSelf"] = new BSReflectionReference(
                () => m_InternalObject.enabledSelf ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["visible"] = new BSReflectionReference(
                () => m_InternalObject.visible ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.visible = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["experimental"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_IExperimentalFeatures( m_InternalObject.experimental ),
                null );

            m_Properties["cacheAsBitmap"] = new BSReflectionReference(
                () => m_InternalObject.cacheAsBitmap ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.cacheAsBitmap = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["parent"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_VisualElement( m_InternalObject.parent ),
                null );

            m_Properties["panel"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_IPanel( m_InternalObject.panel ),
                null );

            m_Properties["contentContainer"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_VisualElement( m_InternalObject.contentContainer ),
                null );

            m_Properties["childCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.childCount ),
                null );

            m_Properties["schedule"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_IVisualElementScheduler( m_InternalObject.schedule ),
                null );

            m_Properties["style"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_IStyle( m_InternalObject.style ),
                null );

            m_Properties["customStyle"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_ICustomStyle( m_InternalObject.customStyle ),
                null );

            m_Properties["styleSheets"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_VisualElementStyleSheetSet(
                    m_InternalObject.styleSheets ),
                null );

            m_Properties["tooltip"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tooltip ),
                x => m_InternalObject.tooltip = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["resolvedStyle"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_IResolvedStyle( m_InternalObject.resolvedStyle ),
                null );

            m_Properties["focusable"] = new BSReflectionReference(
                () => m_InternalObject.focusable ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.focusable = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["tabIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.tabIndex ),
                x => m_InternalObject.tabIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["delegatesFocus"] = new BSReflectionReference(
                () => m_InternalObject.delegatesFocus ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.delegatesFocus = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["ContainsPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ContainsPoint(localPoint)",
                    a => m_InternalObject.ContainsPoint( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Overlaps"] = new BSFunctionReference(
                new BSFunction(
                    "function Overlaps(rectangle)",
                    a => m_InternalObject.Overlaps( WrapperHelper.UnwrapObject < Rect >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ClassListContains"] = new BSFunctionReference(
                new BSFunction(
                    "function ClassListContains(cls)",
                    a => m_InternalObject.ClassListContains( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ElementAt"] = new BSFunctionReference(
                new BSFunction(
                    "function ElementAt(index)",
                    a => new BSWrapperObject_UnityEngine_UIElements_VisualElement(
                        m_InternalObject.ElementAt( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["IndexOf"] = new BSFunctionReference(
                new BSFunction(
                    "function IndexOf(element)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.IndexOf( WrapperHelper.UnwrapObject < VisualElement >( a[0] ) ) ),
                    1 ) );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(child)",
                    a => m_InternalObject.Contains( WrapperHelper.UnwrapObject < VisualElement >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["FindCommonAncestor"] = new BSFunctionReference(
                new BSFunction(
                    "function FindCommonAncestor(other)",
                    a => new BSWrapperObject_UnityEngine_UIElements_VisualElement(
                        m_InternalObject.FindCommonAncestor( WrapperHelper.UnwrapObject < VisualElement >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
