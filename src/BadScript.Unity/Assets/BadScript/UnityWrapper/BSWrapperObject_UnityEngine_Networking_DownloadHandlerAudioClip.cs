using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Networking_DownloadHandlerAudioClip : BSWrapperObject < DownloadHandlerAudioClip >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Networking_DownloadHandlerAudioClip( DownloadHandlerAudioClip obj ) : base(
            obj )
        {
            m_Properties["audioClip"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AudioClip( m_InternalObject.audioClip ),
                null );

            m_Properties["streamAudio"] = new BSReflectionReference(
                () => m_InternalObject.streamAudio ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.streamAudio = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["compressed"] = new BSReflectionReference(
                () => m_InternalObject.compressed ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.compressed = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isDone"] = new BSReflectionReference(
                () => m_InternalObject.isDone ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["error"] = new BSReflectionReference( () => new BSObject( m_InternalObject.error ), null );
            m_Properties["text"] = new BSReflectionReference( () => new BSObject( m_InternalObject.text ), null );

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
