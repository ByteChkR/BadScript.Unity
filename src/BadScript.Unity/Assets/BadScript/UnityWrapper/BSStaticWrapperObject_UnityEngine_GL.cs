using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_GL : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_GL() : base( typeof( GL ) )
        {
            m_StaticProperties["wireframe"] = new BSReflectionReference(
                () => GL.wireframe ? BSObject.One : BSObject.Zero,
                x => GL.wireframe = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["sRGBWrite"] = new BSReflectionReference(
                () => GL.sRGBWrite ? BSObject.One : BSObject.Zero,
                x => GL.sRGBWrite = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["invertCulling"] = new BSReflectionReference(
                () => GL.invertCulling ? BSObject.One : BSObject.Zero,
                x => GL.invertCulling = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["modelview"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( GL.modelview ),
                x => GL.modelview = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_StaticProperties["TRIANGLES"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) GL.TRIANGLES ),
                null );

            m_StaticProperties["TRIANGLE_STRIP"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) GL.TRIANGLE_STRIP ),
                null );

            m_StaticProperties["QUADS"] = new BSReflectionReference( () => new BSObject( ( decimal ) GL.QUADS ), null );
            m_StaticProperties["LINES"] = new BSReflectionReference( () => new BSObject( ( decimal ) GL.LINES ), null );

            m_StaticProperties["LINE_STRIP"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) GL.LINE_STRIP ),
                null );

            m_StaticProperties["GetGPUProjectionMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGPUProjectionMatrix(proj, renderIntoTexture)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        GL.GetGPUProjectionMatrix(
                            WrapperHelper.UnwrapObject < Matrix4x4 >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

        }

        #endregion
    }

}
