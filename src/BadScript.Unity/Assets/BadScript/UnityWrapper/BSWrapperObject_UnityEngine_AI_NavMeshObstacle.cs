using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.AI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AI_NavMeshObstacle : BSWrapperObject < NavMeshObstacle >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AI_NavMeshObstacle( NavMeshObstacle obj ) : base( obj )
        {
            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                x => m_InternalObject.height = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["radius"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.radius ),
                x => m_InternalObject.radius = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["velocity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.velocity ),
                x => m_InternalObject.velocity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["carving"] = new BSReflectionReference(
                () => m_InternalObject.carving ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.carving = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["carveOnlyStationary"] = new BSReflectionReference(
                () => m_InternalObject.carveOnlyStationary ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.carveOnlyStationary = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["carvingMoveThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.carvingMoveThreshold ),
                x => m_InternalObject.carvingMoveThreshold = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["carvingTimeToStationary"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.carvingTimeToStationary ),
                x => m_InternalObject.carvingTimeToStationary = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["center"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.center ),
                x => m_InternalObject.center = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["size"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.size ),
                x => m_InternalObject.size = WrapperHelper.UnwrapObject < Vector3 >( x ) );

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
