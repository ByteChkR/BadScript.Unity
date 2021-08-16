using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Texture2D : BSWrapperObject < Texture2D >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Texture2D( Texture2D obj ) : base( obj )
        {
            m_Properties["isReadable"] = new BSReflectionReference(
                () => m_InternalObject.isReadable ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["vtOnly"] = new BSReflectionReference(
                () => m_InternalObject.vtOnly ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["streamingMipmaps"] = new BSReflectionReference(
                () => m_InternalObject.streamingMipmaps ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["streamingMipmapsPriority"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.streamingMipmapsPriority ),
                null );

            m_Properties["requestedMipmapLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.requestedMipmapLevel ),
                x => m_InternalObject.requestedMipmapLevel = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["minimumMipmapLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minimumMipmapLevel ),
                x => m_InternalObject.minimumMipmapLevel = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["calculatedMipmapLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.calculatedMipmapLevel ),
                null );

            m_Properties["desiredMipmapLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.desiredMipmapLevel ),
                null );

            m_Properties["loadingMipmapLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.loadingMipmapLevel ),
                null );

            m_Properties["loadedMipmapLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.loadedMipmapLevel ),
                null );

            m_Properties["alphaIsTransparency"] = new BSReflectionReference(
                () => m_InternalObject.alphaIsTransparency ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.alphaIsTransparency = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["mipmapCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.mipmapCount ),
                null );

            m_Properties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.width ),
                x => m_InternalObject.width = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                x => m_InternalObject.height = WrapperHelper.UnwrapObject < int >( x ) );

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

            m_Properties["Compress"] = new BSFunctionReference(
                new BSFunction(
                    "function Compress(highQuality)",
                    a =>
                    {
                        m_InternalObject.Compress( WrapperHelper.UnwrapObject < bool >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["ClearRequestedMipmapLevel"] = new BSFunctionReference(
                new BSFunction(
                    "function ClearRequestedMipmapLevel()",
                    a =>
                    {
                        m_InternalObject.ClearRequestedMipmapLevel();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["IsRequestedMipmapLevelLoaded"] = new BSFunctionReference(
                new BSFunction(
                    "function IsRequestedMipmapLevelLoaded()",
                    a => m_InternalObject.IsRequestedMipmapLevelLoaded() ? BSObject.One : BSObject.Zero,
                    0 ) );

            m_Properties["ClearMinimumMipmapLevel"] = new BSFunctionReference(
                new BSFunction(
                    "function ClearMinimumMipmapLevel()",
                    a =>
                    {
                        m_InternalObject.ClearMinimumMipmapLevel();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["UpdateExternalTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function UpdateExternalTexture(nativeTex)",
                    a =>
                    {
                        m_InternalObject.UpdateExternalTexture( WrapperHelper.UnwrapObject < IntPtr >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetPixel"] = new BSFunctionReference(
                new BSFunction(
                    "function SetPixel(x, y, color)",
                    a =>
                    {
                        m_InternalObject.SetPixel(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Color >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["SetPixel"] = new BSFunctionReference(
                new BSFunction(
                    "function SetPixel(x, y, color, mipLevel)",
                    a =>
                    {
                        m_InternalObject.SetPixel(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < Color >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["GetPixel"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPixel(x, y)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        m_InternalObject.GetPixel(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetPixel"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPixel(x, y, mipLevel)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        m_InternalObject.GetPixel(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_Properties["GetPixelBilinear"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPixelBilinear(u, v)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        m_InternalObject.GetPixelBilinear(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetPixelBilinear"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPixelBilinear(u, v, mipLevel)",
                    a => new BSWrapperObject_UnityEngine_Color(
                        m_InternalObject.GetPixelBilinear(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_Properties["LoadRawTextureData"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadRawTextureData(data, size)",
                    a =>
                    {
                        m_InternalObject.LoadRawTextureData(
                            WrapperHelper.UnwrapObject < IntPtr >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["Apply"] = new BSFunctionReference(
                new BSFunction(
                    "function Apply(updateMipmaps, makeNoLongerReadable)",
                    a =>
                    {
                        m_InternalObject.Apply(
                            WrapperHelper.UnwrapObject < bool >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["Apply"] = new BSFunctionReference(
                new BSFunction(
                    "function Apply(updateMipmaps)",
                    a =>
                    {
                        m_InternalObject.Apply( WrapperHelper.UnwrapObject < bool >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["Apply"] = new BSFunctionReference(
                new BSFunction(
                    "function Apply()",
                    a =>
                    {
                        m_InternalObject.Apply();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Resize"] = new BSFunctionReference(
                new BSFunction(
                    "function Resize(width, height)",
                    a => m_InternalObject.Resize(
                        WrapperHelper.UnwrapObject < int >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["ReadPixels"] = new BSFunctionReference(
                new BSFunction(
                    "function ReadPixels(source, destX, destY, recalculateMipMaps)",
                    a =>
                    {
                        m_InternalObject.ReadPixels(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < bool >( a[3] ) );

                        return new BSObject( null );
                    },
                    4 ) );

            m_Properties["ReadPixels"] = new BSFunctionReference(
                new BSFunction(
                    "function ReadPixels(source, destX, destY)",
                    a =>
                    {
                        m_InternalObject.ReadPixels(
                            WrapperHelper.UnwrapObject < Rect >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_Properties["GetNativeTexturePtr"] = new BSFunctionReference(
                new BSFunction(
                    "function GetNativeTexturePtr()",
                    a => new BSWrapperObject_System_IntPtr( m_InternalObject.GetNativeTexturePtr() ),
                    0 ) );

            m_Properties["GetNativeTextureID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetNativeTextureID()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetNativeTextureID() ),
                    0 ) );

            m_Properties["IncrementUpdateCount"] = new BSFunctionReference(
                new BSFunction(
                    "function IncrementUpdateCount()",
                    a =>
                    {
                        m_InternalObject.IncrementUpdateCount();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["GetInstanceID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInstanceID()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetInstanceID() ),
                    0 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}
