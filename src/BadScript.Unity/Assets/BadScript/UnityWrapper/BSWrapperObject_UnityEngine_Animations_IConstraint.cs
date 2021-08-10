using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Animations;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Animations_IConstraint : BSWrapperObject < IConstraint >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Animations_IConstraint( IConstraint obj ) : base( obj )
        {
            m_Properties["weight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.weight ),
                x => m_InternalObject.weight = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["constraintActive"] = new BSReflectionReference(
                () => m_InternalObject.constraintActive ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.constraintActive = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["locked"] = new BSReflectionReference(
                () => m_InternalObject.locked ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.locked = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["sourceCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sourceCount ),
                null );

            m_Properties["AddSource"] = new BSFunctionReference(
                new BSFunction(
                    "function AddSource(source)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.AddSource(
                            WrapperHelper.UnwrapObject < ConstraintSource >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetSource"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSource(index)",
                    a => new BSWrapperObject_UnityEngine_Animations_ConstraintSource(
                        m_InternalObject.GetSource( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
