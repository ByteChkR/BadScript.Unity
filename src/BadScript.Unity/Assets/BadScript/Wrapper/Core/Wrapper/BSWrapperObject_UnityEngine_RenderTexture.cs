using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_RenderTexture : BSWrapperObject < RenderTexture >

    {
        #region Public

        public BSWrapperObject_UnityEngine_RenderTexture( RenderTexture obj ) : base( obj )
        {
            m_Properties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.width ),
                x => m_InternalObject.width = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                x => m_InternalObject.height = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["useMipMap"] = new BSReflectionReference(
                () => m_InternalObject.useMipMap ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useMipMap = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["sRGB"] = new BSReflectionReference(
                () => m_InternalObject.sRGB ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["autoGenerateMips"] = new BSReflectionReference(
                () => m_InternalObject.autoGenerateMips ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.autoGenerateMips = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["volumeDepth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.volumeDepth ),
                x => m_InternalObject.volumeDepth = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["antiAliasing"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.antiAliasing ),
                x => m_InternalObject.antiAliasing = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["bindTextureMS"] = new BSReflectionReference(
                () => m_InternalObject.bindTextureMS ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.bindTextureMS = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["enableRandomWrite"] = new BSReflectionReference(
                () => m_InternalObject.enableRandomWrite ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enableRandomWrite = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useDynamicScale"] = new BSReflectionReference(
                () => m_InternalObject.useDynamicScale ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useDynamicScale = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isPowerOfTwo"] = new BSReflectionReference(
                () => m_InternalObject.isPowerOfTwo ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isPowerOfTwo = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["colorBuffer"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderBuffer( m_InternalObject.colorBuffer ),
                null );

            m_Properties["depthBuffer"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderBuffer( m_InternalObject.depthBuffer ),
                null );

            m_Properties["depth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.depth ),
                x => m_InternalObject.depth = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["descriptor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RenderTextureDescriptor( m_InternalObject.descriptor ),
                x => m_InternalObject.descriptor = WrapperHelper.UnwrapObject < RenderTextureDescriptor >( x ) );

            m_Properties["generateMips"] = new BSReflectionReference(
                () => m_InternalObject.autoGenerateMips ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.autoGenerateMips = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isCubemap"] = new BSReflectionReference(
                () => m_InternalObject.isCubemap ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isCubemap = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isVolume"] = new BSReflectionReference(
                () => m_InternalObject.isVolume ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isVolume = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["mipmapCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.mipmapCount ),
                null );

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

            m_Properties["GetNativeDepthBufferPtr"] = new BSFunctionReference(
                new BSFunction(
                    "function GetNativeDepthBufferPtr()",
                    a => new BSWrapperObject_System_IntPtr( m_InternalObject.GetNativeDepthBufferPtr() ),
                    0 ) );

            m_Properties["DiscardContents"] = new BSFunctionReference(
                new BSFunction(
                    "function DiscardContents(discardColor, discardDepth)",
                    a =>
                    {
                        m_InternalObject.DiscardContents(
                            WrapperHelper.UnwrapObject < bool >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["MarkRestoreExpected"] = new BSFunctionReference(
                new BSFunction(
                    "function MarkRestoreExpected()",
                    a =>
                    {
                        m_InternalObject.MarkRestoreExpected();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["DiscardContents"] = new BSFunctionReference(
                new BSFunction(
                    "function DiscardContents()",
                    a =>
                    {
                        m_InternalObject.DiscardContents();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["ResolveAntiAliasedSurface"] = new BSFunctionReference(
                new BSFunction(
                    "function ResolveAntiAliasedSurface()",
                    a =>
                    {
                        m_InternalObject.ResolveAntiAliasedSurface();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["ResolveAntiAliasedSurface"] = new BSFunctionReference(
                new BSFunction(
                    "function ResolveAntiAliasedSurface(target)",
                    a =>
                    {
                        m_InternalObject.ResolveAntiAliasedSurface(
                            WrapperHelper.UnwrapObject < RenderTexture >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["SetGlobalShaderProperty"] = new BSFunctionReference(
                new BSFunction(
                    "function SetGlobalShaderProperty(propertyName)",
                    a =>
                    {
                        m_InternalObject.SetGlobalShaderProperty( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["Create"] = new BSFunctionReference(
                new BSFunction(
                    "function Create()",
                    a => m_InternalObject.Create() ? BSObject.One : BSObject.Zero,
                    0 ) );

            m_Properties["Release"] = new BSFunctionReference(
                new BSFunction(
                    "function Release()",
                    a =>
                    {
                        m_InternalObject.Release();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["IsCreated"] = new BSFunctionReference(
                new BSFunction(
                    "function IsCreated()",
                    a => m_InternalObject.IsCreated() ? BSObject.One : BSObject.Zero,
                    0 ) );

            m_Properties["GenerateMips"] = new BSFunctionReference(
                new BSFunction(
                    "function GenerateMips()",
                    a =>
                    {
                        m_InternalObject.GenerateMips();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["GetTexelOffset"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTexelOffset()",
                    a => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.GetTexelOffset() ),
                    0 ) );

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
