using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_MouseCaptureController : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_MouseCaptureController() : base(
            typeof( MouseCaptureController ) )
        {
            m_StaticProperties["HasMouseCapture"] = new BSFunctionReference(
                new BSFunction(
                    "function HasMouseCapture(handler)",
                    a => MouseCaptureController.HasMouseCapture( WrapperHelper.UnwrapObject < IEventHandler >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
