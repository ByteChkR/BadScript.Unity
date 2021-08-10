using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Animations;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Animations_AnimatorControllerPlayable : BSWrapperObject < AnimatorControllerPlayable
        >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Animations_AnimatorControllerPlayable( AnimatorControllerPlayable obj ) :
            base( obj )
        {
            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < AnimatorControllerPlayable >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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
