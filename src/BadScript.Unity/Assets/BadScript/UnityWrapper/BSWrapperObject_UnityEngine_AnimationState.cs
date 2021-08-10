using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AnimationState : BSWrapperObject < AnimationState >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AnimationState( AnimationState obj ) : base( obj )
        {
            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["weight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.weight ),
                x => m_InternalObject.weight = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["time"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.time ),
                x => m_InternalObject.time = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["normalizedTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.normalizedTime ),
                x => m_InternalObject.normalizedTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["speed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.speed ),
                x => m_InternalObject.speed = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["normalizedSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.normalizedSpeed ),
                x => m_InternalObject.normalizedSpeed = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["length"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.length ),
                null );

            m_Properties["layer"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.layer ),
                x => m_InternalObject.layer = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["clip"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AnimationClip( m_InternalObject.clip ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(o)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
