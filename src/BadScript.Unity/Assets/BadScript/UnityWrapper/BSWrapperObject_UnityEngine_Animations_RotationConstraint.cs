using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Animations;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Animations_RotationConstraint : BSWrapperObject < RotationConstraint >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Animations_RotationConstraint( RotationConstraint obj ) : base( obj )
        {
            m_Properties["weight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.weight ),
                x => m_InternalObject.weight = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["rotationAtRest"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.rotationAtRest ),
                x => m_InternalObject.rotationAtRest = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["rotationOffset"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.rotationOffset ),
                x => m_InternalObject.rotationOffset = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["constraintActive"] = new BSReflectionReference(
                () => m_InternalObject.constraintActive ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.constraintActive = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["locked"] = new BSReflectionReference(
                () => m_InternalObject.locked ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.locked = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["sourceCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sourceCount ),
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
