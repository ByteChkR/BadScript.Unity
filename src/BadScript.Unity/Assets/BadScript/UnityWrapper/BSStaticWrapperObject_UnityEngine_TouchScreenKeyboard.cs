using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_TouchScreenKeyboard : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_TouchScreenKeyboard() : base( typeof( TouchScreenKeyboard ) )
        {
            m_StaticProperties["isSupported"] = new BSReflectionReference(
                () => TouchScreenKeyboard.isSupported ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["isInPlaceEditingAllowed"] = new BSReflectionReference(
                () => TouchScreenKeyboard.isInPlaceEditingAllowed ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["hideInput"] = new BSReflectionReference(
                () => TouchScreenKeyboard.hideInput ? BSObject.One : BSObject.Zero,
                x => TouchScreenKeyboard.hideInput = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["area"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( TouchScreenKeyboard.area ),
                null );

            m_StaticProperties["visible"] = new BSReflectionReference(
                () => TouchScreenKeyboard.visible ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["Open"] = new BSFunctionReference(
                new BSFunction(
                    "function Open(text)",
                    a => new BSWrapperObject_UnityEngine_TouchScreenKeyboard(
                        TouchScreenKeyboard.Open( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
