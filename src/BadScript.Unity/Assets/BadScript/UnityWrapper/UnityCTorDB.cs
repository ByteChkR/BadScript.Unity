
#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN
#define BS_UNITY_WIN
#elif UNITY_IOS
#define BS_UNITY_IOS
#define BS_UNITY_APPLE
#elif UNITY_ANDROID
#define BS_UNITY_ANDROID
#elif UNITY_TVOS
#define BS_UNITY_TVOS
#define BS_UNITY_APPLE
#endif


using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BadScript.Common.Types;
using BadScript.Tools.CodeGenerator.Runtime;
using Microsoft.Win32.SafeHandles;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Analytics;
using UnityEngine.Android;
using UnityEngine.Animations;
using UnityEngine.Apple;
using UnityEngine.Assertions;
using UnityEngine.Assertions.Comparers;
using UnityEngine.Audio;
using UnityEngine.CrashReportHandler;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.AI;
using UnityEngine.Experimental.Audio;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Experimental.Playables;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.TerrainAPI;
using UnityEngine.Experimental.Video;
using UnityEngine.Internal;
using UnityEngine.iOS;
using UnityEngine.Jobs;
using UnityEngine.LowLevel;
using UnityEngine.Lumin;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.Networking.Types;
using UnityEngine.ParticleSystemJobs;
using UnityEngine.Playables;
using UnityEngine.PlayerLoop;
using UnityEngine.Profiling;
using UnityEngine.Profiling.Experimental;
using UnityEngine.Profiling.Memory.Experimental;
using UnityEngine.Rendering;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.SearchService;
using UnityEngine.Serialization;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.Sprites;
using UnityEngine.Subsystems;
using UnityEngine.SubsystemsImplementation;
using UnityEngine.TestTools;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;
using UnityEngine.Tilemaps;
using UnityEngine.tvOS;
using UnityEngine.U2D;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;
using UnityEngine.VFX;
using UnityEngine.Video;
using UnityEngine.Windows.Speech;
using UnityEngine.Windows.WebCam;
using UnityEngine.WSA;
using UnityEngine.XR;
using UnityEngineInternal;
using UnityEngineInternal.XR.WSA;
using Application = UnityEngine.Application;
using Button = UnityEngine.UIElements.Button;
using Cookie = UnityEngine.Experimental.GlobalIllumination.Cookie;
using Cursor = UnityEngine.Cursor;
using Device = UnityEngine.tvOS.Device;
using Image = UnityEngine.UIElements.Image;
using LocalNotification = UnityEngine.iOS.LocalNotification;
using NotificationServices = UnityEngine.iOS.NotificationServices;
using Object = UnityEngine.Object;
using RemoteNotification = UnityEngine.iOS.RemoteNotification;
using RenderSettings = UnityEngine.RenderSettings;
using Slider = UnityEngine.UIElements.Slider;
using Tile = UnityEngine.WSA.Tile;
using Toggle = UnityEngine.UIElements.Toggle;


namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class UnityCTorDB : IWrapperConstructorDataBase
    {
        private readonly Dictionary < Type, (IWrapperObjectCreator[], Func < object[], object >) > m_Creators;

        public Type[] Types => m_Creators.Keys.ToArray();

        #region Public

        public UnityCTorDB()
        {
            m_Creators = new Dictionary < Type, (IWrapperObjectCreator[], Func < object[], object >) >
            {
                {
                    typeof( NavMeshPath ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_NavMeshPath(
                          ( NavMeshPath ) m_Creators[typeof( NavMeshPath )].
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
                    typeof( NavMeshData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_NavMeshData(
                          ( NavMeshData ) m_Creators[typeof( NavMeshData )].
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
                    typeof( Vector3 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Vector3(
                          ( Vector3 ) m_Creators[typeof( Vector3 )].
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
                    typeof( Ray ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Ray(
                          ( Ray ) m_Creators[typeof( Ray )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
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
                    typeof( NavMeshBuildSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_NavMeshBuildSettings(
                          ( NavMeshBuildSettings ) m_Creators[typeof( NavMeshBuildSettings )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( NavMeshBuildDebugSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_NavMeshBuildDebugSettings(
                          ( NavMeshBuildDebugSettings ) m_Creators[typeof( NavMeshBuildDebugSettings )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( AsyncOperation ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AsyncOperation(
                          ( AsyncOperation ) m_Creators[typeof( AsyncOperation )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( NavMeshAgent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_NavMeshAgent(
                          ( NavMeshAgent ) m_Creators[typeof( NavMeshAgent )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( OffMeshLinkData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_OffMeshLinkData(
                          ( OffMeshLinkData ) m_Creators[typeof( OffMeshLinkData )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( OffMeshLink ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_OffMeshLink(
                          ( OffMeshLink ) m_Creators[typeof( OffMeshLink )].
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
                    typeof( GameObject ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GameObject(
                          ( GameObject ) m_Creators[typeof( GameObject )].
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
                    typeof( Component ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Component(
                          ( Component ) m_Creators[typeof( Component )].
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
                    typeof( NavMeshObstacle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_NavMeshObstacle(
                          ( NavMeshObstacle ) m_Creators[typeof( NavMeshObstacle )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( NavMeshHit ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_NavMeshHit(
                          ( NavMeshHit ) m_Creators[typeof( NavMeshHit )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( NavMeshTriangulation ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_NavMeshTriangulation(
                          ( NavMeshTriangulation ) m_Creators[typeof( NavMeshTriangulation )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( NavMeshDataInstance ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_NavMeshDataInstance(
                          ( NavMeshDataInstance ) m_Creators[typeof( NavMeshDataInstance )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( NavMeshLinkData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_NavMeshLinkData(
                          ( NavMeshLinkData ) m_Creators[typeof( NavMeshLinkData )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( NavMeshLinkInstance ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_NavMeshLinkInstance(
                          ( NavMeshLinkInstance ) m_Creators[typeof( NavMeshLinkInstance )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( NavMeshQueryFilter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_NavMeshQueryFilter(
                          ( NavMeshQueryFilter ) m_Creators[typeof( NavMeshQueryFilter )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( NavMeshBuildSource ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_NavMeshBuildSource(
                          ( NavMeshBuildSource ) m_Creators[typeof( NavMeshBuildSource )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( NavMeshBuildMarkup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AI_NavMeshBuildMarkup(
                          ( NavMeshBuildMarkup ) m_Creators[typeof( NavMeshBuildMarkup )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( PolygonId ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_AI_PolygonId(
                          ( PolygonId ) m_Creators[typeof( PolygonId )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( NavMeshLocation ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_AI_NavMeshLocation(
                          ( NavMeshLocation ) m_Creators[typeof( NavMeshLocation )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( NavMeshWorld ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_AI_NavMeshWorld(
                          ( NavMeshWorld ) m_Creators[typeof( NavMeshWorld )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( NavMeshQuery ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_AI_NavMeshQuery(
                          ( NavMeshQuery ) m_Creators[typeof( NavMeshQuery )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
#if BS_UNITY_ANDROID
                {
                    typeof( AndroidJavaRunnable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AndroidJavaRunnable(
                          ( AndroidJavaRunnable ) m_Creators[typeof( AndroidJavaRunnable )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
#endif
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
                    typeof( IntPtr ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_IntPtr(
                          ( IntPtr ) m_Creators[typeof( IntPtr )].
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
                    typeof( Assembly ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_Assembly(
                          ( Assembly ) m_Creators[typeof( Assembly )].
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
                    typeof( FileStream ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_IO_FileStream(
                          ( FileStream ) m_Creators[typeof( FileStream )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
#if BS_UNITY_WIN
                {
                    typeof( SafeFileHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Microsoft_Win32_SafeHandles_SafeFileHandle(
                          ( SafeFileHandle ) m_Creators[typeof( SafeFileHandle )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
#endif
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
#if BS_UNITY_WIN
                {
                    typeof( SafeWaitHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Microsoft_Win32_SafeHandles_SafeWaitHandle(
                          ( SafeWaitHandle ) m_Creators[typeof( SafeWaitHandle )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
#endif
                {
                    typeof( TimeSpan ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_TimeSpan(
                          ( TimeSpan ) m_Creators[typeof( TimeSpan )].
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
                    typeof( StreamingContext ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Runtime_Serialization_StreamingContext(
                          ( StreamingContext ) m_Creators[typeof( StreamingContext )].
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
                    typeof( AsyncCallback ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_AsyncCallback(
                          ( AsyncCallback ) m_Creators[typeof( AsyncCallback )].
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
                    typeof( MethodBase ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_MethodBase(
                          ( MethodBase ) m_Creators[typeof( MethodBase )].
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
                    typeof( TextInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Globalization_TextInfo(
                          ( TextInfo ) m_Creators[typeof( TextInfo )].
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
                    typeof( TypeFilter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_TypeFilter(
                          ( TypeFilter ) m_Creators[typeof( TypeFilter )].
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
#if BS_UNITY_ANDROID
                {
                    typeof( AndroidJavaException ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AndroidJavaException(
                          ( AndroidJavaException ) m_Creators[typeof( AndroidJavaException )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( AndroidJavaProxy ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AndroidJavaProxy(
                          ( AndroidJavaProxy ) m_Creators[typeof( AndroidJavaProxy )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( AndroidJavaClass ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AndroidJavaClass(
                          ( AndroidJavaClass ) m_Creators[typeof( AndroidJavaClass )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( AndroidJavaObject ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AndroidJavaObject(
                          ( AndroidJavaObject ) m_Creators[typeof( AndroidJavaObject )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( jvalue ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_jvalue(
                          ( jvalue ) m_Creators[typeof( jvalue )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
#endif
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
#if BS_UNITY_ANDROID
                {
                    typeof( AndroidDevice ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Android_AndroidDevice(
                          ( AndroidDevice ) m_Creators[typeof( AndroidDevice )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( PermissionCallbacks ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Android_PermissionCallbacks(
                          ( PermissionCallbacks ) m_Creators[typeof( PermissionCallbacks )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( Permission ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Android_Permission(
                          ( Permission ) m_Creators[typeof( Permission )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
#endif
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
                    typeof( PlayableOutput ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_PlayableOutput(
                          ( PlayableOutput ) m_Creators[typeof( PlayableOutput )].
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
                    typeof( IAnimationClipSource ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_IAnimationClipSource(
                          ( IAnimationClipSource ) m_Creators[typeof( IAnimationClipSource )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( SharedBetweenAnimatorsAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SharedBetweenAnimatorsAttribute(
                          ( SharedBetweenAnimatorsAttribute ) m_Creators[typeof( SharedBetweenAnimatorsAttribute )].
                                                              Item1.First( x => x.ArgCount == a.Length ).
                                                              Create( a ) ) )
                },
                {
                    typeof( StateMachineBehaviour ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_StateMachineBehaviour(
                          ( StateMachineBehaviour ) m_Creators[typeof( StateMachineBehaviour )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( Animation ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animation(
                          ( Animation ) m_Creators[typeof( Animation )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( AnimationClip ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AnimationClip(
                          ( AnimationClip ) m_Creators[typeof( AnimationClip )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( AnimationState ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AnimationState(
                          ( AnimationState ) m_Creators[typeof( AnimationState )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( AnimationEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AnimationEvent(
                          ( AnimationEvent ) m_Creators[typeof( AnimationEvent )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( AnimatorClipInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AnimatorClipInfo(
                          ( AnimatorClipInfo ) m_Creators[typeof( AnimatorClipInfo )].
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
                    typeof( AnimationClipPair ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AnimationClipPair(
                          ( AnimationClipPair ) m_Creators[typeof( AnimationClipPair )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( AnimatorOverrideController ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AnimatorOverrideController(
                          ( AnimatorOverrideController ) m_Creators[typeof( AnimatorOverrideController )].
                                                         Item1.First( x => x.ArgCount == a.Length ).
                                                         Create( a ) ) )
                },
                {
                    typeof( AnimatorUtility ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AnimatorUtility(
                          ( AnimatorUtility ) m_Creators[typeof( AnimatorUtility )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( SkeletonBone ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SkeletonBone(
                          ( SkeletonBone ) m_Creators[typeof( SkeletonBone )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( HumanLimit ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_HumanLimit(
                          ( HumanLimit ) m_Creators[typeof( HumanLimit )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( HumanBone ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_HumanBone(
                          ( HumanBone ) m_Creators[typeof( HumanBone )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( AvatarBuilder ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AvatarBuilder(
                          ( AvatarBuilder ) m_Creators[typeof( AvatarBuilder )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( AvatarMask ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AvatarMask(
                          ( AvatarMask ) m_Creators[typeof( AvatarMask )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( HumanPose ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_HumanPose(
                          ( HumanPose ) m_Creators[typeof( HumanPose )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( HumanPoseHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_HumanPoseHandler(
                          ( HumanPoseHandler ) m_Creators[typeof( HumanPoseHandler )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( HumanTrait ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_HumanTrait(
                          ( HumanTrait ) m_Creators[typeof( HumanTrait )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Motion ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Motion(
                          ( Motion ) m_Creators[typeof( Motion )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( AnimationPlayableOutput ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_AnimationPlayableOutput(
                          ( AnimationPlayableOutput ) m_Creators[typeof( AnimationPlayableOutput )].
                                                      Item1.First( x => x.ArgCount == a.Length ).
                                                      Create( a ) ) )
                },
                {
                    typeof( PlayableBinding ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_PlayableBinding(
                          ( PlayableBinding ) m_Creators[typeof( PlayableBinding )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( IAnimationJob ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_IAnimationJob(
                          ( IAnimationJob ) m_Creators[typeof( IAnimationJob )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( IAnimationJobPlayable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_IAnimationJobPlayable(
                          ( IAnimationJobPlayable ) m_Creators[typeof( IAnimationJobPlayable )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( IAnimationWindowPreview ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_IAnimationWindowPreview(
                          ( IAnimationWindowPreview ) m_Creators[typeof( IAnimationWindowPreview )].
                                                      Item1.First( x => x.ArgCount == a.Length ).
                                                      Create( a ) ) )
                },
                {
                    typeof( NotKeyableAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_NotKeyableAttribute(
                          ( NotKeyableAttribute ) m_Creators[typeof( NotKeyableAttribute )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( AimConstraint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_AimConstraint(
                          ( AimConstraint ) m_Creators[typeof( AimConstraint )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( ConstraintSource ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_ConstraintSource(
                          ( ConstraintSource ) m_Creators[typeof( ConstraintSource )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( AnimationClipPlayable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_AnimationClipPlayable(
                          ( AnimationClipPlayable ) m_Creators[typeof( AnimationClipPlayable )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( AnimationHumanStream ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_AnimationHumanStream(
                          ( AnimationHumanStream ) m_Creators[typeof( AnimationHumanStream )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( MuscleHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_MuscleHandle(
                          ( MuscleHandle ) m_Creators[typeof( MuscleHandle )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( AnimationLayerMixerPlayable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_AnimationLayerMixerPlayable(
                          ( AnimationLayerMixerPlayable ) m_Creators[typeof( AnimationLayerMixerPlayable )].
                                                          Item1.First( x => x.ArgCount == a.Length ).
                                                          Create( a ) ) )
                },
                {
                    typeof( AnimationMixerPlayable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_AnimationMixerPlayable(
                          ( AnimationMixerPlayable ) m_Creators[typeof( AnimationMixerPlayable )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( AnimationScriptPlayable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_AnimationScriptPlayable(
                          ( AnimationScriptPlayable ) m_Creators[typeof( AnimationScriptPlayable )].
                                                      Item1.First( x => x.ArgCount == a.Length ).
                                                      Create( a ) ) )
                },
                {
                    typeof( AnimationStream ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_AnimationStream(
                          ( AnimationStream ) m_Creators[typeof( AnimationStream )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( TransformStreamHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_TransformStreamHandle(
                          ( TransformStreamHandle ) m_Creators[typeof( TransformStreamHandle )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( PropertyStreamHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_PropertyStreamHandle(
                          ( PropertyStreamHandle ) m_Creators[typeof( PropertyStreamHandle )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( TransformSceneHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_TransformSceneHandle(
                          ( TransformSceneHandle ) m_Creators[typeof( TransformSceneHandle )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( PropertySceneHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_PropertySceneHandle(
                          ( PropertySceneHandle ) m_Creators[typeof( PropertySceneHandle )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( AnimatorControllerPlayable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_AnimatorControllerPlayable(
                          ( AnimatorControllerPlayable ) m_Creators[typeof( AnimatorControllerPlayable )].
                                                         Item1.First( x => x.ArgCount == a.Length ).
                                                         Create( a ) ) )
                },
                {
                    typeof( IConstraint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_IConstraint(
                          ( IConstraint ) m_Creators[typeof( IConstraint )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( PositionConstraint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_PositionConstraint(
                          ( PositionConstraint ) m_Creators[typeof( PositionConstraint )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( RotationConstraint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_RotationConstraint(
                          ( RotationConstraint ) m_Creators[typeof( RotationConstraint )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( ScaleConstraint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_ScaleConstraint(
                          ( ScaleConstraint ) m_Creators[typeof( ScaleConstraint )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( LookAtConstraint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_LookAtConstraint(
                          ( LookAtConstraint ) m_Creators[typeof( LookAtConstraint )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( ParentConstraint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Animations_ParentConstraint(
                          ( ParentConstraint ) m_Creators[typeof( ParentConstraint )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( AssetBundle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AssetBundle(
                          ( AssetBundle ) m_Creators[typeof( AssetBundle )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( AssetBundleRequest ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AssetBundleRequest(
                          ( AssetBundleRequest ) m_Creators[typeof( AssetBundleRequest )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( AssetBundleCreateRequest ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AssetBundleCreateRequest(
                          ( AssetBundleCreateRequest ) m_Creators[typeof( AssetBundleCreateRequest )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( AssetBundleRecompressOperation ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AssetBundleRecompressOperation(
                          ( AssetBundleRecompressOperation ) m_Creators[typeof( AssetBundleRecompressOperation )].
                                                             Item1.First( x => x.ArgCount == a.Length ).
                                                             Create( a ) ) )
                },
                {
                    typeof( BuildCompression ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_BuildCompression(
                          ( BuildCompression ) m_Creators[typeof( BuildCompression )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( AssetBundleManifest ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AssetBundleManifest(
                          ( AssetBundleManifest ) m_Creators[typeof( AssetBundleManifest )].
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
                    typeof( AudioSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AudioSettings(
                          ( AudioSettings ) m_Creators[typeof( AudioSettings )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( AudioConfiguration ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AudioConfiguration(
                          ( AudioConfiguration ) m_Creators[typeof( AudioConfiguration )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( AudioSource ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AudioSource(
                          ( AudioSource ) m_Creators[typeof( AudioSource )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( AudioClip ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AudioClip(
                          ( AudioClip ) m_Creators[typeof( AudioClip )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( AudioMixerGroup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Audio_AudioMixerGroup(
                          ( AudioMixerGroup ) m_Creators[typeof( AudioMixerGroup )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( AudioMixer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Audio_AudioMixer(
                          ( AudioMixer ) m_Creators[typeof( AudioMixer )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( AudioMixerSnapshot ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Audio_AudioMixerSnapshot(
                          ( AudioMixerSnapshot ) m_Creators[typeof( AudioMixerSnapshot )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( AnimationCurve ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AnimationCurve(
                          ( AnimationCurve ) m_Creators[typeof( AnimationCurve )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( Keyframe ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Keyframe(
                          ( Keyframe ) m_Creators[typeof( Keyframe )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( AudioLowPassFilter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AudioLowPassFilter(
                          ( AudioLowPassFilter ) m_Creators[typeof( AudioLowPassFilter )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( AudioHighPassFilter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AudioHighPassFilter(
                          ( AudioHighPassFilter ) m_Creators[typeof( AudioHighPassFilter )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( AudioReverbFilter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AudioReverbFilter(
                          ( AudioReverbFilter ) m_Creators[typeof( AudioReverbFilter )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( AudioBehaviour ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AudioBehaviour(
                          ( AudioBehaviour ) m_Creators[typeof( AudioBehaviour )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( AudioListener ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AudioListener(
                          ( AudioListener ) m_Creators[typeof( AudioListener )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( AudioReverbZone ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AudioReverbZone(
                          ( AudioReverbZone ) m_Creators[typeof( AudioReverbZone )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( AudioDistortionFilter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AudioDistortionFilter(
                          ( AudioDistortionFilter ) m_Creators[typeof( AudioDistortionFilter )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( AudioEchoFilter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AudioEchoFilter(
                          ( AudioEchoFilter ) m_Creators[typeof( AudioEchoFilter )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( AudioChorusFilter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AudioChorusFilter(
                          ( AudioChorusFilter ) m_Creators[typeof( AudioChorusFilter )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( Microphone ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Microphone(
                          ( Microphone ) m_Creators[typeof( Microphone )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( AudioRenderer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AudioRenderer(
                          ( AudioRenderer ) m_Creators[typeof( AudioRenderer )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( WebCamDevice ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WebCamDevice(
                          ( WebCamDevice ) m_Creators[typeof( WebCamDevice )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( WebCamTexture ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WebCamTexture(
                          ( WebCamTexture ) m_Creators[typeof( WebCamTexture )].
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
                    typeof( Color ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Color(
                          ( Color ) m_Creators[typeof( Color )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( AudioClipPlayable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Audio_AudioClipPlayable(
                          ( AudioClipPlayable ) m_Creators[typeof( AudioClipPlayable )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( AudioMixerPlayable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Audio_AudioMixerPlayable(
                          ( AudioMixerPlayable ) m_Creators[typeof( AudioMixerPlayable )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( AudioPlayableOutput ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Audio_AudioPlayableOutput(
                          ( AudioPlayableOutput ) m_Creators[typeof( AudioPlayableOutput )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( AudioSampleProvider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_Audio_AudioSampleProvider(
                          ( AudioSampleProvider ) m_Creators[typeof( AudioSampleProvider )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( ClothSphereColliderPair ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ClothSphereColliderPair(
                          ( ClothSphereColliderPair ) m_Creators[typeof( ClothSphereColliderPair )].
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
                    typeof( PhysicMaterial ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PhysicMaterial(
                          ( PhysicMaterial ) m_Creators[typeof( PhysicMaterial )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( ClothSkinningCoefficient ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ClothSkinningCoefficient(
                          ( ClothSkinningCoefficient ) m_Creators[typeof( ClothSkinningCoefficient )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( Cloth ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Cloth(
                          ( Cloth ) m_Creators[typeof( Cloth )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( ClusterInput ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ClusterInput(
                          ( ClusterInput ) m_Creators[typeof( ClusterInput )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( ClusterNetwork ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ClusterNetwork(
                          ( ClusterNetwork ) m_Creators[typeof( ClusterNetwork )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( MemorylessManager ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngineInternal_MemorylessManager(
                          ( MemorylessManager ) m_Creators[typeof( MemorylessManager )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( MathfInternal ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngineInternal_MathfInternal(
                          ( MathfInternal ) m_Creators[typeof( MathfInternal )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( APIUpdaterRuntimeServices ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngineInternal_APIUpdaterRuntimeServices(
                          ( APIUpdaterRuntimeServices ) m_Creators[typeof( APIUpdaterRuntimeServices )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( TypeInferenceRuleAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngineInternal_TypeInferenceRuleAttribute(
                          ( TypeInferenceRuleAttribute ) m_Creators[typeof( TypeInferenceRuleAttribute )].
                                                         Item1.First( x => x.ArgCount == a.Length ).
                                                         Create( a ) ) )
                },
                {
                    typeof( GenericStack ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngineInternal_GenericStack(
                          ( GenericStack ) m_Creators[typeof( GenericStack )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( SortingLayer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SortingLayer(
                          ( SortingLayer ) m_Creators[typeof( SortingLayer )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( Application ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Application(
                          ( Application ) m_Creators[typeof( Application )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( CachedAssetBundle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CachedAssetBundle(
                          ( CachedAssetBundle ) m_Creators[typeof( CachedAssetBundle )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( Cache ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Cache(
                          ( Cache ) m_Creators[typeof( Cache )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( CacheIndex ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CacheIndex(
                          ( CacheIndex ) m_Creators[typeof( CacheIndex )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Caching ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Caching(
                          ( Caching ) m_Creators[typeof( Caching )].
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
                    typeof( RenderTextureDescriptor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RenderTextureDescriptor(
                          ( RenderTextureDescriptor ) m_Creators[typeof( RenderTextureDescriptor )].
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
                    typeof( BoundingSphere ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_BoundingSphere(
                          ( BoundingSphere ) m_Creators[typeof( BoundingSphere )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( CullingGroupEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CullingGroupEvent(
                          ( CullingGroupEvent ) m_Creators[typeof( CullingGroupEvent )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( CullingGroup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CullingGroup(
                          ( CullingGroup ) m_Creators[typeof( CullingGroup )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( FlareLayer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_FlareLayer(
                          ( FlareLayer ) m_Creators[typeof( FlareLayer )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( ReflectionProbe ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ReflectionProbe(
                          ( ReflectionProbe ) m_Creators[typeof( ReflectionProbe )].
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
                    typeof( CrashReport ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CrashReport(
                          ( CrashReport ) m_Creators[typeof( CrashReport )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( Debug ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Debug(
                          ( Debug ) m_Creators[typeof( Debug )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( ILogger ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ILogger(
                          ( ILogger ) m_Creators[typeof( ILogger )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( ILogHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ILogHandler(
                          ( ILogHandler ) m_Creators[typeof( ILogHandler )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( ExposedPropertyResolver ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ExposedPropertyResolver(
                          ( ExposedPropertyResolver ) m_Creators[typeof( ExposedPropertyResolver )].
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
                    typeof( EventProvider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventProvider(
                          ( EventProvider ) m_Creators[typeof( EventProvider )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( BoundsInt ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_BoundsInt(
                          ( BoundsInt ) m_Creators[typeof( BoundsInt )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Vector3Int ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Vector3Int(
                          ( Vector3Int ) m_Creators[typeof( Vector3Int )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( GeometryUtility ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GeometryUtility(
                          ( GeometryUtility ) m_Creators[typeof( GeometryUtility )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( Ray2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Ray2D(
                          ( Ray2D ) m_Creators[typeof( Ray2D )].
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
                    typeof( RectOffset ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RectOffset(
                          ( RectOffset ) m_Creators[typeof( RectOffset )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( DynamicGI ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_DynamicGI(
                          ( DynamicGI ) m_Creators[typeof( DynamicGI )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( LightingSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LightingSettings(
                          ( LightingSettings ) m_Creators[typeof( LightingSettings )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( Gizmos ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Gizmos(
                          ( Gizmos ) m_Creators[typeof( Gizmos )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( BeforeRenderOrderAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_BeforeRenderOrderAttribute(
                          ( BeforeRenderOrderAttribute ) m_Creators[typeof( BeforeRenderOrderAttribute )].
                                                         Item1.First( x => x.ArgCount == a.Length ).
                                                         Create( a ) ) )
                },
                {
                    typeof( BillboardAsset ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_BillboardAsset(
                          ( BillboardAsset ) m_Creators[typeof( BillboardAsset )].
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
                    typeof( BillboardRenderer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_BillboardRenderer(
                          ( BillboardRenderer ) m_Creators[typeof( BillboardRenderer )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( Display ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Display(
                          ( Display ) m_Creators[typeof( Display )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( SleepTimeout ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SleepTimeout(
                          ( SleepTimeout ) m_Creators[typeof( SleepTimeout )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( Screen ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Screen(
                          ( Screen ) m_Creators[typeof( Screen )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( Resolution ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Resolution(
                          ( Resolution ) m_Creators[typeof( Resolution )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Graphics ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Graphics(
                          ( Graphics ) m_Creators[typeof( Graphics )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( GraphicsFence ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_GraphicsFence(
                          ( GraphicsFence ) m_Creators[typeof( GraphicsFence )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( GL ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GL(
                          ( GL ) m_Creators[typeof( GL )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( FrameTiming ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_FrameTiming(
                          ( FrameTiming ) m_Creators[typeof( FrameTiming )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( LightmapData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LightmapData(
                          ( LightmapData ) m_Creators[typeof( LightmapData )].
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
                    typeof( LightmapSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LightmapSettings(
                          ( LightmapSettings ) m_Creators[typeof( LightmapSettings )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( LightProbes ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LightProbes(
                          ( LightProbes ) m_Creators[typeof( LightProbes )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( HDROutputSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_HDROutputSettings(
                          ( HDROutputSettings ) m_Creators[typeof( HDROutputSettings )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( RenderTargetSetup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RenderTargetSetup(
                          ( RenderTargetSetup ) m_Creators[typeof( RenderTargetSetup )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( QualitySettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_QualitySettings(
                          ( QualitySettings ) m_Creators[typeof( QualitySettings )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( RenderPipelineAsset ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_RenderPipelineAsset(
                          ( RenderPipelineAsset ) m_Creators[typeof( RenderPipelineAsset )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( ImageEffectTransformsToLDR ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ImageEffectTransformsToLDR(
                          ( ImageEffectTransformsToLDR ) m_Creators[typeof( ImageEffectTransformsToLDR )].
                                                         Item1.First( x => x.ArgCount == a.Length ).
                                                         Create( a ) ) )
                },
                {
                    typeof( ImageEffectAllowedInSceneView ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ImageEffectAllowedInSceneView(
                          ( ImageEffectAllowedInSceneView ) m_Creators[typeof( ImageEffectAllowedInSceneView )].
                                                            Item1.First( x => x.ArgCount == a.Length ).
                                                            Create( a ) ) )
                },
                {
                    typeof( ImageEffectOpaque ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ImageEffectOpaque(
                          ( ImageEffectOpaque ) m_Creators[typeof( ImageEffectOpaque )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( ImageEffectAfterScale ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ImageEffectAfterScale(
                          ( ImageEffectAfterScale ) m_Creators[typeof( ImageEffectAfterScale )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( ImageEffectUsesCommandBuffer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ImageEffectUsesCommandBuffer(
                          ( ImageEffectUsesCommandBuffer ) m_Creators[typeof( ImageEffectUsesCommandBuffer )].
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
                    typeof( Renderer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Renderer(
                          ( Renderer ) m_Creators[typeof( Renderer )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( Projector ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Projector(
                          ( Projector ) m_Creators[typeof( Projector )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( TrailRenderer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TrailRenderer(
                          ( TrailRenderer ) m_Creators[typeof( TrailRenderer )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( Gradient ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Gradient(
                          ( Gradient ) m_Creators[typeof( Gradient )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( LineRenderer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LineRenderer(
                          ( LineRenderer ) m_Creators[typeof( LineRenderer )].
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
                    typeof( RenderSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RenderSettings(
                          ( RenderSettings ) m_Creators[typeof( RenderSettings )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( Light ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Light(
                          ( Light ) m_Creators[typeof( Light )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( Flare ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Flare(
                          ( Flare ) m_Creators[typeof( Flare )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( LightBakingOutput ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LightBakingOutput(
                          ( LightBakingOutput ) m_Creators[typeof( LightBakingOutput )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( SphericalHarmonicsL2 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_SphericalHarmonicsL2(
                          ( SphericalHarmonicsL2 ) m_Creators[typeof( SphericalHarmonicsL2 )].
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
                    typeof( OcclusionPortal ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_OcclusionPortal(
                          ( OcclusionPortal ) m_Creators[typeof( OcclusionPortal )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( OcclusionArea ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_OcclusionArea(
                          ( OcclusionArea ) m_Creators[typeof( OcclusionArea )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( LensFlare ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LensFlare(
                          ( LensFlare ) m_Creators[typeof( LensFlare )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Skybox ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Skybox(
                          ( Skybox ) m_Creators[typeof( Skybox )].
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
                    typeof( LightProbeProxyVolume ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LightProbeProxyVolume(
                          ( LightProbeProxyVolume ) m_Creators[typeof( LightProbeProxyVolume )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( SkinnedMeshRenderer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SkinnedMeshRenderer(
                          ( SkinnedMeshRenderer ) m_Creators[typeof( SkinnedMeshRenderer )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( MeshRenderer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_MeshRenderer(
                          ( MeshRenderer ) m_Creators[typeof( MeshRenderer )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( LightProbeGroup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LightProbeGroup(
                          ( LightProbeGroup ) m_Creators[typeof( LightProbeGroup )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( LineUtility ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LineUtility(
                          ( LineUtility ) m_Creators[typeof( LineUtility )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( LOD ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LOD(
                          ( LOD ) m_Creators[typeof( LOD )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( LODGroup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LODGroup(
                          ( LODGroup ) m_Creators[typeof( LODGroup )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( BoneWeight ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_BoneWeight(
                          ( BoneWeight ) m_Creators[typeof( BoneWeight )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( BoneWeight1 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_BoneWeight1(
                          ( BoneWeight1 ) m_Creators[typeof( BoneWeight1 )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( CombineInstance ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CombineInstance(
                          ( CombineInstance ) m_Creators[typeof( CombineInstance )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( Texture3D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Texture3D(
                          ( Texture3D ) m_Creators[typeof( Texture3D )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Texture2DArray ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Texture2DArray(
                          ( Texture2DArray ) m_Creators[typeof( Texture2DArray )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( CubemapArray ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CubemapArray(
                          ( CubemapArray ) m_Creators[typeof( CubemapArray )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( SparseTexture ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SparseTexture(
                          ( SparseTexture ) m_Creators[typeof( SparseTexture )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( CustomRenderTextureUpdateZone ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CustomRenderTextureUpdateZone(
                          ( CustomRenderTextureUpdateZone ) m_Creators[typeof( CustomRenderTextureUpdateZone )].
                                                            Item1.First( x => x.ArgCount == a.Length ).
                                                            Create( a ) ) )
                },
                {
                    typeof( CustomRenderTexture ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CustomRenderTexture(
                          ( CustomRenderTexture ) m_Creators[typeof( CustomRenderTexture )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( Handheld ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Handheld(
                          ( Handheld ) m_Creators[typeof( Handheld )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( Cursor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Cursor(
                          ( Cursor ) m_Creators[typeof( Cursor )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( iPhoneSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_iPhoneSettings(
                          ( iPhoneSettings ) m_Creators[typeof( iPhoneSettings )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( iPhoneUtils ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_iPhoneUtils(
                          ( iPhoneUtils ) m_Creators[typeof( iPhoneUtils )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( Logger ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Logger(
                          ( Logger ) m_Creators[typeof( Logger )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( Color32 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Color32(
                          ( Color32 ) m_Creators[typeof( Color32 )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( ColorUtility ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ColorUtility(
                          ( ColorUtility ) m_Creators[typeof( ColorUtility )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( GradientColorKey ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GradientColorKey(
                          ( GradientColorKey ) m_Creators[typeof( GradientColorKey )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( GradientAlphaKey ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GradientAlphaKey(
                          ( GradientAlphaKey ) m_Creators[typeof( GradientAlphaKey )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( Mathf ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Mathf(
                          ( Mathf ) m_Creators[typeof( Mathf )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( Ping ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Ping(
                          ( Ping ) m_Creators[typeof( Ping )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( PlayerPrefsException ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PlayerPrefsException(
                          ( PlayerPrefsException ) m_Creators[typeof( PlayerPrefsException )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( PlayerPrefs ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PlayerPrefs(
                          ( PlayerPrefs ) m_Creators[typeof( PlayerPrefs )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( PropertyAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PropertyAttribute(
                          ( PropertyAttribute ) m_Creators[typeof( PropertyAttribute )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( ContextMenuItemAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ContextMenuItemAttribute(
                          ( ContextMenuItemAttribute ) m_Creators[typeof( ContextMenuItemAttribute )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( InspectorNameAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_InspectorNameAttribute(
                          ( InspectorNameAttribute ) m_Creators[typeof( InspectorNameAttribute )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( TooltipAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TooltipAttribute(
                          ( TooltipAttribute ) m_Creators[typeof( TooltipAttribute )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( SpaceAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SpaceAttribute(
                          ( SpaceAttribute ) m_Creators[typeof( SpaceAttribute )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( HeaderAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_HeaderAttribute(
                          ( HeaderAttribute ) m_Creators[typeof( HeaderAttribute )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( RangeAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RangeAttribute(
                          ( RangeAttribute ) m_Creators[typeof( RangeAttribute )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( MinAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_MinAttribute(
                          ( MinAttribute ) m_Creators[typeof( MinAttribute )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( MultilineAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_MultilineAttribute(
                          ( MultilineAttribute ) m_Creators[typeof( MultilineAttribute )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( TextAreaAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TextAreaAttribute(
                          ( TextAreaAttribute ) m_Creators[typeof( TextAreaAttribute )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( ColorUsageAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ColorUsageAttribute(
                          ( ColorUsageAttribute ) m_Creators[typeof( ColorUsageAttribute )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( GradientUsageAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GradientUsageAttribute(
                          ( GradientUsageAttribute ) m_Creators[typeof( GradientUsageAttribute )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( DelayedAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_DelayedAttribute(
                          ( DelayedAttribute ) m_Creators[typeof( DelayedAttribute )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( NonReorderableAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_NonReorderableAttribute(
                          ( NonReorderableAttribute ) m_Creators[typeof( NonReorderableAttribute )].
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
                    typeof( ResourceRequest ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ResourceRequest(
                          ( ResourceRequest ) m_Creators[typeof( ResourceRequest )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( ResourcesAPI ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ResourcesAPI(
                          ( ResourcesAPI ) m_Creators[typeof( ResourcesAPI )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( Resources ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Resources(
                          ( Resources ) m_Creators[typeof( Resources )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( DisallowMultipleComponent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_DisallowMultipleComponent(
                          ( DisallowMultipleComponent ) m_Creators[typeof( DisallowMultipleComponent )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( RequireComponent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RequireComponent(
                          ( RequireComponent ) m_Creators[typeof( RequireComponent )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( AddComponentMenu ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AddComponentMenu(
                          ( AddComponentMenu ) m_Creators[typeof( AddComponentMenu )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( CreateAssetMenuAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CreateAssetMenuAttribute(
                          ( CreateAssetMenuAttribute ) m_Creators[typeof( CreateAssetMenuAttribute )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( ContextMenu ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ContextMenu(
                          ( ContextMenu ) m_Creators[typeof( ContextMenu )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( ExecuteInEditMode ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ExecuteInEditMode(
                          ( ExecuteInEditMode ) m_Creators[typeof( ExecuteInEditMode )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( ExecuteAlways ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ExecuteAlways(
                          ( ExecuteAlways ) m_Creators[typeof( ExecuteAlways )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( HideInInspector ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_HideInInspector(
                          ( HideInInspector ) m_Creators[typeof( HideInInspector )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( HelpURLAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_HelpURLAttribute(
                          ( HelpURLAttribute ) m_Creators[typeof( HelpURLAttribute )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( DefaultExecutionOrder ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_DefaultExecutionOrder(
                          ( DefaultExecutionOrder ) m_Creators[typeof( DefaultExecutionOrder )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( AssemblyIsEditorAssembly ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AssemblyIsEditorAssembly(
                          ( AssemblyIsEditorAssembly ) m_Creators[typeof( AssemblyIsEditorAssembly )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( ExcludeFromPresetAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ExcludeFromPresetAttribute(
                          ( ExcludeFromPresetAttribute ) m_Creators[typeof( ExcludeFromPresetAttribute )].
                                                         Item1.First( x => x.ArgCount == a.Length ).
                                                         Create( a ) ) )
                },
                {
                    typeof( Behaviour ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Behaviour(
                          ( Behaviour ) m_Creators[typeof( Behaviour )].
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
                    typeof( CustomYieldInstruction ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CustomYieldInstruction(
                          ( CustomYieldInstruction ) m_Creators[typeof( CustomYieldInstruction )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( ExcludeFromObjectFactoryAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ExcludeFromObjectFactoryAttribute(
                          ( ExcludeFromObjectFactoryAttribute ) m_Creators[typeof( ExcludeFromObjectFactoryAttribute )].
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
                    typeof( MonoBehaviour ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_MonoBehaviour(
                          ( MonoBehaviour ) m_Creators[typeof( MonoBehaviour )].
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
                    typeof( RangeInt ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RangeInt(
                          ( RangeInt ) m_Creators[typeof( RangeInt )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( RuntimeInitializeOnLoadMethodAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RuntimeInitializeOnLoadMethodAttribute(
                          ( RuntimeInitializeOnLoadMethodAttribute ) m_Creators[
                                                                         typeof( RuntimeInitializeOnLoadMethodAttribute
                                                                         )].
                                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                                     Create( a ) ) )
                },
                {
                    typeof( ScriptableObject ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ScriptableObject(
                          ( ScriptableObject ) m_Creators[typeof( ScriptableObject )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( SelectionBaseAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SelectionBaseAttribute(
                          ( SelectionBaseAttribute ) m_Creators[typeof( SelectionBaseAttribute )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( UnityException ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UnityException(
                          ( UnityException ) m_Creators[typeof( UnityException )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( MissingComponentException ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_MissingComponentException(
                          ( MissingComponentException ) m_Creators[typeof( MissingComponentException )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( UnassignedReferenceException ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UnassignedReferenceException(
                          ( UnassignedReferenceException ) m_Creators[typeof( UnassignedReferenceException )].
                                                           Item1.First( x => x.ArgCount == a.Length ).
                                                           Create( a ) ) )
                },
                {
                    typeof( MissingReferenceException ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_MissingReferenceException(
                          ( MissingReferenceException ) m_Creators[typeof( MissingReferenceException )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( TextAsset ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TextAsset(
                          ( TextAsset ) m_Creators[typeof( TextAsset )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( TrackedReference ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TrackedReference(
                          ( TrackedReference ) m_Creators[typeof( TrackedReference )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( UnityAPICompatibilityVersionAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UnityAPICompatibilityVersionAttribute(
                          ( UnityAPICompatibilityVersionAttribute ) m_Creators[
                                                                        typeof( UnityAPICompatibilityVersionAttribute
                                                                        )].
                                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                                    Create( a ) ) )
                },
                {
                    typeof( WaitForEndOfFrame ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WaitForEndOfFrame(
                          ( WaitForEndOfFrame ) m_Creators[typeof( WaitForEndOfFrame )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( WaitForFixedUpdate ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WaitForFixedUpdate(
                          ( WaitForFixedUpdate ) m_Creators[typeof( WaitForFixedUpdate )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( WaitForSeconds ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WaitForSeconds(
                          ( WaitForSeconds ) m_Creators[typeof( WaitForSeconds )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( WaitForSecondsRealtime ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WaitForSecondsRealtime(
                          ( WaitForSecondsRealtime ) m_Creators[typeof( WaitForSecondsRealtime )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( WaitUntil ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WaitUntil(
                          ( WaitUntil ) m_Creators[typeof( WaitUntil )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( WaitWhile ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WaitWhile(
                          ( WaitWhile ) m_Creators[typeof( WaitWhile )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( YieldInstruction ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_YieldInstruction(
                          ( YieldInstruction ) m_Creators[typeof( YieldInstruction )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( Security ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Security(
                          ( Security ) m_Creators[typeof( Security )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( SerializeField ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SerializeField(
                          ( SerializeField ) m_Creators[typeof( SerializeField )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( SerializeReference ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SerializeReference(
                          ( SerializeReference ) m_Creators[typeof( SerializeReference )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( PreferBinarySerialization ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PreferBinarySerialization(
                          ( PreferBinarySerialization ) m_Creators[typeof( PreferBinarySerialization )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( ISerializationCallbackReceiver ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ISerializationCallbackReceiver(
                          ( ISerializationCallbackReceiver ) m_Creators[typeof( ISerializationCallbackReceiver )].
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
                    typeof( ShaderVariantCollection ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ShaderVariantCollection(
                          ( ShaderVariantCollection ) m_Creators[typeof( ShaderVariantCollection )].
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
                    typeof( StaticBatchingUtility ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_StaticBatchingUtility(
                          ( StaticBatchingUtility ) m_Creators[typeof( StaticBatchingUtility )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( SystemInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SystemInfo(
                          ( SystemInfo ) m_Creators[typeof( SystemInfo )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Time ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Time(
                          ( Time ) m_Creators[typeof( Time )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
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
                    typeof( UnityEventQueueSystem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UnityEventQueueSystem(
                          ( UnityEventQueueSystem ) m_Creators[typeof( UnityEventQueueSystem )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( Pose ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Pose(
                          ( Pose ) m_Creators[typeof( Pose )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( DrivenRectTransformTracker ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_DrivenRectTransformTracker(
                          ( DrivenRectTransformTracker ) m_Creators[typeof( DrivenRectTransformTracker )].
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
                    typeof( SpriteRenderer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SpriteRenderer(
                          ( SpriteRenderer ) m_Creators[typeof( SpriteRenderer )].
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
                    typeof( SecondarySpriteTexture ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SecondarySpriteTexture(
                          ( SecondarySpriteTexture ) m_Creators[typeof( SecondarySpriteTexture )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( DataUtility ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Sprites_DataUtility(
                          ( DataUtility ) m_Creators[typeof( DataUtility )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( SpriteBone ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_U2D_SpriteBone(
                          ( SpriteBone ) m_Creators[typeof( SpriteBone )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( SpriteAtlasManager ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_U2D_SpriteAtlasManager(
                          ( SpriteAtlasManager ) m_Creators[typeof( SpriteAtlasManager )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( SpriteAtlas ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_U2D_SpriteAtlas(
                          ( SpriteAtlas ) m_Creators[typeof( SpriteAtlas )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( Profiler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Profiling_Profiler(
                          ( Profiler ) m_Creators[typeof( Profiler )].
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
                    typeof( Sampler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Profiling_Sampler(
                          ( Sampler ) m_Creators[typeof( Sampler )].
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
                    typeof( DebugScreenCapture ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Profiling_Experimental_DebugScreenCapture(
                          ( DebugScreenCapture ) m_Creators[typeof( DebugScreenCapture )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( MetaData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Profiling_Memory_Experimental_MetaData(
                          ( MetaData ) m_Creators[typeof( MetaData )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( MemoryProfiler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Profiling_Memory_Experimental_MemoryProfiler(
                          ( MemoryProfiler ) m_Creators[typeof( MemoryProfiler )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( IJobParallelForTransform ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Jobs_IJobParallelForTransform(
                          ( IJobParallelForTransform ) m_Creators[typeof( IJobParallelForTransform )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( TransformAccess ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Jobs_TransformAccess(
                          ( TransformAccess ) m_Creators[typeof( TransformAccess )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( TransformAccessArray ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Jobs_TransformAccessArray(
                          ( TransformAccessArray ) m_Creators[typeof( TransformAccessArray )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( AppCallbackItem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WSA_AppCallbackItem(
                          ( AppCallbackItem ) m_Creators[typeof( AppCallbackItem )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( WindowSizeChanged ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WSA_WindowSizeChanged(
                          ( WindowSizeChanged ) m_Creators[typeof( WindowSizeChanged )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( WindowActivated ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WSA_WindowActivated(
                          ( WindowActivated ) m_Creators[typeof( WindowActivated )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( UnityEngine.WSA.Application ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WSA_Application(
                          ( UnityEngine.WSA.Application ) m_Creators[typeof( UnityEngine.WSA.Application )].
                                                          Item1.First( x => x.ArgCount == a.Length ).
                                                          Create( a ) ) )
                },
                {
                    typeof( Launcher ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WSA_Launcher(
                          ( Launcher ) m_Creators[typeof( Launcher )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( SecondaryTileData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WSA_SecondaryTileData(
                          ( SecondaryTileData ) m_Creators[typeof( SecondaryTileData )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( Tile ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WSA_Tile(
                          ( Tile ) m_Creators[typeof( Tile )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( Toast ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WSA_Toast(
                          ( Toast ) m_Creators[typeof( Toast )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
#if BS_UNITY_WIN
                {
                    typeof( PhraseRecognizer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Windows_Speech_PhraseRecognizer(
                          ( PhraseRecognizer ) m_Creators[typeof( PhraseRecognizer )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( DictationRecognizer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Windows_Speech_DictationRecognizer(
                          ( DictationRecognizer ) m_Creators[typeof( DictationRecognizer )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( SemanticMeaning ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Windows_Speech_SemanticMeaning(
                          ( SemanticMeaning ) m_Creators[typeof( SemanticMeaning )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( PhraseRecognizedEventArgs ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Windows_Speech_PhraseRecognizedEventArgs(
                          ( PhraseRecognizedEventArgs ) m_Creators[typeof( PhraseRecognizedEventArgs )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( KeywordRecognizer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Windows_Speech_KeywordRecognizer(
                          ( KeywordRecognizer ) m_Creators[typeof( KeywordRecognizer )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( GrammarRecognizer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Windows_Speech_GrammarRecognizer(
                          ( GrammarRecognizer ) m_Creators[typeof( GrammarRecognizer )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( PhotoCapture ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Windows_WebCam_PhotoCapture(
                          ( PhotoCapture ) m_Creators[typeof( PhotoCapture )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( PhotoCaptureFrame ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Windows_WebCam_PhotoCaptureFrame(
                          ( PhotoCaptureFrame ) m_Creators[typeof( PhotoCaptureFrame )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( VideoCapture ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Windows_WebCam_VideoCapture(
                          ( VideoCapture ) m_Creators[typeof( VideoCapture )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( WebCam ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Windows_WebCam_WebCam(
                          ( WebCam ) m_Creators[typeof( WebCam )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( CameraParameters ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Windows_WebCam_CameraParameters(
                          ( CameraParameters ) m_Creators[typeof( CameraParameters )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
#endif
                {
                    typeof( UnityEventBase ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Events_UnityEventBase(
                          ( UnityEventBase ) m_Creators[typeof( UnityEventBase )].
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
                    typeof( UnityEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Events_UnityEvent(
                          ( UnityEvent ) m_Creators[typeof( UnityEvent )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( FormerlySerializedAsAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Serialization_FormerlySerializedAsAttribute(
                          ( FormerlySerializedAsAttribute ) m_Creators[typeof( FormerlySerializedAsAttribute )].
                                                            Item1.First( x => x.ArgCount == a.Length ).
                                                            Create( a ) ) )
                },
                {
                    typeof( UnitySurrogateSelector ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Serialization_UnitySurrogateSelector(
                          ( UnitySurrogateSelector ) m_Creators[typeof( UnitySurrogateSelector )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( ObjectSelectorHandlerWithLabelsAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SearchService_ObjectSelectorHandlerWithLabelsAttribute(
                          ( ObjectSelectorHandlerWithLabelsAttribute ) m_Creators[
                                                                           typeof(
                                                                               ObjectSelectorHandlerWithLabelsAttribute
                                                                           )].
                                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                                       Create( a ) ) )
                },
                {
                    typeof( ObjectSelectorHandlerWithTagsAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SearchService_ObjectSelectorHandlerWithTagsAttribute(
                          ( ObjectSelectorHandlerWithTagsAttribute ) m_Creators[
                                                                         typeof( ObjectSelectorHandlerWithTagsAttribute
                                                                         )].
                                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                                     Create( a ) ) )
                },
                {
                    typeof( AlwaysLinkAssemblyAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Scripting_AlwaysLinkAssemblyAttribute(
                          ( AlwaysLinkAssemblyAttribute ) m_Creators[typeof( AlwaysLinkAssemblyAttribute )].
                                                          Item1.First( x => x.ArgCount == a.Length ).
                                                          Create( a ) ) )
                },
                {
                    typeof( PreserveAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Scripting_PreserveAttribute(
                          ( PreserveAttribute ) m_Creators[typeof( PreserveAttribute )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( RequireAttributeUsagesAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Scripting_RequireAttributeUsagesAttribute(
                          ( RequireAttributeUsagesAttribute ) m_Creators[typeof( RequireAttributeUsagesAttribute )].
                                                              Item1.First( x => x.ArgCount == a.Length ).
                                                              Create( a ) ) )
                },
                {
                    typeof( RequireDerivedAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Scripting_RequireDerivedAttribute(
                          ( RequireDerivedAttribute ) m_Creators[typeof( RequireDerivedAttribute )].
                                                      Item1.First( x => x.ArgCount == a.Length ).
                                                      Create( a ) ) )
                },
                {
                    typeof( RequiredInterfaceAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Scripting_RequiredInterfaceAttribute(
                          ( RequiredInterfaceAttribute ) m_Creators[typeof( RequiredInterfaceAttribute )].
                                                         Item1.First( x => x.ArgCount == a.Length ).
                                                         Create( a ) ) )
                },
                {
                    typeof( RequiredMemberAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Scripting_RequiredMemberAttribute(
                          ( RequiredMemberAttribute ) m_Creators[typeof( RequiredMemberAttribute )].
                                                      Item1.First( x => x.ArgCount == a.Length ).
                                                      Create( a ) ) )
                },
                {
                    typeof( RequireImplementorsAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Scripting_RequireImplementorsAttribute(
                          ( RequireImplementorsAttribute ) m_Creators[typeof( RequireImplementorsAttribute )].
                                                           Item1.First( x => x.ArgCount == a.Length ).
                                                           Create( a ) ) )
                },
                {
                    typeof( MovedFromAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Scripting_APIUpdating_MovedFromAttribute(
                          ( MovedFromAttribute ) m_Creators[typeof( MovedFromAttribute )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( SceneManagerAPI ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SceneManagement_SceneManagerAPI(
                          ( SceneManagerAPI ) m_Creators[typeof( SceneManagerAPI )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( SceneManager ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SceneManagement_SceneManager(
                          ( SceneManager ) m_Creators[typeof( SceneManager )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( CreateSceneParameters ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SceneManagement_CreateSceneParameters(
                          ( CreateSceneParameters ) m_Creators[typeof( CreateSceneParameters )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( LoadSceneParameters ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SceneManagement_LoadSceneParameters(
                          ( LoadSceneParameters ) m_Creators[typeof( LoadSceneParameters )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( PlayerLoopSystem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LowLevel_PlayerLoopSystem(
                          ( PlayerLoopSystem ) m_Creators[typeof( PlayerLoopSystem )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( PlayerLoop ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LowLevel_PlayerLoop(
                          ( PlayerLoop ) m_Creators[typeof( PlayerLoop )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( TimeUpdate ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PlayerLoop_TimeUpdate(
                          ( TimeUpdate ) m_Creators[typeof( TimeUpdate )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Initialization ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PlayerLoop_Initialization(
                          ( Initialization ) m_Creators[typeof( Initialization )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( EarlyUpdate ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PlayerLoop_EarlyUpdate(
                          ( EarlyUpdate ) m_Creators[typeof( EarlyUpdate )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( FixedUpdate ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PlayerLoop_FixedUpdate(
                          ( FixedUpdate ) m_Creators[typeof( FixedUpdate )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( PreUpdate ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PlayerLoop_PreUpdate(
                          ( PreUpdate ) m_Creators[typeof( PreUpdate )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Update ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PlayerLoop_Update(
                          ( Update ) m_Creators[typeof( Update )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( PreLateUpdate ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PlayerLoop_PreLateUpdate(
                          ( PreLateUpdate ) m_Creators[typeof( PreLateUpdate )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( PostLateUpdate ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PlayerLoop_PostLateUpdate(
                          ( PostLateUpdate ) m_Creators[typeof( PostLateUpdate )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( IConnectionState ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_PlayerConnection_IConnectionState(
                          ( IConnectionState ) m_Creators[typeof( IConnectionState )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( MessageEventArgs ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_PlayerConnection_MessageEventArgs(
                          ( MessageEventArgs ) m_Creators[typeof( MessageEventArgs )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( IEditorPlayerConnection ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_PlayerConnection_IEditorPlayerConnection(
                          ( IEditorPlayerConnection ) m_Creators[typeof( IEditorPlayerConnection )].
                                                      Item1.First( x => x.ArgCount == a.Length ).
                                                      Create( a ) ) )
                },
                {
                    typeof( PlayerConnection ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_PlayerConnection_PlayerConnection(
                          ( PlayerConnection ) m_Creators[typeof( PlayerConnection )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( UsesLuminPlatformLevelAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Lumin_UsesLuminPlatformLevelAttribute(
                          ( UsesLuminPlatformLevelAttribute ) m_Creators[typeof( UsesLuminPlatformLevelAttribute )].
                                                              Item1.First( x => x.ArgCount == a.Length ).
                                                              Create( a ) ) )
                },
                {
                    typeof( UsesLuminPrivilegeAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Lumin_UsesLuminPrivilegeAttribute(
                          ( UsesLuminPrivilegeAttribute ) m_Creators[typeof( UsesLuminPrivilegeAttribute )].
                                                          Item1.First( x => x.ArgCount == a.Length ).
                                                          Create( a ) ) )
                },
#if BS_UNITY_TVOS
                {
                    typeof( Remote ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_tvOS_Remote(
                          ( Remote ) m_Creators[typeof( Remote )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( Device ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_tvOS_Device(
                          ( Device ) m_Creators[typeof( Device )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
#endif
#if BS_UNITY_IOS
                {
                    typeof( UnityEngine.iOS.Device ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_iOS_Device(
                          ( UnityEngine.iOS.Device ) m_Creators[typeof( UnityEngine.iOS.Device )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( LocalNotification ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_iOS_LocalNotification(
                          ( LocalNotification ) m_Creators[typeof( LocalNotification )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( RemoteNotification ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_iOS_RemoteNotification(
                          ( RemoteNotification ) m_Creators[typeof( RemoteNotification )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( NotificationServices ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_iOS_NotificationServices(
                          ( NotificationServices ) m_Creators[typeof( NotificationServices )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( OnDemandResourcesRequest ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_iOS_OnDemandResourcesRequest(
                          ( OnDemandResourcesRequest ) m_Creators[typeof( OnDemandResourcesRequest )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
#endif
                {
                    typeof( DefaultValueAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Internal_DefaultValueAttribute(
                          ( DefaultValueAttribute ) m_Creators[typeof( DefaultValueAttribute )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( ExcludeFromDocsAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Internal_ExcludeFromDocsAttribute(
                          ( ExcludeFromDocsAttribute ) m_Creators[typeof( ExcludeFromDocsAttribute )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( AsyncGPUReadbackRequest ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_AsyncGPUReadbackRequest(
                          ( AsyncGPUReadbackRequest ) m_Creators[typeof( AsyncGPUReadbackRequest )].
                                                      Item1.First( x => x.ArgCount == a.Length ).
                                                      Create( a ) ) )
                },
                {
                    typeof( PIX ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_PIX(
                          ( PIX ) m_Creators[typeof( PIX )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
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
                    typeof( RenderTargetBinding ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_RenderTargetBinding(
                          ( RenderTargetBinding ) m_Creators[typeof( RenderTargetBinding )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( ReflectionProbeBlendInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_ReflectionProbeBlendInfo(
                          ( ReflectionProbeBlendInfo ) m_Creators[typeof( ReflectionProbeBlendInfo )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( GraphicsSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_GraphicsSettings(
                          ( GraphicsSettings ) m_Creators[typeof( GraphicsSettings )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( OnDemandRendering ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_OnDemandRendering(
                          ( OnDemandRendering ) m_Creators[typeof( OnDemandRendering )].
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
                    typeof( SplashScreen ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_SplashScreen(
                          ( SplashScreen ) m_Creators[typeof( SplashScreen )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( BatchVisibility ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_BatchVisibility(
                          ( BatchVisibility ) m_Creators[typeof( BatchVisibility )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( BatchCullingContext ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_BatchCullingContext(
                          ( BatchCullingContext ) m_Creators[typeof( BatchCullingContext )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( LODParameters ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_LODParameters(
                          ( LODParameters ) m_Creators[typeof( LODParameters )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( BatchRendererGroup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_BatchRendererGroup(
                          ( BatchRendererGroup ) m_Creators[typeof( BatchRendererGroup )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( AttachmentDescriptor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_AttachmentDescriptor(
                          ( AttachmentDescriptor ) m_Creators[typeof( AttachmentDescriptor )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( BlendState ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_BlendState(
                          ( BlendState ) m_Creators[typeof( BlendState )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( RenderTargetBlendState ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_RenderTargetBlendState(
                          ( RenderTargetBlendState ) m_Creators[typeof( RenderTargetBlendState )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( CameraProperties ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_CameraProperties(
                          ( CameraProperties ) m_Creators[typeof( CameraProperties )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( ScriptableCullingParameters ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_ScriptableCullingParameters(
                          ( ScriptableCullingParameters ) m_Creators[typeof( ScriptableCullingParameters )].
                                                          Item1.First( x => x.ArgCount == a.Length ).
                                                          Create( a ) ) )
                },
                {
                    typeof( CullingResults ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_CullingResults(
                          ( CullingResults ) m_Creators[typeof( CullingResults )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( DepthState ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_DepthState(
                          ( DepthState ) m_Creators[typeof( DepthState )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( DrawingSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_DrawingSettings(
                          ( DrawingSettings ) m_Creators[typeof( DrawingSettings )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( SortingSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_SortingSettings(
                          ( SortingSettings ) m_Creators[typeof( SortingSettings )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( FilteringSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_FilteringSettings(
                          ( FilteringSettings ) m_Creators[typeof( FilteringSettings )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( RenderQueueRange ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_RenderQueueRange(
                          ( RenderQueueRange ) m_Creators[typeof( RenderQueueRange )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( SortingLayerRange ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_SortingLayerRange(
                          ( SortingLayerRange ) m_Creators[typeof( SortingLayerRange )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( RasterState ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_RasterState(
                          ( RasterState ) m_Creators[typeof( RasterState )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( RenderPipeline ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_RenderPipeline(
                          ( RenderPipeline ) m_Creators[typeof( RenderPipeline )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( RenderStateBlock ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_RenderStateBlock(
                          ( RenderStateBlock ) m_Creators[typeof( RenderStateBlock )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( StencilState ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_StencilState(
                          ( StencilState ) m_Creators[typeof( StencilState )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( ScopedRenderPass ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_ScopedRenderPass(
                          ( ScopedRenderPass ) m_Creators[typeof( ScopedRenderPass )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( ScopedSubPass ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_ScopedSubPass(
                          ( ScopedSubPass ) m_Creators[typeof( ScopedSubPass )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( ScriptableRenderContext ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_ScriptableRenderContext(
                          ( ScriptableRenderContext ) m_Creators[typeof( ScriptableRenderContext )].
                                                      Item1.First( x => x.ArgCount == a.Length ).
                                                      Create( a ) ) )
                },
                {
                    typeof( ShadowDrawingSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_ShadowDrawingSettings(
                          ( ShadowDrawingSettings ) m_Creators[typeof( ShadowDrawingSettings )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( ShadowSplitData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_ShadowSplitData(
                          ( ShadowSplitData ) m_Creators[typeof( ShadowSplitData )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( SupportedRenderingFeatures ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_SupportedRenderingFeatures(
                          ( SupportedRenderingFeatures ) m_Creators[typeof( SupportedRenderingFeatures )].
                                                         Item1.First( x => x.ArgCount == a.Length ).
                                                         Create( a ) ) )
                },
                {
                    typeof( VisibleLight ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_VisibleLight(
                          ( VisibleLight ) m_Creators[typeof( VisibleLight )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( VisibleReflectionProbe ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_VisibleReflectionProbe(
                          ( VisibleReflectionProbe ) m_Creators[typeof( VisibleReflectionProbe )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( PlatformKeywordSet ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_PlatformKeywordSet(
                          ( PlatformKeywordSet ) m_Creators[typeof( PlatformKeywordSet )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( ShaderKeyword ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_ShaderKeyword(
                          ( ShaderKeyword ) m_Creators[typeof( ShaderKeyword )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( ShaderKeywordSet ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_ShaderKeywordSet(
                          ( ShaderKeywordSet ) m_Creators[typeof( ShaderKeywordSet )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( SortingGroup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_SortingGroup(
                          ( SortingGroup ) m_Creators[typeof( SortingGroup )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( FrameData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_FrameData(
                          ( FrameData ) m_Creators[typeof( FrameData )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( INotification ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_INotification(
                          ( INotification ) m_Creators[typeof( INotification )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( INotificationReceiver ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_INotificationReceiver(
                          ( INotificationReceiver ) m_Creators[typeof( INotificationReceiver )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( IPlayable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_IPlayable(
                          ( IPlayable ) m_Creators[typeof( IPlayable )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( IPlayableBehaviour ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_IPlayableBehaviour(
                          ( IPlayableBehaviour ) m_Creators[typeof( IPlayableBehaviour )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( IPlayableOutput ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_IPlayableOutput(
                          ( IPlayableOutput ) m_Creators[typeof( IPlayableOutput )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( Notification ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_Notification(
                          ( Notification ) m_Creators[typeof( Notification )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( IPlayableAsset ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_IPlayableAsset(
                          ( IPlayableAsset ) m_Creators[typeof( IPlayableAsset )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( PlayableAsset ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_PlayableAsset(
                          ( PlayableAsset ) m_Creators[typeof( PlayableAsset )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( PlayableBehaviour ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_PlayableBehaviour(
                          ( PlayableBehaviour ) m_Creators[typeof( PlayableBehaviour )].
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
                    typeof( PlayableOutputHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_PlayableOutputHandle(
                          ( PlayableOutputHandle ) m_Creators[typeof( PlayableOutputHandle )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( ScriptPlayableOutput ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_ScriptPlayableOutput(
                          ( ScriptPlayableOutput ) m_Creators[typeof( ScriptPlayableOutput )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( LinearColor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_LinearColor(
                          ( LinearColor ) m_Creators[typeof( LinearColor )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( DirectionalLight ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_DirectionalLight(
                          ( DirectionalLight ) m_Creators[typeof( DirectionalLight )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( PointLight ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_PointLight(
                          ( PointLight ) m_Creators[typeof( PointLight )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( SpotLight ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_SpotLight(
                          ( SpotLight ) m_Creators[typeof( SpotLight )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( RectangleLight ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_RectangleLight(
                          ( RectangleLight ) m_Creators[typeof( RectangleLight )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( DiscLight ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_DiscLight(
                          ( DiscLight ) m_Creators[typeof( DiscLight )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( SpotLightBoxShape ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_SpotLightBoxShape(
                          ( SpotLightBoxShape ) m_Creators[typeof( SpotLightBoxShape )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( SpotLightPyramidShape ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_SpotLightPyramidShape(
                          ( SpotLightPyramidShape ) m_Creators[typeof( SpotLightPyramidShape )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( Cookie ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_Cookie(
                          ( Cookie ) m_Creators[typeof( Cookie )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( LightDataGI ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_LightDataGI(
                          ( LightDataGI ) m_Creators[typeof( LightDataGI )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( UnityEngine.Experimental.GlobalIllumination.RenderSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_RenderSettings(
                          ( UnityEngine.Experimental.GlobalIllumination.RenderSettings ) m_Creators[
                                  typeof( UnityEngine.Experimental.GlobalIllumination.RenderSettings )].
                              Item1.First( x => x.ArgCount == a.Length ).
                              Create( a ) ) )
                },
                {
                    typeof( CameraPlayable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_Playables_CameraPlayable(
                          ( CameraPlayable ) m_Creators[typeof( CameraPlayable )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( MaterialEffectPlayable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_Playables_MaterialEffectPlayable(
                          ( MaterialEffectPlayable ) m_Creators[typeof( MaterialEffectPlayable )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( TextureMixerPlayable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_Playables_TextureMixerPlayable(
                          ( TextureMixerPlayable ) m_Creators[typeof( TextureMixerPlayable )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( TexturePlayableOutput ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_Playables_TexturePlayableOutput(
                          ( TexturePlayableOutput ) m_Creators[typeof( TexturePlayableOutput )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( IScriptableRuntimeReflectionSystem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_Rendering_IScriptableRuntimeReflectionSystem(
                          ( IScriptableRuntimeReflectionSystem ) m_Creators[
                                                                     typeof( IScriptableRuntimeReflectionSystem )].
                                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                                 Create( a ) ) )
                },
                {
                    typeof( ScriptableRuntimeReflectionSystem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_Rendering_ScriptableRuntimeReflectionSystem(
                          ( ScriptableRuntimeReflectionSystem ) m_Creators[typeof( ScriptableRuntimeReflectionSystem )].
                                                                Item1.First( x => x.ArgCount == a.Length ).
                                                                Create( a ) ) )
                },
                {
                    typeof( GraphicsFormatUtility ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_Rendering_GraphicsFormatUtility(
                          ( GraphicsFormatUtility ) m_Creators[typeof( GraphicsFormatUtility )].
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
                    typeof( ShaderWarmupSetup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_Rendering_ShaderWarmupSetup(
                          ( ShaderWarmupSetup ) m_Creators[typeof( ShaderWarmupSetup )].
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
                    typeof( AssertionException ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Assertions_AssertionException(
                          ( AssertionException ) m_Creators[typeof( AssertionException )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( FloatComparer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Assertions_Comparers_FloatComparer(
                          ( FloatComparer ) m_Creators[typeof( FloatComparer )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
#if BS_UNITY_APPLE
                {
                    typeof( FrameCapture ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Apple_FrameCapture(
                          ( FrameCapture ) m_Creators[typeof( FrameCapture )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
#endif
                {
                    typeof( ExcludeFromCoverageAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TestTools_ExcludeFromCoverageAttribute(
                          ( ExcludeFromCoverageAttribute ) m_Creators[typeof( ExcludeFromCoverageAttribute )].
                                                           Item1.First( x => x.ArgCount == a.Length ).
                                                           Create( a ) ) )
                },
                {
                    typeof( CoveredSequencePoint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TestTools_CoveredSequencePoint(
                          ( CoveredSequencePoint ) m_Creators[typeof( CoveredSequencePoint )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( CoveredMethodStats ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TestTools_CoveredMethodStats(
                          ( CoveredMethodStats ) m_Creators[typeof( CoveredMethodStats )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( CrashReportHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CrashReportHandler_CrashReportHandler(
                          ( CrashReportHandler ) m_Creators[typeof( CrashReportHandler )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( PlayableDirector ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Playables_PlayableDirector(
                          ( PlayableDirector ) m_Creators[typeof( PlayableDirector )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( ISocialPlatform ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_ISocialPlatform(
                          ( ISocialPlatform ) m_Creators[typeof( ISocialPlatform )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( ILocalUser ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_ILocalUser(
                          ( ILocalUser ) m_Creators[typeof( ILocalUser )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( ILeaderboard ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_ILeaderboard(
                          ( ILeaderboard ) m_Creators[typeof( ILeaderboard )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( Range ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_Range(
                          ( Range ) m_Creators[typeof( Range )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( IScore ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_IScore(
                          ( IScore ) m_Creators[typeof( IScore )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( Local ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_Local(
                          ( Local ) m_Creators[typeof( Local )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( IUserProfile ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_IUserProfile(
                          ( IUserProfile ) m_Creators[typeof( IUserProfile )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( IAchievement ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_IAchievement(
                          ( IAchievement ) m_Creators[typeof( IAchievement )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( IAchievementDescription ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_IAchievementDescription(
                          ( IAchievementDescription ) m_Creators[typeof( IAchievementDescription )].
                                                      Item1.First( x => x.ArgCount == a.Length ).
                                                      Create( a ) ) )
                },
                {
                    typeof( LocalUser ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_Impl_LocalUser(
                          ( LocalUser ) m_Creators[typeof( LocalUser )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( UserProfile ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_Impl_UserProfile(
                          ( UserProfile ) m_Creators[typeof( UserProfile )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( Achievement ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_Impl_Achievement(
                          ( Achievement ) m_Creators[typeof( Achievement )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( AchievementDescription ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_Impl_AchievementDescription(
                          ( AchievementDescription ) m_Creators[typeof( AchievementDescription )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( Score ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_Impl_Score(
                          ( Score ) m_Creators[typeof( Score )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( Leaderboard ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_Impl_Leaderboard(
                          ( Leaderboard ) m_Creators[typeof( Leaderboard )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( GameCenterPlatform ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SocialPlatforms_GameCenter_GameCenterPlatform(
                          ( GameCenterPlatform ) m_Creators[typeof( GameCenterPlatform )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( Grid ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Grid(
                          ( Grid ) m_Creators[typeof( Grid )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( GridLayout ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GridLayout(
                          ( GridLayout ) m_Creators[typeof( GridLayout )].
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
                    typeof( GUI ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GUI(
                          ( GUI ) m_Creators[typeof( GUI )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( GUISkin ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GUISkin(
                          ( GUISkin ) m_Creators[typeof( GUISkin )].
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
                    typeof( GUIStyle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GUIStyle(
                          ( GUIStyle ) m_Creators[typeof( GUIStyle )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( GUIStyleState ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GUIStyleState(
                          ( GUIStyleState ) m_Creators[typeof( GUIStyleState )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( GUIContent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GUIContent(
                          ( GUIContent ) m_Creators[typeof( GUIContent )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( GUISettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GUISettings(
                          ( GUISettings ) m_Creators[typeof( GUISettings )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( GUILayout ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GUILayout(
                          ( GUILayout ) m_Creators[typeof( GUILayout )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( GUILayoutOption ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GUILayoutOption(
                          ( GUILayoutOption ) m_Creators[typeof( GUILayoutOption )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( GUILayoutUtility ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GUILayoutUtility(
                          ( GUILayoutUtility ) m_Creators[typeof( GUILayoutUtility )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( GUITargetAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GUITargetAttribute(
                          ( GUITargetAttribute ) m_Creators[typeof( GUITargetAttribute )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( GUIUtility ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GUIUtility(
                          ( GUIUtility ) m_Creators[typeof( GUIUtility )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( ExitGUIException ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ExitGUIException(
                          ( ExitGUIException ) m_Creators[typeof( ExitGUIException )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( TextEditor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TextEditor(
                          ( TextEditor ) m_Creators[typeof( TextEditor )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( AndroidInput ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AndroidInput(
                          ( AndroidInput ) m_Creators[typeof( AndroidInput )].
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
                    typeof( Gyroscope ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Gyroscope(
                          ( Gyroscope ) m_Creators[typeof( Gyroscope )].
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
                    typeof( LocationService ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LocationService(
                          ( LocationService ) m_Creators[typeof( LocationService )].
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
                    typeof( Input ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Input(
                          ( Input ) m_Creators[typeof( Input )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( LocalizationAsset ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_LocalizationAsset(
                          ( LocalizationAsset ) m_Creators[typeof( LocalizationAsset )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( ParticleSystem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ParticleSystem(
                          ( ParticleSystem ) m_Creators[typeof( ParticleSystem )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( ParticleCollisionEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ParticleCollisionEvent(
                          ( ParticleCollisionEvent ) m_Creators[typeof( ParticleCollisionEvent )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( ParticleSystemRenderer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ParticleSystemRenderer(
                          ( ParticleSystemRenderer ) m_Creators[typeof( ParticleSystemRenderer )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( ParticleSystemForceField ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ParticleSystemForceField(
                          ( ParticleSystemForceField ) m_Creators[typeof( ParticleSystemForceField )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( IJobParticleSystem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ParticleSystemJobs_IJobParticleSystem(
                          ( IJobParticleSystem ) m_Creators[typeof( IJobParticleSystem )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( IJobParticleSystemParallelFor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ParticleSystemJobs_IJobParticleSystemParallelFor(
                          ( IJobParticleSystemParallelFor ) m_Creators[typeof( IJobParticleSystemParallelFor )].
                                                            Item1.First( x => x.ArgCount == a.Length ).
                                                            Create( a ) ) )
                },
                {
                    typeof( IJobParticleSystemParallelForBatch ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ParticleSystemJobs_IJobParticleSystemParallelForBatch(
                          ( IJobParticleSystemParallelForBatch ) m_Creators[
                                                                     typeof( IJobParticleSystemParallelForBatch )].
                                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                                 Create( a ) ) )
                },
                {
                    typeof( ParticleSystemNativeArray3 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemNativeArray3(
                          ( ParticleSystemNativeArray3 ) m_Creators[typeof( ParticleSystemNativeArray3 )].
                                                         Item1.First( x => x.ArgCount == a.Length ).
                                                         Create( a ) ) )
                },
                {
                    typeof( ParticleSystemNativeArray4 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemNativeArray4(
                          ( ParticleSystemNativeArray4 ) m_Creators[typeof( ParticleSystemNativeArray4 )].
                                                         Item1.First( x => x.ArgCount == a.Length ).
                                                         Create( a ) ) )
                },
                {
                    typeof( ParticleSystemJobData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemJobData(
                          ( ParticleSystemJobData ) m_Creators[typeof( ParticleSystemJobData )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( WheelFrictionCurve ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WheelFrictionCurve(
                          ( WheelFrictionCurve ) m_Creators[typeof( WheelFrictionCurve )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( SoftJointLimit ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SoftJointLimit(
                          ( SoftJointLimit ) m_Creators[typeof( SoftJointLimit )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( SoftJointLimitSpring ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SoftJointLimitSpring(
                          ( SoftJointLimitSpring ) m_Creators[typeof( SoftJointLimitSpring )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( JointDrive ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_JointDrive(
                          ( JointDrive ) m_Creators[typeof( JointDrive )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( JointMotor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_JointMotor(
                          ( JointMotor ) m_Creators[typeof( JointMotor )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( JointSpring ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_JointSpring(
                          ( JointSpring ) m_Creators[typeof( JointSpring )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( JointLimits ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_JointLimits(
                          ( JointLimits ) m_Creators[typeof( JointLimits )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( ControllerColliderHit ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ControllerColliderHit(
                          ( ControllerColliderHit ) m_Creators[typeof( ControllerColliderHit )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( CharacterController ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CharacterController(
                          ( CharacterController ) m_Creators[typeof( CharacterController )].
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
                    typeof( Collision ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Collision(
                          ( Collision ) m_Creators[typeof( Collision )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( ContactPoint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ContactPoint(
                          ( ContactPoint ) m_Creators[typeof( ContactPoint )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( RaycastHit ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RaycastHit(
                          ( RaycastHit ) m_Creators[typeof( RaycastHit )].
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
                    typeof( CapsuleCollider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CapsuleCollider(
                          ( CapsuleCollider ) m_Creators[typeof( CapsuleCollider )].
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
                    typeof( ConstantForce ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ConstantForce(
                          ( ConstantForce ) m_Creators[typeof( ConstantForce )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( Joint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Joint(
                          ( Joint ) m_Creators[typeof( Joint )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( HingeJoint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_HingeJoint(
                          ( HingeJoint ) m_Creators[typeof( HingeJoint )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( SpringJoint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SpringJoint(
                          ( SpringJoint ) m_Creators[typeof( SpringJoint )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( FixedJoint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_FixedJoint(
                          ( FixedJoint ) m_Creators[typeof( FixedJoint )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( CharacterJoint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CharacterJoint(
                          ( CharacterJoint ) m_Creators[typeof( CharacterJoint )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( ConfigurableJoint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ConfigurableJoint(
                          ( ConfigurableJoint ) m_Creators[typeof( ConfigurableJoint )].
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
                    typeof( ArticulationJacobian ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ArticulationJacobian(
                          ( ArticulationJacobian ) m_Creators[typeof( ArticulationJacobian )].
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
                    typeof( RaycastCommand ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RaycastCommand(
                          ( RaycastCommand ) m_Creators[typeof( RaycastCommand )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( JobHandle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_Unity_Jobs_JobHandle(
                          ( JobHandle ) m_Creators[typeof( JobHandle )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( SpherecastCommand ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SpherecastCommand(
                          ( SpherecastCommand ) m_Creators[typeof( SpherecastCommand )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( CapsulecastCommand ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CapsulecastCommand(
                          ( CapsulecastCommand ) m_Creators[typeof( CapsulecastCommand )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( BoxcastCommand ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_BoxcastCommand(
                          ( BoxcastCommand ) m_Creators[typeof( BoxcastCommand )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( PhysicsScene2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PhysicsScene2D(
                          ( PhysicsScene2D ) m_Creators[typeof( PhysicsScene2D )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( RaycastHit2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RaycastHit2D(
                          ( RaycastHit2D ) m_Creators[typeof( RaycastHit2D )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( Collider2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Collider2D(
                          ( Collider2D ) m_Creators[typeof( Collider2D )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( CompositeCollider2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CompositeCollider2D(
                          ( CompositeCollider2D ) m_Creators[typeof( CompositeCollider2D )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( Rigidbody2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rigidbody2D(
                          ( Rigidbody2D ) m_Creators[typeof( Rigidbody2D )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( PhysicsMaterial2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PhysicsMaterial2D(
                          ( PhysicsMaterial2D ) m_Creators[typeof( PhysicsMaterial2D )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( ContactFilter2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ContactFilter2D(
                          ( ContactFilter2D ) m_Creators[typeof( ContactFilter2D )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( ColliderDistance2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ColliderDistance2D(
                          ( ColliderDistance2D ) m_Creators[typeof( ColliderDistance2D )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( Physics2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Physics2D(
                          ( Physics2D ) m_Creators[typeof( Physics2D )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( PhysicsJobOptions2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PhysicsJobOptions2D(
                          ( PhysicsJobOptions2D ) m_Creators[typeof( PhysicsJobOptions2D )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( Collision2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Collision2D(
                          ( Collision2D ) m_Creators[typeof( Collision2D )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( ContactPoint2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ContactPoint2D(
                          ( ContactPoint2D ) m_Creators[typeof( ContactPoint2D )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( JointAngleLimits2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_JointAngleLimits2D(
                          ( JointAngleLimits2D ) m_Creators[typeof( JointAngleLimits2D )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( JointTranslationLimits2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_JointTranslationLimits2D(
                          ( JointTranslationLimits2D ) m_Creators[typeof( JointTranslationLimits2D )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( JointMotor2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_JointMotor2D(
                          ( JointMotor2D ) m_Creators[typeof( JointMotor2D )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( JointSuspension2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_JointSuspension2D(
                          ( JointSuspension2D ) m_Creators[typeof( JointSuspension2D )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( CircleCollider2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CircleCollider2D(
                          ( CircleCollider2D ) m_Creators[typeof( CircleCollider2D )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( CapsuleCollider2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CapsuleCollider2D(
                          ( CapsuleCollider2D ) m_Creators[typeof( CapsuleCollider2D )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( EdgeCollider2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EdgeCollider2D(
                          ( EdgeCollider2D ) m_Creators[typeof( EdgeCollider2D )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( BoxCollider2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_BoxCollider2D(
                          ( BoxCollider2D ) m_Creators[typeof( BoxCollider2D )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( PolygonCollider2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PolygonCollider2D(
                          ( PolygonCollider2D ) m_Creators[typeof( PolygonCollider2D )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( Joint2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Joint2D(
                          ( Joint2D ) m_Creators[typeof( Joint2D )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( AnchoredJoint2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AnchoredJoint2D(
                          ( AnchoredJoint2D ) m_Creators[typeof( AnchoredJoint2D )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( SpringJoint2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SpringJoint2D(
                          ( SpringJoint2D ) m_Creators[typeof( SpringJoint2D )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( DistanceJoint2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_DistanceJoint2D(
                          ( DistanceJoint2D ) m_Creators[typeof( DistanceJoint2D )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( FrictionJoint2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_FrictionJoint2D(
                          ( FrictionJoint2D ) m_Creators[typeof( FrictionJoint2D )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( HingeJoint2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_HingeJoint2D(
                          ( HingeJoint2D ) m_Creators[typeof( HingeJoint2D )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( RelativeJoint2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RelativeJoint2D(
                          ( RelativeJoint2D ) m_Creators[typeof( RelativeJoint2D )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( SliderJoint2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SliderJoint2D(
                          ( SliderJoint2D ) m_Creators[typeof( SliderJoint2D )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( TargetJoint2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TargetJoint2D(
                          ( TargetJoint2D ) m_Creators[typeof( TargetJoint2D )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( FixedJoint2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_FixedJoint2D(
                          ( FixedJoint2D ) m_Creators[typeof( FixedJoint2D )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( WheelJoint2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WheelJoint2D(
                          ( WheelJoint2D ) m_Creators[typeof( WheelJoint2D )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( Effector2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Effector2D(
                          ( Effector2D ) m_Creators[typeof( Effector2D )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( AreaEffector2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_AreaEffector2D(
                          ( AreaEffector2D ) m_Creators[typeof( AreaEffector2D )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( BuoyancyEffector2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_BuoyancyEffector2D(
                          ( BuoyancyEffector2D ) m_Creators[typeof( BuoyancyEffector2D )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( PointEffector2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PointEffector2D(
                          ( PointEffector2D ) m_Creators[typeof( PointEffector2D )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( PlatformEffector2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PlatformEffector2D(
                          ( PlatformEffector2D ) m_Creators[typeof( PlatformEffector2D )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( SurfaceEffector2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SurfaceEffector2D(
                          ( SurfaceEffector2D ) m_Creators[typeof( SurfaceEffector2D )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( PhysicsUpdateBehaviour2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PhysicsUpdateBehaviour2D(
                          ( PhysicsUpdateBehaviour2D ) m_Creators[typeof( PhysicsUpdateBehaviour2D )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( ConstantForce2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ConstantForce2D(
                          ( ConstantForce2D ) m_Creators[typeof( ConstantForce2D )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( SpriteMask ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SpriteMask(
                          ( SpriteMask ) m_Creators[typeof( SpriteMask )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( SpriteShapeParameters ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_U2D_SpriteShapeParameters(
                          ( SpriteShapeParameters ) m_Creators[typeof( SpriteShapeParameters )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( SpriteShapeSegment ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_U2D_SpriteShapeSegment(
                          ( SpriteShapeSegment ) m_Creators[typeof( SpriteShapeSegment )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( SpriteShapeRenderer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_U2D_SpriteShapeRenderer(
                          ( SpriteShapeRenderer ) m_Creators[typeof( SpriteShapeRenderer )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( SpriteShapeMetaData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_U2D_SpriteShapeMetaData(
                          ( SpriteShapeMetaData ) m_Creators[typeof( SpriteShapeMetaData )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( ShapeControlPoint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_U2D_ShapeControlPoint(
                          ( ShapeControlPoint ) m_Creators[typeof( ShapeControlPoint )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( AngleRangeInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_U2D_AngleRangeInfo(
                          ( AngleRangeInfo ) m_Creators[typeof( AngleRangeInfo )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( SpriteShapeUtility ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_U2D_SpriteShapeUtility(
                          ( SpriteShapeUtility ) m_Creators[typeof( SpriteShapeUtility )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( StreamingController ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_StreamingController(
                          ( StreamingController ) m_Creators[typeof( StreamingController )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( IntegratedSubsystem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_IntegratedSubsystem(
                          ( IntegratedSubsystem ) m_Creators[typeof( IntegratedSubsystem )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( IntegratedSubsystemDescriptor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_IntegratedSubsystemDescriptor(
                          ( IntegratedSubsystemDescriptor ) m_Creators[typeof( IntegratedSubsystemDescriptor )].
                                                            Item1.First( x => x.ArgCount == a.Length ).
                                                            Create( a ) ) )
                },
                {
                    typeof( ISubsystem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ISubsystem(
                          ( ISubsystem ) m_Creators[typeof( ISubsystem )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( ISubsystemDescriptor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ISubsystemDescriptor(
                          ( ISubsystemDescriptor ) m_Creators[typeof( ISubsystemDescriptor )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( Subsystem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Subsystem(
                          ( Subsystem ) m_Creators[typeof( Subsystem )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( SubsystemDescriptor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SubsystemDescriptor(
                          ( SubsystemDescriptor ) m_Creators[typeof( SubsystemDescriptor )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( ExampleSubsystem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Subsystems_ExampleSubsystem(
                          ( ExampleSubsystem ) m_Creators[typeof( ExampleSubsystem )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( ExampleSubsystemDescriptor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Subsystems_ExampleSubsystemDescriptor(
                          ( ExampleSubsystemDescriptor ) m_Creators[typeof( ExampleSubsystemDescriptor )].
                                                         Item1.First( x => x.ArgCount == a.Length ).
                                                         Create( a ) ) )
                },
                {
                    typeof( SubsystemDescriptorWithProvider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SubsystemsImplementation_SubsystemDescriptorWithProvider(
                          ( SubsystemDescriptorWithProvider ) m_Creators[typeof( SubsystemDescriptorWithProvider )].
                                                              Item1.First( x => x.ArgCount == a.Length ).
                                                              Create( a ) ) )
                },
                {
                    typeof( SubsystemProvider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SubsystemsImplementation_SubsystemProvider(
                          ( SubsystemProvider ) m_Creators[typeof( SubsystemProvider )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( SubsystemWithProvider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SubsystemsImplementation_SubsystemWithProvider(
                          ( SubsystemWithProvider ) m_Creators[typeof( SubsystemWithProvider )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( Terrain ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Terrain(
                          ( Terrain ) m_Creators[typeof( Terrain )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( TerrainData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TerrainData(
                          ( TerrainData ) m_Creators[typeof( TerrainData )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( TreeInstance ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TreeInstance(
                          ( TreeInstance ) m_Creators[typeof( TreeInstance )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( Tree ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Tree(
                          ( Tree ) m_Creators[typeof( Tree )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( TreePrototype ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TreePrototype(
                          ( TreePrototype ) m_Creators[typeof( TreePrototype )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( DetailPrototype ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_DetailPrototype(
                          ( DetailPrototype ) m_Creators[typeof( DetailPrototype )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( SplatPrototype ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_SplatPrototype(
                          ( SplatPrototype ) m_Creators[typeof( SplatPrototype )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( PatchExtents ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_PatchExtents(
                          ( PatchExtents ) m_Creators[typeof( PatchExtents )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( TerrainLayer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TerrainLayer(
                          ( TerrainLayer ) m_Creators[typeof( TerrainLayer )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( BrushTransform ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_TerrainAPI_BrushTransform(
                          ( BrushTransform ) m_Creators[typeof( BrushTransform )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( PaintContext ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_TerrainAPI_PaintContext(
                          ( PaintContext ) m_Creators[typeof( PaintContext )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( TerrainCollider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TerrainCollider(
                          ( TerrainCollider ) m_Creators[typeof( TerrainCollider )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( FaceInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TextCore_FaceInfo(
                          ( FaceInfo ) m_Creators[typeof( FaceInfo )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( GlyphRect ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TextCore_GlyphRect(
                          ( GlyphRect ) m_Creators[typeof( GlyphRect )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( GlyphMetrics ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TextCore_GlyphMetrics(
                          ( GlyphMetrics ) m_Creators[typeof( GlyphMetrics )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( Glyph ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TextCore_Glyph(
                          ( Glyph ) m_Creators[typeof( Glyph )].
                                    Item1.First( x => x.ArgCount == a.Length ).
                                    Create( a ) ) )
                },
                {
                    typeof( GlyphValueRecord ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TextCore_LowLevel_GlyphValueRecord(
                          ( GlyphValueRecord ) m_Creators[typeof( GlyphValueRecord )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( GlyphAdjustmentRecord ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TextCore_LowLevel_GlyphAdjustmentRecord(
                          ( GlyphAdjustmentRecord ) m_Creators[typeof( GlyphAdjustmentRecord )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( GlyphPairAdjustmentRecord ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TextCore_LowLevel_GlyphPairAdjustmentRecord(
                          ( GlyphPairAdjustmentRecord ) m_Creators[typeof( GlyphPairAdjustmentRecord )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( FontEngine ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TextCore_LowLevel_FontEngine(
                          ( FontEngine ) m_Creators[typeof( FontEngine )].
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
                    typeof( TextGenerator ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TextGenerator(
                          ( TextGenerator ) m_Creators[typeof( TextGenerator )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( TextMesh ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_TextMesh(
                          ( TextMesh ) m_Creators[typeof( TextMesh )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( CharacterInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CharacterInfo(
                          ( CharacterInfo ) m_Creators[typeof( CharacterInfo )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( UICharInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UICharInfo(
                          ( UICharInfo ) m_Creators[typeof( UICharInfo )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( UILineInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UILineInfo(
                          ( UILineInfo ) m_Creators[typeof( UILineInfo )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( UIVertex ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIVertex(
                          ( UIVertex ) m_Creators[typeof( UIVertex )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( CustomGridBrushAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CustomGridBrushAttribute(
                          ( CustomGridBrushAttribute ) m_Creators[typeof( CustomGridBrushAttribute )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( GridBrushBase ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_GridBrushBase(
                          ( GridBrushBase ) m_Creators[typeof( GridBrushBase )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( ITilemap ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Tilemaps_ITilemap(
                          ( ITilemap ) m_Creators[typeof( ITilemap )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( TileBase ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Tilemaps_TileBase(
                          ( TileBase ) m_Creators[typeof( TileBase )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( UnityEngine.Tilemaps.Tile ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Tilemaps_Tile(
                          ( UnityEngine.Tilemaps.Tile ) m_Creators[typeof( UnityEngine.Tilemaps.Tile )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( Tilemap ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Tilemaps_Tilemap(
                          ( Tilemap ) m_Creators[typeof( Tilemap )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( TilemapRenderer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Tilemaps_TilemapRenderer(
                          ( TilemapRenderer ) m_Creators[typeof( TilemapRenderer )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( TileData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Tilemaps_TileData(
                          ( TileData ) m_Creators[typeof( TileData )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( TileAnimationData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Tilemaps_TileAnimationData(
                          ( TileAnimationData ) m_Creators[typeof( TileAnimationData )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( TilemapCollider2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Tilemaps_TilemapCollider2D(
                          ( TilemapCollider2D ) m_Creators[typeof( TilemapCollider2D )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( ICanvasRaycastFilter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_ICanvasRaycastFilter(
                          ( ICanvasRaycastFilter ) m_Creators[typeof( ICanvasRaycastFilter )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( CanvasGroup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_CanvasGroup(
                          ( CanvasGroup ) m_Creators[typeof( CanvasGroup )].
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
                    typeof( RectTransformUtility ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RectTransformUtility(
                          ( RectTransformUtility ) m_Creators[typeof( RectTransformUtility )].
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
                    typeof( BindableElement ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_BindableElement(
                          ( BindableElement ) m_Creators[typeof( BindableElement )].
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
                    typeof( VisualElement ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_VisualElement(
                          ( VisualElement ) m_Creators[typeof( VisualElement )].
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
                    typeof( UnityEngine.UIElements.Cursor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Cursor(
                          ( UnityEngine.UIElements.Cursor ) m_Creators[typeof( UnityEngine.UIElements.Cursor )].
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
                    typeof( Clickable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Clickable(
                          ( Clickable ) m_Creators[typeof( Clickable )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( ContextualMenuManipulator ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ContextualMenuManipulator(
                          ( ContextualMenuManipulator ) m_Creators[typeof( ContextualMenuManipulator )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( DropdownMenuEventInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_DropdownMenuEventInfo(
                          ( DropdownMenuEventInfo ) m_Creators[typeof( DropdownMenuEventInfo )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( DropdownMenuItem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_DropdownMenuItem(
                          ( DropdownMenuItem ) m_Creators[typeof( DropdownMenuItem )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( DropdownMenuSeparator ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_DropdownMenuSeparator(
                          ( DropdownMenuSeparator ) m_Creators[typeof( DropdownMenuSeparator )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( DropdownMenuAction ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_DropdownMenuAction(
                          ( DropdownMenuAction ) m_Creators[typeof( DropdownMenuAction )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( DropdownMenu ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_DropdownMenu(
                          ( DropdownMenu ) m_Creators[typeof( DropdownMenu )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( EventDispatcherGate ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_EventDispatcherGate(
                          ( EventDispatcherGate ) m_Creators[typeof( EventDispatcherGate )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( FocusChangeDirection ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_FocusChangeDirection(
                          ( FocusChangeDirection ) m_Creators[typeof( FocusChangeDirection )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( IFocusRing ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IFocusRing(
                          ( IFocusRing ) m_Creators[typeof( IFocusRing )].
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
                    typeof( IMGUIContainer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IMGUIContainer(
                          ( IMGUIContainer ) m_Creators[typeof( IMGUIContainer )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( ImmediateModeElement ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ImmediateModeElement(
                          ( ImmediateModeElement ) m_Creators[typeof( ImmediateModeElement )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( ManipulatorActivationFilter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ManipulatorActivationFilter(
                          ( ManipulatorActivationFilter ) m_Creators[typeof( ManipulatorActivationFilter )].
                                                          Item1.First( x => x.ArgCount == a.Length ).
                                                          Create( a ) ) )
                },
                {
                    typeof( IMouseEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IMouseEvent(
                          ( IMouseEvent ) m_Creators[typeof( IMouseEvent )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( IPointerEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IPointerEvent(
                          ( IPointerEvent ) m_Creators[typeof( IPointerEvent )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( IManipulator ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IManipulator(
                          ( IManipulator ) m_Creators[typeof( IManipulator )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( Manipulator ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Manipulator(
                          ( Manipulator ) m_Creators[typeof( Manipulator )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( MouseManipulator ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_MouseManipulator(
                          ( MouseManipulator ) m_Creators[typeof( MouseManipulator )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( PointerManipulator ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_PointerManipulator(
                          ( PointerManipulator ) m_Creators[typeof( PointerManipulator )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( TimerState ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_TimerState(
                          ( TimerState ) m_Creators[typeof( TimerState )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( TemplateContainer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_TemplateContainer(
                          ( TemplateContainer ) m_Creators[typeof( TemplateContainer )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( TextElement ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_TextElement(
                          ( TextElement ) m_Creators[typeof( TextElement )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( VisualElementFocusChangeDirection ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_VisualElementFocusChangeDirection(
                          ( VisualElementFocusChangeDirection ) m_Creators[typeof( VisualElementFocusChangeDirection )].
                                                                Item1.First( x => x.ArgCount == a.Length ).
                                                                Create( a ) ) )
                },
                {
                    typeof( VisualElementFocusRing ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_VisualElementFocusRing(
                          ( VisualElementFocusRing ) m_Creators[typeof( VisualElementFocusRing )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( IBindable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IBindable(
                          ( IBindable ) m_Creators[typeof( IBindable )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Box ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Box(
                          ( Box ) m_Creators[typeof( Box )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( Button ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Button(
                          ( Button ) m_Creators[typeof( Button )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( Foldout ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Foldout(
                          ( Foldout ) m_Creators[typeof( Foldout )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( HelpBox ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_HelpBox(
                          ( HelpBox ) m_Creators[typeof( HelpBox )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( Image ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Image(
                          ( Image ) m_Creators[typeof( Image )].
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
                    typeof( ListView ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ListView(
                          ( ListView ) m_Creators[typeof( ListView )].
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
                    typeof( MinMaxSlider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_MinMaxSlider(
                          ( MinMaxSlider ) m_Creators[typeof( MinMaxSlider )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( PopupWindow ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_PopupWindow(
                          ( PopupWindow ) m_Creators[typeof( PopupWindow )].
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
                    typeof( ScrollView ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ScrollView(
                          ( ScrollView ) m_Creators[typeof( ScrollView )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( SliderInt ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_SliderInt(
                          ( SliderInt ) m_Creators[typeof( SliderInt )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( TextField ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_TextField(
                          ( TextField ) m_Creators[typeof( TextField )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( Toggle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Toggle(
                          ( Toggle ) m_Creators[typeof( Toggle )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( TwoPaneSplitView ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_TwoPaneSplitView(
                          ( TwoPaneSplitView ) m_Creators[typeof( TwoPaneSplitView )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( IPointerCaptureEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IPointerCaptureEvent(
                          ( IPointerCaptureEvent ) m_Creators[typeof( IPointerCaptureEvent )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( PointerCaptureOutEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_PointerCaptureOutEvent(
                          ( PointerCaptureOutEvent ) m_Creators[typeof( PointerCaptureOutEvent )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( PointerCaptureEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_PointerCaptureEvent(
                          ( PointerCaptureEvent ) m_Creators[typeof( PointerCaptureEvent )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( IMouseCaptureEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IMouseCaptureEvent(
                          ( IMouseCaptureEvent ) m_Creators[typeof( IMouseCaptureEvent )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( MouseCaptureOutEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_MouseCaptureOutEvent(
                          ( MouseCaptureOutEvent ) m_Creators[typeof( MouseCaptureOutEvent )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( MouseCaptureEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_MouseCaptureEvent(
                          ( MouseCaptureEvent ) m_Creators[typeof( MouseCaptureEvent )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( IChangeEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IChangeEvent(
                          ( IChangeEvent ) m_Creators[typeof( IChangeEvent )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( ICommandEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ICommandEvent(
                          ( ICommandEvent ) m_Creators[typeof( ICommandEvent )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( ValidateCommandEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ValidateCommandEvent(
                          ( ValidateCommandEvent ) m_Creators[typeof( ValidateCommandEvent )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( ExecuteCommandEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ExecuteCommandEvent(
                          ( ExecuteCommandEvent ) m_Creators[typeof( ExecuteCommandEvent )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( IDragAndDropEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IDragAndDropEvent(
                          ( IDragAndDropEvent ) m_Creators[typeof( IDragAndDropEvent )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( DragExitedEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_DragExitedEvent(
                          ( DragExitedEvent ) m_Creators[typeof( DragExitedEvent )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( DragEnterEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_DragEnterEvent(
                          ( DragEnterEvent ) m_Creators[typeof( DragEnterEvent )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( DragLeaveEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_DragLeaveEvent(
                          ( DragLeaveEvent ) m_Creators[typeof( DragLeaveEvent )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( DragUpdatedEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_DragUpdatedEvent(
                          ( DragUpdatedEvent ) m_Creators[typeof( DragUpdatedEvent )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( DragPerformEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_DragPerformEvent(
                          ( DragPerformEvent ) m_Creators[typeof( DragPerformEvent )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( CallbackEventHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_CallbackEventHandler(
                          ( CallbackEventHandler ) m_Creators[typeof( CallbackEventHandler )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( IFocusEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IFocusEvent(
                          ( IFocusEvent ) m_Creators[typeof( IFocusEvent )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( FocusOutEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_FocusOutEvent(
                          ( FocusOutEvent ) m_Creators[typeof( FocusOutEvent )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( BlurEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_BlurEvent(
                          ( BlurEvent ) m_Creators[typeof( BlurEvent )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( FocusInEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_FocusInEvent(
                          ( FocusInEvent ) m_Creators[typeof( FocusInEvent )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( FocusEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_FocusEvent(
                          ( FocusEvent ) m_Creators[typeof( FocusEvent )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( InputEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_InputEvent(
                          ( InputEvent ) m_Creators[typeof( InputEvent )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( IKeyboardEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IKeyboardEvent(
                          ( IKeyboardEvent ) m_Creators[typeof( IKeyboardEvent )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( KeyDownEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_KeyDownEvent(
                          ( KeyDownEvent ) m_Creators[typeof( KeyDownEvent )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( KeyUpEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_KeyUpEvent(
                          ( KeyUpEvent ) m_Creators[typeof( KeyUpEvent )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( GeometryChangedEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_GeometryChangedEvent(
                          ( GeometryChangedEvent ) m_Creators[typeof( GeometryChangedEvent )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( MouseDownEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_MouseDownEvent(
                          ( MouseDownEvent ) m_Creators[typeof( MouseDownEvent )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( MouseUpEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_MouseUpEvent(
                          ( MouseUpEvent ) m_Creators[typeof( MouseUpEvent )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( MouseMoveEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_MouseMoveEvent(
                          ( MouseMoveEvent ) m_Creators[typeof( MouseMoveEvent )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( ContextClickEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ContextClickEvent(
                          ( ContextClickEvent ) m_Creators[typeof( ContextClickEvent )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( WheelEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_WheelEvent(
                          ( WheelEvent ) m_Creators[typeof( WheelEvent )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( MouseEnterEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_MouseEnterEvent(
                          ( MouseEnterEvent ) m_Creators[typeof( MouseEnterEvent )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( MouseLeaveEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_MouseLeaveEvent(
                          ( MouseLeaveEvent ) m_Creators[typeof( MouseLeaveEvent )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( MouseEnterWindowEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_MouseEnterWindowEvent(
                          ( MouseEnterWindowEvent ) m_Creators[typeof( MouseEnterWindowEvent )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( MouseLeaveWindowEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_MouseLeaveWindowEvent(
                          ( MouseLeaveWindowEvent ) m_Creators[typeof( MouseLeaveWindowEvent )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( MouseOverEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_MouseOverEvent(
                          ( MouseOverEvent ) m_Creators[typeof( MouseOverEvent )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( MouseOutEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_MouseOutEvent(
                          ( MouseOutEvent ) m_Creators[typeof( MouseOutEvent )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( ContextualMenuPopulateEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ContextualMenuPopulateEvent(
                          ( ContextualMenuPopulateEvent ) m_Creators[typeof( ContextualMenuPopulateEvent )].
                                                          Item1.First( x => x.ArgCount == a.Length ).
                                                          Create( a ) ) )
                },
                {
                    typeof( IPanelChangedEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IPanelChangedEvent(
                          ( IPanelChangedEvent ) m_Creators[typeof( IPanelChangedEvent )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( AttachToPanelEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_AttachToPanelEvent(
                          ( AttachToPanelEvent ) m_Creators[typeof( AttachToPanelEvent )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( DetachFromPanelEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_DetachFromPanelEvent(
                          ( DetachFromPanelEvent ) m_Creators[typeof( DetachFromPanelEvent )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( PointerDownEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_PointerDownEvent(
                          ( PointerDownEvent ) m_Creators[typeof( PointerDownEvent )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( PointerMoveEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_PointerMoveEvent(
                          ( PointerMoveEvent ) m_Creators[typeof( PointerMoveEvent )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( PointerStationaryEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_PointerStationaryEvent(
                          ( PointerStationaryEvent ) m_Creators[typeof( PointerStationaryEvent )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( PointerUpEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_PointerUpEvent(
                          ( PointerUpEvent ) m_Creators[typeof( PointerUpEvent )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( PointerCancelEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_PointerCancelEvent(
                          ( PointerCancelEvent ) m_Creators[typeof( PointerCancelEvent )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( ClickEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ClickEvent(
                          ( ClickEvent ) m_Creators[typeof( ClickEvent )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( PointerEnterEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_PointerEnterEvent(
                          ( PointerEnterEvent ) m_Creators[typeof( PointerEnterEvent )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( PointerLeaveEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_PointerLeaveEvent(
                          ( PointerLeaveEvent ) m_Creators[typeof( PointerLeaveEvent )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( PointerOverEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_PointerOverEvent(
                          ( PointerOverEvent ) m_Creators[typeof( PointerOverEvent )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( PointerOutEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_PointerOutEvent(
                          ( PointerOutEvent ) m_Creators[typeof( PointerOutEvent )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( CustomStyleResolvedEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_CustomStyleResolvedEvent(
                          ( CustomStyleResolvedEvent ) m_Creators[typeof( CustomStyleResolvedEvent )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( TooltipEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_TooltipEvent(
                          ( TooltipEvent ) m_Creators[typeof( TooltipEvent )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( IMGUIEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IMGUIEvent(
                          ( IMGUIEvent ) m_Creators[typeof( IMGUIEvent )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Vertex ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Vertex(
                          ( Vertex ) m_Creators[typeof( Vertex )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( MeshWriteData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_MeshWriteData(
                          ( MeshWriteData ) m_Creators[typeof( MeshWriteData )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( MeshGenerationContext ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_MeshGenerationContext(
                          ( MeshGenerationContext ) m_Creators[typeof( MeshGenerationContext )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( ThemeStyleSheet ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_ThemeStyleSheet(
                          ( ThemeStyleSheet ) m_Creators[typeof( ThemeStyleSheet )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( IUxmlAttributes ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IUxmlAttributes(
                          ( IUxmlAttributes ) m_Creators[typeof( IUxmlAttributes )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( UxmlRootElementFactory ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlRootElementFactory(
                          ( UxmlRootElementFactory ) m_Creators[typeof( UxmlRootElementFactory )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( CreationContext ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_CreationContext(
                          ( CreationContext ) m_Creators[typeof( CreationContext )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( VisualTreeAsset ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_VisualTreeAsset(
                          ( VisualTreeAsset ) m_Creators[typeof( VisualTreeAsset )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( UxmlRootElementTraits ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlRootElementTraits(
                          ( UxmlRootElementTraits ) m_Creators[typeof( UxmlRootElementTraits )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( UxmlStyleFactory ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlStyleFactory(
                          ( UxmlStyleFactory ) m_Creators[typeof( UxmlStyleFactory )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( UxmlStyleTraits ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlStyleTraits(
                          ( UxmlStyleTraits ) m_Creators[typeof( UxmlStyleTraits )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( UxmlTemplateFactory ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlTemplateFactory(
                          ( UxmlTemplateFactory ) m_Creators[typeof( UxmlTemplateFactory )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( UxmlTemplateTraits ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlTemplateTraits(
                          ( UxmlTemplateTraits ) m_Creators[typeof( UxmlTemplateTraits )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( UxmlAttributeOverridesFactory ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlAttributeOverridesFactory(
                          ( UxmlAttributeOverridesFactory ) m_Creators[typeof( UxmlAttributeOverridesFactory )].
                                                            Item1.First( x => x.ArgCount == a.Length ).
                                                            Create( a ) ) )
                },
                {
                    typeof( UxmlAttributeOverridesTraits ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlAttributeOverridesTraits(
                          ( UxmlAttributeOverridesTraits ) m_Creators[typeof( UxmlAttributeOverridesTraits )].
                                                           Item1.First( x => x.ArgCount == a.Length ).
                                                           Create( a ) ) )
                },
                {
                    typeof( UxmlAttributeDescription ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlAttributeDescription(
                          ( UxmlAttributeDescription ) m_Creators[typeof( UxmlAttributeDescription )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( UxmlTypeRestriction ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlTypeRestriction(
                          ( UxmlTypeRestriction ) m_Creators[typeof( UxmlTypeRestriction )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( UxmlStringAttributeDescription ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlStringAttributeDescription(
                          ( UxmlStringAttributeDescription ) m_Creators[typeof( UxmlStringAttributeDescription )].
                                                             Item1.First( x => x.ArgCount == a.Length ).
                                                             Create( a ) ) )
                },
                {
                    typeof( UxmlFloatAttributeDescription ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlFloatAttributeDescription(
                          ( UxmlFloatAttributeDescription ) m_Creators[typeof( UxmlFloatAttributeDescription )].
                                                            Item1.First( x => x.ArgCount == a.Length ).
                                                            Create( a ) ) )
                },
                {
                    typeof( UxmlDoubleAttributeDescription ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlDoubleAttributeDescription(
                          ( UxmlDoubleAttributeDescription ) m_Creators[typeof( UxmlDoubleAttributeDescription )].
                                                             Item1.First( x => x.ArgCount == a.Length ).
                                                             Create( a ) ) )
                },
                {
                    typeof( UxmlIntAttributeDescription ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlIntAttributeDescription(
                          ( UxmlIntAttributeDescription ) m_Creators[typeof( UxmlIntAttributeDescription )].
                                                          Item1.First( x => x.ArgCount == a.Length ).
                                                          Create( a ) ) )
                },
                {
                    typeof( UxmlLongAttributeDescription ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlLongAttributeDescription(
                          ( UxmlLongAttributeDescription ) m_Creators[typeof( UxmlLongAttributeDescription )].
                                                           Item1.First( x => x.ArgCount == a.Length ).
                                                           Create( a ) ) )
                },
                {
                    typeof( UxmlBoolAttributeDescription ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlBoolAttributeDescription(
                          ( UxmlBoolAttributeDescription ) m_Creators[typeof( UxmlBoolAttributeDescription )].
                                                           Item1.First( x => x.ArgCount == a.Length ).
                                                           Create( a ) ) )
                },
                {
                    typeof( UxmlColorAttributeDescription ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlColorAttributeDescription(
                          ( UxmlColorAttributeDescription ) m_Creators[typeof( UxmlColorAttributeDescription )].
                                                            Item1.First( x => x.ArgCount == a.Length ).
                                                            Create( a ) ) )
                },
                {
                    typeof( UxmlChildElementDescription ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlChildElementDescription(
                          ( UxmlChildElementDescription ) m_Creators[typeof( UxmlChildElementDescription )].
                                                          Item1.First( x => x.ArgCount == a.Length ).
                                                          Create( a ) ) )
                },
                {
                    typeof( UxmlTraits ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlTraits(
                          ( UxmlTraits ) m_Creators[typeof( UxmlTraits )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( IUxmlFactory ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_IUxmlFactory(
                          ( IUxmlFactory ) m_Creators[typeof( IUxmlFactory )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( UxmlValueMatches ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlValueMatches(
                          ( UxmlValueMatches ) m_Creators[typeof( UxmlValueMatches )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( UxmlValueBounds ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlValueBounds(
                          ( UxmlValueBounds ) m_Creators[typeof( UxmlValueBounds )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( UxmlEnumeration ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_UxmlEnumeration(
                          ( UxmlEnumeration ) m_Creators[typeof( UxmlEnumeration )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( StyleValues ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Experimental_StyleValues(
                          ( StyleValues ) m_Creators[typeof( StyleValues )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( IValueAnimation ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UIElements_Experimental_IValueAnimation(
                          ( IValueAnimation ) m_Creators[typeof( IValueAnimation )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( NetworkTransport ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_NetworkTransport(
                          ( NetworkTransport ) m_Creators[typeof( NetworkTransport )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( EndPoint ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Net_EndPoint(
                          ( EndPoint ) m_Creators[typeof( EndPoint )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( SocketAddress ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Net_SocketAddress(
                          ( SocketAddress ) m_Creators[typeof( SocketAddress )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( HostTopology ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_HostTopology(
                          ( HostTopology ) m_Creators[typeof( HostTopology )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( ConnectionConfig ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_ConnectionConfig(
                          ( ConnectionConfig ) m_Creators[typeof( ConnectionConfig )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( ChannelQOS ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_ChannelQOS(
                          ( ChannelQOS ) m_Creators[typeof( ChannelQOS )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( GlobalConfig ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_GlobalConfig(
                          ( GlobalConfig ) m_Creators[typeof( GlobalConfig )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( ConnectionSimulatorConfig ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_ConnectionSimulatorConfig(
                          ( ConnectionSimulatorConfig ) m_Creators[typeof( ConnectionSimulatorConfig )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( Utility ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_Utility(
                          ( Utility ) m_Creators[typeof( Utility )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( NetworkAccessToken ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_Types_NetworkAccessToken(
                          ( NetworkAccessToken ) m_Creators[typeof( NetworkAccessToken )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( MatchInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_Match_MatchInfo(
                          ( MatchInfo ) m_Creators[typeof( MatchInfo )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( MatchInfoSnapshot ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_Match_MatchInfoSnapshot(
                          ( MatchInfoSnapshot ) m_Creators[typeof( MatchInfoSnapshot )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( NetworkMatch ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_Match_NetworkMatch(
                          ( NetworkMatch ) m_Creators[typeof( NetworkMatch )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( Uri ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Uri(
                          ( Uri ) m_Creators[typeof( Uri )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( RemoteConfigSettings ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_RemoteConfigSettings(
                          ( RemoteConfigSettings ) m_Creators[typeof( RemoteConfigSettings )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( ContinuousEvent ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Analytics_ContinuousEvent(
                          ( ContinuousEvent ) m_Creators[typeof( ContinuousEvent )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( WWWForm ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WWWForm(
                          ( WWWForm ) m_Creators[typeof( WWWForm )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( IMultipartFormSection ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_IMultipartFormSection(
                          ( IMultipartFormSection ) m_Creators[typeof( IMultipartFormSection )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( MultipartFormDataSection ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_MultipartFormDataSection(
                          ( MultipartFormDataSection ) m_Creators[typeof( MultipartFormDataSection )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( MultipartFormFileSection ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_MultipartFormFileSection(
                          ( MultipartFormFileSection ) m_Creators[typeof( MultipartFormFileSection )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( UnityWebRequestAsyncOperation ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequestAsyncOperation(
                          ( UnityWebRequestAsyncOperation ) m_Creators[typeof( UnityWebRequestAsyncOperation )].
                                                            Item1.First( x => x.ArgCount == a.Length ).
                                                            Create( a ) ) )
                },
                {
                    typeof( UnityWebRequest ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_UnityWebRequest(
                          ( UnityWebRequest ) m_Creators[typeof( UnityWebRequest )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( UploadHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_UploadHandler(
                          ( UploadHandler ) m_Creators[typeof( UploadHandler )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( DownloadHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_DownloadHandler(
                          ( DownloadHandler ) m_Creators[typeof( DownloadHandler )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( CertificateHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_CertificateHandler(
                          ( CertificateHandler ) m_Creators[typeof( CertificateHandler )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( Encoding ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Text_Encoding(
                          ( Encoding ) m_Creators[typeof( Encoding )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( EncoderFallback ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Text_EncoderFallback(
                          ( EncoderFallback ) m_Creators[typeof( EncoderFallback )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( DecoderFallback ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Text_DecoderFallback(
                          ( DecoderFallback ) m_Creators[typeof( DecoderFallback )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( DownloadHandlerBuffer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_DownloadHandlerBuffer(
                          ( DownloadHandlerBuffer ) m_Creators[typeof( DownloadHandlerBuffer )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( DownloadHandlerScript ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_DownloadHandlerScript(
                          ( DownloadHandlerScript ) m_Creators[typeof( DownloadHandlerScript )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( DownloadHandlerFile ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_DownloadHandlerFile(
                          ( DownloadHandlerFile ) m_Creators[typeof( DownloadHandlerFile )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( UploadHandlerRaw ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_UploadHandlerRaw(
                          ( UploadHandlerRaw ) m_Creators[typeof( UploadHandlerRaw )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( UploadHandlerFile ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_UploadHandlerFile(
                          ( UploadHandlerFile ) m_Creators[typeof( UploadHandlerFile )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( DownloadHandlerAssetBundle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_DownloadHandlerAssetBundle(
                          ( DownloadHandlerAssetBundle ) m_Creators[typeof( DownloadHandlerAssetBundle )].
                                                         Item1.First( x => x.ArgCount == a.Length ).
                                                         Create( a ) ) )
                },
                {
                    typeof( DownloadHandlerAudioClip ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_DownloadHandlerAudioClip(
                          ( DownloadHandlerAudioClip ) m_Creators[typeof( DownloadHandlerAudioClip )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( DownloadHandlerTexture ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Networking_DownloadHandlerTexture(
                          ( DownloadHandlerTexture ) m_Creators[typeof( DownloadHandlerTexture )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( WWW ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WWW(
                          ( WWW ) m_Creators[typeof( WWW )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( VFXEventAttribute ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_VFX_VFXEventAttribute(
                          ( VFXEventAttribute ) m_Creators[typeof( VFXEventAttribute )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( VFXExpressionValues ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_VFX_VFXExpressionValues(
                          ( VFXExpressionValues ) m_Creators[typeof( VFXExpressionValues )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( VFXSpawnerCallbacks ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_VFX_VFXSpawnerCallbacks(
                          ( VFXSpawnerCallbacks ) m_Creators[typeof( VFXSpawnerCallbacks )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( VFXSpawnerState ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_VFX_VFXSpawnerState(
                          ( VFXSpawnerState ) m_Creators[typeof( VFXSpawnerState )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( VFXExposedProperty ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_VFX_VFXExposedProperty(
                          ( VFXExposedProperty ) m_Creators[typeof( VFXExposedProperty )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( VisualEffectObject ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_VFX_VisualEffectObject(
                          ( VisualEffectObject ) m_Creators[typeof( VisualEffectObject )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( VisualEffectAsset ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_VFX_VisualEffectAsset(
                          ( VisualEffectAsset ) m_Creators[typeof( VisualEffectAsset )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( VFXOutputEventArgs ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_VFX_VFXOutputEventArgs(
                          ( VFXOutputEventArgs ) m_Creators[typeof( VFXOutputEventArgs )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( VisualEffect ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_VFX_VisualEffect(
                          ( VisualEffect ) m_Creators[typeof( VisualEffect )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( VFXParticleSystemInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_VFX_VFXParticleSystemInfo(
                          ( VFXParticleSystemInfo ) m_Creators[typeof( VFXParticleSystemInfo )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( RemoteSpeechAccess ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngineInternal_XR_WSA_RemoteSpeechAccess(
                          ( RemoteSpeechAccess ) m_Creators[typeof( RemoteSpeechAccess )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( WheelHit ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WheelHit(
                          ( WheelHit ) m_Creators[typeof( WheelHit )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( WheelCollider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WheelCollider(
                          ( WheelCollider ) m_Creators[typeof( WheelCollider )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( VideoClipPlayable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Experimental_Video_VideoClipPlayable(
                          ( VideoClipPlayable ) m_Creators[typeof( VideoClipPlayable )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( VideoClip ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Video_VideoClip(
                          ( VideoClip ) m_Creators[typeof( VideoClip )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( VideoPlayer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Video_VideoPlayer(
                          ( VideoPlayer ) m_Creators[typeof( VideoPlayer )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( Resolver ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_VirtualTexturing_Resolver(
                          ( Resolver ) m_Creators[typeof( Resolver )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( GPUCacheSetting ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_Rendering_VirtualTexturing_GPUCacheSetting(
                          ( GPUCacheSetting ) m_Creators[typeof( GPUCacheSetting )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( WindZone ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_WindZone(
                          ( WindZone ) m_Creators[typeof( WindZone )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( XRNodeState ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_XRNodeState(
                          ( XRNodeState ) m_Creators[typeof( XRNodeState )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( HapticCapabilities ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_HapticCapabilities(
                          ( HapticCapabilities ) m_Creators[typeof( HapticCapabilities )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( InputFeatureUsage ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_InputFeatureUsage(
                          ( InputFeatureUsage ) m_Creators[typeof( InputFeatureUsage )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( InputDevice ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_InputDevice(
                          ( InputDevice ) m_Creators[typeof( InputDevice )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( XRInputSubsystem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_XRInputSubsystem(
                          ( XRInputSubsystem ) m_Creators[typeof( XRInputSubsystem )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( XRInputSubsystemDescriptor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_XRInputSubsystemDescriptor(
                          ( XRInputSubsystemDescriptor ) m_Creators[typeof( XRInputSubsystemDescriptor )].
                                                         Item1.First( x => x.ArgCount == a.Length ).
                                                         Create( a ) ) )
                },
                {
                    typeof( Hand ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_Hand(
                          ( Hand ) m_Creators[typeof( Hand )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( Eyes ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_Eyes(
                          ( Eyes ) m_Creators[typeof( Eyes )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( Bone ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_Bone(
                          ( Bone ) m_Creators[typeof( Bone )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( InputDevices ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_InputDevices(
                          ( InputDevices ) m_Creators[typeof( InputDevices )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( XRDisplaySubsystem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_XRDisplaySubsystem(
                          ( XRDisplaySubsystem ) m_Creators[typeof( XRDisplaySubsystem )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( XRDisplaySubsystemDescriptor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_XRDisplaySubsystemDescriptor(
                          ( XRDisplaySubsystemDescriptor ) m_Creators[typeof( XRDisplaySubsystemDescriptor )].
                                                           Item1.First( x => x.ArgCount == a.Length ).
                                                           Create( a ) ) )
                },
                {
                    typeof( XRMirrorViewBlitMode ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_XRMirrorViewBlitMode(
                          ( XRMirrorViewBlitMode ) m_Creators[typeof( XRMirrorViewBlitMode )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( XRMirrorViewBlitModeDesc ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_XRMirrorViewBlitModeDesc(
                          ( XRMirrorViewBlitModeDesc ) m_Creators[typeof( XRMirrorViewBlitModeDesc )].
                                                       Item1.First( x => x.ArgCount == a.Length ).
                                                       Create( a ) ) )
                },
                {
                    typeof( MeshId ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_MeshId(
                          ( MeshId ) m_Creators[typeof( MeshId )].
                                     Item1.First( x => x.ArgCount == a.Length ).
                                     Create( a ) ) )
                },
                {
                    typeof( MeshGenerationResult ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_MeshGenerationResult(
                          ( MeshGenerationResult ) m_Creators[typeof( MeshGenerationResult )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( MeshInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_MeshInfo(
                          ( MeshInfo ) m_Creators[typeof( MeshInfo )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( XRMeshSubsystem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_XRMeshSubsystem(
                          ( XRMeshSubsystem ) m_Creators[typeof( XRMeshSubsystem )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( XRMeshSubsystemDescriptor ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_XR_XRMeshSubsystemDescriptor(
                          ( XRMeshSubsystemDescriptor ) m_Creators[typeof( XRMeshSubsystemDescriptor )].
                                                        Item1.First( x => x.ArgCount == a.Length ).
                                                        Create( a ) ) )
                },
                {
                    typeof( ConstructorInfo ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Reflection_ConstructorInfo(
                          ( ConstructorInfo ) m_Creators[typeof( ConstructorInfo )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( IEqualityComparer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_Collections_IEqualityComparer(
                          ( IEqualityComparer ) m_Creators[typeof( IEqualityComparer )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( IComparable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_System_IComparable(
                          ( IComparable ) m_Creators[typeof( IComparable )].
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
                    typeof( UnityEngine.UI.Button ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_Button(
                          ( UnityEngine.UI.Button ) m_Creators[typeof( UnityEngine.UI.Button )].
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
                    typeof( Graphic ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_Graphic(
                          ( Graphic ) m_Creators[typeof( Graphic )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( UnityEngine.UI.Image ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_Image(
                          ( UnityEngine.UI.Image ) m_Creators[typeof( UnityEngine.UI.Image )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( ICanvasElement ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_ICanvasElement(
                          ( ICanvasElement ) m_Creators[typeof( ICanvasElement )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( CanvasUpdateRegistry ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_CanvasUpdateRegistry(
                          ( CanvasUpdateRegistry ) m_Creators[typeof( CanvasUpdateRegistry )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( ClipperRegistry ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_ClipperRegistry(
                          ( ClipperRegistry ) m_Creators[typeof( ClipperRegistry )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( IClipper ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_IClipper(
                          ( IClipper ) m_Creators[typeof( IClipper )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( IClippable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_IClippable(
                          ( IClippable ) m_Creators[typeof( IClippable )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Dropdown ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_Dropdown(
                          ( Dropdown ) m_Creators[typeof( Dropdown )].
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
                    typeof( FontData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_FontData(
                          ( FontData ) m_Creators[typeof( FontData )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( GraphicRaycaster ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_GraphicRaycaster(
                          ( GraphicRaycaster ) m_Creators[typeof( GraphicRaycaster )].
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
                    typeof( GraphicRegistry ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_GraphicRegistry(
                          ( GraphicRegistry ) m_Creators[typeof( GraphicRegistry )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( IMaskable ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_IMaskable(
                          ( IMaskable ) m_Creators[typeof( IMaskable )].
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
                    typeof( AspectRatioFitter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_AspectRatioFitter(
                          ( AspectRatioFitter ) m_Creators[typeof( AspectRatioFitter )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( CanvasScaler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_CanvasScaler(
                          ( CanvasScaler ) m_Creators[typeof( CanvasScaler )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( ContentSizeFitter ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_ContentSizeFitter(
                          ( ContentSizeFitter ) m_Creators[typeof( ContentSizeFitter )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( GridLayoutGroup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_GridLayoutGroup(
                          ( GridLayoutGroup ) m_Creators[typeof( GridLayoutGroup )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( HorizontalLayoutGroup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_HorizontalLayoutGroup(
                          ( HorizontalLayoutGroup ) m_Creators[typeof( HorizontalLayoutGroup )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( HorizontalOrVerticalLayoutGroup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_HorizontalOrVerticalLayoutGroup(
                          ( HorizontalOrVerticalLayoutGroup ) m_Creators[typeof( HorizontalOrVerticalLayoutGroup )].
                                                              Item1.First( x => x.ArgCount == a.Length ).
                                                              Create( a ) ) )
                },
                {
                    typeof( ILayoutElement ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_ILayoutElement(
                          ( ILayoutElement ) m_Creators[typeof( ILayoutElement )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( ILayoutController ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_ILayoutController(
                          ( ILayoutController ) m_Creators[typeof( ILayoutController )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( ILayoutGroup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_ILayoutGroup(
                          ( ILayoutGroup ) m_Creators[typeof( ILayoutGroup )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( ILayoutSelfController ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_ILayoutSelfController(
                          ( ILayoutSelfController ) m_Creators[typeof( ILayoutSelfController )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( ILayoutIgnorer ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_ILayoutIgnorer(
                          ( ILayoutIgnorer ) m_Creators[typeof( ILayoutIgnorer )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( LayoutElement ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_LayoutElement(
                          ( LayoutElement ) m_Creators[typeof( LayoutElement )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( LayoutGroup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_LayoutGroup(
                          ( LayoutGroup ) m_Creators[typeof( LayoutGroup )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( LayoutRebuilder ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_LayoutRebuilder(
                          ( LayoutRebuilder ) m_Creators[typeof( LayoutRebuilder )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( VerticalLayoutGroup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_VerticalLayoutGroup(
                          ( VerticalLayoutGroup ) m_Creators[typeof( VerticalLayoutGroup )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( Mask ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_Mask(
                          ( Mask ) m_Creators[typeof( Mask )].Item1.First( x => x.ArgCount == a.Length ).Create( a ) ) )
                },
                {
                    typeof( MaskUtilities ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_MaskUtilities(
                          ( MaskUtilities ) m_Creators[typeof( MaskUtilities )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( RectMask2D ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_RectMask2D(
                          ( RectMask2D ) m_Creators[typeof( RectMask2D )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( MaskableGraphic ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_MaskableGraphic(
                          ( MaskableGraphic ) m_Creators[typeof( MaskableGraphic )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( IMaterialModifier ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_IMaterialModifier(
                          ( IMaterialModifier ) m_Creators[typeof( IMaterialModifier )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( RawImage ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_RawImage(
                          ( RawImage ) m_Creators[typeof( RawImage )].
                                       Item1.First( x => x.ArgCount == a.Length ).
                                       Create( a ) ) )
                },
                {
                    typeof( ScrollRect ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_ScrollRect(
                          ( ScrollRect ) m_Creators[typeof( ScrollRect )].
                                         Item1.First( x => x.ArgCount == a.Length ).
                                         Create( a ) ) )
                },
                {
                    typeof( Scrollbar ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_Scrollbar(
                          ( Scrollbar ) m_Creators[typeof( Scrollbar )].
                                        Item1.First( x => x.ArgCount == a.Length ).
                                        Create( a ) ) )
                },
                {
                    typeof( UnityEngine.UI.Slider ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_Slider(
                          ( UnityEngine.UI.Slider ) m_Creators[typeof( UnityEngine.UI.Slider )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( UnityEngine.UI.Toggle ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_Toggle(
                          ( UnityEngine.UI.Toggle ) m_Creators[typeof( UnityEngine.UI.Toggle )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( ToggleGroup ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_ToggleGroup(
                          ( ToggleGroup ) m_Creators[typeof( ToggleGroup )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( VertexHelper ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_VertexHelper(
                          ( VertexHelper ) m_Creators[typeof( VertexHelper )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( BaseMeshEffect ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_BaseMeshEffect(
                          ( BaseMeshEffect ) m_Creators[typeof( BaseMeshEffect )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( IMeshModifier ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_IMeshModifier(
                          ( IMeshModifier ) m_Creators[typeof( IMeshModifier )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( Outline ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_Outline(
                          ( Outline ) m_Creators[typeof( Outline )].
                                      Item1.First( x => x.ArgCount == a.Length ).
                                      Create( a ) ) )
                },
                {
                    typeof( PositionAsUV1 ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_PositionAsUV1(
                          ( PositionAsUV1 ) m_Creators[typeof( PositionAsUV1 )].
                                            Item1.First( x => x.ArgCount == a.Length ).
                                            Create( a ) ) )
                },
                {
                    typeof( Shadow ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_UI_Shadow(
                          ( Shadow ) m_Creators[typeof( Shadow )].
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
                    typeof( AbstractEventData ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_AbstractEventData(
                          ( AbstractEventData ) m_Creators[typeof( AbstractEventData )].
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
                    typeof( IEventSystemHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_IEventSystemHandler(
                          ( IEventSystemHandler ) m_Creators[typeof( IEventSystemHandler )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( IPointerEnterHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_IPointerEnterHandler(
                          ( IPointerEnterHandler ) m_Creators[typeof( IPointerEnterHandler )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( IPointerExitHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_IPointerExitHandler(
                          ( IPointerExitHandler ) m_Creators[typeof( IPointerExitHandler )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( IPointerDownHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_IPointerDownHandler(
                          ( IPointerDownHandler ) m_Creators[typeof( IPointerDownHandler )].
                                                  Item1.First( x => x.ArgCount == a.Length ).
                                                  Create( a ) ) )
                },
                {
                    typeof( IPointerUpHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_IPointerUpHandler(
                          ( IPointerUpHandler ) m_Creators[typeof( IPointerUpHandler )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( IPointerClickHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_IPointerClickHandler(
                          ( IPointerClickHandler ) m_Creators[typeof( IPointerClickHandler )].
                                                   Item1.First( x => x.ArgCount == a.Length ).
                                                   Create( a ) ) )
                },
                {
                    typeof( IBeginDragHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_IBeginDragHandler(
                          ( IBeginDragHandler ) m_Creators[typeof( IBeginDragHandler )].
                                                Item1.First( x => x.ArgCount == a.Length ).
                                                Create( a ) ) )
                },
                {
                    typeof( IInitializePotentialDragHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_IInitializePotentialDragHandler(
                          ( IInitializePotentialDragHandler ) m_Creators[typeof( IInitializePotentialDragHandler )].
                                                              Item1.First( x => x.ArgCount == a.Length ).
                                                              Create( a ) ) )
                },
                {
                    typeof( IDragHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_IDragHandler(
                          ( IDragHandler ) m_Creators[typeof( IDragHandler )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( IEndDragHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_IEndDragHandler(
                          ( IEndDragHandler ) m_Creators[typeof( IEndDragHandler )].
                                              Item1.First( x => x.ArgCount == a.Length ).
                                              Create( a ) ) )
                },
                {
                    typeof( IDropHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_IDropHandler(
                          ( IDropHandler ) m_Creators[typeof( IDropHandler )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( IScrollHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_IScrollHandler(
                          ( IScrollHandler ) m_Creators[typeof( IScrollHandler )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( IUpdateSelectedHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_IUpdateSelectedHandler(
                          ( IUpdateSelectedHandler ) m_Creators[typeof( IUpdateSelectedHandler )].
                                                     Item1.First( x => x.ArgCount == a.Length ).
                                                     Create( a ) ) )
                },
                {
                    typeof( ISelectHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_ISelectHandler(
                          ( ISelectHandler ) m_Creators[typeof( ISelectHandler )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( IDeselectHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_IDeselectHandler(
                          ( IDeselectHandler ) m_Creators[typeof( IDeselectHandler )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( IMoveHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_IMoveHandler(
                          ( IMoveHandler ) m_Creators[typeof( IMoveHandler )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( ISubmitHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_ISubmitHandler(
                          ( ISubmitHandler ) m_Creators[typeof( ISubmitHandler )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( ICancelHandler ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_ICancelHandler(
                          ( ICancelHandler ) m_Creators[typeof( ICancelHandler )].
                                             Item1.First( x => x.ArgCount == a.Length ).
                                             Create( a ) ) )
                },
                {
                    typeof( EventSystem ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_EventSystem(
                          ( EventSystem ) m_Creators[typeof( EventSystem )].
                                          Item1.First( x => x.ArgCount == a.Length ).
                                          Create( a ) ) )
                },
                {
                    typeof( EventTrigger ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_EventTrigger(
                          ( EventTrigger ) m_Creators[typeof( EventTrigger )].
                                           Item1.First( x => x.ArgCount == a.Length ).
                                           Create( a ) ) )
                },
                {
                    typeof( PointerInputModule ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_PointerInputModule(
                          ( PointerInputModule ) m_Creators[typeof( PointerInputModule )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( StandaloneInputModule ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_StandaloneInputModule(
                          ( StandaloneInputModule ) m_Creators[typeof( StandaloneInputModule )].
                                                    Item1.First( x => x.ArgCount == a.Length ).
                                                    Create( a ) ) )
                },
                {
                    typeof( TouchInputModule ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_TouchInputModule(
                          ( TouchInputModule ) m_Creators[typeof( TouchInputModule )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( Physics2DRaycaster ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_Physics2DRaycaster(
                          ( Physics2DRaycaster ) m_Creators[typeof( Physics2DRaycaster )].
                                                 Item1.First( x => x.ArgCount == a.Length ).
                                                 Create( a ) ) )
                },
                {
                    typeof( PhysicsRaycaster ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_PhysicsRaycaster(
                          ( PhysicsRaycaster ) m_Creators[typeof( PhysicsRaycaster )].
                                               Item1.First( x => x.ArgCount == a.Length ).
                                               Create( a ) ) )
                },
                {
                    typeof( UIBehaviour ),
                    ( new IWrapperObjectCreator[] { },
                      a => new BSWrapperObject_UnityEngine_EventSystems_UIBehaviour(
                          ( UIBehaviour ) m_Creators[typeof( UIBehaviour )].
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
