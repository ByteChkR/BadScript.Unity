using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_PhysicsScene2D : BSWrapperObject < PhysicsScene2D >

    {
        #region Public

        public BSWrapperObject_UnityEngine_PhysicsScene2D( PhysicsScene2D obj ) : base( obj )
        {
            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < PhysicsScene2D >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Simulate"] = new BSFunctionReference(
                new BSFunction(
                    "function Simulate(step)",
                    a => m_InternalObject.Simulate( WrapperHelper.UnwrapObject < float >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end, layerMask)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        m_InternalObject.Linecast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_Properties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end, contactFilter)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        m_InternalObject.Linecast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < ContactFilter2D >( a[2] ) ) ),
                    3 ) );

            m_Properties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, distance, layerMask)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        m_InternalObject.Raycast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_Properties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, distance, contactFilter)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        m_InternalObject.Raycast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < ContactFilter2D >( a[3] ) ) ),
                    4 ) );

            m_Properties["CircleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CircleCast(origin, radius, direction, distance, layerMask)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        m_InternalObject.CircleCast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_Properties["CircleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CircleCast(origin, radius, direction, distance, contactFilter)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        m_InternalObject.CircleCast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < ContactFilter2D >( a[4] ) ) ),
                    5 ) );

            m_Properties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(origin, size, angle, direction, distance, layerMask)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        m_InternalObject.BoxCast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ) ) ),
                    6 ) );

            m_Properties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(origin, size, angle, direction, distance, contactFilter)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        m_InternalObject.BoxCast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < ContactFilter2D >( a[5] ) ) ),
                    6 ) );

            m_Properties["GetRayIntersection"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRayIntersection(ray, distance, layerMask)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        m_InternalObject.GetRayIntersection(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_Properties["OverlapPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapPoint(point, layerMask)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        m_InternalObject.OverlapPoint(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_Properties["OverlapPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapPoint(point, contactFilter)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        m_InternalObject.OverlapPoint(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < ContactFilter2D >( a[1] ) ) ),
                    2 ) );

            m_Properties["OverlapCircle"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCircle(point, radius, layerMask)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        m_InternalObject.OverlapCircle(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_Properties["OverlapCircle"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCircle(point, radius, contactFilter)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        m_InternalObject.OverlapCircle(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < ContactFilter2D >( a[2] ) ) ),
                    3 ) );

            m_Properties["OverlapBox"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBox(point, size, angle, layerMask)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        m_InternalObject.OverlapBox(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_Properties["OverlapBox"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBox(point, size, angle, contactFilter)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        m_InternalObject.OverlapBox(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < ContactFilter2D >( a[3] ) ) ),
                    4 ) );

            m_Properties["OverlapArea"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapArea(pointA, pointB, layerMask)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        m_InternalObject.OverlapArea(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_Properties["OverlapArea"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapArea(pointA, pointB, contactFilter)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        m_InternalObject.OverlapArea(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < ContactFilter2D >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}
