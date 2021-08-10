using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_IBindingExtensions : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_IBindingExtensions() : base( typeof( IBindingExtensions ) )
        {
            m_StaticProperties["IsBound"] = new BSFunctionReference(
                new BSFunction(
                    "function IsBound(control)",
                    a => IBindingExtensions.IsBound( WrapperHelper.UnwrapObject < IBindable >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
