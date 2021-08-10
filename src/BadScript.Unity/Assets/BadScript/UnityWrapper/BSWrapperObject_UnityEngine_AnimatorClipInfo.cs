using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AnimatorClipInfo : BSWrapperObject < AnimatorClipInfo >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AnimatorClipInfo( AnimatorClipInfo obj ) : base( obj )
        {
            m_Properties["clip"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AnimationClip( m_InternalObject.clip ),
                null );

            m_Properties["weight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.weight ),
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
