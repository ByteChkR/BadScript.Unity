using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_PointEffector2D : BSWrapperObject < PointEffector2D >

    {
        #region Public

        public BSWrapperObject_UnityEngine_PointEffector2D( PointEffector2D obj ) : base( obj )
        {
            m_Properties["forceMagnitude"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.forceMagnitude ),
                x => m_InternalObject.forceMagnitude = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["forceVariation"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.forceVariation ),
                x => m_InternalObject.forceVariation = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["distanceScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.distanceScale ),
                x => m_InternalObject.distanceScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["drag"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.drag ),
                x => m_InternalObject.drag = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["angularDrag"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.angularDrag ),
                x => m_InternalObject.angularDrag = WrapperHelper.UnwrapObject < float >( x ) );

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
