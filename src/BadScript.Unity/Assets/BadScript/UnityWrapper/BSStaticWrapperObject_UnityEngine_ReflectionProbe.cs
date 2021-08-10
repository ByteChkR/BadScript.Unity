using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_ReflectionProbe : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_ReflectionProbe() : base( typeof( ReflectionProbe ) )
        {
            m_StaticProperties["minBakedCubemapResolution"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) ReflectionProbe.minBakedCubemapResolution ),
                null );

            m_StaticProperties["maxBakedCubemapResolution"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) ReflectionProbe.maxBakedCubemapResolution ),
                null );

            m_StaticProperties["defaultTextureHDRDecodeValues"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector4( ReflectionProbe.defaultTextureHDRDecodeValues ),
                null );

            m_StaticProperties["defaultTexture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture( ReflectionProbe.defaultTexture ),
                null );

            m_StaticProperties["BlendCubemap"] = new BSFunctionReference(
                new BSFunction(
                    "function BlendCubemap(src, dst, blend, target)",
                    a => ReflectionProbe.BlendCubemap(
                        WrapperHelper.UnwrapObject < Texture >( a[0] ),
                        WrapperHelper.UnwrapObject < Texture >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < RenderTexture >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

        }

        #endregion
    }

}
