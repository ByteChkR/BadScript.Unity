using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_WebCamTexture : BSWrapperObject < WebCamTexture >

    {
        #region Public

        public BSWrapperObject_UnityEngine_WebCamTexture( WebCamTexture obj ) : base( obj )
        {
            m_Properties["isPlaying"] = new BSReflectionReference(
                () => m_InternalObject.isPlaying ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["deviceName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.deviceName ),
                x => m_InternalObject.deviceName = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["requestedFPS"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.requestedFPS ),
                x => m_InternalObject.requestedFPS = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["requestedWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.requestedWidth ),
                x => m_InternalObject.requestedWidth = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["requestedHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.requestedHeight ),
                x => m_InternalObject.requestedHeight = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["videoRotationAngle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.videoRotationAngle ),
                null );

            m_Properties["videoVerticallyMirrored"] = new BSReflectionReference(
                () => m_InternalObject.videoVerticallyMirrored ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["didUpdateThisFrame"] = new BSReflectionReference(
                () => m_InternalObject.didUpdateThisFrame ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isDepth"] = new BSReflectionReference(
                () => m_InternalObject.isDepth ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["mipmapCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.mipmapCount ),
                null );

            m_Properties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.width ),
                x => m_InternalObject.width = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                x => m_InternalObject.height = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["isReadable"] = new BSReflectionReference(
                () => m_InternalObject.isReadable ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["anisoLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.anisoLevel ),
                x => m_InternalObject.anisoLevel = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["mipMapBias"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.mipMapBias ),
                x => m_InternalObject.mipMapBias = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["texelSize"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.texelSize ),
                null );

            m_Properties["updateCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.updateCount ),
                null );

            m_Properties["imageContentsHash"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Hash128( m_InternalObject.imageContentsHash ),
                x => m_InternalObject.imageContentsHash = WrapperHelper.UnwrapObject < Hash128 >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetPixel"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPixel(x, y)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        m_InternalObject.GetPixel(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
