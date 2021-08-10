using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.Experimental.AI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Experimental_AI_NavMeshQuery : BSWrapperObject < NavMeshQuery >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Experimental_AI_NavMeshQuery( NavMeshQuery obj ) : base( obj )
        {
            m_Properties["IsValid"] = new BSFunctionReference(
                new BSFunction(
                    "function IsValid(polygon)",
                    a => m_InternalObject.IsValid( WrapperHelper.UnwrapObject < PolygonId >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["IsValid"] = new BSFunctionReference(
                new BSFunction(
                    "function IsValid(location)",
                    a => m_InternalObject.IsValid( WrapperHelper.UnwrapObject < NavMeshLocation >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetAgentTypeIdForPolygon"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAgentTypeIdForPolygon(polygon)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetAgentTypeIdForPolygon(
                            WrapperHelper.UnwrapObject < PolygonId >( a[0] ) ) ),
                    1 ) );

            m_Properties["CreateLocation"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateLocation(position, polygon)",
                    a => new BSWrapperObject_UnityEngine_Experimental_AI_NavMeshLocation(
                        m_InternalObject.CreateLocation(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < PolygonId >( a[1] ) ) ),
                    2 ) );

            m_Properties["MapLocation"] = new BSFunctionReference(
                new BSFunction(
                    "function MapLocation(position, extents, agentTypeID, areaMask)",
                    a => new BSWrapperObject_UnityEngine_Experimental_AI_NavMeshLocation(
                        m_InternalObject.MapLocation(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_Properties["MoveLocation"] = new BSFunctionReference(
                new BSFunction(
                    "function MoveLocation(location, target, areaMask)",
                    a => new BSWrapperObject_UnityEngine_Experimental_AI_NavMeshLocation(
                        m_InternalObject.MoveLocation(
                            WrapperHelper.UnwrapObject < NavMeshLocation >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_Properties["PolygonLocalToWorldMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function PolygonLocalToWorldMatrix(polygon)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        m_InternalObject.PolygonLocalToWorldMatrix(
                            WrapperHelper.UnwrapObject < PolygonId >( a[0] ) ) ),
                    1 ) );

            m_Properties["PolygonWorldToLocalMatrix"] = new BSFunctionReference(
                new BSFunction(
                    "function PolygonWorldToLocalMatrix(polygon)",
                    a => new BSWrapperObject_UnityEngine_Matrix4x4(
                        m_InternalObject.PolygonWorldToLocalMatrix(
                            WrapperHelper.UnwrapObject < PolygonId >( a[0] ) ) ),
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
