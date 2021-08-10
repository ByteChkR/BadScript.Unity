using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Cubemap : BSWrapperObject < Cubemap >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Cubemap( Cubemap obj ) : base( obj )
        {
            m_Properties["isReadable"] = new BSReflectionReference(
                () => m_InternalObject.isReadable ? BSObject.One : BSObject.Zero,
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

            m_Properties["desiredMipmapLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.desiredMipmapLevel ),
                null );

            m_Properties["loadingMipmapLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.loadingMipmapLevel ),
                null );

            m_Properties["loadedMipmapLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.loadedMipmapLevel ),
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
