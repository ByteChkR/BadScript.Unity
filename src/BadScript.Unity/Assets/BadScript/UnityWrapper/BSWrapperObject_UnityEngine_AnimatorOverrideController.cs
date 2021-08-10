using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AnimatorOverrideController : BSWrapperObject < AnimatorOverrideController >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AnimatorOverrideController( AnimatorOverrideController obj ) : base( obj )
        {
            m_Properties["runtimeAnimatorController"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RuntimeAnimatorController(
                    m_InternalObject.runtimeAnimatorController ),
                x => m_InternalObject.runtimeAnimatorController =
                    WrapperHelper.UnwrapObject < RuntimeAnimatorController >( x ) );

            m_Properties["overridesCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.overridesCount ),
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
