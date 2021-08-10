using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AudioClip : BSWrapperObject < AudioClip >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AudioClip( AudioClip obj ) : base( obj )
        {
            m_Properties["length"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.length ),
                null );

            m_Properties["samples"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.samples ),
                null );

            m_Properties["channels"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.channels ),
                null );

            m_Properties["frequency"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.frequency ),
                null );

            m_Properties["isReadyToPlay"] = new BSReflectionReference(
                () => m_InternalObject.isReadyToPlay ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["preloadAudioData"] = new BSReflectionReference(
                () => m_InternalObject.preloadAudioData ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["ambisonic"] = new BSReflectionReference(
                () => m_InternalObject.ambisonic ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["loadInBackground"] = new BSReflectionReference(
                () => m_InternalObject.loadInBackground ? BSObject.One : BSObject.Zero,
                null );

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
