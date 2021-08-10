using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Animation : BSWrapperObject < Animation >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Animation( Animation obj ) : base( obj )
        {
            m_Properties["clip"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AnimationClip( m_InternalObject.clip ),
                x => m_InternalObject.clip = WrapperHelper.UnwrapObject < AnimationClip >( x ) );

            m_Properties["playAutomatically"] = new BSReflectionReference(
                () => m_InternalObject.playAutomatically ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.playAutomatically = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["isPlaying"] = new BSReflectionReference(
                () => m_InternalObject.isPlaying ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["animatePhysics"] = new BSReflectionReference(
                () => m_InternalObject.animatePhysics ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.animatePhysics = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["animateOnlyIfVisible"] = new BSReflectionReference(
                () => m_InternalObject.animateOnlyIfVisible ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.animateOnlyIfVisible = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["localBounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Bounds( m_InternalObject.localBounds ),
                x => m_InternalObject.localBounds = WrapperHelper.UnwrapObject < Bounds >( x ) );

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

            m_Properties["IsPlaying"] = new BSFunctionReference(
                new BSFunction(
                    "function IsPlaying(name)",
                    a => m_InternalObject.IsPlaying( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Play"] = new BSFunctionReference(
                new BSFunction(
                    "function Play(animation)",
                    a => m_InternalObject.Play( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["CrossFadeQueued"] = new BSFunctionReference(
                new BSFunction(
                    "function CrossFadeQueued(animation)",
                    a => new BSWrapperObject_UnityEngine_AnimationState(
                        m_InternalObject.CrossFadeQueued( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["CrossFadeQueued"] = new BSFunctionReference(
                new BSFunction(
                    "function CrossFadeQueued(animation, fadeLength)",
                    a => new BSWrapperObject_UnityEngine_AnimationState(
                        m_InternalObject.CrossFadeQueued(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_Properties["PlayQueued"] = new BSFunctionReference(
                new BSFunction(
                    "function PlayQueued(animation)",
                    a => new BSWrapperObject_UnityEngine_AnimationState(
                        m_InternalObject.PlayQueued( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetClip"] = new BSFunctionReference(
                new BSFunction(
                    "function GetClip(name)",
                    a => new BSWrapperObject_UnityEngine_AnimationClip(
                        m_InternalObject.GetClip( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
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
