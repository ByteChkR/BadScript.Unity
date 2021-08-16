using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UIElements_IStyle : BSWrapperObject < IStyle >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_IStyle( IStyle obj ) : base( obj )
        {
            m_Properties["backgroundColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleColor( m_InternalObject.backgroundColor ),
                x => m_InternalObject.backgroundColor = WrapperHelper.UnwrapObject < StyleColor >( x ) );

            m_Properties["backgroundImage"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleBackground( m_InternalObject.backgroundImage ),
                x => m_InternalObject.backgroundImage = WrapperHelper.UnwrapObject < StyleBackground >( x ) );

            m_Properties["borderBottomColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleColor( m_InternalObject.borderBottomColor ),
                x => m_InternalObject.borderBottomColor = WrapperHelper.UnwrapObject < StyleColor >( x ) );

            m_Properties["borderBottomLeftRadius"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.borderBottomLeftRadius ),
                x => m_InternalObject.borderBottomLeftRadius = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["borderBottomRightRadius"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength(
                    m_InternalObject.borderBottomRightRadius ),
                x => m_InternalObject.borderBottomRightRadius = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["borderBottomWidth"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleFloat( m_InternalObject.borderBottomWidth ),
                x => m_InternalObject.borderBottomWidth = WrapperHelper.UnwrapObject < StyleFloat >( x ) );

            m_Properties["borderLeftColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleColor( m_InternalObject.borderLeftColor ),
                x => m_InternalObject.borderLeftColor = WrapperHelper.UnwrapObject < StyleColor >( x ) );

            m_Properties["borderLeftWidth"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleFloat( m_InternalObject.borderLeftWidth ),
                x => m_InternalObject.borderLeftWidth = WrapperHelper.UnwrapObject < StyleFloat >( x ) );

            m_Properties["borderRightColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleColor( m_InternalObject.borderRightColor ),
                x => m_InternalObject.borderRightColor = WrapperHelper.UnwrapObject < StyleColor >( x ) );

            m_Properties["borderRightWidth"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleFloat( m_InternalObject.borderRightWidth ),
                x => m_InternalObject.borderRightWidth = WrapperHelper.UnwrapObject < StyleFloat >( x ) );

            m_Properties["borderTopColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleColor( m_InternalObject.borderTopColor ),
                x => m_InternalObject.borderTopColor = WrapperHelper.UnwrapObject < StyleColor >( x ) );

            m_Properties["borderTopLeftRadius"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.borderTopLeftRadius ),
                x => m_InternalObject.borderTopLeftRadius = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["borderTopRightRadius"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.borderTopRightRadius ),
                x => m_InternalObject.borderTopRightRadius = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["borderTopWidth"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleFloat( m_InternalObject.borderTopWidth ),
                x => m_InternalObject.borderTopWidth = WrapperHelper.UnwrapObject < StyleFloat >( x ) );

            m_Properties["bottom"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.bottom ),
                x => m_InternalObject.bottom = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["color"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleColor( m_InternalObject.color ),
                x => m_InternalObject.color = WrapperHelper.UnwrapObject < StyleColor >( x ) );

            m_Properties["cursor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleCursor( m_InternalObject.cursor ),
                x => m_InternalObject.cursor = WrapperHelper.UnwrapObject < StyleCursor >( x ) );

            m_Properties["flexBasis"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.flexBasis ),
                x => m_InternalObject.flexBasis = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["flexGrow"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleFloat( m_InternalObject.flexGrow ),
                x => m_InternalObject.flexGrow = WrapperHelper.UnwrapObject < StyleFloat >( x ) );

            m_Properties["flexShrink"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleFloat( m_InternalObject.flexShrink ),
                x => m_InternalObject.flexShrink = WrapperHelper.UnwrapObject < StyleFloat >( x ) );

            m_Properties["fontSize"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.fontSize ),
                x => m_InternalObject.fontSize = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["height"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.height ),
                x => m_InternalObject.height = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["left"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.left ),
                x => m_InternalObject.left = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["marginBottom"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.marginBottom ),
                x => m_InternalObject.marginBottom = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["marginLeft"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.marginLeft ),
                x => m_InternalObject.marginLeft = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["marginRight"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.marginRight ),
                x => m_InternalObject.marginRight = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["marginTop"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.marginTop ),
                x => m_InternalObject.marginTop = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["maxHeight"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.maxHeight ),
                x => m_InternalObject.maxHeight = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["maxWidth"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.maxWidth ),
                x => m_InternalObject.maxWidth = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["minHeight"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.minHeight ),
                x => m_InternalObject.minHeight = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["minWidth"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.minWidth ),
                x => m_InternalObject.minWidth = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["opacity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleFloat( m_InternalObject.opacity ),
                x => m_InternalObject.opacity = WrapperHelper.UnwrapObject < StyleFloat >( x ) );

            m_Properties["paddingBottom"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.paddingBottom ),
                x => m_InternalObject.paddingBottom = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["paddingLeft"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.paddingLeft ),
                x => m_InternalObject.paddingLeft = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["paddingRight"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.paddingRight ),
                x => m_InternalObject.paddingRight = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["paddingTop"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.paddingTop ),
                x => m_InternalObject.paddingTop = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["right"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.right ),
                x => m_InternalObject.right = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["top"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.top ),
                x => m_InternalObject.top = WrapperHelper.UnwrapObject < StyleLength >( x ) );

            m_Properties["unityBackgroundImageTintColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleColor(
                    m_InternalObject.unityBackgroundImageTintColor ),
                x => m_InternalObject.unityBackgroundImageTintColor = WrapperHelper.UnwrapObject < StyleColor >( x ) );

            m_Properties["unityFont"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleFont( m_InternalObject.unityFont ),
                x => m_InternalObject.unityFont = WrapperHelper.UnwrapObject < StyleFont >( x ) );

            m_Properties["unitySliceBottom"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleInt( m_InternalObject.unitySliceBottom ),
                x => m_InternalObject.unitySliceBottom = WrapperHelper.UnwrapObject < StyleInt >( x ) );

            m_Properties["unitySliceLeft"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleInt( m_InternalObject.unitySliceLeft ),
                x => m_InternalObject.unitySliceLeft = WrapperHelper.UnwrapObject < StyleInt >( x ) );

            m_Properties["unitySliceRight"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleInt( m_InternalObject.unitySliceRight ),
                x => m_InternalObject.unitySliceRight = WrapperHelper.UnwrapObject < StyleInt >( x ) );

            m_Properties["unitySliceTop"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleInt( m_InternalObject.unitySliceTop ),
                x => m_InternalObject.unitySliceTop = WrapperHelper.UnwrapObject < StyleInt >( x ) );

            m_Properties["width"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_StyleLength( m_InternalObject.width ),
                x => m_InternalObject.width = WrapperHelper.UnwrapObject < StyleLength >( x ) );

        }

        #endregion
    }

}
