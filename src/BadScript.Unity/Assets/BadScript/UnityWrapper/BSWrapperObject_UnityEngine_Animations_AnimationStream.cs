using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Animations;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Animations_AnimationStream : BSWrapperObject < AnimationStream >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Animations_AnimationStream( AnimationStream obj ) : base( obj )
        {
            m_Properties["isValid"] = new BSReflectionReference(
                () => m_InternalObject.isValid ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["deltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.deltaTime ),
                null );

            m_Properties["velocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.velocity ),
                x => m_InternalObject.velocity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["angularVelocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.angularVelocity ),
                x => m_InternalObject.angularVelocity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["rootMotionPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.rootMotionPosition ),
                null );

            m_Properties["rootMotionRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.rootMotionRotation ),
                null );

            m_Properties["isHumanStream"] = new BSReflectionReference(
                () => m_InternalObject.isHumanStream ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["inputStreamCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.inputStreamCount ),
                null );

            m_Properties["GetInputStream"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInputStream(index)",
                    a => new BSWrapperObject_UnityEngine_Animations_AnimationStream(
                        m_InternalObject.GetInputStream( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetInputWeight"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInputWeight(index)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInputWeight( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
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
