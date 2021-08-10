using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_Experimental_StyleValues : BSWrapperObject < StyleValues >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_Experimental_StyleValues( StyleValues obj ) : base( obj )
        {
            m_Properties["top"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.top ),
                x => m_InternalObject.top = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["left"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.left ),
                x => m_InternalObject.left = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.width ),
                x => m_InternalObject.width = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                x => m_InternalObject.height = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["right"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.right ),
                x => m_InternalObject.right = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bottom"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bottom ),
                x => m_InternalObject.bottom = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["color"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.color ),
                x => m_InternalObject.color = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["backgroundColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.backgroundColor ),
                x => m_InternalObject.backgroundColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["unityBackgroundImageTintColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.unityBackgroundImageTintColor ),
                x => m_InternalObject.unityBackgroundImageTintColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["borderColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.borderColor ),
                x => m_InternalObject.borderColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["marginLeft"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.marginLeft ),
                x => m_InternalObject.marginLeft = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["marginTop"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.marginTop ),
                x => m_InternalObject.marginTop = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["marginRight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.marginRight ),
                x => m_InternalObject.marginRight = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["marginBottom"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.marginBottom ),
                x => m_InternalObject.marginBottom = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["paddingLeft"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.paddingLeft ),
                x => m_InternalObject.paddingLeft = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["paddingTop"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.paddingTop ),
                x => m_InternalObject.paddingTop = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["paddingRight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.paddingRight ),
                x => m_InternalObject.paddingRight = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["paddingBottom"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.paddingBottom ),
                x => m_InternalObject.paddingBottom = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["borderLeftWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.borderLeftWidth ),
                x => m_InternalObject.borderLeftWidth = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["borderRightWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.borderRightWidth ),
                x => m_InternalObject.borderRightWidth = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["borderTopWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.borderTopWidth ),
                x => m_InternalObject.borderTopWidth = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["borderBottomWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.borderBottomWidth ),
                x => m_InternalObject.borderBottomWidth = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["borderTopLeftRadius"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.borderTopLeftRadius ),
                x => m_InternalObject.borderTopLeftRadius = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["borderTopRightRadius"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.borderTopRightRadius ),
                x => m_InternalObject.borderTopRightRadius = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["borderBottomLeftRadius"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.borderBottomLeftRadius ),
                x => m_InternalObject.borderBottomLeftRadius = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["borderBottomRightRadius"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.borderBottomRightRadius ),
                x => m_InternalObject.borderBottomRightRadius = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["opacity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.opacity ),
                x => m_InternalObject.opacity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["flexGrow"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.flexGrow ),
                x => m_InternalObject.flexGrow = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["flexShrink"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.flexShrink ),
                x => m_InternalObject.flexShrink = WrapperHelper.UnwrapObject < float >( x ) );

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
