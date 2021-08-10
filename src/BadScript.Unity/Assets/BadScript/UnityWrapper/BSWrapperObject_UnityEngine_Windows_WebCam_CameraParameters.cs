using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Windows.WebCam;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Windows_WebCam_CameraParameters : BSWrapperObject < CameraParameters >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Windows_WebCam_CameraParameters( CameraParameters obj ) : base( obj )
        {
            m_Properties["hologramOpacity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.hologramOpacity ),
                x => m_InternalObject.hologramOpacity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["frameRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.frameRate ),
                x => m_InternalObject.frameRate = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["cameraResolutionWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cameraResolutionWidth ),
                x => m_InternalObject.cameraResolutionWidth = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["cameraResolutionHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.cameraResolutionHeight ),
                x => m_InternalObject.cameraResolutionHeight = WrapperHelper.UnwrapObject < int >( x ) );

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
