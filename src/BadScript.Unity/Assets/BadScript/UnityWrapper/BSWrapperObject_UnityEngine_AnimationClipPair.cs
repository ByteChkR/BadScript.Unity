using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AnimationClipPair : BSWrapperObject < AnimationClipPair >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AnimationClipPair( AnimationClipPair obj ) : base( obj )
        {
            m_Properties["originalClip"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AnimationClip( m_InternalObject.originalClip ),
                x => m_InternalObject.originalClip = WrapperHelper.UnwrapObject < AnimationClip >( x ) );

            m_Properties["overrideClip"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AnimationClip( m_InternalObject.overrideClip ),
                x => m_InternalObject.overrideClip = WrapperHelper.UnwrapObject < AnimationClip >( x ) );

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
