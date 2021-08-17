using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
#pragma warning disable 618

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Physics : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Physics() : base( typeof( Physics ) )
        {
            m_StaticProperties["gravity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( Physics.gravity ),
                x => Physics.gravity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_StaticProperties["defaultContactOffset"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.defaultContactOffset ),
                x => Physics.defaultContactOffset = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["sleepThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.sleepThreshold ),
                x => Physics.sleepThreshold = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["queriesHitTriggers"] = new BSReflectionReference(
                () => Physics.queriesHitTriggers ? BSObject.One : BSObject.Zero,
                x => Physics.queriesHitTriggers = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["queriesHitBackfaces"] = new BSReflectionReference(
                () => Physics.queriesHitBackfaces ? BSObject.One : BSObject.Zero,
                x => Physics.queriesHitBackfaces = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["bounceThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.bounceThreshold ),
                x => Physics.bounceThreshold = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["defaultMaxDepenetrationVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.defaultMaxDepenetrationVelocity ),
                x => Physics.defaultMaxDepenetrationVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["defaultSolverIterations"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.defaultSolverIterations ),
                x => Physics.defaultSolverIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["defaultSolverVelocityIterations"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.defaultSolverVelocityIterations ),
                x => Physics.defaultSolverVelocityIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["bounceTreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.bounceTreshold ),
                x => Physics.bounceTreshold = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["sleepVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.sleepVelocity ),
                x => Physics.sleepVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["sleepAngularVelocity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.sleepAngularVelocity ),
                x => Physics.sleepAngularVelocity = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["solverIterationCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.defaultSolverIterations ),
                x => Physics.defaultSolverIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["solverVelocityIterationCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.defaultSolverVelocityIterations ),
                x => Physics.defaultSolverVelocityIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["penetrationPenaltyForce"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.penetrationPenaltyForce ),
                x => Physics.penetrationPenaltyForce = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["defaultMaxAngularSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.defaultMaxAngularSpeed ),
                x => Physics.defaultMaxAngularSpeed = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["defaultPhysicsScene"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_PhysicsScene( Physics.defaultPhysicsScene ),
                null );

            m_StaticProperties["autoSimulation"] = new BSReflectionReference(
                () => Physics.autoSimulation ? BSObject.One : BSObject.Zero,
                x => Physics.autoSimulation = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["autoSyncTransforms"] = new BSReflectionReference(
                () => Physics.autoSyncTransforms ? BSObject.One : BSObject.Zero,
                x => Physics.autoSyncTransforms = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["reuseCollisionCallbacks"] = new BSReflectionReference(
                () => Physics.reuseCollisionCallbacks ? BSObject.One : BSObject.Zero,
                x => Physics.reuseCollisionCallbacks = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["interCollisionDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.interCollisionDistance ),
                x => Physics.interCollisionDistance = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["interCollisionStiffness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.interCollisionStiffness ),
                x => Physics.interCollisionStiffness = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["interCollisionSettingsToggle"] = new BSReflectionReference(
                () => Physics.interCollisionSettingsToggle ? BSObject.One : BSObject.Zero,
                x => Physics.interCollisionSettingsToggle = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["clothGravity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( Physics.clothGravity ),
                x => Physics.clothGravity = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_StaticProperties["IgnoreRaycastLayer"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.IgnoreRaycastLayer ),
                null );

            m_StaticProperties["DefaultRaycastLayers"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.DefaultRaycastLayers ),
                null );

            m_StaticProperties["AllLayers"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics.AllLayers ),
                null );

            m_StaticProperties["IgnoreCollision"] = new BSFunctionReference(
                new BSFunction(
                    "function IgnoreCollision(collider1, collider2, ignore)",
                    a =>
                    {
                        Physics.IgnoreCollision(
                            WrapperHelper.UnwrapObject < Collider >( a[0] ),
                            WrapperHelper.UnwrapObject < Collider >( a[1] ),
                            WrapperHelper.UnwrapObject < bool >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_StaticProperties["IgnoreCollision"] = new BSFunctionReference(
                new BSFunction(
                    "function IgnoreCollision(collider1, collider2)",
                    a =>
                    {
                        Physics.IgnoreCollision(
                            WrapperHelper.UnwrapObject < Collider >( a[0] ),
                            WrapperHelper.UnwrapObject < Collider >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["IgnoreLayerCollision"] = new BSFunctionReference(
                new BSFunction(
                    "function IgnoreLayerCollision(layer1, layer2, ignore)",
                    a =>
                    {
                        Physics.IgnoreLayerCollision(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < bool >( a[2] ) );

                        return new BSObject( null );
                    },
                    3 ) );

            m_StaticProperties["IgnoreLayerCollision"] = new BSFunctionReference(
                new BSFunction(
                    "function IgnoreLayerCollision(layer1, layer2)",
                    a =>
                    {
                        Physics.IgnoreLayerCollision(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["GetIgnoreLayerCollision"] = new BSFunctionReference(
                new BSFunction(
                    "function GetIgnoreLayerCollision(layer1, layer2)",
                    a => Physics.GetIgnoreLayerCollision(
                        WrapperHelper.UnwrapObject < int >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["GetIgnoreCollision"] = new BSFunctionReference(
                new BSFunction(
                    "function GetIgnoreCollision(collider1, collider2)",
                    a => Physics.GetIgnoreCollision(
                        WrapperHelper.UnwrapObject < Collider >( a[0] ),
                        WrapperHelper.UnwrapObject < Collider >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance, layerMask)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, maxDistance)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(ray, maxDistance, layerMask)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(ray, maxDistance)",
                    a => Physics.Raycast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(ray)",
                    a => Physics.Raycast( WrapperHelper.UnwrapObject < Ray >( a[0] ) ) ? BSObject.One : BSObject.Zero,
                    1 ) );

            m_StaticProperties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end, layerMask)",
                    a => Physics.Linecast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end)",
                    a => Physics.Linecast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    6 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction, maxDistance)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CapsuleCast(point1, point2, radius, direction)",
                    a => Physics.CapsuleCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius, maxDistance, layerMask)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius, maxDistance)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["SphereCast"] = new BSFunctionReference(
                new BSFunction(
                    "function SphereCast(ray, radius)",
                    a => Physics.SphereCast(
                        WrapperHelper.UnwrapObject < Ray >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ),
                        WrapperHelper.UnwrapObject < int >( a[5] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    6 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation, maxDistance)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ),
                        WrapperHelper.UnwrapObject < float >( a[4] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    5 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction, orientation)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(center, halfExtents, direction)",
                    a => Physics.BoxCast(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["Simulate"] = new BSFunctionReference(
                new BSFunction(
                    "function Simulate(step)",
                    a =>
                    {
                        Physics.Simulate( WrapperHelper.UnwrapObject < float >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["SyncTransforms"] = new BSFunctionReference(
                new BSFunction(
                    "function SyncTransforms()",
                    a =>
                    {
                        Physics.SyncTransforms();

                        return new BSObject( null );
                    },
                    0 ) );

            m_StaticProperties["ClosestPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPoint(point, collider, position, rotation)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        Physics.ClosestPoint(
                            WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                            WrapperHelper.UnwrapObject < Collider >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[2] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["CheckSphere"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckSphere(position, radius, layerMask)",
                    a => Physics.CheckSphere(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ),
                        WrapperHelper.UnwrapObject < int >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["CheckSphere"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckSphere(position, radius)",
                    a => Physics.CheckSphere(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < float >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["CheckCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckCapsule(start, end, radius, layerMask)",
                    a => Physics.CheckCapsule(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CheckCapsule"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckCapsule(start, end, radius)",
                    a => Physics.CheckCapsule(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < float >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents, orientation, layerMask)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[2] ),
                        WrapperHelper.UnwrapObject < int >( a[3] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    4 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents, orientation)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                        WrapperHelper.UnwrapObject < Quaternion >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["CheckBox"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckBox(center, halfExtents)",
                    a => Physics.CheckBox(
                        WrapperHelper.UnwrapObject < Vector3 >( a[0] ),
                        WrapperHelper.UnwrapObject < Vector3 >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["RebuildBroadphaseRegions"] = new BSFunctionReference(
                new BSFunction(
                    "function RebuildBroadphaseRegions(worldBounds, subdivisions)",
                    a =>
                    {
                        Physics.RebuildBroadphaseRegions(
                            WrapperHelper.UnwrapObject < Bounds >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["BakeMesh"] = new BSFunctionReference(
                new BSFunction(
                    "function BakeMesh(meshID, convex)",
                    a =>
                    {
                        Physics.BakeMesh(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

        }

        #endregion
    }

}
