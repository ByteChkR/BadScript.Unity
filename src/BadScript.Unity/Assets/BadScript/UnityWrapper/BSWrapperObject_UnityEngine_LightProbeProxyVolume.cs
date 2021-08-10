using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_LightProbeProxyVolume : BSWrapperObject < LightProbeProxyVolume >

    {
        #region Public

        public BSWrapperObject_UnityEngine_LightProbeProxyVolume( LightProbeProxyVolume obj ) : base( obj )
        {
            m_Properties["boundsGlobal"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Bounds( m_InternalObject.boundsGlobal ),
                null );

            m_Properties["sizeCustom"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.sizeCustom ),
                x => m_InternalObject.sizeCustom = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["originCustom"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.originCustom ),
                x => m_InternalObject.originCustom = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["probeDensity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.probeDensity ),
                x => m_InternalObject.probeDensity = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["gridResolutionX"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.gridResolutionX ),
                x => m_InternalObject.gridResolutionX = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["gridResolutionY"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.gridResolutionY ),
                x => m_InternalObject.gridResolutionY = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["gridResolutionZ"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.gridResolutionZ ),
                x => m_InternalObject.gridResolutionZ = WrapperHelper.UnwrapObject < int >( x ) );

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
