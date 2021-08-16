using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using BadScript.Common.Types;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Unity.Wrapper.Core.Generated;
using Microsoft.Win32.SafeHandles;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Playables;
using UnityEngine.Profiling;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;
using Cursor = UnityEngine.UIElements.Cursor;
using Image = UnityEngine.UI.Image;
using Object = UnityEngine.Object;
using Slider = UnityEngine.UIElements.Slider;

namespace BadScript.Unity.Wrapper.Core
{

    public class UnityCoreCtorDB : IWrapperConstructorDataBase
    {
        private readonly Dictionary < Type, (IWrapperObjectCreator[], Func < object[], object >) > m_Creators;

        public Type[] Types => m_Creators.Keys.ToArray();

        #region Public

        public UnityCoreCtorDB()
        {
            m_Creators = new Dictionary < Type, (IWrapperObjectCreator[], Func < object[], object >) >
            {
                {
                    typeof( GameObject ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GameObject(
                          ( GameObject ) m_Creators[typeof( GameObject )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Transform ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Transform(
                          ( Transform ) m_Creators[typeof( Transform )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Vector3 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Vector3(
                          ( Vector3 ) m_Creators[typeof( Vector3 )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( object ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Object(
                          ( object ) m_Creators[typeof( object )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( IFormatProvider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_IFormatProvider(
                          ( IFormatProvider ) m_Creators[typeof( IFormatProvider )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( Quaternion ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Quaternion(
                          ( Quaternion ) m_Creators[typeof( Quaternion )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Matrix4x4 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Matrix4x4(
                          ( Matrix4x4 ) m_Creators[typeof( Matrix4x4 )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( FrustumPlanes ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_FrustumPlanes(
                          ( FrustumPlanes ) m_Creators[typeof( FrustumPlanes )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( Vector4 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Vector4(
                          ( Vector4 ) m_Creators[typeof( Vector4 )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( Plane ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Plane(
                          ( Plane ) m_Creators[typeof( Plane )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( IEnumerator ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Collections_IEnumerator(
                          ( IEnumerator ) m_Creators[typeof( IEnumerator )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( Component ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Component(
                          ( Component ) m_Creators[typeof( Component )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Scene ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SceneManagement_Scene(
                          ( Scene ) m_Creators[typeof( Scene )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( MonoBehaviour ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_MonoBehaviour(
                          ( MonoBehaviour ) m_Creators[typeof( MonoBehaviour )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( Coroutine ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Coroutine(
                          ( Coroutine ) m_Creators[typeof( Coroutine )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Object ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Object(
                          ( Object ) m_Creators[typeof( Object )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( Physics ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Physics(
                          ( Physics ) m_Creators[typeof( Physics )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( PhysicsScene ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PhysicsScene(
                          ( PhysicsScene ) m_Creators[typeof( PhysicsScene )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( Collider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Collider(
                          ( Collider ) m_Creators[typeof( Collider )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( Rigidbody ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rigidbody(
                          ( Rigidbody ) m_Creators[typeof( Rigidbody )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( ArticulationBody ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ArticulationBody(
                          ( ArticulationBody ) m_Creators[typeof( ArticulationBody )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( ArticulationDrive ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ArticulationDrive(
                          ( ArticulationDrive ) m_Creators[typeof( ArticulationDrive )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( ArticulationReducedSpace ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ArticulationReducedSpace(
                          ( ArticulationReducedSpace ) m_Creators[typeof( ArticulationReducedSpace )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( Bounds ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Bounds(
                          ( Bounds ) m_Creators[typeof( Bounds )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( Ray ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Ray(
                          ( Ray ) m_Creators[typeof( Ray )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( PhysicMaterial ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PhysicMaterial(
                          ( PhysicMaterial ) m_Creators[typeof( PhysicMaterial )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( Input ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Input(
                          ( Input ) m_Creators[typeof( Input )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( Vector2 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Vector2(
                          ( Vector2 ) m_Creators[typeof( Vector2 )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( LocationService ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LocationService(
                          ( LocationService ) m_Creators[typeof( LocationService )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( LocationInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LocationInfo(
                          ( LocationInfo ) m_Creators[typeof( LocationInfo )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( Compass ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Compass(
                          ( Compass ) m_Creators[typeof( Compass )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( Gyroscope ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Gyroscope(
                          ( Gyroscope ) m_Creators[typeof( Gyroscope )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Touch ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Touch(
                          ( Touch ) m_Creators[typeof( Touch )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( AccelerationEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AccelerationEvent(
                          ( AccelerationEvent ) m_Creators[typeof( AccelerationEvent )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( LayerMask ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LayerMask(
                          ( LayerMask ) m_Creators[typeof( LayerMask )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Camera ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Camera(
                          ( Camera ) m_Creators[typeof( Camera )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( Color ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Color(
                          ( Color ) m_Creators[typeof( Color )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( Rect ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rect(
                          ( Rect ) m_Creators[typeof( Rect )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( RenderTexture ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RenderTexture(
                          ( RenderTexture ) m_Creators[typeof( RenderTexture )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( RenderBuffer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RenderBuffer(
                          ( RenderBuffer ) m_Creators[typeof( RenderBuffer )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( IntPtr ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_IntPtr(
                          ( IntPtr ) m_Creators[typeof( IntPtr )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( RenderTextureDescriptor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RenderTextureDescriptor(
                          ( RenderTextureDescriptor ) m_Creators[typeof( RenderTextureDescriptor )].
                                                      Item1.First( x => x.ArgCount == a.Length ).
                                                      Create( a ) ) )
                },
                {
                    typeof( Hash128 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Hash128(
                          ( Hash128 ) m_Creators[typeof( Hash128 )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( Shader ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Shader(
                          ( Shader ) m_Creators[typeof( Shader )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( ShaderTagId ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_ShaderTagId(
                          ( ShaderTagId ) m_Creators[typeof( ShaderTagId )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( Texture ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Texture(
                          ( Texture ) m_Creators[typeof( Texture )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( ComputeBuffer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ComputeBuffer(
                          ( ComputeBuffer ) m_Creators[typeof( ComputeBuffer )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( Array ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Array(
                          ( Array ) m_Creators[typeof( Array )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( IComparer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Collections_IComparer(
                          ( IComparer ) m_Creators[typeof( IComparer )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( GraphicsBuffer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GraphicsBuffer(
                          ( GraphicsBuffer ) m_Creators[typeof( GraphicsBuffer )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( Cubemap ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Cubemap(
                          ( Cubemap ) m_Creators[typeof( Cubemap )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( CommandBuffer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_CommandBuffer(
                          ( CommandBuffer ) m_Creators[typeof( CommandBuffer )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( RenderTargetIdentifier ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_RenderTargetIdentifier(
                          ( RenderTargetIdentifier ) m_Creators[typeof( RenderTargetIdentifier )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( ComputeShader ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ComputeShader(
                          ( ComputeShader ) m_Creators[typeof( ComputeShader )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( RayTracingShader ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_Rendering_RayTracingShader(
                          ( RayTracingShader ) m_Creators[typeof( RayTracingShader )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( RayTracingAccelerationStructure ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure(
                          ( RayTracingAccelerationStructure ) m_Creators[typeof( RayTracingAccelerationStructure )].
                                                              Item1.First( x => x.ArgCount == a.Length ).
                                                              Create( a ) ) )
                },
                {
                    typeof( Renderer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Renderer(
                          ( Renderer ) m_Creators[typeof( Renderer )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( Material ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Material(
                          ( Material ) m_Creators[typeof( Material )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( MaterialPropertyBlock ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_MaterialPropertyBlock(
                          ( MaterialPropertyBlock ) m_Creators[typeof( MaterialPropertyBlock )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( CustomSampler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Profiling_CustomSampler(
                          ( CustomSampler ) m_Creators[typeof( CustomSampler )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( Recorder ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Profiling_Recorder(
                          ( Recorder ) m_Creators[typeof( Recorder )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( RenderTargetBinding ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_RenderTargetBinding(
                          ( RenderTargetBinding ) m_Creators[typeof( RenderTargetBinding )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( Mesh ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Mesh(
                          ( Mesh ) m_Creators[typeof( Mesh )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( VertexAttributeDescriptor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_VertexAttributeDescriptor(
                          ( VertexAttributeDescriptor ) m_Creators[typeof( VertexAttributeDescriptor )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( SubMeshDescriptor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_SubMeshDescriptor(
                          ( SubMeshDescriptor ) m_Creators[typeof( SubMeshDescriptor )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( RectInt ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RectInt(
                          ( RectInt ) m_Creators[typeof( RectInt )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( Vector2Int ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Vector2Int(
                          ( Vector2Int ) m_Creators[typeof( Vector2Int )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( GraphicsFence ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_GPUFence(
                          ( GraphicsFence ) m_Creators[typeof( GraphicsFence )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( MeshFilter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_MeshFilter(
                          ( MeshFilter ) m_Creators[typeof( MeshFilter )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( MeshCollider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_MeshCollider(
                          ( MeshCollider ) m_Creators[typeof( MeshCollider )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( BoxCollider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_BoxCollider(
                          ( BoxCollider ) m_Creators[typeof( BoxCollider )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( SphereCollider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SphereCollider(
                          ( SphereCollider ) m_Creators[typeof( SphereCollider )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( CapsuleCollider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CapsuleCollider(
                          ( CapsuleCollider ) m_Creators[typeof( CapsuleCollider )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( RectTransform ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RectTransform(
                          ( RectTransform ) m_Creators[typeof( RectTransform )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( ScrollView ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ScrollView(
                          ( ScrollView ) m_Creators[typeof( ScrollView )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( VisualElement ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_VisualElement(
                          ( VisualElement ) m_Creators[typeof( VisualElement )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( FocusController ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_FocusController(
                          ( FocusController ) m_Creators[typeof( FocusController )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( Focusable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Focusable(
                          ( Focusable ) m_Creators[typeof( Focusable )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( EventBase ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_EventBase(
                          ( EventBase ) m_Creators[typeof( EventBase )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( IEventHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IEventHandler(
                          ( IEventHandler ) m_Creators[typeof( IEventHandler )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( Event ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Event(
                          ( Event ) m_Creators[typeof( Event )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( char ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Char(
                          ( char ) m_Creators[typeof( char )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( CultureInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Globalization_CultureInfo(
                          ( CultureInfo ) m_Creators[typeof( CultureInfo )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( Calendar ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Globalization_Calendar(
                          ( Calendar ) m_Creators[typeof( Calendar )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( DateTime ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_DateTime(
                          ( DateTime ) m_Creators[typeof( DateTime )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( TimeSpan ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_TimeSpan(
                          ( TimeSpan ) m_Creators[typeof( TimeSpan )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( TextInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Globalization_TextInfo(
                          ( TextInfo ) m_Creators[typeof( TextInfo )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( CompareInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Globalization_CompareInfo(
                          ( CompareInfo ) m_Creators[typeof( CompareInfo )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( SortVersion ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Globalization_SortVersion(
                          ( SortVersion ) m_Creators[typeof( SortVersion )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( Guid ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Guid(
                          ( Guid ) m_Creators[typeof( Guid )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( SortKey ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Globalization_SortKey(
                          ( SortKey ) m_Creators[typeof( SortKey )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( Assembly ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_Assembly(
                          ( Assembly ) m_Creators[typeof( Assembly )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( MethodInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_MethodInfo(
                          ( MethodInfo ) m_Creators[typeof( MethodInfo )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( ParameterInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_ParameterInfo(
                          ( ParameterInfo ) m_Creators[typeof( ParameterInfo )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( MemberInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_MemberInfo(
                          ( MemberInfo ) m_Creators[typeof( MemberInfo )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Module ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_Module(
                          ( Module ) m_Creators[typeof( Module )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( ModuleHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_ModuleHandle(
                          ( ModuleHandle ) m_Creators[typeof( ModuleHandle )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( RuntimeFieldHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_RuntimeFieldHandle(
                          ( RuntimeFieldHandle ) m_Creators[typeof( RuntimeFieldHandle )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( SerializationInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Runtime_Serialization_SerializationInfo(
                          ( SerializationInfo ) m_Creators[typeof( SerializationInfo )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( SerializationInfoEnumerator ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Runtime_Serialization_SerializationInfoEnumerator(
                          ( SerializationInfoEnumerator ) m_Creators[typeof( SerializationInfoEnumerator )].
                                                          Item1.First( x => x.ArgCount == a.Length ).
                                                          Create( a ) ) )
                },
                {
                    typeof( SerializationEntry ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Runtime_Serialization_SerializationEntry(
                          ( SerializationEntry ) m_Creators[typeof( SerializationEntry )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( StreamingContext ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Runtime_Serialization_StreamingContext(
                          ( StreamingContext ) m_Creators[typeof( StreamingContext )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( RuntimeMethodHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_RuntimeMethodHandle(
                          ( RuntimeMethodHandle ) m_Creators[typeof( RuntimeMethodHandle )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( RuntimeTypeHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_RuntimeTypeHandle(
                          ( RuntimeTypeHandle ) m_Creators[typeof( RuntimeTypeHandle )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( TypeFilter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_TypeFilter(
                          ( TypeFilter ) m_Creators[typeof( TypeFilter )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( IAsyncResult ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_IAsyncResult(
                          ( IAsyncResult ) m_Creators[typeof( IAsyncResult )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( WaitHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Threading_WaitHandle(
                          ( WaitHandle ) m_Creators[typeof( WaitHandle )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( SafeWaitHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Microsoft_Win32_SafeHandles_SafeWaitHandle(
                          ( SafeWaitHandle ) m_Creators[typeof( SafeWaitHandle )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( IDictionary ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Collections_IDictionary(
                          ( IDictionary ) m_Creators[typeof( IDictionary )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( ICollection ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Collections_ICollection(
                          ( ICollection ) m_Creators[typeof( ICollection )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( IDictionaryEnumerator ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Collections_IDictionaryEnumerator(
                          ( IDictionaryEnumerator ) m_Creators[typeof( IDictionaryEnumerator )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( DictionaryEntry ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Collections_DictionaryEntry(
                          ( DictionaryEntry ) m_Creators[typeof( DictionaryEntry )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( AsyncCallback ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_AsyncCallback(
                          ( AsyncCallback ) m_Creators[typeof( AsyncCallback )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( FieldInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_FieldInfo(
                          ( FieldInfo ) m_Creators[typeof( FieldInfo )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Binder ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_Binder(
                          ( Binder ) m_Creators[typeof( Binder )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( MethodBase ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_MethodBase(
                          ( MethodBase ) m_Creators[typeof( MethodBase )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( MethodBody ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_MethodBody(
                          ( MethodBody ) m_Creators[typeof( MethodBody )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( PropertyInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_PropertyInfo(
                          ( PropertyInfo ) m_Creators[typeof( PropertyInfo )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( X509Certificate ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Security_Cryptography_X509Certificates_X509Certificate(
                          ( X509Certificate ) m_Creators[typeof( X509Certificate )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( SecureString ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Security_SecureString(
                          ( SecureString ) m_Creators[typeof( SecureString )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( ICustomAttributeProvider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_ICustomAttributeProvider(
                          ( ICustomAttributeProvider ) m_Creators[typeof( ICustomAttributeProvider )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( Delegate ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Delegate(
                          ( Delegate ) m_Creators[typeof( Delegate )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( IPermission ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Security_IPermission(
                          ( IPermission ) m_Creators[typeof( IPermission )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( SecurityElement ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Security_SecurityElement(
                          ( SecurityElement ) m_Creators[typeof( SecurityElement )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( Hashtable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Collections_Hashtable(
                          ( Hashtable ) m_Creators[typeof( Hashtable )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( ArrayList ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Collections_ArrayList(
                          ( ArrayList ) m_Creators[typeof( ArrayList )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( IList ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Collections_IList(
                          ( IList ) m_Creators[typeof( IList )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( ModuleResolveEventHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_ModuleResolveEventHandler(
                          ( ModuleResolveEventHandler ) m_Creators[typeof( ModuleResolveEventHandler )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( ResolveEventArgs ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_ResolveEventArgs(
                          ( ResolveEventArgs ) m_Creators[typeof( ResolveEventArgs )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( FileStream ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_IO_FileStream(
                          ( FileStream ) m_Creators[typeof( FileStream )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( SafeFileHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Microsoft_Win32_SafeHandles_SafeFileHandle(
                          ( SafeFileHandle ) m_Creators[typeof( SafeFileHandle )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( Task ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Threading_Tasks_Task(
                          ( Task ) m_Creators[typeof( Task )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( TaskFactory ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Threading_Tasks_TaskFactory(
                          ( TaskFactory ) m_Creators[typeof( TaskFactory )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( CancellationToken ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Threading_CancellationToken(
                          ( CancellationToken ) m_Creators[typeof( CancellationToken )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( CancellationTokenRegistration ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Threading_CancellationTokenRegistration(
                          ( CancellationTokenRegistration ) m_Creators[typeof( CancellationTokenRegistration )].
                                                            Item1.First( x => x.ArgCount == a.Length ).
                                                            Create( a ) ) )
                },
                {
                    typeof( Action ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Action(
                          ( Action ) m_Creators[typeof( Action )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( TaskScheduler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Threading_Tasks_TaskScheduler(
                          ( TaskScheduler ) m_Creators[typeof( TaskScheduler )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( AggregateException ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_AggregateException(
                          ( AggregateException ) m_Creators[typeof( AggregateException )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( Exception ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Exception(
                          ( Exception ) m_Creators[typeof( Exception )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( TaskAwaiter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Runtime_CompilerServices_TaskAwaiter(
                          ( TaskAwaiter ) m_Creators[typeof( TaskAwaiter )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( ConfiguredTaskAwaitable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Runtime_CompilerServices_ConfiguredTaskAwaitable(
                          ( ConfiguredTaskAwaitable ) m_Creators[typeof( ConfiguredTaskAwaitable )].
                                                      Item1.First( x => x.ArgCount == a.Length ).
                                                      Create( a ) ) )
                },
                {
                    typeof( YieldAwaitable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Runtime_CompilerServices_YieldAwaitable(
                          ( YieldAwaitable ) m_Creators[typeof( YieldAwaitable )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( Stream ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_IO_Stream(
                          ( Stream ) m_Creators[typeof( Stream )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( AssemblyName ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_AssemblyName(
                          ( AssemblyName ) m_Creators[typeof( AssemblyName )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( StrongNameKeyPair ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_StrongNameKeyPair(
                          ( StrongNameKeyPair ) m_Creators[typeof( StrongNameKeyPair )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( Version ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Version(
                          ( Version ) m_Creators[typeof( Version )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( ManifestResourceInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_ManifestResourceInfo(
                          ( ManifestResourceInfo ) m_Creators[typeof( ManifestResourceInfo )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( NumberFormatInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Globalization_NumberFormatInfo(
                          ( NumberFormatInfo ) m_Creators[typeof( NumberFormatInfo )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( DateTimeFormatInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Globalization_DateTimeFormatInfo(
                          ( DateTimeFormatInfo ) m_Creators[typeof( DateTimeFormatInfo )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( ITransform ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ITransform(
                          ( ITransform ) m_Creators[typeof( ITransform )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( IExperimentalFeatures ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IExperimentalFeatures(
                          ( IExperimentalFeatures ) m_Creators[typeof( IExperimentalFeatures )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( ITransitionAnimations ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Experimental_ITransitionAnimations(
                          ( ITransitionAnimations ) m_Creators[typeof( ITransitionAnimations )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( IPanel ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IPanel(
                          ( IPanel ) m_Creators[typeof( IPanel )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( EventDispatcher ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_EventDispatcher(
                          ( EventDispatcher ) m_Creators[typeof( EventDispatcher )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( ContextualMenuManager ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ContextualMenuManager(
                          ( ContextualMenuManager ) m_Creators[typeof( ContextualMenuManager )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( IVisualElementScheduler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IVisualElementScheduler(
                          ( IVisualElementScheduler ) m_Creators[typeof( IVisualElementScheduler )].
                                                      Item1.First( x => x.ArgCount == a.Length ).
                                                      Create( a ) ) )
                },
                {
                    typeof( IVisualElementScheduledItem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IVisualElementScheduledItem(
                          ( IVisualElementScheduledItem ) m_Creators[typeof( IVisualElementScheduledItem )].
                                                          Item1.First( x => x.ArgCount == a.Length ).
                                                          Create( a ) ) )
                },
                {
                    typeof( IStyle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IStyle(
                          ( IStyle ) m_Creators[typeof( IStyle )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( StyleColor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_StyleColor(
                          ( StyleColor ) m_Creators[typeof( StyleColor )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( StyleBackground ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_StyleBackground(
                          ( StyleBackground ) m_Creators[typeof( StyleBackground )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( Background ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Background(
                          ( Background ) m_Creators[typeof( Background )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Texture2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Texture2D(
                          ( Texture2D ) m_Creators[typeof( Texture2D )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( VectorImage ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_VectorImage(
                          ( VectorImage ) m_Creators[typeof( VectorImage )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( StyleLength ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_StyleLength(
                          ( StyleLength ) m_Creators[typeof( StyleLength )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( Length ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Length(
                          ( Length ) m_Creators[typeof( Length )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( StyleFloat ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_StyleFloat(
                          ( StyleFloat ) m_Creators[typeof( StyleFloat )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( StyleCursor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_StyleCursor(
                          ( StyleCursor ) m_Creators[typeof( StyleCursor )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( Cursor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Cursor(
                          ( Cursor ) m_Creators[typeof( Cursor )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( StyleFont ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_StyleFont(
                          ( StyleFont ) m_Creators[typeof( StyleFont )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Font ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Font(
                          ( Font ) m_Creators[typeof( Font )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( StyleInt ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_StyleInt(
                          ( StyleInt ) m_Creators[typeof( StyleInt )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( ICustomStyle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ICustomStyle(
                          ( ICustomStyle ) m_Creators[typeof( ICustomStyle )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( VisualElementStyleSheetSet ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_VisualElementStyleSheetSet(
                          ( VisualElementStyleSheetSet ) m_Creators[typeof( VisualElementStyleSheetSet )].
                                                         Item1.First( x => x.ArgCount == a.Length ).
                                                         Create( a ) ) )
                },
                {
                    typeof( StyleSheet ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_StyleSheet(
                          ( StyleSheet ) m_Creators[typeof( StyleSheet )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( IResolvedStyle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IResolvedStyle(
                          ( IResolvedStyle ) m_Creators[typeof( IResolvedStyle )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( Scroller ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Scroller(
                          ( Scroller ) m_Creators[typeof( Scroller )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( Slider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Slider(
                          ( Slider ) m_Creators[typeof( Slider )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( Label ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Label(
                          ( Label ) m_Creators[typeof( Label )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( IBinding ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IBinding(
                          ( IBinding ) m_Creators[typeof( IBinding )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( RepeatButton ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_RepeatButton(
                          ( RepeatButton ) m_Creators[typeof( RepeatButton )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( Text ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_Text(
                          ( Text ) m_Creators[typeof( Text )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( TextGenerator ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TextGenerator(
                          ( TextGenerator ) m_Creators[typeof( TextGenerator )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( TextGenerationSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TextGenerationSettings(
                          ( TextGenerationSettings ) m_Creators[typeof( TextGenerationSettings )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( Canvas ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Canvas(
                          ( Canvas ) m_Creators[typeof( Canvas )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( CanvasRenderer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CanvasRenderer(
                          ( CanvasRenderer ) m_Creators[typeof( CanvasRenderer )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( UnityAction ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Events_UnityAction(
                          ( UnityAction ) m_Creators[typeof( UnityAction )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( InputField ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_InputField(
                          ( InputField ) m_Creators[typeof( InputField )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Graphic ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_Graphic(
                          ( Graphic ) m_Creators[typeof( Graphic )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( TouchScreenKeyboard ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TouchScreenKeyboard(
                          ( TouchScreenKeyboard ) m_Creators[typeof( TouchScreenKeyboard )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( RangeInt ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RangeInt(
                          ( RangeInt ) m_Creators[typeof( RangeInt )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( Navigation ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_Navigation(
                          ( Navigation ) m_Creators[typeof( Navigation )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Selectable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_Selectable(
                          ( Selectable ) m_Creators[typeof( Selectable )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( ColorBlock ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_ColorBlock(
                          ( ColorBlock ) m_Creators[typeof( ColorBlock )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( SpriteState ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_SpriteState(
                          ( SpriteState ) m_Creators[typeof( SpriteState )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( Sprite ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Sprite(
                          ( Sprite ) m_Creators[typeof( Sprite )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( AnimationTriggers ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_AnimationTriggers(
                          ( AnimationTriggers ) m_Creators[typeof( AnimationTriggers )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( Image ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_Image(
                          ( Image ) m_Creators[typeof( Image )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( Animator ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animator(
                          ( Animator ) m_Creators[typeof( Animator )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( RuntimeAnimatorController ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RuntimeAnimatorController(
                          ( RuntimeAnimatorController ) m_Creators[typeof( RuntimeAnimatorController )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( Avatar ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Avatar(
                          ( Avatar ) m_Creators[typeof( Avatar )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( HumanDescription ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_HumanDescription(
                          ( HumanDescription ) m_Creators[typeof( HumanDescription )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( PlayableGraph ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_PlayableGraph(
                          ( PlayableGraph ) m_Creators[typeof( PlayableGraph )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( Playable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_Playable(
                          ( Playable ) m_Creators[typeof( Playable )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( PlayableHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_PlayableHandle(
                          ( PlayableHandle ) m_Creators[typeof( PlayableHandle )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( PlayableOutput ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_PlayableOutput(
                          ( PlayableOutput ) m_Creators[typeof( PlayableOutput )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( PlayableOutputHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_PlayableOutputHandle(
                          ( PlayableOutputHandle ) m_Creators[typeof( PlayableOutputHandle )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( IExposedPropertyTable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_IExposedPropertyTable(
                          ( IExposedPropertyTable ) m_Creators[typeof( IExposedPropertyTable )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( PropertyName ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PropertyName(
                          ( PropertyName ) m_Creators[typeof( PropertyName )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( AnimatorStateInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AnimatorStateInfo(
                          ( AnimatorStateInfo ) m_Creators[typeof( AnimatorStateInfo )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( AnimatorTransitionInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AnimatorTransitionInfo(
                          ( AnimatorTransitionInfo ) m_Creators[typeof( AnimatorTransitionInfo )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( AnimatorControllerParameter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AnimatorControllerParameter(
                          ( AnimatorControllerParameter ) m_Creators[typeof( AnimatorControllerParameter )].
                                                          Item1.First( x => x.ArgCount == a.Length ).
                                                          Create( a ) ) )
                },
                {
                    typeof( MatchTargetWeightMask ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_MatchTargetWeightMask(
                          ( MatchTargetWeightMask ) m_Creators[typeof( MatchTargetWeightMask )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( AxisEventData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_AxisEventData(
                          ( AxisEventData ) m_Creators[typeof( AxisEventData )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( BaseInputModule ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_BaseInputModule(
                          ( BaseInputModule ) m_Creators[typeof( BaseInputModule )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( BaseInput ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_BaseInput(
                          ( BaseInput ) m_Creators[typeof( BaseInput )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( PointerEventData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_PointerEventData(
                          ( PointerEventData ) m_Creators[typeof( PointerEventData )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( RaycastResult ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_RaycastResult(
                          ( RaycastResult ) m_Creators[typeof( RaycastResult )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( BaseRaycaster ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_BaseRaycaster(
                          ( BaseRaycaster ) m_Creators[typeof( BaseRaycaster )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( BaseEventData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_BaseEventData(
                          ( BaseEventData ) m_Creators[typeof( BaseEventData )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },

            };
        }

        public ABSObject Get( Type t, object[] args )
        {
            return ( ABSObject ) m_Creators[t].Item2( args );
        }

        public bool HasType < T >()
        {
            return m_Creators.ContainsKey( typeof( T ) );
        }

        #endregion
    }

}
