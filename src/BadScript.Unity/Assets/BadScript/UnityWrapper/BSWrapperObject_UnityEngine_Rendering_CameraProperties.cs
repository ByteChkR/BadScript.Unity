using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_CameraProperties : BSWrapperObject < CameraProperties >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_CameraProperties( CameraProperties obj ) : base( obj )
        {
            m_Properties["GetShadowCullingPlane"] = new BSFunctionReference(
                new BSFunction(
                    "function GetShadowCullingPlane(index)",
                    a => new BSWrapperObject_UnityEngine_Plane(
                        m_InternalObject.GetShadowCullingPlane( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetCameraCullingPlane"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCameraCullingPlane(index)",
                    a => new BSWrapperObject_UnityEngine_Plane(
                        m_InternalObject.GetCameraCullingPlane( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < CameraProperties >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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
