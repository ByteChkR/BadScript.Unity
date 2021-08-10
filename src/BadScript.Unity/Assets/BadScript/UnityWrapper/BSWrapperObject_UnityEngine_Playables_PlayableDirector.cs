using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Playables_PlayableDirector : BSWrapperObject < PlayableDirector >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Playables_PlayableDirector( PlayableDirector obj ) : base( obj )
        {
            m_Properties["playableAsset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Playables_PlayableAsset( m_InternalObject.playableAsset ),
                x => m_InternalObject.playableAsset = WrapperHelper.UnwrapObject < PlayableAsset >( x ) );

            m_Properties["playableGraph"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Playables_PlayableGraph( m_InternalObject.playableGraph ),
                null );

            m_Properties["playOnAwake"] = new BSReflectionReference(
                () => m_InternalObject.playOnAwake ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.playOnAwake = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["time"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.time ),
                x => m_InternalObject.time = WrapperHelper.UnwrapObject < double >( x ) );

            m_Properties["initialTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.initialTime ),
                x => m_InternalObject.initialTime = WrapperHelper.UnwrapObject < double >( x ) );

            m_Properties["duration"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.duration ),
                null );

            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isActiveAndEnabled"] = new BSReflectionReference(
                () => m_InternalObject.isActiveAndEnabled ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["transform"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Transform( m_InternalObject.transform ),
                null );

            m_Properties["gameObject"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.gameObject ),
                null );

            m_Properties["tag"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tag ),
                x => m_InternalObject.tag = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetGenericBinding"] = new BSFunctionReference(
                new BSFunction(
                    "function GetGenericBinding(key)",
                    a => new BSWrapperObject_UnityEngine_Object(
                        m_InternalObject.GetGenericBinding( WrapperHelper.UnwrapObject < Object >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetComponent"] = new BSFunctionReference(
                new BSFunction(
                    "function GetComponent(type)",
                    a => new BSWrapperObject_UnityEngine_Component(
                        m_InternalObject.GetComponent( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["CompareTag"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTag(tag)",
                    a => m_InternalObject.CompareTag( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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
