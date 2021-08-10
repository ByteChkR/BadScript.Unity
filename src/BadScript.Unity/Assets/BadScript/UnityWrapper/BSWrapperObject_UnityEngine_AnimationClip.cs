using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AnimationClip : BSWrapperObject < AnimationClip >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AnimationClip( AnimationClip obj ) : base( obj )
        {
            m_Properties["length"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.length ),
                null );

            m_Properties["frameRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.frameRate ),
                x => m_InternalObject.frameRate = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["localBounds"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Bounds( m_InternalObject.localBounds ),
                x => m_InternalObject.localBounds = WrapperHelper.UnwrapObject < Bounds >( x ) );

            m_Properties["legacy"] = new BSReflectionReference(
                () => m_InternalObject.legacy ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.legacy = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["humanMotion"] = new BSReflectionReference(
                () => m_InternalObject.humanMotion ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["empty"] = new BSReflectionReference(
                () => m_InternalObject.empty ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["hasGenericRootTransform"] = new BSReflectionReference(
                () => m_InternalObject.hasGenericRootTransform ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["hasMotionFloatCurves"] = new BSReflectionReference(
                () => m_InternalObject.hasMotionFloatCurves ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["hasMotionCurves"] = new BSReflectionReference(
                () => m_InternalObject.hasMotionCurves ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["hasRootCurves"] = new BSReflectionReference(
                () => m_InternalObject.hasRootCurves ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["averageDuration"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.averageDuration ),
                null );

            m_Properties["averageAngularSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.averageAngularSpeed ),
                null );

            m_Properties["averageSpeed"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.averageSpeed ),
                null );

            m_Properties["apparentSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.apparentSpeed ),
                null );

            m_Properties["isLooping"] = new BSReflectionReference(
                () => m_InternalObject.isLooping ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isHumanMotion"] = new BSReflectionReference(
                () => m_InternalObject.isHumanMotion ? BSObject.One : BSObject.Zero,
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
