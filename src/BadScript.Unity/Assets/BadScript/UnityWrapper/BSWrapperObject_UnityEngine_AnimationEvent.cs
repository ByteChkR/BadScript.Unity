using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AnimationEvent : BSWrapperObject < AnimationEvent >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AnimationEvent( AnimationEvent obj ) : base( obj )
        {
            m_Properties["data"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.data ),
                x => m_InternalObject.data = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["stringParameter"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.stringParameter ),
                x => m_InternalObject.stringParameter = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["floatParameter"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.floatParameter ),
                x => m_InternalObject.floatParameter = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["intParameter"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.intParameter ),
                x => m_InternalObject.intParameter = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["objectReferenceParameter"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Object( m_InternalObject.objectReferenceParameter ),
                x => m_InternalObject.objectReferenceParameter = WrapperHelper.UnwrapObject < Object >( x ) );

            m_Properties["functionName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.functionName ),
                x => m_InternalObject.functionName = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["time"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.time ),
                x => m_InternalObject.time = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["isFiredByLegacy"] = new BSReflectionReference(
                () => m_InternalObject.isFiredByLegacy ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isFiredByAnimator"] = new BSReflectionReference(
                () => m_InternalObject.isFiredByAnimator ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["animationState"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AnimationState( m_InternalObject.animationState ),
                null );

            m_Properties["animatorStateInfo"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AnimatorStateInfo( m_InternalObject.animatorStateInfo ),
                null );

            m_Properties["animatorClipInfo"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AnimatorClipInfo( m_InternalObject.animatorClipInfo ),
                null );

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
