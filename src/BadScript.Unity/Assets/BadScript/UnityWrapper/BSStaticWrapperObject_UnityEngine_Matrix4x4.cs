using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Matrix4x4 : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Matrix4x4() : base( typeof( Matrix4x4 ) )
        {
            m_StaticProperties["zero"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( Matrix4x4.zero ),
                null );

            m_StaticProperties["identity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( Matrix4x4.identity ),
                null );

            m_StaticProperties["Determinant"] = new BSFunctionReference(
                new BSFunction(
                    "function Determinant(m)",
                    a => new BSObject(
                        ( decimal ) Matrix4x4.Determinant( WrapperHelper.UnwrapObject < Matrix4x4 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["TRS"] = new BSFunctionReference(
                new BSFunction(
                    "function TRS(pos, q, s)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        Matrix4x4.TRS(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["Inverse"] = new BSFunctionReference(
                new BSFunction(
                    "function Inverse(m)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        Matrix4x4.Inverse( WrapperHelper.UnwrapObject < Matrix4x4 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Transpose"] = new BSFunctionReference(
                new BSFunction(
                    "function Transpose(m)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        Matrix4x4.Transpose( WrapperHelper.UnwrapObject < Matrix4x4 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Ortho"] = new BSFunctionReference(
                new BSFunction(
                    "function Ortho(left, right, bottom, top, zNear, zFar)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        Matrix4x4.Ortho(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["Perspective"] = new BSFunctionReference(
                new BSFunction(
                    "function Perspective(fov, aspect, zNear, zFar)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        Matrix4x4.Perspective(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["LookAt"] = new BSFunctionReference(
                new BSFunction(
                    "function LookAt(from, to, up)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        Matrix4x4.LookAt(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["Frustum"] = new BSFunctionReference(
                new BSFunction(
                    "function Frustum(left, right, bottom, top, zNear, zFar)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        Matrix4x4.Frustum(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["Frustum"] = new BSFunctionReference(
                new BSFunction(
                    "function Frustum(fp)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        Matrix4x4.Frustum( WrapperHelper.UnwrapObject < FrustumPlanes >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Scale"] = new BSFunctionReference(
                new BSFunction(
                    "function Scale(vector)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        Matrix4x4.Scale( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Translate"] = new BSFunctionReference(
                new BSFunction(
                    "function Translate(vector)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        Matrix4x4.Translate( WrapperHelper.UnwrapObject < Vector3 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Rotate"] = new BSFunctionReference(
                new BSFunction(
                    "function Rotate(q)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        Matrix4x4.Rotate( WrapperHelper.UnwrapObject < Quaternion >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
