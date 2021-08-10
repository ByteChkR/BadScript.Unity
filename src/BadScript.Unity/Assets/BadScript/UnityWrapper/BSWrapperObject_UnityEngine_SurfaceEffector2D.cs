using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_SurfaceEffector2D : BSWrapperObject < SurfaceEffector2D >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SurfaceEffector2D( SurfaceEffector2D obj ) : base( obj )
        {
            m_Properties["speed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.speed ),
                x => m_InternalObject.speed = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["speedVariation"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.speedVariation ),
                x => m_InternalObject.speedVariation = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["forceScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.forceScale ),
                x => m_InternalObject.forceScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["useContactForce"] = new BSReflectionReference(
                () => m_InternalObject.useContactForce ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useContactForce = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useFriction"] = new BSReflectionReference(
                () => m_InternalObject.useFriction ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useFriction = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useBounce"] = new BSReflectionReference(
                () => m_InternalObject.useBounce ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useBounce = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["useColliderMask"] = new BSReflectionReference(
                () => m_InternalObject.useColliderMask ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.useColliderMask = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["colliderMask"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.colliderMask ),
                x => m_InternalObject.colliderMask = WrapperHelper.UnwrapObject < int >( x ) );

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
