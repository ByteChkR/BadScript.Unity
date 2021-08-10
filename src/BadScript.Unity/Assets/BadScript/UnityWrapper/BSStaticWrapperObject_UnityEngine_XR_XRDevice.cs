using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.XR;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_XR_XRDevice : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_XR_XRDevice() : base( typeof( XRDevice ) )
        {
            m_StaticProperties["refreshRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) XRDevice.refreshRate ),
                null );

            m_StaticProperties["fovZoomFactor"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) XRDevice.fovZoomFactor ),
                x => XRDevice.fovZoomFactor = WrapperHelper.UnwrapObject < float >( x ) );

        }

        #endregion
    }

}
