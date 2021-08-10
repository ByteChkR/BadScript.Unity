using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Physics2D : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Physics2D() : base( typeof( Physics2D ) )
        {
            m_StaticProperties["defaultPhysicsScene"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_PhysicsScene2D( Physics2D.defaultPhysicsScene ),
                null );

            m_StaticProperties["velocityIterations"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.velocityIterations ),
                x => Physics2D.velocityIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["positionIterations"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.positionIterations ),
                x => Physics2D.positionIterations = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["gravity"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( Physics2D.gravity ),
                x => Physics2D.gravity = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_StaticProperties["queriesHitTriggers"] = new BSReflectionReference(
                () => Physics2D.queriesHitTriggers ? BSObject.One : BSObject.Zero,
                x => Physics2D.queriesHitTriggers = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["queriesStartInColliders"] = new BSReflectionReference(
                () => Physics2D.queriesStartInColliders ? BSObject.One : BSObject.Zero,
                x => Physics2D.queriesStartInColliders = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["callbacksOnDisable"] = new BSReflectionReference(
                () => Physics2D.callbacksOnDisable ? BSObject.One : BSObject.Zero,
                x => Physics2D.callbacksOnDisable = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["reuseCollisionCallbacks"] = new BSReflectionReference(
                () => Physics2D.reuseCollisionCallbacks ? BSObject.One : BSObject.Zero,
                x => Physics2D.reuseCollisionCallbacks = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["autoSyncTransforms"] = new BSReflectionReference(
                () => Physics2D.autoSyncTransforms ? BSObject.One : BSObject.Zero,
                x => Physics2D.autoSyncTransforms = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["jobOptions"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_PhysicsJobOptions2D( Physics2D.jobOptions ),
                x => Physics2D.jobOptions = WrapperHelper.UnwrapObject < PhysicsJobOptions2D >( x ) );

            m_StaticProperties["velocityThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.velocityThreshold ),
                x => Physics2D.velocityThreshold = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["maxLinearCorrection"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.maxLinearCorrection ),
                x => Physics2D.maxLinearCorrection = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["maxAngularCorrection"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.maxAngularCorrection ),
                x => Physics2D.maxAngularCorrection = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["maxTranslationSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.maxTranslationSpeed ),
                x => Physics2D.maxTranslationSpeed = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["maxRotationSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.maxRotationSpeed ),
                x => Physics2D.maxRotationSpeed = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["defaultContactOffset"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.defaultContactOffset ),
                x => Physics2D.defaultContactOffset = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["baumgarteScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.baumgarteScale ),
                x => Physics2D.baumgarteScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["baumgarteTOIScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.baumgarteTOIScale ),
                x => Physics2D.baumgarteTOIScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["timeToSleep"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.timeToSleep ),
                x => Physics2D.timeToSleep = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["linearSleepTolerance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.linearSleepTolerance ),
                x => Physics2D.linearSleepTolerance = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["angularSleepTolerance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.angularSleepTolerance ),
                x => Physics2D.angularSleepTolerance = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["alwaysShowColliders"] = new BSReflectionReference(
                () => Physics2D.alwaysShowColliders ? BSObject.One : BSObject.Zero,
                x => Physics2D.alwaysShowColliders = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["showColliderSleep"] = new BSReflectionReference(
                () => Physics2D.showColliderSleep ? BSObject.One : BSObject.Zero,
                x => Physics2D.showColliderSleep = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["showColliderContacts"] = new BSReflectionReference(
                () => Physics2D.showColliderContacts ? BSObject.One : BSObject.Zero,
                x => Physics2D.showColliderContacts = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["showColliderAABB"] = new BSReflectionReference(
                () => Physics2D.showColliderAABB ? BSObject.One : BSObject.Zero,
                x => Physics2D.showColliderAABB = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["contactArrowScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.contactArrowScale ),
                x => Physics2D.contactArrowScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["colliderAwakeColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Physics2D.colliderAwakeColor ),
                x => Physics2D.colliderAwakeColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_StaticProperties["colliderAsleepColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Physics2D.colliderAsleepColor ),
                x => Physics2D.colliderAsleepColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_StaticProperties["colliderContactColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Physics2D.colliderContactColor ),
                x => Physics2D.colliderContactColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_StaticProperties["colliderAABBColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Physics2D.colliderAABBColor ),
                x => Physics2D.colliderAABBColor = WrapperHelper.UnwrapObject < Color >( x ) );

            m_StaticProperties["changeStopsCallbacks"] = new BSReflectionReference(
                () => Physics2D.changeStopsCallbacks ? BSObject.One : BSObject.Zero,
                x => Physics2D.changeStopsCallbacks = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["minPenetrationForPenalty"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.defaultContactOffset ),
                x => Physics2D.defaultContactOffset = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["autoSimulation"] = new BSReflectionReference(
                () => Physics2D.autoSimulation ? BSObject.One : BSObject.Zero,
                x => Physics2D.autoSimulation = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["IgnoreRaycastLayer"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.IgnoreRaycastLayer ),
                null );

            m_StaticProperties["DefaultRaycastLayers"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.DefaultRaycastLayers ),
                null );

            m_StaticProperties["AllLayers"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Physics2D.AllLayers ),
                null );

            m_StaticProperties["Simulate"] = new BSFunctionReference(
                new BSFunction(
                    "function Simulate(step)",
                    a => Physics2D.Simulate( WrapperHelper.UnwrapObject < float >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetIgnoreCollision"] = new BSFunctionReference(
                new BSFunction(
                    "function GetIgnoreCollision(collider1, collider2)",
                    a => Physics2D.GetIgnoreCollision(
                        WrapperHelper.UnwrapObject < Collider2D >( a[0] ),
                        WrapperHelper.UnwrapObject < Collider2D >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["GetIgnoreLayerCollision"] = new BSFunctionReference(
                new BSFunction(
                    "function GetIgnoreLayerCollision(layer1, layer2)",
                    a => Physics2D.GetIgnoreLayerCollision(
                        WrapperHelper.UnwrapObject < int >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["GetLayerCollisionMask"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLayerCollisionMask(layer)",
                    a => new BSObject(
                        ( decimal ) Physics2D.GetLayerCollisionMask( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["IsTouching"] = new BSFunctionReference(
                new BSFunction(
                    "function IsTouching(collider1, collider2)",
                    a => Physics2D.IsTouching(
                        WrapperHelper.UnwrapObject < Collider2D >( a[0] ),
                        WrapperHelper.UnwrapObject < Collider2D >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsTouching"] = new BSFunctionReference(
                new BSFunction(
                    "function IsTouching(collider1, collider2, contactFilter)",
                    a => Physics2D.IsTouching(
                        WrapperHelper.UnwrapObject < Collider2D >( a[0] ),
                        WrapperHelper.UnwrapObject < Collider2D >( a[1] ),
                        WrapperHelper.UnwrapObject < ContactFilter2D >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_StaticProperties["IsTouching"] = new BSFunctionReference(
                new BSFunction(
                    "function IsTouching(collider, contactFilter)",
                    a => Physics2D.IsTouching(
                        WrapperHelper.UnwrapObject < Collider2D >( a[0] ),
                        WrapperHelper.UnwrapObject < ContactFilter2D >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["IsTouchingLayers"] = new BSFunctionReference(
                new BSFunction(
                    "function IsTouchingLayers(collider)",
                    a => Physics2D.IsTouchingLayers( WrapperHelper.UnwrapObject < Collider2D >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsTouchingLayers"] = new BSFunctionReference(
                new BSFunction(
                    "function IsTouchingLayers(collider, layerMask)",
                    a => Physics2D.IsTouchingLayers(
                        WrapperHelper.UnwrapObject < Collider2D >( a[0] ),
                        WrapperHelper.UnwrapObject < int >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["Distance"] = new BSFunctionReference(
                new BSFunction(
                    "function Distance(colliderA, colliderB)",
                    a => new BSWrapperObject_UnityEngine_ColliderDistance2D(
                        Physics2D.Distance(
                            WrapperHelper.UnwrapObject < Collider2D >( a[0] ),
                            WrapperHelper.UnwrapObject < Collider2D >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["ClosestPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPoint(position, collider)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        Physics2D.ClosestPoint(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Collider2D >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["ClosestPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function ClosestPoint(position, rigidbody)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        Physics2D.ClosestPoint(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Rigidbody2D >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.Linecast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end, layerMask)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.Linecast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end, layerMask, minDepth)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.Linecast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["Linecast"] = new BSFunctionReference(
                new BSFunction(
                    "function Linecast(start, end, layerMask, minDepth, maxDepth)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.Linecast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.Raycast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, distance)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.Raycast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, distance, layerMask)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.Raycast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, distance, layerMask, minDepth)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.Raycast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["Raycast"] = new BSFunctionReference(
                new BSFunction(
                    "function Raycast(origin, direction, distance, layerMask, minDepth, maxDepth)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.Raycast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["CircleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CircleCast(origin, radius, direction)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.CircleCast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["CircleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CircleCast(origin, radius, direction, distance)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.CircleCast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["CircleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CircleCast(origin, radius, direction, distance, layerMask)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.CircleCast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["CircleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CircleCast(origin, radius, direction, distance, layerMask, minDepth)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.CircleCast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["CircleCast"] = new BSFunctionReference(
                new BSFunction(
                    "function CircleCast(origin, radius, direction, distance, layerMask, minDepth, maxDepth)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.CircleCast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < int >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ),
                            WrapperHelper.UnwrapObject < float >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(origin, size, angle, direction)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.BoxCast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(origin, size, angle, direction, distance)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.BoxCast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(origin, size, angle, direction, distance, layerMask)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.BoxCast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(origin, size, angle, direction, distance, layerMask, minDepth)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.BoxCast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < float >( a[6] ) ) ),
                    7 ) );

            m_StaticProperties["BoxCast"] = new BSFunctionReference(
                new BSFunction(
                    "function BoxCast(origin, size, angle, direction, distance, layerMask, minDepth, maxDepth)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.BoxCast(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < int >( a[5] ),
                            WrapperHelper.UnwrapObject < float >( a[6] ),
                            WrapperHelper.UnwrapObject < float >( a[7] ) ) ),
                    8 ) );

            m_StaticProperties["GetRayIntersection"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRayIntersection(ray)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.GetRayIntersection( WrapperHelper.UnwrapObject < Ray >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetRayIntersection"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRayIntersection(ray, distance)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.GetRayIntersection(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetRayIntersection"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRayIntersection(ray, distance, layerMask)",
                    a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                        Physics2D.GetRayIntersection(
                            WrapperHelper.UnwrapObject < Ray >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["OverlapPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapPoint(point)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapPoint( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["OverlapPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapPoint(point, layerMask)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapPoint(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["OverlapPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapPoint(point, layerMask, minDepth)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapPoint(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["OverlapPoint"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapPoint(point, layerMask, minDepth, maxDepth)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapPoint(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["OverlapCircle"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCircle(point, radius)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapCircle(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["OverlapCircle"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCircle(point, radius, layerMask)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapCircle(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["OverlapCircle"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCircle(point, radius, layerMask, minDepth)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapCircle(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["OverlapCircle"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapCircle(point, radius, layerMask, minDepth, maxDepth)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapCircle(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["OverlapBox"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBox(point, size, angle)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapBox(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["OverlapBox"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBox(point, size, angle, layerMask)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapBox(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["OverlapBox"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBox(point, size, angle, layerMask, minDepth)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapBox(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ) ) ),
                    5 ) );

            m_StaticProperties["OverlapBox"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapBox(point, size, angle, layerMask, minDepth, maxDepth)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapBox(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < float >( a[2] ),
                            WrapperHelper.UnwrapObject < int >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ),
                            WrapperHelper.UnwrapObject < float >( a[5] ) ) ),
                    6 ) );

            m_StaticProperties["OverlapArea"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapArea(pointA, pointB)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapArea(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["OverlapArea"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapArea(pointA, pointB, layerMask)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapArea(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["OverlapArea"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapArea(pointA, pointB, layerMask, minDepth)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapArea(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["OverlapArea"] = new BSFunctionReference(
                new BSFunction(
                    "function OverlapArea(pointA, pointB, layerMask, minDepth, maxDepth)",
                    a => new BSWrapperObject_UnityEngine_Collider2D(
                        Physics2D.OverlapArea(
                            WrapperHelper.UnwrapObject < Vector2 >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector2 >( a[1] ),
                            WrapperHelper.UnwrapObject < int >( a[2] ),
                            WrapperHelper.UnwrapObject < float >( a[3] ),
                            WrapperHelper.UnwrapObject < float >( a[4] ) ) ),
                    5 ) );

        }

        #endregion
    }

}
