using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_PointerCaptureHelper : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_PointerCaptureHelper() : base(
            typeof( PointerCaptureHelper ) )
        {
            m_StaticProperties["HasPointerCapture"] = new BSFunctionReference(
                new BSFunction(
                    "function HasPointerCapture(handler, pointerId)",
                    a => PointerCaptureHelper.HasPointerCapture(
                        WrapperHelper.UnwrapObject < IEventHandler >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["GetCapturingElement"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCapturingElement(panel, pointerId)",
                    a => new BSWrapperObject_UnityEngine_UIElements_IEventHandler(
                        PointerCaptureHelper.GetCapturingElement(
                            WrapperHelper.UnwrapObject < IPanel >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
