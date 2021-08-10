using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_UQueryExtensions : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_UQueryExtensions() : base( typeof( UQueryExtensions ) )
        {
            m_StaticProperties["Q"] = new BSFunctionReference(
                new BSFunction(
                    "function Q(e, name, className)",
                    a => new BSWrapperObject_UnityEngine_UIElements_VisualElement(
                        UQueryExtensions.Q(
                            WrapperHelper.UnwrapObject < VisualElement >( a[0] ),
                            WrapperHelper.UnwrapObject < string >( a[1] ),
                            WrapperHelper.UnwrapObject < string >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}
