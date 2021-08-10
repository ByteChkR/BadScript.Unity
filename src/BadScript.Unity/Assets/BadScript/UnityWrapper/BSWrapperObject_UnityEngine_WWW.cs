using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_WWW : BSWrapperObject < WWW >

    {
        #region Public

        public BSWrapperObject_UnityEngine_WWW( WWW obj ) : base( obj )
        {
            m_Properties["assetBundle"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AssetBundle( m_InternalObject.assetBundle ),
                null );

            m_Properties["size"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.size ),
                null );

            m_Properties["bytesDownloaded"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bytesDownloaded ),
                null );

            m_Properties["error"] = new BSReflectionReference( () => new BSObject( m_InternalObject.error ), null );

            m_Properties["isDone"] = new BSReflectionReference(
                () => m_InternalObject.isDone ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["progress"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.progress ),
                null );

            m_Properties["text"] = new BSReflectionReference( () => new BSObject( m_InternalObject.text ), null );

            m_Properties["texture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.texture ),
                null );

            m_Properties["textureNonReadable"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.textureNonReadable ),
                null );

            m_Properties["uploadProgress"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.uploadProgress ),
                null );

            m_Properties["url"] = new BSReflectionReference( () => new BSObject( m_InternalObject.url ), null );

            m_Properties["keepWaiting"] = new BSReflectionReference(
                () => m_InternalObject.keepWaiting ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["Current"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.Current ),
                null );

            m_Properties["GetAudioClip"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAudioClip(threeD)",
                    a => new BSWrapperObject_UnityEngine_AudioClip(
                        m_InternalObject.GetAudioClip( WrapperHelper.UnwrapObject < bool >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetAudioClip"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAudioClip(threeD, stream)",
                    a => new BSWrapperObject_UnityEngine_AudioClip(
                        m_InternalObject.GetAudioClip(
                            WrapperHelper.UnwrapObject < bool >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetAudioClipCompressed"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAudioClipCompressed(threeD)",
                    a => new BSWrapperObject_UnityEngine_AudioClip(
                        m_InternalObject.GetAudioClipCompressed( WrapperHelper.UnwrapObject < bool >( a[0] ) ) ),
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
