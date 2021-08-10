using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Animator : BSWrapperObject < Animator >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Animator( Animator obj ) : base( obj )
        {
            m_Properties["isOptimizable"] = new BSReflectionReference(
                () => m_InternalObject.isOptimizable ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["isHuman"] = new BSReflectionReference(
                () => m_InternalObject.isHuman ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["hasRootMotion"] = new BSReflectionReference(
                () => m_InternalObject.hasRootMotion ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["humanScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.humanScale ),
                null );

            m_Properties["isInitialized"] = new BSReflectionReference(
                () => m_InternalObject.isInitialized ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["deltaPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.deltaPosition ),
                null );

            m_Properties["deltaRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.deltaRotation ),
                null );

            m_Properties["velocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.velocity ),
                null );

            m_Properties["angularVelocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.angularVelocity ),
                null );

            m_Properties["rootPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.rootPosition ),
                x => m_InternalObject.rootPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["rootRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.rootRotation ),
                x => m_InternalObject.rootRotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["applyRootMotion"] = new BSReflectionReference(
                () => m_InternalObject.applyRootMotion ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.applyRootMotion = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["linearVelocityBlending"] = new BSReflectionReference(
                () => m_InternalObject.linearVelocityBlending ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.linearVelocityBlending = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["animatePhysics"] = new BSReflectionReference(
                () => m_InternalObject.animatePhysics ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.animatePhysics = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["hasTransformHierarchy"] = new BSReflectionReference(
                () => m_InternalObject.hasTransformHierarchy ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["gravityWeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.gravityWeight ),
                null );

            m_Properties["bodyPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.bodyPosition ),
                x => m_InternalObject.bodyPosition = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["bodyRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.bodyRotation ),
                x => m_InternalObject.bodyRotation = WrapperHelper.UnwrapObject < Quaternion >( x ) );

            m_Properties["stabilizeFeet"] = new BSReflectionReference(
                () => m_InternalObject.stabilizeFeet ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.stabilizeFeet = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["layerCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.layerCount ),
                null );

            m_Properties["parameterCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.parameterCount ),
                null );

            m_Properties["feetPivotActive"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.feetPivotActive ),
                x => m_InternalObject.feetPivotActive = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["pivotWeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pivotWeight ),
                null );

            m_Properties["pivotPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.pivotPosition ),
                null );

            m_Properties["isMatchingTarget"] = new BSReflectionReference(
                () => m_InternalObject.isMatchingTarget ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["speed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.speed ),
                x => m_InternalObject.speed = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["targetPosition"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.targetPosition ),
                null );

            m_Properties["targetRotation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Quaternion( m_InternalObject.targetRotation ),
                null );

            m_Properties["playbackTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.playbackTime ),
                x => m_InternalObject.playbackTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["recorderStartTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.recorderStartTime ),
                x => m_InternalObject.recorderStartTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["recorderStopTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.recorderStopTime ),
                x => m_InternalObject.recorderStopTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["runtimeAnimatorController"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_RuntimeAnimatorController(
                    m_InternalObject.runtimeAnimatorController ),
                x => m_InternalObject.runtimeAnimatorController =
                    WrapperHelper.UnwrapObject < RuntimeAnimatorController >( x ) );

            m_Properties["hasBoundPlayables"] = new BSReflectionReference(
                () => m_InternalObject.hasBoundPlayables ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["avatar"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Avatar( m_InternalObject.avatar ),
                x => m_InternalObject.avatar = WrapperHelper.UnwrapObject < Avatar >( x ) );

            m_Properties["playableGraph"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Playables_PlayableGraph( m_InternalObject.playableGraph ),
                null );

            m_Properties["layersAffectMassCenter"] = new BSReflectionReference(
                () => m_InternalObject.layersAffectMassCenter ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.layersAffectMassCenter = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["leftFeetBottomHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.leftFeetBottomHeight ),
                null );

            m_Properties["rightFeetBottomHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.rightFeetBottomHeight ),
                null );

            m_Properties["logWarnings"] = new BSReflectionReference(
                () => m_InternalObject.logWarnings ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.logWarnings = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["fireEvents"] = new BSReflectionReference(
                () => m_InternalObject.fireEvents ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.fireEvents = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["keepAnimatorControllerStateOnDisable"] = new BSReflectionReference(
                () => m_InternalObject.keepAnimatorControllerStateOnDisable ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.keepAnimatorControllerStateOnDisable = WrapperHelper.UnwrapObject < bool >( x ) );

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

            m_Properties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetFloat( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(id)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetFloat( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetBool"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBool(name)",
                    a => m_InternalObject.GetBool( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetBool"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBool(id)",
                    a => m_InternalObject.GetBool( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetInteger"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInteger(name)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInteger( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetInteger"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInteger(id)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInteger( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["IsParameterControlledByCurve"] = new BSFunctionReference(
                new BSFunction(
                    "function IsParameterControlledByCurve(name)",
                    a => m_InternalObject.IsParameterControlledByCurve( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["IsParameterControlledByCurve"] = new BSFunctionReference(
                new BSFunction(
                    "function IsParameterControlledByCurve(id)",
                    a => m_InternalObject.IsParameterControlledByCurve( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetLayerName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLayerName(layerIndex)",
                    a => new BSObject( m_InternalObject.GetLayerName( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetLayerIndex"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLayerIndex(layerName)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetLayerIndex( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetLayerWeight"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLayerWeight(layerIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetLayerWeight( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetCurrentAnimatorStateInfo"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCurrentAnimatorStateInfo(layerIndex)",
                    a => new BSWrapperObject_UnityEngine_AnimatorStateInfo(
                        m_InternalObject.GetCurrentAnimatorStateInfo( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetNextAnimatorStateInfo"] = new BSFunctionReference(
                new BSFunction(
                    "function GetNextAnimatorStateInfo(layerIndex)",
                    a => new BSWrapperObject_UnityEngine_AnimatorStateInfo(
                        m_InternalObject.GetNextAnimatorStateInfo( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetAnimatorTransitionInfo"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAnimatorTransitionInfo(layerIndex)",
                    a => new BSWrapperObject_UnityEngine_AnimatorTransitionInfo(
                        m_InternalObject.GetAnimatorTransitionInfo( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetCurrentAnimatorClipInfoCount"] = new BSFunctionReference(
                new BSFunction(
                    "function GetCurrentAnimatorClipInfoCount(layerIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetCurrentAnimatorClipInfoCount(
                            WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetNextAnimatorClipInfoCount"] = new BSFunctionReference(
                new BSFunction(
                    "function GetNextAnimatorClipInfoCount(layerIndex)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetNextAnimatorClipInfoCount(
                            WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["IsInTransition"] = new BSFunctionReference(
                new BSFunction(
                    "function IsInTransition(layerIndex)",
                    a => m_InternalObject.IsInTransition( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetParameter"] = new BSFunctionReference(
                new BSFunction(
                    "function GetParameter(index)",
                    a => new BSWrapperObject_UnityEngine_AnimatorControllerParameter(
                        m_InternalObject.GetParameter( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["HasState"] = new BSFunctionReference(
                new BSFunction(
                    "function HasState(layerIndex, stateID)",
                    a => m_InternalObject.HasState(
                        WrapperHelper.UnwrapObject < int >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_Properties["GetVector"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector(name)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.GetVector( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetVector"] = new BSFunctionReference(
                new BSFunction(
                    "function GetVector(id)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        m_InternalObject.GetVector( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetQuaternion"] = new BSFunctionReference(
                new BSFunction(
                    "function GetQuaternion(name)",
                    a => new BSWrapperObject_UnityEngine_Quaternion(
                        m_InternalObject.GetQuaternion( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetQuaternion"] = new BSFunctionReference(
                new BSFunction(
                    "function GetQuaternion(id)",
                    a => new BSWrapperObject_UnityEngine_Quaternion(
                        m_InternalObject.GetQuaternion( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
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
