using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Windows.WebCam;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Windows_WebCam_PhotoCaptureFrame : BSWrapperObject < PhotoCaptureFrame >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Windows_WebCam_PhotoCaptureFrame( PhotoCaptureFrame obj ) : base( obj )
        {
            m_Properties["dataLength"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.dataLength ),
                null );

            m_Properties["hasLocationData"] = new BSReflectionReference(
                () => m_InternalObject.hasLocationData ? BSObject.One : BSObject.Zero,
                null );

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
