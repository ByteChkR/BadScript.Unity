using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Physics : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Physics() : base(typeof(UnityEngine.Physics))
        {
            m_StaticProperties["gravity"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Physics.gravity), x=> UnityEngine.Physics.gravity = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_StaticProperties["defaultContactOffset"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.defaultContactOffset), x=> UnityEngine.Physics.defaultContactOffset = WrapperHelper.UnwrapObject<System.Single>(x));
            m_StaticProperties["sleepThreshold"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.sleepThreshold), x=> UnityEngine.Physics.sleepThreshold = WrapperHelper.UnwrapObject<System.Single>(x));
            m_StaticProperties["queriesHitTriggers"] = new BSReflectionReference(() => UnityEngine.Physics.queriesHitTriggers ? BSObject.One : BSObject.Zero, x=> UnityEngine.Physics.queriesHitTriggers = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["queriesHitBackfaces"] = new BSReflectionReference(() => UnityEngine.Physics.queriesHitBackfaces ? BSObject.One : BSObject.Zero, x=> UnityEngine.Physics.queriesHitBackfaces = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["bounceThreshold"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.bounceThreshold), x=> UnityEngine.Physics.bounceThreshold = WrapperHelper.UnwrapObject<System.Single>(x));
            m_StaticProperties["defaultMaxDepenetrationVelocity"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.defaultMaxDepenetrationVelocity), x=> UnityEngine.Physics.defaultMaxDepenetrationVelocity = WrapperHelper.UnwrapObject<System.Single>(x));
            m_StaticProperties["defaultSolverIterations"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.defaultSolverIterations), x=> UnityEngine.Physics.defaultSolverIterations = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_StaticProperties["defaultSolverVelocityIterations"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.defaultSolverVelocityIterations), x=> UnityEngine.Physics.defaultSolverVelocityIterations = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_StaticProperties["bounceTreshold"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.bounceTreshold), x=> UnityEngine.Physics.bounceTreshold = WrapperHelper.UnwrapObject<System.Single>(x));
            m_StaticProperties["sleepVelocity"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.sleepVelocity), x=> UnityEngine.Physics.sleepVelocity = WrapperHelper.UnwrapObject<System.Single>(x));
            m_StaticProperties["sleepAngularVelocity"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.sleepAngularVelocity), x=> UnityEngine.Physics.sleepAngularVelocity = WrapperHelper.UnwrapObject<System.Single>(x));
            m_StaticProperties["solverIterationCount"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.defaultSolverIterations), x=> UnityEngine.Physics.defaultSolverIterations = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_StaticProperties["solverVelocityIterationCount"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.defaultSolverVelocityIterations), x=> UnityEngine.Physics.defaultSolverVelocityIterations = WrapperHelper.UnwrapObject<System.Int32>(x));
            m_StaticProperties["penetrationPenaltyForce"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.penetrationPenaltyForce), x=> UnityEngine.Physics.penetrationPenaltyForce = WrapperHelper.UnwrapObject<System.Single>(x));
            m_StaticProperties["defaultMaxAngularSpeed"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.defaultMaxAngularSpeed), x=> UnityEngine.Physics.defaultMaxAngularSpeed = WrapperHelper.UnwrapObject<System.Single>(x));
            m_StaticProperties["defaultPhysicsScene"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_PhysicsScene(UnityEngine.Physics.defaultPhysicsScene), null);
            m_StaticProperties["autoSimulation"] = new BSReflectionReference(() => UnityEngine.Physics.autoSimulation ? BSObject.One : BSObject.Zero, x=> UnityEngine.Physics.autoSimulation = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["autoSyncTransforms"] = new BSReflectionReference(() => UnityEngine.Physics.autoSyncTransforms ? BSObject.One : BSObject.Zero, x=> UnityEngine.Physics.autoSyncTransforms = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["reuseCollisionCallbacks"] = new BSReflectionReference(() => UnityEngine.Physics.reuseCollisionCallbacks ? BSObject.One : BSObject.Zero, x=> UnityEngine.Physics.reuseCollisionCallbacks = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["interCollisionDistance"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.interCollisionDistance), x=> UnityEngine.Physics.interCollisionDistance = WrapperHelper.UnwrapObject<System.Single>(x));
            m_StaticProperties["interCollisionStiffness"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.interCollisionStiffness), x=> UnityEngine.Physics.interCollisionStiffness = WrapperHelper.UnwrapObject<System.Single>(x));
            m_StaticProperties["interCollisionSettingsToggle"] = new BSReflectionReference(() => UnityEngine.Physics.interCollisionSettingsToggle ? BSObject.One : BSObject.Zero, x=> UnityEngine.Physics.interCollisionSettingsToggle = WrapperHelper.UnwrapObject<System.Boolean>(x));
            m_StaticProperties["clothGravity"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Physics.clothGravity), x=> UnityEngine.Physics.clothGravity = WrapperHelper.UnwrapObject<UnityEngine.Vector3>(x));
            m_StaticProperties["IgnoreRaycastLayer"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.IgnoreRaycastLayer), null);
            m_StaticProperties["DefaultRaycastLayers"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.DefaultRaycastLayers), null);
            m_StaticProperties["AllLayers"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Physics.AllLayers), null);
            m_StaticProperties["IgnoreCollision"] = new BSFunctionReference(new BSFunction("function IgnoreCollision(collider1, collider2, ignore)", a => {
                UnityEngine.Physics.IgnoreCollision(WrapperHelper.UnwrapObject<UnityEngine.Collider>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Collider>(a[1]), WrapperHelper.UnwrapObject<System.Boolean>(a[2]));
                return new BSObject(null);
            }, 3));
            m_StaticProperties["IgnoreCollision"] = new BSFunctionReference(new BSFunction("function IgnoreCollision(collider1, collider2)", a => {
                UnityEngine.Physics.IgnoreCollision(WrapperHelper.UnwrapObject<UnityEngine.Collider>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Collider>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["IgnoreLayerCollision"] = new BSFunctionReference(new BSFunction("function IgnoreLayerCollision(layer1, layer2, ignore)", a => {
                UnityEngine.Physics.IgnoreLayerCollision(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Boolean>(a[2]));
                return new BSObject(null);
            }, 3));
            m_StaticProperties["IgnoreLayerCollision"] = new BSFunctionReference(new BSFunction("function IgnoreLayerCollision(layer1, layer2)", a => {
                UnityEngine.Physics.IgnoreLayerCollision(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["GetIgnoreLayerCollision"] = new BSFunctionReference(new BSFunction("function GetIgnoreLayerCollision(layer1, layer2)", a => UnityEngine.Physics.GetIgnoreLayerCollision(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["GetIgnoreCollision"] = new BSFunctionReference(new BSFunction("function GetIgnoreCollision(collider1, collider2)", a => UnityEngine.Physics.GetIgnoreCollision(WrapperHelper.UnwrapObject<UnityEngine.Collider>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Collider>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["Raycast"] = new BSFunctionReference(new BSFunction("function Raycast(origin, direction, maxDistance, layerMask)", a => UnityEngine.Physics.Raycast(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3])) ? BSObject.One : BSObject.Zero, 4));
            m_StaticProperties["Raycast"] = new BSFunctionReference(new BSFunction("function Raycast(origin, direction, maxDistance)", a => UnityEngine.Physics.Raycast(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2])) ? BSObject.One : BSObject.Zero, 3));
            m_StaticProperties["Raycast"] = new BSFunctionReference(new BSFunction("function Raycast(origin, direction)", a => UnityEngine.Physics.Raycast(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["Raycast"] = new BSFunctionReference(new BSFunction("function Raycast(ray, maxDistance, layerMask)", a => UnityEngine.Physics.Raycast(WrapperHelper.UnwrapObject<UnityEngine.Ray>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2])) ? BSObject.One : BSObject.Zero, 3));
            m_StaticProperties["Raycast"] = new BSFunctionReference(new BSFunction("function Raycast(ray, maxDistance)", a => UnityEngine.Physics.Raycast(WrapperHelper.UnwrapObject<UnityEngine.Ray>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["Raycast"] = new BSFunctionReference(new BSFunction("function Raycast(ray)", a => UnityEngine.Physics.Raycast(WrapperHelper.UnwrapObject<UnityEngine.Ray>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_StaticProperties["Linecast"] = new BSFunctionReference(new BSFunction("function Linecast(start, end, layerMask)", a => UnityEngine.Physics.Linecast(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2])) ? BSObject.One : BSObject.Zero, 3));
            m_StaticProperties["Linecast"] = new BSFunctionReference(new BSFunction("function Linecast(start, end)", a => UnityEngine.Physics.Linecast(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(new BSFunction("function CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask)", a => UnityEngine.Physics.CapsuleCast(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[3]), WrapperHelper.UnwrapObject<System.Single>(a[4]), WrapperHelper.UnwrapObject<System.Int32>(a[5])) ? BSObject.One : BSObject.Zero, 6));
            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(new BSFunction("function CapsuleCast(point1, point2, radius, direction, maxDistance)", a => UnityEngine.Physics.CapsuleCast(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[3]), WrapperHelper.UnwrapObject<System.Single>(a[4])) ? BSObject.One : BSObject.Zero, 5));
            m_StaticProperties["CapsuleCast"] = new BSFunctionReference(new BSFunction("function CapsuleCast(point1, point2, radius, direction)", a => UnityEngine.Physics.CapsuleCast(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[3])) ? BSObject.One : BSObject.Zero, 4));
            m_StaticProperties["SphereCast"] = new BSFunctionReference(new BSFunction("function SphereCast(ray, radius, maxDistance, layerMask)", a => UnityEngine.Physics.SphereCast(WrapperHelper.UnwrapObject<UnityEngine.Ray>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3])) ? BSObject.One : BSObject.Zero, 4));
            m_StaticProperties["SphereCast"] = new BSFunctionReference(new BSFunction("function SphereCast(ray, radius, maxDistance)", a => UnityEngine.Physics.SphereCast(WrapperHelper.UnwrapObject<UnityEngine.Ray>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2])) ? BSObject.One : BSObject.Zero, 3));
            m_StaticProperties["SphereCast"] = new BSFunctionReference(new BSFunction("function SphereCast(ray, radius)", a => UnityEngine.Physics.SphereCast(WrapperHelper.UnwrapObject<UnityEngine.Ray>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["BoxCast"] = new BSFunctionReference(new BSFunction("function BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask)", a => UnityEngine.Physics.BoxCast(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[2]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[3]), WrapperHelper.UnwrapObject<System.Single>(a[4]), WrapperHelper.UnwrapObject<System.Int32>(a[5])) ? BSObject.One : BSObject.Zero, 6));
            m_StaticProperties["BoxCast"] = new BSFunctionReference(new BSFunction("function BoxCast(center, halfExtents, direction, orientation, maxDistance)", a => UnityEngine.Physics.BoxCast(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[2]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[3]), WrapperHelper.UnwrapObject<System.Single>(a[4])) ? BSObject.One : BSObject.Zero, 5));
            m_StaticProperties["BoxCast"] = new BSFunctionReference(new BSFunction("function BoxCast(center, halfExtents, direction, orientation)", a => UnityEngine.Physics.BoxCast(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[2]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[3])) ? BSObject.One : BSObject.Zero, 4));
            m_StaticProperties["BoxCast"] = new BSFunctionReference(new BSFunction("function BoxCast(center, halfExtents, direction)", a => UnityEngine.Physics.BoxCast(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[2])) ? BSObject.One : BSObject.Zero, 3));
            m_StaticProperties["Simulate"] = new BSFunctionReference(new BSFunction("function Simulate(step)", a => {
                UnityEngine.Physics.Simulate(WrapperHelper.UnwrapObject<System.Single>(a[0]));
                return new BSObject(null);
            }, 1));
            m_StaticProperties["SyncTransforms"] = new BSFunctionReference(new BSFunction("function SyncTransforms()", a => {
                UnityEngine.Physics.SyncTransforms();
                return new BSObject(null);
            }, 0));
            m_StaticProperties["ClosestPoint"] = new BSFunctionReference(new BSFunction("function ClosestPoint(point, collider, position, rotation)", a => new BSWrapperObject_UnityEngine_Vector3(UnityEngine.Physics.ClosestPoint(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Collider>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[2]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[3]))), 4));
            m_StaticProperties["CheckSphere"] = new BSFunctionReference(new BSFunction("function CheckSphere(position, radius, layerMask)", a => UnityEngine.Physics.CheckSphere(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2])) ? BSObject.One : BSObject.Zero, 3));
            m_StaticProperties["CheckSphere"] = new BSFunctionReference(new BSFunction("function CheckSphere(position, radius)", a => UnityEngine.Physics.CheckSphere(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["CheckCapsule"] = new BSFunctionReference(new BSFunction("function CheckCapsule(start, end, radius, layerMask)", a => UnityEngine.Physics.CheckCapsule(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3])) ? BSObject.One : BSObject.Zero, 4));
            m_StaticProperties["CheckCapsule"] = new BSFunctionReference(new BSFunction("function CheckCapsule(start, end, radius)", a => UnityEngine.Physics.CheckCapsule(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<System.Single>(a[2])) ? BSObject.One : BSObject.Zero, 3));
            m_StaticProperties["CheckBox"] = new BSFunctionReference(new BSFunction("function CheckBox(center, halfExtents, orientation, layerMask)", a => UnityEngine.Physics.CheckBox(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3])) ? BSObject.One : BSObject.Zero, 4));
            m_StaticProperties["CheckBox"] = new BSFunctionReference(new BSFunction("function CheckBox(center, halfExtents, orientation)", a => UnityEngine.Physics.CheckBox(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1]), WrapperHelper.UnwrapObject<UnityEngine.Quaternion>(a[2])) ? BSObject.One : BSObject.Zero, 3));
            m_StaticProperties["CheckBox"] = new BSFunctionReference(new BSFunction("function CheckBox(center, halfExtents)", a => UnityEngine.Physics.CheckBox(WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[0]), WrapperHelper.UnwrapObject<UnityEngine.Vector3>(a[1])) ? BSObject.One : BSObject.Zero, 2));
            m_StaticProperties["RebuildBroadphaseRegions"] = new BSFunctionReference(new BSFunction("function RebuildBroadphaseRegions(worldBounds, subdivisions)", a => {
                UnityEngine.Physics.RebuildBroadphaseRegions(WrapperHelper.UnwrapObject<UnityEngine.Bounds>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["BakeMesh"] = new BSFunctionReference(new BSFunction("function BakeMesh(meshID, convex)", a => {
                UnityEngine.Physics.BakeMesh(WrapperHelper.UnwrapObject<System.Int32>(a[0]), WrapperHelper.UnwrapObject<System.Boolean>(a[1]));
                return new BSObject(null);
            }, 2));

        }
    }

}