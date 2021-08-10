using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Animations;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Animations_AnimationHumanStream : BSWrapperObject < AnimationHumanStream >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Animations_AnimationHumanStream( AnimationHumanStream obj ) : base( obj )
        {
            m_Properties["isValid"] = new BSReflectionReference(
                () => m_InternalObject.isValid ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["humanScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.humanScale ),
                null );

            m_Properties["leftFootHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.leftFootHeight ),
                null );

            m_Properties["rightFootHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.rightFootHeight ),
                null );

            m_Properties["bodyLocalPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.bodyLocalPosition ),
                x => m_InternalObject.bodyLocalPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["bodyLocalRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.bodyLocalRotation ),
                x => m_InternalObject.bodyLocalRotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["bodyPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.bodyPosition ),
                x => m_InternalObject.bodyPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["bodyRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.bodyRotation ),
                x => m_InternalObject.bodyRotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["leftFootVelocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.leftFootVelocity ),
                null );

            m_Properties["rightFootVelocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.rightFootVelocity ),
                null );

            m_Properties["GetMuscle"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMuscle(muscle)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetMuscle( WrapperHelper.UnwrapObject < MuscleHandle >( a[0] ) ) ),
                    1 ) );

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
