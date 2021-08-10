
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
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BadScript.Tools.CodeGenerator.Runtime;
using Microsoft.Win32.SafeHandles;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Accessibility;
using UnityEngine.AI;
using UnityEngine.Analytics;
using UnityEngine.Android;
using UnityEngine.Animations;
using UnityEngine.Apple;
using UnityEngine.Apple.ReplayKit;
using UnityEngine.Assertions;
using UnityEngine.Assertions.Comparers;
using UnityEngine.Assertions.Must;
using UnityEngine.Audio;
using UnityEngine.CrashReportHandler;
using UnityEngine.Diagnostics;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.AI;
using UnityEngine.Experimental.Animations;
using UnityEngine.Experimental.AssetBundlePatching;
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
using UnityEngine.SubsystemsImplementation.Extensions;
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
using UnityEngine.Windows;
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
using Directory = UnityEngine.Windows.Directory;
using File = UnityEngine.Windows.File;
using Image = UnityEngine.UIElements.Image;
using LocalNotification = UnityEngine.iOS.LocalNotification;
using NotificationServices = UnityEngine.iOS.NotificationServices;
using Object = UnityEngine.Object;
using PlayerConnection = UnityEngine.Networking.PlayerConnection.PlayerConnection;
using PointerType = UnityEngine.UIElements.PointerType;
using Random = UnityEngine.Random;
using RemoteNotification = UnityEngine.iOS.RemoteNotification;
using RenderSettings = UnityEngine.RenderSettings;
using Slider = UnityEngine.UIElements.Slider;
using Tile = UnityEngine.WSA.Tile;
using Toggle = UnityEngine.UIElements.Toggle;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class UnityStaticDB : WrapperStaticDataBase
    {
#region Public

        public UnityStaticDB()
        {
            StaticTypes[typeof( NavMeshPath )] = new BSStaticWrapperObject_UnityEngine_AI_NavMeshPath();
            StaticTypes[typeof( object )] = new BSStaticWrapperObject_System_Object();
            StaticTypes[typeof( NavMeshBuilder )] = new BSStaticWrapperObject_UnityEngine_AI_NavMeshBuilder();
            StaticTypes[typeof( NavMeshData )] = new BSStaticWrapperObject_UnityEngine_AI_NavMeshData();
            StaticTypes[typeof( Bounds )] = new BSStaticWrapperObject_UnityEngine_Bounds();
            StaticTypes[typeof( Vector3 )] = new BSStaticWrapperObject_UnityEngine_Vector3();
            StaticTypes[typeof( IFormatProvider )] = new BSStaticWrapperObject_System_IFormatProvider();
            StaticTypes[typeof( Ray )] = new BSStaticWrapperObject_UnityEngine_Ray();
            StaticTypes[typeof( Quaternion )] = new BSStaticWrapperObject_UnityEngine_Quaternion();

            StaticTypes[typeof( NavMeshBuildSettings )] =
                new BSStaticWrapperObject_UnityEngine_AI_NavMeshBuildSettings();

            StaticTypes[typeof( NavMeshBuildDebugSettings )] =
                new BSStaticWrapperObject_UnityEngine_AI_NavMeshBuildDebugSettings();

            StaticTypes[typeof( AsyncOperation )] = new BSStaticWrapperObject_UnityEngine_AsyncOperation();
            StaticTypes[typeof( NavMeshAgent )] = new BSStaticWrapperObject_UnityEngine_AI_NavMeshAgent();
            StaticTypes[typeof( OffMeshLinkData )] = new BSStaticWrapperObject_UnityEngine_AI_OffMeshLinkData();
            StaticTypes[typeof( OffMeshLink )] = new BSStaticWrapperObject_UnityEngine_AI_OffMeshLink();
            StaticTypes[typeof( Transform )] = new BSStaticWrapperObject_UnityEngine_Transform();
            StaticTypes[typeof( Matrix4x4 )] = new BSStaticWrapperObject_UnityEngine_Matrix4x4();
            StaticTypes[typeof( FrustumPlanes )] = new BSStaticWrapperObject_UnityEngine_FrustumPlanes();
            StaticTypes[typeof( Vector4 )] = new BSStaticWrapperObject_UnityEngine_Vector4();
            StaticTypes[typeof( Plane )] = new BSStaticWrapperObject_UnityEngine_Plane();
            StaticTypes[typeof( GameObject )] = new BSStaticWrapperObject_UnityEngine_GameObject();
            StaticTypes[typeof( Scene )] = new BSStaticWrapperObject_UnityEngine_SceneManagement_Scene();
            StaticTypes[typeof( Component )] = new BSStaticWrapperObject_UnityEngine_Component();
            StaticTypes[typeof( Object )] = new BSStaticWrapperObject_UnityEngine_Object();
            StaticTypes[typeof( NavMeshObstacle )] = new BSStaticWrapperObject_UnityEngine_AI_NavMeshObstacle();
            StaticTypes[typeof( NavMeshHit )] = new BSStaticWrapperObject_UnityEngine_AI_NavMeshHit();

            StaticTypes[typeof( NavMeshTriangulation )] =
                new BSStaticWrapperObject_UnityEngine_AI_NavMeshTriangulation();

            StaticTypes[typeof( NavMeshDataInstance )] = new BSStaticWrapperObject_UnityEngine_AI_NavMeshDataInstance();
            StaticTypes[typeof( NavMeshLinkData )] = new BSStaticWrapperObject_UnityEngine_AI_NavMeshLinkData();
            StaticTypes[typeof( NavMeshLinkInstance )] = new BSStaticWrapperObject_UnityEngine_AI_NavMeshLinkInstance();
            StaticTypes[typeof( NavMeshQueryFilter )] = new BSStaticWrapperObject_UnityEngine_AI_NavMeshQueryFilter();
            StaticTypes[typeof( NavMesh )] = new BSStaticWrapperObject_UnityEngine_AI_NavMesh();
            StaticTypes[typeof( NavMeshBuildSource )] = new BSStaticWrapperObject_UnityEngine_AI_NavMeshBuildSource();
            StaticTypes[typeof( NavMeshBuildMarkup )] = new BSStaticWrapperObject_UnityEngine_AI_NavMeshBuildMarkup();
            StaticTypes[typeof( PolygonId )] = new BSStaticWrapperObject_UnityEngine_Experimental_AI_PolygonId();

            StaticTypes[typeof( NavMeshLocation )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_AI_NavMeshLocation();

            StaticTypes[typeof( NavMeshWorld )] = new BSStaticWrapperObject_UnityEngine_Experimental_AI_NavMeshWorld();
            StaticTypes[typeof( NavMeshQuery )] = new BSStaticWrapperObject_UnityEngine_Experimental_AI_NavMeshQuery();
            StaticTypes[typeof( VisionUtility )] = new BSStaticWrapperObject_UnityEngine_Accessibility_VisionUtility();
#if BS_UNITY_ANDROID
            StaticTypes[typeof( AndroidJavaRunnable )] = new BSStaticWrapperObject_UnityEngine_AndroidJavaRunnable();
#endif
            StaticTypes[typeof( MethodInfo )] = new BSStaticWrapperObject_System_Reflection_MethodInfo();
            StaticTypes[typeof( ParameterInfo )] = new BSStaticWrapperObject_System_Reflection_ParameterInfo();
            StaticTypes[typeof( MemberInfo )] = new BSStaticWrapperObject_System_Reflection_MemberInfo();
            StaticTypes[typeof( Module )] = new BSStaticWrapperObject_System_Reflection_Module();
            StaticTypes[typeof( ModuleHandle )] = new BSStaticWrapperObject_System_ModuleHandle();
            StaticTypes[typeof( RuntimeFieldHandle )] = new BSStaticWrapperObject_System_RuntimeFieldHandle();
            StaticTypes[typeof( IntPtr )] = new BSStaticWrapperObject_System_IntPtr();
            StaticTypes[typeof( RuntimeMethodHandle )] = new BSStaticWrapperObject_System_RuntimeMethodHandle();
            StaticTypes[typeof( RuntimeTypeHandle )] = new BSStaticWrapperObject_System_RuntimeTypeHandle();
            StaticTypes[typeof( Assembly )] = new BSStaticWrapperObject_System_Reflection_Assembly();
            StaticTypes[typeof( IPermission )] = new BSStaticWrapperObject_System_Security_IPermission();
            StaticTypes[typeof( FileStream )] = new BSStaticWrapperObject_System_IO_FileStream();
#if BS_UNITY_WIN
            StaticTypes[typeof( SafeFileHandle )] =
                new BSStaticWrapperObject_Microsoft_Win32_SafeHandles_SafeFileHandle();
            StaticTypes[typeof(SafeWaitHandle)] =
                new BSStaticWrapperObject_Microsoft_Win32_SafeHandles_SafeWaitHandle();
#endif
            StaticTypes[typeof( IAsyncResult )] = new BSStaticWrapperObject_System_IAsyncResult();
            StaticTypes[typeof( WaitHandle )] = new BSStaticWrapperObject_System_Threading_WaitHandle();

            
            StaticTypes[typeof( TimeSpan )] = new BSStaticWrapperObject_System_TimeSpan();
            StaticTypes[typeof( IDictionary )] = new BSStaticWrapperObject_System_Collections_IDictionary();
            StaticTypes[typeof( ICollection )] = new BSStaticWrapperObject_System_Collections_ICollection();

            StaticTypes[typeof( StreamingContext )] =
                new BSStaticWrapperObject_System_Runtime_Serialization_StreamingContext();

            StaticTypes[typeof( Task )] = new BSStaticWrapperObject_System_Threading_Tasks_Task();
            StaticTypes[typeof( TaskFactory )] = new BSStaticWrapperObject_System_Threading_Tasks_TaskFactory();
            StaticTypes[typeof( CancellationToken )] = new BSStaticWrapperObject_System_Threading_CancellationToken();

            StaticTypes[typeof( CancellationTokenRegistration )] =
                new BSStaticWrapperObject_System_Threading_CancellationTokenRegistration();

            StaticTypes[typeof( Action )] = new BSStaticWrapperObject_System_Action();
            StaticTypes[typeof( AsyncCallback )] = new BSStaticWrapperObject_System_AsyncCallback();
            StaticTypes[typeof( TaskScheduler )] = new BSStaticWrapperObject_System_Threading_Tasks_TaskScheduler();
            StaticTypes[typeof( AggregateException )] = new BSStaticWrapperObject_System_AggregateException();
            StaticTypes[typeof( Exception )] = new BSStaticWrapperObject_System_Exception();
            StaticTypes[typeof( MethodBase )] = new BSStaticWrapperObject_System_Reflection_MethodBase();

            StaticTypes[typeof( ConfiguredTaskAwaitable )] =
                new BSStaticWrapperObject_System_Runtime_CompilerServices_ConfiguredTaskAwaitable();

            StaticTypes[typeof( Stream )] = new BSStaticWrapperObject_System_IO_Stream();
            StaticTypes[typeof( AssemblyName )] = new BSStaticWrapperObject_System_Reflection_AssemblyName();
            StaticTypes[typeof( CultureInfo )] = new BSStaticWrapperObject_System_Globalization_CultureInfo();
            StaticTypes[typeof( Calendar )] = new BSStaticWrapperObject_System_Globalization_Calendar();
            StaticTypes[typeof( DateTime )] = new BSStaticWrapperObject_System_DateTime();
            StaticTypes[typeof( TextInfo )] = new BSStaticWrapperObject_System_Globalization_TextInfo();
            StaticTypes[typeof( char )] = new BSStaticWrapperObject_System_Char();
            StaticTypes[typeof( CompareInfo )] = new BSStaticWrapperObject_System_Globalization_CompareInfo();
            StaticTypes[typeof( SortVersion )] = new BSStaticWrapperObject_System_Globalization_SortVersion();
            StaticTypes[typeof( Guid )] = new BSStaticWrapperObject_System_Guid();
            StaticTypes[typeof( SortKey )] = new BSStaticWrapperObject_System_Globalization_SortKey();
            StaticTypes[typeof( NumberFormatInfo )] = new BSStaticWrapperObject_System_Globalization_NumberFormatInfo();

            StaticTypes[typeof( DateTimeFormatInfo )] =
                new BSStaticWrapperObject_System_Globalization_DateTimeFormatInfo();

            StaticTypes[typeof( StrongNameKeyPair )] = new BSStaticWrapperObject_System_Reflection_StrongNameKeyPair();
            StaticTypes[typeof( Version )] = new BSStaticWrapperObject_System_Version();

            StaticTypes[typeof( ManifestResourceInfo )] =
                new BSStaticWrapperObject_System_Reflection_ManifestResourceInfo();

            StaticTypes[typeof( TypeFilter )] = new BSStaticWrapperObject_System_Reflection_TypeFilter();
            StaticTypes[typeof( FieldInfo )] = new BSStaticWrapperObject_System_Reflection_FieldInfo();

            StaticTypes[typeof( ICustomAttributeProvider )] =
                new BSStaticWrapperObject_System_Reflection_ICustomAttributeProvider();

            StaticTypes[typeof( Delegate )] = new BSStaticWrapperObject_System_Delegate();
#if BS_UNITY_ANDROID
            StaticTypes[typeof( AndroidJavaException )] = new BSStaticWrapperObject_UnityEngine_AndroidJavaException();
            StaticTypes[typeof( AndroidJavaProxy )] = new BSStaticWrapperObject_UnityEngine_AndroidJavaProxy();
            StaticTypes[typeof( AndroidJavaClass )] = new BSStaticWrapperObject_UnityEngine_AndroidJavaClass();
            StaticTypes[typeof( AndroidJavaObject )] = new BSStaticWrapperObject_UnityEngine_AndroidJavaObject();
            StaticTypes[typeof( jvalue )] = new BSStaticWrapperObject_UnityEngine_jvalue();
            StaticTypes[typeof( AndroidJNIHelper )] = new BSStaticWrapperObject_UnityEngine_AndroidJNIHelper();
            StaticTypes[typeof(AndroidJNI)] = new BSStaticWrapperObject_UnityEngine_AndroidJNI();
            StaticTypes[typeof(AndroidDevice)] = new BSStaticWrapperObject_UnityEngine_Android_AndroidDevice();
            StaticTypes[typeof(PermissionCallbacks)] =
                new BSStaticWrapperObject_UnityEngine_Android_PermissionCallbacks();

            StaticTypes[typeof(Permission)] = new BSStaticWrapperObject_UnityEngine_Android_Permission();

#endif
            StaticTypes[typeof( Array )] = new BSStaticWrapperObject_System_Array();
            StaticTypes[typeof( IComparer )] = new BSStaticWrapperObject_System_Collections_IComparer();
            
            StaticTypes[typeof( Animator )] = new BSStaticWrapperObject_UnityEngine_Animator();

            StaticTypes[typeof( RuntimeAnimatorController )] =
                new BSStaticWrapperObject_UnityEngine_RuntimeAnimatorController();

            StaticTypes[typeof( Avatar )] = new BSStaticWrapperObject_UnityEngine_Avatar();
            StaticTypes[typeof( HumanDescription )] = new BSStaticWrapperObject_UnityEngine_HumanDescription();
            StaticTypes[typeof( PlayableGraph )] = new BSStaticWrapperObject_UnityEngine_Playables_PlayableGraph();
            StaticTypes[typeof( Playable )] = new BSStaticWrapperObject_UnityEngine_Playables_Playable();
            StaticTypes[typeof( PlayableOutput )] = new BSStaticWrapperObject_UnityEngine_Playables_PlayableOutput();
            StaticTypes[typeof( AnimatorStateInfo )] = new BSStaticWrapperObject_UnityEngine_AnimatorStateInfo();

            StaticTypes[typeof( AnimatorTransitionInfo )] =
                new BSStaticWrapperObject_UnityEngine_AnimatorTransitionInfo();

            StaticTypes[typeof( AnimatorControllerParameter )] =
                new BSStaticWrapperObject_UnityEngine_AnimatorControllerParameter();

            StaticTypes[typeof( IAnimationClipSource )] = new BSStaticWrapperObject_UnityEngine_IAnimationClipSource();

            StaticTypes[typeof( SharedBetweenAnimatorsAttribute )] =
                new BSStaticWrapperObject_UnityEngine_SharedBetweenAnimatorsAttribute();

            StaticTypes[typeof( StateMachineBehaviour )] =
                new BSStaticWrapperObject_UnityEngine_StateMachineBehaviour();

            StaticTypes[typeof( Animation )] = new BSStaticWrapperObject_UnityEngine_Animation();
            StaticTypes[typeof( AnimationClip )] = new BSStaticWrapperObject_UnityEngine_AnimationClip();
            StaticTypes[typeof( AnimationState )] = new BSStaticWrapperObject_UnityEngine_AnimationState();
            StaticTypes[typeof( AnimationEvent )] = new BSStaticWrapperObject_UnityEngine_AnimationEvent();
            StaticTypes[typeof( AnimatorClipInfo )] = new BSStaticWrapperObject_UnityEngine_AnimatorClipInfo();

            StaticTypes[typeof( MatchTargetWeightMask )] =
                new BSStaticWrapperObject_UnityEngine_MatchTargetWeightMask();

            StaticTypes[typeof( AnimationClipPair )] = new BSStaticWrapperObject_UnityEngine_AnimationClipPair();

            StaticTypes[typeof( AnimatorOverrideController )] =
                new BSStaticWrapperObject_UnityEngine_AnimatorOverrideController();

            StaticTypes[typeof( AnimatorUtility )] = new BSStaticWrapperObject_UnityEngine_AnimatorUtility();
            StaticTypes[typeof( SkeletonBone )] = new BSStaticWrapperObject_UnityEngine_SkeletonBone();
            StaticTypes[typeof( HumanLimit )] = new BSStaticWrapperObject_UnityEngine_HumanLimit();
            StaticTypes[typeof( HumanBone )] = new BSStaticWrapperObject_UnityEngine_HumanBone();
            StaticTypes[typeof( AvatarBuilder )] = new BSStaticWrapperObject_UnityEngine_AvatarBuilder();
            StaticTypes[typeof( AvatarMask )] = new BSStaticWrapperObject_UnityEngine_AvatarMask();
            StaticTypes[typeof( HumanPose )] = new BSStaticWrapperObject_UnityEngine_HumanPose();
            StaticTypes[typeof( HumanPoseHandler )] = new BSStaticWrapperObject_UnityEngine_HumanPoseHandler();
            StaticTypes[typeof( HumanTrait )] = new BSStaticWrapperObject_UnityEngine_HumanTrait();
            StaticTypes[typeof( Motion )] = new BSStaticWrapperObject_UnityEngine_Motion();

            StaticTypes[typeof( AnimationPlayableOutputExtensions )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Animations_AnimationPlayableOutputExtensions();

            StaticTypes[typeof( AnimationPlayableOutput )] =
                new BSStaticWrapperObject_UnityEngine_Animations_AnimationPlayableOutput();

            StaticTypes[typeof( AnimationPlayableUtilities )] =
                new BSStaticWrapperObject_UnityEngine_Playables_AnimationPlayableUtilities();

            StaticTypes[typeof( AnimationPlayableBinding )] =
                new BSStaticWrapperObject_UnityEngine_Animations_AnimationPlayableBinding();

            StaticTypes[typeof( PlayableBinding )] = new BSStaticWrapperObject_UnityEngine_Playables_PlayableBinding();
            StaticTypes[typeof( IAnimationJob )] = new BSStaticWrapperObject_UnityEngine_Animations_IAnimationJob();

            StaticTypes[typeof( IAnimationJobPlayable )] =
                new BSStaticWrapperObject_UnityEngine_Animations_IAnimationJobPlayable();

            StaticTypes[typeof( IAnimationWindowPreview )] =
                new BSStaticWrapperObject_UnityEngine_Animations_IAnimationWindowPreview();

            StaticTypes[typeof( NotKeyableAttribute )] =
                new BSStaticWrapperObject_UnityEngine_Animations_NotKeyableAttribute();

            StaticTypes[typeof( AimConstraint )] = new BSStaticWrapperObject_UnityEngine_Animations_AimConstraint();

            StaticTypes[typeof( ConstraintSource )] =
                new BSStaticWrapperObject_UnityEngine_Animations_ConstraintSource();

            StaticTypes[typeof( AnimationClipPlayable )] =
                new BSStaticWrapperObject_UnityEngine_Animations_AnimationClipPlayable();

            StaticTypes[typeof( AnimationHumanStream )] =
                new BSStaticWrapperObject_UnityEngine_Animations_AnimationHumanStream();

            StaticTypes[typeof( MuscleHandle )] = new BSStaticWrapperObject_UnityEngine_Animations_MuscleHandle();

            StaticTypes[typeof( AnimationLayerMixerPlayable )] =
                new BSStaticWrapperObject_UnityEngine_Animations_AnimationLayerMixerPlayable();

            StaticTypes[typeof( AnimationMixerPlayable )] =
                new BSStaticWrapperObject_UnityEngine_Animations_AnimationMixerPlayable();

            StaticTypes[typeof( AnimationPlayableExtensions )] =
                new BSStaticWrapperObject_UnityEngine_Animations_AnimationPlayableExtensions();

            StaticTypes[typeof( AnimationScriptPlayable )] =
                new BSStaticWrapperObject_UnityEngine_Animations_AnimationScriptPlayable();

            StaticTypes[typeof( AnimationStream )] = new BSStaticWrapperObject_UnityEngine_Animations_AnimationStream();

            StaticTypes[typeof( TransformStreamHandle )] =
                new BSStaticWrapperObject_UnityEngine_Animations_TransformStreamHandle();

            StaticTypes[typeof( PropertyStreamHandle )] =
                new BSStaticWrapperObject_UnityEngine_Animations_PropertyStreamHandle();

            StaticTypes[typeof( TransformSceneHandle )] =
                new BSStaticWrapperObject_UnityEngine_Animations_TransformSceneHandle();

            StaticTypes[typeof( PropertySceneHandle )] =
                new BSStaticWrapperObject_UnityEngine_Animations_PropertySceneHandle();

            StaticTypes[typeof( AnimationSceneHandleUtility )] =
                new BSStaticWrapperObject_UnityEngine_Animations_AnimationSceneHandleUtility();

            StaticTypes[typeof( AnimationStreamHandleUtility )] =
                new BSStaticWrapperObject_UnityEngine_Animations_AnimationStreamHandleUtility();

            StaticTypes[typeof( AnimatorControllerPlayable )] =
                new BSStaticWrapperObject_UnityEngine_Animations_AnimatorControllerPlayable();

            StaticTypes[typeof( AnimatorJobExtensions )] =
                new BSStaticWrapperObject_UnityEngine_Animations_AnimatorJobExtensions();

            StaticTypes[typeof( IConstraint )] = new BSStaticWrapperObject_UnityEngine_Animations_IConstraint();

            StaticTypes[typeof( PositionConstraint )] =
                new BSStaticWrapperObject_UnityEngine_Animations_PositionConstraint();

            StaticTypes[typeof( RotationConstraint )] =
                new BSStaticWrapperObject_UnityEngine_Animations_RotationConstraint();

            StaticTypes[typeof( ScaleConstraint )] = new BSStaticWrapperObject_UnityEngine_Animations_ScaleConstraint();

            StaticTypes[typeof( LookAtConstraint )] =
                new BSStaticWrapperObject_UnityEngine_Animations_LookAtConstraint();

            StaticTypes[typeof( ParentConstraint )] =
                new BSStaticWrapperObject_UnityEngine_Animations_ParentConstraint();

            StaticTypes[typeof( AssetBundle )] = new BSStaticWrapperObject_UnityEngine_AssetBundle();
            StaticTypes[typeof( AssetBundleRequest )] = new BSStaticWrapperObject_UnityEngine_AssetBundleRequest();

            StaticTypes[typeof( AssetBundleCreateRequest )] =
                new BSStaticWrapperObject_UnityEngine_AssetBundleCreateRequest();

            StaticTypes[typeof( AssetBundleRecompressOperation )] =
                new BSStaticWrapperObject_UnityEngine_AssetBundleRecompressOperation();

            StaticTypes[typeof( BuildCompression )] = new BSStaticWrapperObject_UnityEngine_BuildCompression();
            StaticTypes[typeof( AssetBundleManifest )] = new BSStaticWrapperObject_UnityEngine_AssetBundleManifest();
            StaticTypes[typeof( Hash128 )] = new BSStaticWrapperObject_UnityEngine_Hash128();

            StaticTypes[typeof( AssetBundleUtility )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_AssetBundlePatching_AssetBundleUtility();

            StaticTypes[typeof( AudioSettings )] = new BSStaticWrapperObject_UnityEngine_AudioSettings();
            StaticTypes[typeof( AudioConfiguration )] = new BSStaticWrapperObject_UnityEngine_AudioConfiguration();
            StaticTypes[typeof( AudioSource )] = new BSStaticWrapperObject_UnityEngine_AudioSource();
            StaticTypes[typeof( AudioClip )] = new BSStaticWrapperObject_UnityEngine_AudioClip();
            StaticTypes[typeof( AudioMixerGroup )] = new BSStaticWrapperObject_UnityEngine_Audio_AudioMixerGroup();
            StaticTypes[typeof( AudioMixer )] = new BSStaticWrapperObject_UnityEngine_Audio_AudioMixer();

            StaticTypes[typeof( AudioMixerSnapshot )] =
                new BSStaticWrapperObject_UnityEngine_Audio_AudioMixerSnapshot();

            StaticTypes[typeof( AnimationCurve )] = new BSStaticWrapperObject_UnityEngine_AnimationCurve();
            StaticTypes[typeof( Keyframe )] = new BSStaticWrapperObject_UnityEngine_Keyframe();
            StaticTypes[typeof( AudioLowPassFilter )] = new BSStaticWrapperObject_UnityEngine_AudioLowPassFilter();
            StaticTypes[typeof( AudioHighPassFilter )] = new BSStaticWrapperObject_UnityEngine_AudioHighPassFilter();
            StaticTypes[typeof( AudioReverbFilter )] = new BSStaticWrapperObject_UnityEngine_AudioReverbFilter();
            StaticTypes[typeof( AudioBehaviour )] = new BSStaticWrapperObject_UnityEngine_AudioBehaviour();
            StaticTypes[typeof( AudioListener )] = new BSStaticWrapperObject_UnityEngine_AudioListener();
            StaticTypes[typeof( AudioReverbZone )] = new BSStaticWrapperObject_UnityEngine_AudioReverbZone();

            StaticTypes[typeof( AudioDistortionFilter )] =
                new BSStaticWrapperObject_UnityEngine_AudioDistortionFilter();

            StaticTypes[typeof( AudioEchoFilter )] = new BSStaticWrapperObject_UnityEngine_AudioEchoFilter();
            StaticTypes[typeof( AudioChorusFilter )] = new BSStaticWrapperObject_UnityEngine_AudioChorusFilter();
            StaticTypes[typeof( Microphone )] = new BSStaticWrapperObject_UnityEngine_Microphone();
            StaticTypes[typeof( AudioRenderer )] = new BSStaticWrapperObject_UnityEngine_AudioRenderer();
            StaticTypes[typeof( WebCamDevice )] = new BSStaticWrapperObject_UnityEngine_WebCamDevice();
            StaticTypes[typeof( WebCamTexture )] = new BSStaticWrapperObject_UnityEngine_WebCamTexture();
            StaticTypes[typeof( Vector2 )] = new BSStaticWrapperObject_UnityEngine_Vector2();
            StaticTypes[typeof( Color )] = new BSStaticWrapperObject_UnityEngine_Color();
            StaticTypes[typeof( AudioClipPlayable )] = new BSStaticWrapperObject_UnityEngine_Audio_AudioClipPlayable();

            StaticTypes[typeof( AudioMixerPlayable )] =
                new BSStaticWrapperObject_UnityEngine_Audio_AudioMixerPlayable();

            StaticTypes[typeof( AudioPlayableBinding )] =
                new BSStaticWrapperObject_UnityEngine_Audio_AudioPlayableBinding();

            StaticTypes[typeof( AudioPlayableOutput )] =
                new BSStaticWrapperObject_UnityEngine_Audio_AudioPlayableOutput();

            StaticTypes[typeof( AudioSampleProvider )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Audio_AudioSampleProvider();

            StaticTypes[typeof( ClothSphereColliderPair )] =
                new BSStaticWrapperObject_UnityEngine_ClothSphereColliderPair();

            StaticTypes[typeof( SphereCollider )] = new BSStaticWrapperObject_UnityEngine_SphereCollider();
            StaticTypes[typeof( Rigidbody )] = new BSStaticWrapperObject_UnityEngine_Rigidbody();
            StaticTypes[typeof( ArticulationBody )] = new BSStaticWrapperObject_UnityEngine_ArticulationBody();
            StaticTypes[typeof( ArticulationDrive )] = new BSStaticWrapperObject_UnityEngine_ArticulationDrive();

            StaticTypes[typeof( ArticulationReducedSpace )] =
                new BSStaticWrapperObject_UnityEngine_ArticulationReducedSpace();

            StaticTypes[typeof( PhysicMaterial )] = new BSStaticWrapperObject_UnityEngine_PhysicMaterial();

            StaticTypes[typeof( ClothSkinningCoefficient )] =
                new BSStaticWrapperObject_UnityEngine_ClothSkinningCoefficient();

            StaticTypes[typeof( Cloth )] = new BSStaticWrapperObject_UnityEngine_Cloth();
            StaticTypes[typeof( ClusterInput )] = new BSStaticWrapperObject_UnityEngine_ClusterInput();
            StaticTypes[typeof( ClusterNetwork )] = new BSStaticWrapperObject_UnityEngine_ClusterNetwork();
            StaticTypes[typeof( ClusterSerialization )] = new BSStaticWrapperObject_UnityEngine_ClusterSerialization();

            StaticTypes[typeof( GIDebugVisualisation )] =
                new BSStaticWrapperObject_UnityEngineInternal_GIDebugVisualisation();

            StaticTypes[typeof( MemorylessManager )] =
                new BSStaticWrapperObject_UnityEngineInternal_MemorylessManager();

            StaticTypes[typeof( MathfInternal )] = new BSStaticWrapperObject_UnityEngineInternal_MathfInternal();

            StaticTypes[typeof( APIUpdaterRuntimeServices )] =
                new BSStaticWrapperObject_UnityEngineInternal_APIUpdaterRuntimeServices();

            StaticTypes[typeof( TypeInferenceRuleAttribute )] =
                new BSStaticWrapperObject_UnityEngineInternal_TypeInferenceRuleAttribute();

            StaticTypes[typeof( GenericStack )] = new BSStaticWrapperObject_UnityEngineInternal_GenericStack();
            StaticTypes[typeof( SortingLayer )] = new BSStaticWrapperObject_UnityEngine_SortingLayer();
            StaticTypes[typeof( Application )] = new BSStaticWrapperObject_UnityEngine_Application();
            StaticTypes[typeof( CachedAssetBundle )] = new BSStaticWrapperObject_UnityEngine_CachedAssetBundle();
            StaticTypes[typeof( Cache )] = new BSStaticWrapperObject_UnityEngine_Cache();
            StaticTypes[typeof( CacheIndex )] = new BSStaticWrapperObject_UnityEngine_CacheIndex();
            StaticTypes[typeof( Caching )] = new BSStaticWrapperObject_UnityEngine_Caching();
            StaticTypes[typeof( Camera )] = new BSStaticWrapperObject_UnityEngine_Camera();
            StaticTypes[typeof( Rect )] = new BSStaticWrapperObject_UnityEngine_Rect();
            StaticTypes[typeof( RenderTexture )] = new BSStaticWrapperObject_UnityEngine_RenderTexture();
            StaticTypes[typeof( RenderBuffer )] = new BSStaticWrapperObject_UnityEngine_RenderBuffer();

            StaticTypes[typeof( RenderTextureDescriptor )] =
                new BSStaticWrapperObject_UnityEngine_RenderTextureDescriptor();

            StaticTypes[typeof( Cubemap )] = new BSStaticWrapperObject_UnityEngine_Cubemap();
            StaticTypes[typeof( BoundingSphere )] = new BSStaticWrapperObject_UnityEngine_BoundingSphere();
            StaticTypes[typeof( CullingGroupEvent )] = new BSStaticWrapperObject_UnityEngine_CullingGroupEvent();
            StaticTypes[typeof( CullingGroup )] = new BSStaticWrapperObject_UnityEngine_CullingGroup();
            StaticTypes[typeof( FlareLayer )] = new BSStaticWrapperObject_UnityEngine_FlareLayer();
            StaticTypes[typeof( ReflectionProbe )] = new BSStaticWrapperObject_UnityEngine_ReflectionProbe();
            StaticTypes[typeof( Texture )] = new BSStaticWrapperObject_UnityEngine_Texture();
            StaticTypes[typeof( CrashReport )] = new BSStaticWrapperObject_UnityEngine_CrashReport();
            StaticTypes[typeof( Debug )] = new BSStaticWrapperObject_UnityEngine_Debug();
            StaticTypes[typeof( ILogger )] = new BSStaticWrapperObject_UnityEngine_ILogger();
            StaticTypes[typeof( ILogHandler )] = new BSStaticWrapperObject_UnityEngine_ILogHandler();

            StaticTypes[typeof( ExposedPropertyResolver )] =
                new BSStaticWrapperObject_UnityEngine_ExposedPropertyResolver();

            StaticTypes[typeof( IExposedPropertyTable )] =
                new BSStaticWrapperObject_UnityEngine_IExposedPropertyTable();

            StaticTypes[typeof( EventProvider )] = new BSStaticWrapperObject_UnityEngine_EventProvider();
            StaticTypes[typeof( BoundsInt )] = new BSStaticWrapperObject_UnityEngine_BoundsInt();
            StaticTypes[typeof( Vector3Int )] = new BSStaticWrapperObject_UnityEngine_Vector3Int();
            StaticTypes[typeof( GeometryUtility )] = new BSStaticWrapperObject_UnityEngine_GeometryUtility();
            StaticTypes[typeof( Ray2D )] = new BSStaticWrapperObject_UnityEngine_Ray2D();
            StaticTypes[typeof( RectInt )] = new BSStaticWrapperObject_UnityEngine_RectInt();
            StaticTypes[typeof( Vector2Int )] = new BSStaticWrapperObject_UnityEngine_Vector2Int();
            StaticTypes[typeof( RectOffset )] = new BSStaticWrapperObject_UnityEngine_RectOffset();
            StaticTypes[typeof( DynamicGI )] = new BSStaticWrapperObject_UnityEngine_DynamicGI();
            StaticTypes[typeof( LightingSettings )] = new BSStaticWrapperObject_UnityEngine_LightingSettings();
            StaticTypes[typeof( Gizmos )] = new BSStaticWrapperObject_UnityEngine_Gizmos();

            StaticTypes[typeof( BeforeRenderOrderAttribute )] =
                new BSStaticWrapperObject_UnityEngine_BeforeRenderOrderAttribute();

            StaticTypes[typeof( BillboardAsset )] = new BSStaticWrapperObject_UnityEngine_BillboardAsset();
            StaticTypes[typeof( Material )] = new BSStaticWrapperObject_UnityEngine_Material();
            StaticTypes[typeof( Shader )] = new BSStaticWrapperObject_UnityEngine_Shader();
            StaticTypes[typeof( ShaderTagId )] = new BSStaticWrapperObject_UnityEngine_Rendering_ShaderTagId();
            StaticTypes[typeof( BillboardRenderer )] = new BSStaticWrapperObject_UnityEngine_BillboardRenderer();

            StaticTypes[typeof( CustomRenderTextureManager )] =
                new BSStaticWrapperObject_UnityEngine_CustomRenderTextureManager();

            StaticTypes[typeof( Display )] = new BSStaticWrapperObject_UnityEngine_Display();
            StaticTypes[typeof( SleepTimeout )] = new BSStaticWrapperObject_UnityEngine_SleepTimeout();
            StaticTypes[typeof( Screen )] = new BSStaticWrapperObject_UnityEngine_Screen();
            StaticTypes[typeof( Resolution )] = new BSStaticWrapperObject_UnityEngine_Resolution();
            StaticTypes[typeof( Graphics )] = new BSStaticWrapperObject_UnityEngine_Graphics();
            StaticTypes[typeof( GraphicsFence )] = new BSStaticWrapperObject_UnityEngine_Rendering_GraphicsFence();
            StaticTypes[typeof( GL )] = new BSStaticWrapperObject_UnityEngine_GL();

            StaticTypes[typeof( ScalableBufferManager )] =
                new BSStaticWrapperObject_UnityEngine_ScalableBufferManager();

            StaticTypes[typeof( FrameTiming )] = new BSStaticWrapperObject_UnityEngine_FrameTiming();
            StaticTypes[typeof( FrameTimingManager )] = new BSStaticWrapperObject_UnityEngine_FrameTimingManager();
            StaticTypes[typeof( LightmapData )] = new BSStaticWrapperObject_UnityEngine_LightmapData();
            StaticTypes[typeof( Texture2D )] = new BSStaticWrapperObject_UnityEngine_Texture2D();
            StaticTypes[typeof( LightmapSettings )] = new BSStaticWrapperObject_UnityEngine_LightmapSettings();
            StaticTypes[typeof( LightProbes )] = new BSStaticWrapperObject_UnityEngine_LightProbes();
            StaticTypes[typeof( HDROutputSettings )] = new BSStaticWrapperObject_UnityEngine_HDROutputSettings();
            StaticTypes[typeof( RenderTargetSetup )] = new BSStaticWrapperObject_UnityEngine_RenderTargetSetup();
            StaticTypes[typeof( QualitySettings )] = new BSStaticWrapperObject_UnityEngine_QualitySettings();

            StaticTypes[typeof( RenderPipelineAsset )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_RenderPipelineAsset();

            StaticTypes[typeof( RendererExtensions )] = new BSStaticWrapperObject_UnityEngine_RendererExtensions();

            StaticTypes[typeof( ImageEffectTransformsToLDR )] =
                new BSStaticWrapperObject_UnityEngine_ImageEffectTransformsToLDR();

            StaticTypes[typeof( ImageEffectAllowedInSceneView )] =
                new BSStaticWrapperObject_UnityEngine_ImageEffectAllowedInSceneView();

            StaticTypes[typeof( ImageEffectOpaque )] = new BSStaticWrapperObject_UnityEngine_ImageEffectOpaque();

            StaticTypes[typeof( ImageEffectAfterScale )] =
                new BSStaticWrapperObject_UnityEngine_ImageEffectAfterScale();

            StaticTypes[typeof( ImageEffectUsesCommandBuffer )] =
                new BSStaticWrapperObject_UnityEngine_ImageEffectUsesCommandBuffer();

            StaticTypes[typeof( Mesh )] = new BSStaticWrapperObject_UnityEngine_Mesh();

            StaticTypes[typeof( VertexAttributeDescriptor )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_VertexAttributeDescriptor();

            StaticTypes[typeof( SubMeshDescriptor )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_SubMeshDescriptor();

            StaticTypes[typeof( Renderer )] = new BSStaticWrapperObject_UnityEngine_Renderer();
            StaticTypes[typeof( Projector )] = new BSStaticWrapperObject_UnityEngine_Projector();
            StaticTypes[typeof( TrailRenderer )] = new BSStaticWrapperObject_UnityEngine_TrailRenderer();
            StaticTypes[typeof( Gradient )] = new BSStaticWrapperObject_UnityEngine_Gradient();
            StaticTypes[typeof( LineRenderer )] = new BSStaticWrapperObject_UnityEngine_LineRenderer();

            StaticTypes[typeof( MaterialPropertyBlock )] =
                new BSStaticWrapperObject_UnityEngine_MaterialPropertyBlock();

            StaticTypes[typeof( RenderSettings )] = new BSStaticWrapperObject_UnityEngine_RenderSettings();
            StaticTypes[typeof( Light )] = new BSStaticWrapperObject_UnityEngine_Light();
            StaticTypes[typeof( Flare )] = new BSStaticWrapperObject_UnityEngine_Flare();
            StaticTypes[typeof( LightBakingOutput )] = new BSStaticWrapperObject_UnityEngine_LightBakingOutput();

            StaticTypes[typeof( SphericalHarmonicsL2 )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_SphericalHarmonicsL2();

            StaticTypes[typeof( GraphicsBuffer )] = new BSStaticWrapperObject_UnityEngine_GraphicsBuffer();
            StaticTypes[typeof( OcclusionPortal )] = new BSStaticWrapperObject_UnityEngine_OcclusionPortal();
            StaticTypes[typeof( OcclusionArea )] = new BSStaticWrapperObject_UnityEngine_OcclusionArea();
            StaticTypes[typeof( LensFlare )] = new BSStaticWrapperObject_UnityEngine_LensFlare();
            StaticTypes[typeof( Skybox )] = new BSStaticWrapperObject_UnityEngine_Skybox();
            StaticTypes[typeof( MeshFilter )] = new BSStaticWrapperObject_UnityEngine_MeshFilter();

            StaticTypes[typeof( LightProbeProxyVolume )] =
                new BSStaticWrapperObject_UnityEngine_LightProbeProxyVolume();

            StaticTypes[typeof( SkinnedMeshRenderer )] = new BSStaticWrapperObject_UnityEngine_SkinnedMeshRenderer();
            StaticTypes[typeof( MeshRenderer )] = new BSStaticWrapperObject_UnityEngine_MeshRenderer();
            StaticTypes[typeof( LightProbeGroup )] = new BSStaticWrapperObject_UnityEngine_LightProbeGroup();
            StaticTypes[typeof( LineUtility )] = new BSStaticWrapperObject_UnityEngine_LineUtility();
            StaticTypes[typeof( LOD )] = new BSStaticWrapperObject_UnityEngine_LOD();
            StaticTypes[typeof( LODGroup )] = new BSStaticWrapperObject_UnityEngine_LODGroup();
            StaticTypes[typeof( BoneWeight )] = new BSStaticWrapperObject_UnityEngine_BoneWeight();
            StaticTypes[typeof( BoneWeight1 )] = new BSStaticWrapperObject_UnityEngine_BoneWeight1();
            StaticTypes[typeof( CombineInstance )] = new BSStaticWrapperObject_UnityEngine_CombineInstance();
            StaticTypes[typeof( Texture3D )] = new BSStaticWrapperObject_UnityEngine_Texture3D();
            StaticTypes[typeof( Texture2DArray )] = new BSStaticWrapperObject_UnityEngine_Texture2DArray();
            StaticTypes[typeof( CubemapArray )] = new BSStaticWrapperObject_UnityEngine_CubemapArray();
            StaticTypes[typeof( SparseTexture )] = new BSStaticWrapperObject_UnityEngine_SparseTexture();

            StaticTypes[typeof( CustomRenderTextureUpdateZone )] =
                new BSStaticWrapperObject_UnityEngine_CustomRenderTextureUpdateZone();

            StaticTypes[typeof( CustomRenderTexture )] = new BSStaticWrapperObject_UnityEngine_CustomRenderTexture();
            StaticTypes[typeof( Handheld )] = new BSStaticWrapperObject_UnityEngine_Handheld();
            StaticTypes[typeof( HashUtilities )] = new BSStaticWrapperObject_UnityEngine_HashUtilities();
            StaticTypes[typeof( HashUnsafeUtilities )] = new BSStaticWrapperObject_UnityEngine_HashUnsafeUtilities();
            StaticTypes[typeof( Cursor )] = new BSStaticWrapperObject_UnityEngine_Cursor();
            StaticTypes[typeof( iPhoneSettings )] = new BSStaticWrapperObject_UnityEngine_iPhoneSettings();
            StaticTypes[typeof( iPhoneUtils )] = new BSStaticWrapperObject_UnityEngine_iPhoneUtils();
            StaticTypes[typeof( Logger )] = new BSStaticWrapperObject_UnityEngine_Logger();
            StaticTypes[typeof( Color32 )] = new BSStaticWrapperObject_UnityEngine_Color32();
            StaticTypes[typeof( ColorUtility )] = new BSStaticWrapperObject_UnityEngine_ColorUtility();
            StaticTypes[typeof( GradientColorKey )] = new BSStaticWrapperObject_UnityEngine_GradientColorKey();
            StaticTypes[typeof( GradientAlphaKey )] = new BSStaticWrapperObject_UnityEngine_GradientAlphaKey();
            StaticTypes[typeof( Mathf )] = new BSStaticWrapperObject_UnityEngine_Mathf();
            StaticTypes[typeof( Ping )] = new BSStaticWrapperObject_UnityEngine_Ping();
            StaticTypes[typeof( PlayerPrefsException )] = new BSStaticWrapperObject_UnityEngine_PlayerPrefsException();
            StaticTypes[typeof( PlayerPrefs )] = new BSStaticWrapperObject_UnityEngine_PlayerPrefs();
            StaticTypes[typeof( PropertyAttribute )] = new BSStaticWrapperObject_UnityEngine_PropertyAttribute();

            StaticTypes[typeof( ContextMenuItemAttribute )] =
                new BSStaticWrapperObject_UnityEngine_ContextMenuItemAttribute();

            StaticTypes[typeof( InspectorNameAttribute )] =
                new BSStaticWrapperObject_UnityEngine_InspectorNameAttribute();

            StaticTypes[typeof( TooltipAttribute )] = new BSStaticWrapperObject_UnityEngine_TooltipAttribute();
            StaticTypes[typeof( SpaceAttribute )] = new BSStaticWrapperObject_UnityEngine_SpaceAttribute();
            StaticTypes[typeof( HeaderAttribute )] = new BSStaticWrapperObject_UnityEngine_HeaderAttribute();
            StaticTypes[typeof( RangeAttribute )] = new BSStaticWrapperObject_UnityEngine_RangeAttribute();
            StaticTypes[typeof( MinAttribute )] = new BSStaticWrapperObject_UnityEngine_MinAttribute();
            StaticTypes[typeof( MultilineAttribute )] = new BSStaticWrapperObject_UnityEngine_MultilineAttribute();
            StaticTypes[typeof( TextAreaAttribute )] = new BSStaticWrapperObject_UnityEngine_TextAreaAttribute();
            StaticTypes[typeof( ColorUsageAttribute )] = new BSStaticWrapperObject_UnityEngine_ColorUsageAttribute();

            StaticTypes[typeof( GradientUsageAttribute )] =
                new BSStaticWrapperObject_UnityEngine_GradientUsageAttribute();

            StaticTypes[typeof( DelayedAttribute )] = new BSStaticWrapperObject_UnityEngine_DelayedAttribute();

            StaticTypes[typeof( NonReorderableAttribute )] =
                new BSStaticWrapperObject_UnityEngine_NonReorderableAttribute();

            StaticTypes[typeof( PropertyName )] = new BSStaticWrapperObject_UnityEngine_PropertyName();
            StaticTypes[typeof( Random )] = new BSStaticWrapperObject_UnityEngine_Random();
            StaticTypes[typeof( ResourceRequest )] = new BSStaticWrapperObject_UnityEngine_ResourceRequest();
            StaticTypes[typeof( ResourcesAPI )] = new BSStaticWrapperObject_UnityEngine_ResourcesAPI();
            StaticTypes[typeof( Resources )] = new BSStaticWrapperObject_UnityEngine_Resources();

            StaticTypes[typeof( DisallowMultipleComponent )] =
                new BSStaticWrapperObject_UnityEngine_DisallowMultipleComponent();

            StaticTypes[typeof( RequireComponent )] = new BSStaticWrapperObject_UnityEngine_RequireComponent();
            StaticTypes[typeof( AddComponentMenu )] = new BSStaticWrapperObject_UnityEngine_AddComponentMenu();

            StaticTypes[typeof( CreateAssetMenuAttribute )] =
                new BSStaticWrapperObject_UnityEngine_CreateAssetMenuAttribute();

            StaticTypes[typeof( ContextMenu )] = new BSStaticWrapperObject_UnityEngine_ContextMenu();
            StaticTypes[typeof( ExecuteInEditMode )] = new BSStaticWrapperObject_UnityEngine_ExecuteInEditMode();
            StaticTypes[typeof( ExecuteAlways )] = new BSStaticWrapperObject_UnityEngine_ExecuteAlways();
            StaticTypes[typeof( HideInInspector )] = new BSStaticWrapperObject_UnityEngine_HideInInspector();
            StaticTypes[typeof( HelpURLAttribute )] = new BSStaticWrapperObject_UnityEngine_HelpURLAttribute();

            StaticTypes[typeof( DefaultExecutionOrder )] =
                new BSStaticWrapperObject_UnityEngine_DefaultExecutionOrder();

            StaticTypes[typeof( AssemblyIsEditorAssembly )] =
                new BSStaticWrapperObject_UnityEngine_AssemblyIsEditorAssembly();

            StaticTypes[typeof( ExcludeFromPresetAttribute )] =
                new BSStaticWrapperObject_UnityEngine_ExcludeFromPresetAttribute();

            StaticTypes[typeof( Behaviour )] = new BSStaticWrapperObject_UnityEngine_Behaviour();
            StaticTypes[typeof( Coroutine )] = new BSStaticWrapperObject_UnityEngine_Coroutine();

            StaticTypes[typeof( CustomYieldInstruction )] =
                new BSStaticWrapperObject_UnityEngine_CustomYieldInstruction();

            StaticTypes[typeof( ExcludeFromObjectFactoryAttribute )] =
                new BSStaticWrapperObject_UnityEngine_ExcludeFromObjectFactoryAttribute();

            StaticTypes[typeof( LayerMask )] = new BSStaticWrapperObject_UnityEngine_LayerMask();
            StaticTypes[typeof( MonoBehaviour )] = new BSStaticWrapperObject_UnityEngine_MonoBehaviour();
            StaticTypes[typeof( IEnumerator )] = new BSStaticWrapperObject_System_Collections_IEnumerator();
            StaticTypes[typeof( RangeInt )] = new BSStaticWrapperObject_UnityEngine_RangeInt();

            StaticTypes[typeof( RuntimeInitializeOnLoadMethodAttribute )] =
                new BSStaticWrapperObject_UnityEngine_RuntimeInitializeOnLoadMethodAttribute();

            StaticTypes[typeof( ScriptableObject )] = new BSStaticWrapperObject_UnityEngine_ScriptableObject();

            StaticTypes[typeof( SelectionBaseAttribute )] =
                new BSStaticWrapperObject_UnityEngine_SelectionBaseAttribute();

            StaticTypes[typeof( StackTraceUtility )] = new BSStaticWrapperObject_UnityEngine_StackTraceUtility();
            StaticTypes[typeof( UnityException )] = new BSStaticWrapperObject_UnityEngine_UnityException();

            StaticTypes[typeof( MissingComponentException )] =
                new BSStaticWrapperObject_UnityEngine_MissingComponentException();

            StaticTypes[typeof( UnassignedReferenceException )] =
                new BSStaticWrapperObject_UnityEngine_UnassignedReferenceException();

            StaticTypes[typeof( MissingReferenceException )] =
                new BSStaticWrapperObject_UnityEngine_MissingReferenceException();

            StaticTypes[typeof( TextAsset )] = new BSStaticWrapperObject_UnityEngine_TextAsset();
            StaticTypes[typeof( TrackedReference )] = new BSStaticWrapperObject_UnityEngine_TrackedReference();

            StaticTypes[typeof( UnityAPICompatibilityVersionAttribute )] =
                new BSStaticWrapperObject_UnityEngine_UnityAPICompatibilityVersionAttribute();

            StaticTypes[typeof( WaitForEndOfFrame )] = new BSStaticWrapperObject_UnityEngine_WaitForEndOfFrame();
            StaticTypes[typeof( WaitForFixedUpdate )] = new BSStaticWrapperObject_UnityEngine_WaitForFixedUpdate();
            StaticTypes[typeof( WaitForSeconds )] = new BSStaticWrapperObject_UnityEngine_WaitForSeconds();

            StaticTypes[typeof( WaitForSecondsRealtime )] =
                new BSStaticWrapperObject_UnityEngine_WaitForSecondsRealtime();

            StaticTypes[typeof( WaitUntil )] = new BSStaticWrapperObject_UnityEngine_WaitUntil();
            StaticTypes[typeof( WaitWhile )] = new BSStaticWrapperObject_UnityEngine_WaitWhile();
            StaticTypes[typeof( YieldInstruction )] = new BSStaticWrapperObject_UnityEngine_YieldInstruction();
            StaticTypes[typeof( Security )] = new BSStaticWrapperObject_UnityEngine_Security();
            StaticTypes[typeof( Types )] = new BSStaticWrapperObject_UnityEngine_Types();
            StaticTypes[typeof( SerializeField )] = new BSStaticWrapperObject_UnityEngine_SerializeField();
            StaticTypes[typeof( SerializeReference )] = new BSStaticWrapperObject_UnityEngine_SerializeReference();

            StaticTypes[typeof( PreferBinarySerialization )] =
                new BSStaticWrapperObject_UnityEngine_PreferBinarySerialization();

            StaticTypes[typeof( ISerializationCallbackReceiver )] =
                new BSStaticWrapperObject_UnityEngine_ISerializationCallbackReceiver();

            StaticTypes[typeof( ComputeBuffer )] = new BSStaticWrapperObject_UnityEngine_ComputeBuffer();

            StaticTypes[typeof( ShaderVariantCollection )] =
                new BSStaticWrapperObject_UnityEngine_ShaderVariantCollection();

            StaticTypes[typeof( ComputeShader )] = new BSStaticWrapperObject_UnityEngine_ComputeShader();
            StaticTypes[typeof( Snapping )] = new BSStaticWrapperObject_UnityEngine_Snapping();

            StaticTypes[typeof( StaticBatchingUtility )] =
                new BSStaticWrapperObject_UnityEngine_StaticBatchingUtility();

            StaticTypes[typeof( SystemInfo )] = new BSStaticWrapperObject_UnityEngine_SystemInfo();
            StaticTypes[typeof( Time )] = new BSStaticWrapperObject_UnityEngine_Time();
            StaticTypes[typeof( TouchScreenKeyboard )] = new BSStaticWrapperObject_UnityEngine_TouchScreenKeyboard();

            StaticTypes[typeof( UnityEventQueueSystem )] =
                new BSStaticWrapperObject_UnityEngine_UnityEventQueueSystem();

            StaticTypes[typeof( Pose )] = new BSStaticWrapperObject_UnityEngine_Pose();

            StaticTypes[typeof( DrivenRectTransformTracker )] =
                new BSStaticWrapperObject_UnityEngine_DrivenRectTransformTracker();

            StaticTypes[typeof( RectTransform )] = new BSStaticWrapperObject_UnityEngine_RectTransform();
            StaticTypes[typeof( SpriteRenderer )] = new BSStaticWrapperObject_UnityEngine_SpriteRenderer();
            StaticTypes[typeof( Sprite )] = new BSStaticWrapperObject_UnityEngine_Sprite();

            StaticTypes[typeof( SecondarySpriteTexture )] =
                new BSStaticWrapperObject_UnityEngine_SecondarySpriteTexture();

            StaticTypes[typeof( DataUtility )] = new BSStaticWrapperObject_UnityEngine_Sprites_DataUtility();

            StaticTypes[typeof( PixelPerfectRendering )] =
                new BSStaticWrapperObject_UnityEngine_U2D_PixelPerfectRendering();

            StaticTypes[typeof( SpriteBone )] = new BSStaticWrapperObject_UnityEngine_U2D_SpriteBone();

            StaticTypes[typeof( SpriteDataAccessExtensions )] =
                new BSStaticWrapperObject_UnityEngine_U2D_SpriteDataAccessExtensions();

            StaticTypes[typeof( SpriteRendererDataAccessExtensions )] =
                new BSStaticWrapperObject_UnityEngine_U2D_SpriteRendererDataAccessExtensions();

            StaticTypes[typeof( SpriteAtlasManager )] = new BSStaticWrapperObject_UnityEngine_U2D_SpriteAtlasManager();
            StaticTypes[typeof( SpriteAtlas )] = new BSStaticWrapperObject_UnityEngine_U2D_SpriteAtlas();
            StaticTypes[typeof( Profiler )] = new BSStaticWrapperObject_UnityEngine_Profiling_Profiler();
            StaticTypes[typeof( Recorder )] = new BSStaticWrapperObject_UnityEngine_Profiling_Recorder();
            StaticTypes[typeof( Sampler )] = new BSStaticWrapperObject_UnityEngine_Profiling_Sampler();
            StaticTypes[typeof( CustomSampler )] = new BSStaticWrapperObject_UnityEngine_Profiling_CustomSampler();

            StaticTypes[typeof( DebugScreenCapture )] =
                new BSStaticWrapperObject_UnityEngine_Profiling_Experimental_DebugScreenCapture();

            StaticTypes[typeof( MetaData )] =
                new BSStaticWrapperObject_UnityEngine_Profiling_Memory_Experimental_MetaData();

            StaticTypes[typeof( MemoryProfiler )] =
                new BSStaticWrapperObject_UnityEngine_Profiling_Memory_Experimental_MemoryProfiler();

            StaticTypes[typeof( IJobParallelForTransform )] =
                new BSStaticWrapperObject_UnityEngine_Jobs_IJobParallelForTransform();

            StaticTypes[typeof( IJobParallelForTransformExtensions )] =
                new BSStaticWrapperObject_UnityEngine_Jobs_IJobParallelForTransformExtensions();

            StaticTypes[typeof( TransformAccess )] = new BSStaticWrapperObject_UnityEngine_Jobs_TransformAccess();

            StaticTypes[typeof( TransformAccessArray )] =
                new BSStaticWrapperObject_UnityEngine_Jobs_TransformAccessArray();

            StaticTypes[typeof( AppCallbackItem )] = new BSStaticWrapperObject_UnityEngine_WSA_AppCallbackItem();
            StaticTypes[typeof( WindowSizeChanged )] = new BSStaticWrapperObject_UnityEngine_WSA_WindowSizeChanged();
            StaticTypes[typeof( WindowActivated )] = new BSStaticWrapperObject_UnityEngine_WSA_WindowActivated();

            StaticTypes[typeof( UnityEngine.WSA.Application )] =
                new BSStaticWrapperObject_UnityEngine_WSA_Application();

            StaticTypes[typeof( UnityEngine.WSA.Cursor )] = new BSStaticWrapperObject_UnityEngine_WSA_Cursor();
            StaticTypes[typeof( Launcher )] = new BSStaticWrapperObject_UnityEngine_WSA_Launcher();
            StaticTypes[typeof( SecondaryTileData )] = new BSStaticWrapperObject_UnityEngine_WSA_SecondaryTileData();
            StaticTypes[typeof( Tile )] = new BSStaticWrapperObject_UnityEngine_WSA_Tile();
            StaticTypes[typeof( Toast )] = new BSStaticWrapperObject_UnityEngine_WSA_Toast();
#if BS_UNITY_WIN
           
            StaticTypes[typeof( LicenseInformation )] =
                new BSStaticWrapperObject_UnityEngine_Windows_LicenseInformation();

            StaticTypes[typeof( CrashReporting )] = new BSStaticWrapperObject_UnityEngine_Windows_CrashReporting();
            StaticTypes[typeof( Crypto )] = new BSStaticWrapperObject_UnityEngine_Windows_Crypto();
            StaticTypes[typeof( Directory )] = new BSStaticWrapperObject_UnityEngine_Windows_Directory();
            StaticTypes[typeof( File )] = new BSStaticWrapperObject_UnityEngine_Windows_File();

            StaticTypes[typeof( PhraseRecognitionSystem )] =
                new BSStaticWrapperObject_UnityEngine_Windows_Speech_PhraseRecognitionSystem();

            StaticTypes[typeof( PhraseRecognizer )] =
                new BSStaticWrapperObject_UnityEngine_Windows_Speech_PhraseRecognizer();

            StaticTypes[typeof( DictationRecognizer )] =
                new BSStaticWrapperObject_UnityEngine_Windows_Speech_DictationRecognizer();

            StaticTypes[typeof( SemanticMeaning )] =
                new BSStaticWrapperObject_UnityEngine_Windows_Speech_SemanticMeaning();

            StaticTypes[typeof( PhraseRecognizedEventArgs )] =
                new BSStaticWrapperObject_UnityEngine_Windows_Speech_PhraseRecognizedEventArgs();

            StaticTypes[typeof( KeywordRecognizer )] =
                new BSStaticWrapperObject_UnityEngine_Windows_Speech_KeywordRecognizer();

            StaticTypes[typeof( GrammarRecognizer )] =
                new BSStaticWrapperObject_UnityEngine_Windows_Speech_GrammarRecognizer();

            StaticTypes[typeof( PhotoCapture )] = new BSStaticWrapperObject_UnityEngine_Windows_WebCam_PhotoCapture();

            StaticTypes[typeof( PhotoCaptureFrame )] =
                new BSStaticWrapperObject_UnityEngine_Windows_WebCam_PhotoCaptureFrame();

            StaticTypes[typeof( VideoCapture )] = new BSStaticWrapperObject_UnityEngine_Windows_WebCam_VideoCapture();
            StaticTypes[typeof( WebCam )] = new BSStaticWrapperObject_UnityEngine_Windows_WebCam_WebCam();

            StaticTypes[typeof( CameraParameters )] =
                new BSStaticWrapperObject_UnityEngine_Windows_WebCam_CameraParameters();

#endif

            StaticTypes[typeof( UnityEventBase )] = new BSStaticWrapperObject_UnityEngine_Events_UnityEventBase();
            StaticTypes[typeof( UnityAction )] = new BSStaticWrapperObject_UnityEngine_Events_UnityAction();
            StaticTypes[typeof( UnityEvent )] = new BSStaticWrapperObject_UnityEngine_Events_UnityEvent();

            StaticTypes[typeof( FormerlySerializedAsAttribute )] =
                new BSStaticWrapperObject_UnityEngine_Serialization_FormerlySerializedAsAttribute();

            StaticTypes[typeof( UnitySurrogateSelector )] =
                new BSStaticWrapperObject_UnityEngine_Serialization_UnitySurrogateSelector();

            StaticTypes[typeof( ObjectSelectorHandlerWithLabelsAttribute )] =
                new BSStaticWrapperObject_UnityEngine_SearchService_ObjectSelectorHandlerWithLabelsAttribute();

            StaticTypes[typeof( ObjectSelectorHandlerWithTagsAttribute )] =
                new BSStaticWrapperObject_UnityEngine_SearchService_ObjectSelectorHandlerWithTagsAttribute();

            StaticTypes[typeof( AlwaysLinkAssemblyAttribute )] =
                new BSStaticWrapperObject_UnityEngine_Scripting_AlwaysLinkAssemblyAttribute();

            StaticTypes[typeof( GarbageCollector )] =
                new BSStaticWrapperObject_UnityEngine_Scripting_GarbageCollector();

            StaticTypes[typeof( PreserveAttribute )] =
                new BSStaticWrapperObject_UnityEngine_Scripting_PreserveAttribute();

            StaticTypes[typeof( RequireAttributeUsagesAttribute )] =
                new BSStaticWrapperObject_UnityEngine_Scripting_RequireAttributeUsagesAttribute();

            StaticTypes[typeof( RequireDerivedAttribute )] =
                new BSStaticWrapperObject_UnityEngine_Scripting_RequireDerivedAttribute();

            StaticTypes[typeof( RequiredInterfaceAttribute )] =
                new BSStaticWrapperObject_UnityEngine_Scripting_RequiredInterfaceAttribute();

            StaticTypes[typeof( RequiredMemberAttribute )] =
                new BSStaticWrapperObject_UnityEngine_Scripting_RequiredMemberAttribute();

            StaticTypes[typeof( RequireImplementorsAttribute )] =
                new BSStaticWrapperObject_UnityEngine_Scripting_RequireImplementorsAttribute();

            StaticTypes[typeof( MovedFromAttribute )] =
                new BSStaticWrapperObject_UnityEngine_Scripting_APIUpdating_MovedFromAttribute();

            StaticTypes[typeof( SceneManagerAPI )] =
                new BSStaticWrapperObject_UnityEngine_SceneManagement_SceneManagerAPI();

            StaticTypes[typeof( SceneManager )] = new BSStaticWrapperObject_UnityEngine_SceneManagement_SceneManager();

            StaticTypes[typeof( CreateSceneParameters )] =
                new BSStaticWrapperObject_UnityEngine_SceneManagement_CreateSceneParameters();

            StaticTypes[typeof( LoadSceneParameters )] =
                new BSStaticWrapperObject_UnityEngine_SceneManagement_LoadSceneParameters();

            StaticTypes[typeof( SceneUtility )] = new BSStaticWrapperObject_UnityEngine_SceneManagement_SceneUtility();
            StaticTypes[typeof( PlayerLoopSystem )] = new BSStaticWrapperObject_UnityEngine_LowLevel_PlayerLoopSystem();
            StaticTypes[typeof( PlayerLoop )] = new BSStaticWrapperObject_UnityEngine_LowLevel_PlayerLoop();
            StaticTypes[typeof( TimeUpdate )] = new BSStaticWrapperObject_UnityEngine_PlayerLoop_TimeUpdate();
            StaticTypes[typeof( Initialization )] = new BSStaticWrapperObject_UnityEngine_PlayerLoop_Initialization();
            StaticTypes[typeof( EarlyUpdate )] = new BSStaticWrapperObject_UnityEngine_PlayerLoop_EarlyUpdate();
            StaticTypes[typeof( FixedUpdate )] = new BSStaticWrapperObject_UnityEngine_PlayerLoop_FixedUpdate();
            StaticTypes[typeof( PreUpdate )] = new BSStaticWrapperObject_UnityEngine_PlayerLoop_PreUpdate();
            StaticTypes[typeof( Update )] = new BSStaticWrapperObject_UnityEngine_PlayerLoop_Update();
            StaticTypes[typeof( PreLateUpdate )] = new BSStaticWrapperObject_UnityEngine_PlayerLoop_PreLateUpdate();
            StaticTypes[typeof( PostLateUpdate )] = new BSStaticWrapperObject_UnityEngine_PlayerLoop_PostLateUpdate();

            StaticTypes[typeof( IConnectionState )] =
                new BSStaticWrapperObject_UnityEngine_Networking_PlayerConnection_IConnectionState();

            StaticTypes[typeof( MessageEventArgs )] =
                new BSStaticWrapperObject_UnityEngine_Networking_PlayerConnection_MessageEventArgs();

            StaticTypes[typeof( IEditorPlayerConnection )] =
                new BSStaticWrapperObject_UnityEngine_Networking_PlayerConnection_IEditorPlayerConnection();

            StaticTypes[typeof( PlayerConnection )] =
                new BSStaticWrapperObject_UnityEngine_Networking_PlayerConnection_PlayerConnection();

            StaticTypes[typeof( UsesLuminPlatformLevelAttribute )] =
                new BSStaticWrapperObject_UnityEngine_Lumin_UsesLuminPlatformLevelAttribute();

            StaticTypes[typeof( UsesLuminPrivilegeAttribute )] =
                new BSStaticWrapperObject_UnityEngine_Lumin_UsesLuminPrivilegeAttribute();

            StaticTypes[typeof( Remote )] = new BSStaticWrapperObject_UnityEngine_tvOS_Remote();
            StaticTypes[typeof( Device )] = new BSStaticWrapperObject_UnityEngine_tvOS_Device();
#if BS_UNITY_IOS
            StaticTypes[typeof( UnityEngine.iOS.Device )] = new BSStaticWrapperObject_UnityEngine_iOS_Device();
            StaticTypes[typeof( LocalNotification )] = new BSStaticWrapperObject_UnityEngine_iOS_LocalNotification();
            StaticTypes[typeof( RemoteNotification )] = new BSStaticWrapperObject_UnityEngine_iOS_RemoteNotification();

            StaticTypes[typeof( NotificationServices )] =
                new BSStaticWrapperObject_UnityEngine_iOS_NotificationServices();

            StaticTypes[typeof( OnDemandResourcesRequest )] =
                new BSStaticWrapperObject_UnityEngine_iOS_OnDemandResourcesRequest();

            StaticTypes[typeof( OnDemandResources )] = new BSStaticWrapperObject_UnityEngine_iOS_OnDemandResources();
#endif
            StaticTypes[typeof( DefaultValueAttribute )] =
                new BSStaticWrapperObject_UnityEngine_Internal_DefaultValueAttribute();

            StaticTypes[typeof( ExcludeFromDocsAttribute )] =
                new BSStaticWrapperObject_UnityEngine_Internal_ExcludeFromDocsAttribute();

            StaticTypes[typeof( AsyncGPUReadbackRequest )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_AsyncGPUReadbackRequest();

            StaticTypes[typeof( AsyncGPUReadback )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_AsyncGPUReadback();

            StaticTypes[typeof( GraphicsFence )] = new BSStaticWrapperObject_UnityEngine_Rendering_GPUFence();
            StaticTypes[typeof( PIX )] = new BSStaticWrapperObject_UnityEngine_Rendering_PIX();

            StaticTypes[typeof( RenderTargetIdentifier )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_RenderTargetIdentifier();

            StaticTypes[typeof( RenderTargetBinding )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_RenderTargetBinding();

            StaticTypes[typeof( ReflectionProbeBlendInfo )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_ReflectionProbeBlendInfo();

            StaticTypes[typeof( GraphicsSettings )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_GraphicsSettings();

            StaticTypes[typeof( OnDemandRendering )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_OnDemandRendering();

            StaticTypes[typeof( CommandBuffer )] = new BSStaticWrapperObject_UnityEngine_Rendering_CommandBuffer();

            StaticTypes[typeof( CommandBufferExtensions )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_CommandBufferExtensions();

            StaticTypes[typeof( SplashScreen )] = new BSStaticWrapperObject_UnityEngine_Rendering_SplashScreen();
            StaticTypes[typeof( BatchVisibility )] = new BSStaticWrapperObject_UnityEngine_Rendering_BatchVisibility();

            StaticTypes[typeof( BatchCullingContext )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_BatchCullingContext();

            StaticTypes[typeof( LODParameters )] = new BSStaticWrapperObject_UnityEngine_Rendering_LODParameters();

            StaticTypes[typeof( BatchRendererGroup )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_BatchRendererGroup();

            StaticTypes[typeof( AttachmentDescriptor )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_AttachmentDescriptor();

            StaticTypes[typeof( BlendState )] = new BSStaticWrapperObject_UnityEngine_Rendering_BlendState();

            StaticTypes[typeof( RenderTargetBlendState )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_RenderTargetBlendState();

            StaticTypes[typeof( CameraProperties )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_CameraProperties();

            StaticTypes[typeof( ScriptableCullingParameters )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_ScriptableCullingParameters();

            StaticTypes[typeof( CullingResults )] = new BSStaticWrapperObject_UnityEngine_Rendering_CullingResults();
            StaticTypes[typeof( DepthState )] = new BSStaticWrapperObject_UnityEngine_Rendering_DepthState();
            StaticTypes[typeof( DrawingSettings )] = new BSStaticWrapperObject_UnityEngine_Rendering_DrawingSettings();
            StaticTypes[typeof( SortingSettings )] = new BSStaticWrapperObject_UnityEngine_Rendering_SortingSettings();

            StaticTypes[typeof( FilteringSettings )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_FilteringSettings();

            StaticTypes[typeof( RenderQueueRange )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_RenderQueueRange();

            StaticTypes[typeof( SortingLayerRange )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_SortingLayerRange();

            StaticTypes[typeof( RasterState )] = new BSStaticWrapperObject_UnityEngine_Rendering_RasterState();
            StaticTypes[typeof( RenderPipeline )] = new BSStaticWrapperObject_UnityEngine_Rendering_RenderPipeline();

            StaticTypes[typeof( RenderPipelineManager )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_RenderPipelineManager();

            StaticTypes[typeof( RenderStateBlock )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_RenderStateBlock();

            StaticTypes[typeof( StencilState )] = new BSStaticWrapperObject_UnityEngine_Rendering_StencilState();

            StaticTypes[typeof( ScopedRenderPass )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_ScopedRenderPass();

            StaticTypes[typeof( ScopedSubPass )] = new BSStaticWrapperObject_UnityEngine_Rendering_ScopedSubPass();

            StaticTypes[typeof( ScriptableRenderContext )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_ScriptableRenderContext();

            StaticTypes[typeof( ShadowDrawingSettings )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_ShadowDrawingSettings();

            StaticTypes[typeof( ShadowSplitData )] = new BSStaticWrapperObject_UnityEngine_Rendering_ShadowSplitData();

            StaticTypes[typeof( SupportedRenderingFeatures )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_SupportedRenderingFeatures();

            StaticTypes[typeof( VisibleLight )] = new BSStaticWrapperObject_UnityEngine_Rendering_VisibleLight();

            StaticTypes[typeof( VisibleReflectionProbe )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_VisibleReflectionProbe();

            StaticTypes[typeof( PlatformKeywordSet )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_PlatformKeywordSet();

            StaticTypes[typeof( ShaderKeyword )] = new BSStaticWrapperObject_UnityEngine_Rendering_ShaderKeyword();

            StaticTypes[typeof( ShaderKeywordSet )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_ShaderKeywordSet();

            StaticTypes[typeof( SortingGroup )] = new BSStaticWrapperObject_UnityEngine_Rendering_SortingGroup();
            StaticTypes[typeof( FrameData )] = new BSStaticWrapperObject_UnityEngine_Playables_FrameData();
            StaticTypes[typeof( INotification )] = new BSStaticWrapperObject_UnityEngine_Playables_INotification();

            StaticTypes[typeof( INotificationReceiver )] =
                new BSStaticWrapperObject_UnityEngine_Playables_INotificationReceiver();

            StaticTypes[typeof( IPlayable )] = new BSStaticWrapperObject_UnityEngine_Playables_IPlayable();

            StaticTypes[typeof( IPlayableBehaviour )] =
                new BSStaticWrapperObject_UnityEngine_Playables_IPlayableBehaviour();

            StaticTypes[typeof( IPlayableOutput )] = new BSStaticWrapperObject_UnityEngine_Playables_IPlayableOutput();
            StaticTypes[typeof( Notification )] = new BSStaticWrapperObject_UnityEngine_Playables_Notification();
            StaticTypes[typeof( IPlayableAsset )] = new BSStaticWrapperObject_UnityEngine_Playables_IPlayableAsset();
            StaticTypes[typeof( PlayableAsset )] = new BSStaticWrapperObject_UnityEngine_Playables_PlayableAsset();

            StaticTypes[typeof( PlayableBehaviour )] =
                new BSStaticWrapperObject_UnityEngine_Playables_PlayableBehaviour();

            StaticTypes[typeof( PlayableExtensions )] =
                new BSStaticWrapperObject_UnityEngine_Playables_PlayableExtensions();

            StaticTypes[typeof( PlayableHandle )] = new BSStaticWrapperObject_UnityEngine_Playables_PlayableHandle();

            StaticTypes[typeof( PlayableOutputExtensions )] =
                new BSStaticWrapperObject_UnityEngine_Playables_PlayableOutputExtensions();

            StaticTypes[typeof( PlayableOutputHandle )] =
                new BSStaticWrapperObject_UnityEngine_Playables_PlayableOutputHandle();

            StaticTypes[typeof( ScriptPlayableBinding )] =
                new BSStaticWrapperObject_UnityEngine_Playables_ScriptPlayableBinding();

            StaticTypes[typeof( ScriptPlayableOutput )] =
                new BSStaticWrapperObject_UnityEngine_Playables_ScriptPlayableOutput();

            StaticTypes[typeof( Utils )] = new BSStaticWrapperObject_UnityEngine_Diagnostics_Utils();

            StaticTypes[typeof( UnityEngine.Diagnostics.PlayerConnection )] =
                new BSStaticWrapperObject_UnityEngine_Diagnostics_PlayerConnection();

            StaticTypes[typeof( LinearColor )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_LinearColor();

            StaticTypes[typeof( DirectionalLight )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_DirectionalLight();

            StaticTypes[typeof( PointLight )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_PointLight();

            StaticTypes[typeof( SpotLight )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_SpotLight();

            StaticTypes[typeof( RectangleLight )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_RectangleLight();

            StaticTypes[typeof( DiscLight )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_DiscLight();

            StaticTypes[typeof( SpotLightBoxShape )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_SpotLightBoxShape();

            StaticTypes[typeof( SpotLightPyramidShape )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_SpotLightPyramidShape();

            StaticTypes[typeof( Cookie )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_Cookie();

            StaticTypes[typeof( LightDataGI )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_LightDataGI();

            StaticTypes[typeof( LightmapperUtils )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_LightmapperUtils();

            StaticTypes[typeof( Lightmapping )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_Lightmapping();

            StaticTypes[typeof( UnityEngine.Experimental.GlobalIllumination.RenderSettings )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_RenderSettings();

            StaticTypes[typeof( CameraPlayable )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Playables_CameraPlayable();

            StaticTypes[typeof( MaterialEffectPlayable )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Playables_MaterialEffectPlayable();

            StaticTypes[typeof( TextureMixerPlayable )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Playables_TextureMixerPlayable();

            StaticTypes[typeof( TexturePlayableBinding )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Playables_TexturePlayableBinding();

            StaticTypes[typeof( TexturePlayableOutput )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Playables_TexturePlayableOutput();

            StaticTypes[typeof( IScriptableRuntimeReflectionSystem )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Rendering_IScriptableRuntimeReflectionSystem();

            StaticTypes[typeof( ScriptableRuntimeReflectionSystem )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Rendering_ScriptableRuntimeReflectionSystem();

            StaticTypes[typeof( ScriptableRuntimeReflectionSystemSettings )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Rendering_ScriptableRuntimeReflectionSystemSettings();

            StaticTypes[typeof( ExternalGPUProfiler )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Rendering_ExternalGPUProfiler();

            StaticTypes[typeof( GraphicsDeviceSettings )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Rendering_GraphicsDeviceSettings();

            StaticTypes[typeof( GraphicsFormatUtility )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Rendering_GraphicsFormatUtility();

            StaticTypes[typeof( RayTracingAccelerationStructure )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure();

            StaticTypes[typeof( ShaderWarmupSetup )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Rendering_ShaderWarmupSetup();

            StaticTypes[typeof( ShaderWarmup )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Rendering_ShaderWarmup();

            StaticTypes[typeof( RayTracingShader )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Rendering_RayTracingShader();

            StaticTypes[typeof( Assert )] = new BSStaticWrapperObject_UnityEngine_Assertions_Assert();

            StaticTypes[typeof( AssertionException )] =
                new BSStaticWrapperObject_UnityEngine_Assertions_AssertionException();

            StaticTypes[typeof( MustExtensions )] =
                new BSStaticWrapperObject_UnityEngine_Assertions_Must_MustExtensions();

            StaticTypes[typeof( FloatComparer )] =
                new BSStaticWrapperObject_UnityEngine_Assertions_Comparers_FloatComparer();

            StaticTypes[typeof( FrameCapture )] = new BSStaticWrapperObject_UnityEngine_Apple_FrameCapture();
            StaticTypes[typeof( ReplayKit )] = new BSStaticWrapperObject_UnityEngine_Apple_ReplayKit_ReplayKit();

            StaticTypes[typeof( ExcludeFromCoverageAttribute )] =
                new BSStaticWrapperObject_UnityEngine_TestTools_ExcludeFromCoverageAttribute();

            StaticTypes[typeof( CoveredSequencePoint )] =
                new BSStaticWrapperObject_UnityEngine_TestTools_CoveredSequencePoint();

            StaticTypes[typeof( CoveredMethodStats )] =
                new BSStaticWrapperObject_UnityEngine_TestTools_CoveredMethodStats();

            StaticTypes[typeof( Coverage )] = new BSStaticWrapperObject_UnityEngine_TestTools_Coverage();

            StaticTypes[typeof( CrashReportHandler )] =
                new BSStaticWrapperObject_UnityEngine_CrashReportHandler_CrashReportHandler();

            StaticTypes[typeof( PlayableDirector )] =
                new BSStaticWrapperObject_UnityEngine_Playables_PlayableDirector();

            StaticTypes[typeof( Social )] = new BSStaticWrapperObject_UnityEngine_Social();

            StaticTypes[typeof( ISocialPlatform )] =
                new BSStaticWrapperObject_UnityEngine_SocialPlatforms_ISocialPlatform();

            StaticTypes[typeof( ILocalUser )] = new BSStaticWrapperObject_UnityEngine_SocialPlatforms_ILocalUser();
            StaticTypes[typeof( ILeaderboard )] = new BSStaticWrapperObject_UnityEngine_SocialPlatforms_ILeaderboard();
            StaticTypes[typeof( Range )] = new BSStaticWrapperObject_UnityEngine_SocialPlatforms_Range();
            StaticTypes[typeof( IScore )] = new BSStaticWrapperObject_UnityEngine_SocialPlatforms_IScore();
            StaticTypes[typeof( Local )] = new BSStaticWrapperObject_UnityEngine_SocialPlatforms_Local();
            StaticTypes[typeof( IUserProfile )] = new BSStaticWrapperObject_UnityEngine_SocialPlatforms_IUserProfile();
            StaticTypes[typeof( IAchievement )] = new BSStaticWrapperObject_UnityEngine_SocialPlatforms_IAchievement();

            StaticTypes[typeof( IAchievementDescription )] =
                new BSStaticWrapperObject_UnityEngine_SocialPlatforms_IAchievementDescription();

            StaticTypes[typeof( LocalUser )] = new BSStaticWrapperObject_UnityEngine_SocialPlatforms_Impl_LocalUser();

            StaticTypes[typeof( UserProfile )] =
                new BSStaticWrapperObject_UnityEngine_SocialPlatforms_Impl_UserProfile();

            StaticTypes[typeof( Achievement )] =
                new BSStaticWrapperObject_UnityEngine_SocialPlatforms_Impl_Achievement();

            StaticTypes[typeof( AchievementDescription )] =
                new BSStaticWrapperObject_UnityEngine_SocialPlatforms_Impl_AchievementDescription();

            StaticTypes[typeof( Score )] = new BSStaticWrapperObject_UnityEngine_SocialPlatforms_Impl_Score();

            StaticTypes[typeof( Leaderboard )] =
                new BSStaticWrapperObject_UnityEngine_SocialPlatforms_Impl_Leaderboard();

            StaticTypes[typeof( GameCenterPlatform )] =
                new BSStaticWrapperObject_UnityEngine_SocialPlatforms_GameCenter_GameCenterPlatform();

            StaticTypes[typeof( Grid )] = new BSStaticWrapperObject_UnityEngine_Grid();
            StaticTypes[typeof( GridLayout )] = new BSStaticWrapperObject_UnityEngine_GridLayout();
            StaticTypes[typeof( Event )] = new BSStaticWrapperObject_UnityEngine_Event();
            StaticTypes[typeof( GUI )] = new BSStaticWrapperObject_UnityEngine_GUI();
            StaticTypes[typeof( GUISkin )] = new BSStaticWrapperObject_UnityEngine_GUISkin();
            StaticTypes[typeof( Font )] = new BSStaticWrapperObject_UnityEngine_Font();
            StaticTypes[typeof( GUIStyle )] = new BSStaticWrapperObject_UnityEngine_GUIStyle();
            StaticTypes[typeof( GUIStyleState )] = new BSStaticWrapperObject_UnityEngine_GUIStyleState();
            StaticTypes[typeof( GUIContent )] = new BSStaticWrapperObject_UnityEngine_GUIContent();
            StaticTypes[typeof( GUISettings )] = new BSStaticWrapperObject_UnityEngine_GUISettings();
            StaticTypes[typeof( GUILayout )] = new BSStaticWrapperObject_UnityEngine_GUILayout();
            StaticTypes[typeof( GUILayoutOption )] = new BSStaticWrapperObject_UnityEngine_GUILayoutOption();
            StaticTypes[typeof( GUILayoutUtility )] = new BSStaticWrapperObject_UnityEngine_GUILayoutUtility();
            StaticTypes[typeof( GUITargetAttribute )] = new BSStaticWrapperObject_UnityEngine_GUITargetAttribute();
            StaticTypes[typeof( GUIUtility )] = new BSStaticWrapperObject_UnityEngine_GUIUtility();
            StaticTypes[typeof( ExitGUIException )] = new BSStaticWrapperObject_UnityEngine_ExitGUIException();
            StaticTypes[typeof( TextEditor )] = new BSStaticWrapperObject_UnityEngine_TextEditor();
            StaticTypes[typeof( ImageConversion )] = new BSStaticWrapperObject_UnityEngine_ImageConversion();
#if BS_UNITY_ANDROID
            StaticTypes[typeof( AndroidInput )] = new BSStaticWrapperObject_UnityEngine_AndroidInput();
#endif
            StaticTypes[typeof( Touch )] = new BSStaticWrapperObject_UnityEngine_Touch();
            StaticTypes[typeof( AccelerationEvent )] = new BSStaticWrapperObject_UnityEngine_AccelerationEvent();
            StaticTypes[typeof( Gyroscope )] = new BSStaticWrapperObject_UnityEngine_Gyroscope();
            StaticTypes[typeof( LocationInfo )] = new BSStaticWrapperObject_UnityEngine_LocationInfo();
            StaticTypes[typeof( LocationService )] = new BSStaticWrapperObject_UnityEngine_LocationService();
            StaticTypes[typeof( Compass )] = new BSStaticWrapperObject_UnityEngine_Compass();
            StaticTypes[typeof( Input )] = new BSStaticWrapperObject_UnityEngine_Input();
            StaticTypes[typeof( JsonUtility )] = new BSStaticWrapperObject_UnityEngine_JsonUtility();
            StaticTypes[typeof( LocalizationAsset )] = new BSStaticWrapperObject_UnityEngine_LocalizationAsset();
            StaticTypes[typeof( ParticleSystem )] = new BSStaticWrapperObject_UnityEngine_ParticleSystem();

            StaticTypes[typeof( ParticlePhysicsExtensions )] =
                new BSStaticWrapperObject_UnityEngine_ParticlePhysicsExtensions();

            StaticTypes[typeof( ParticleCollisionEvent )] =
                new BSStaticWrapperObject_UnityEngine_ParticleCollisionEvent();

            StaticTypes[typeof( ParticleSystemRenderer )] =
                new BSStaticWrapperObject_UnityEngine_ParticleSystemRenderer();

            StaticTypes[typeof( ParticleSystemForceField )] =
                new BSStaticWrapperObject_UnityEngine_ParticleSystemForceField();

            StaticTypes[typeof( IJobParticleSystem )] =
                new BSStaticWrapperObject_UnityEngine_ParticleSystemJobs_IJobParticleSystem();

            StaticTypes[typeof( IJobParticleSystemParallelFor )] =
                new BSStaticWrapperObject_UnityEngine_ParticleSystemJobs_IJobParticleSystemParallelFor();

            StaticTypes[typeof( IJobParticleSystemParallelForBatch )] =
                new BSStaticWrapperObject_UnityEngine_ParticleSystemJobs_IJobParticleSystemParallelForBatch();

            StaticTypes[typeof( IParticleSystemJobExtensions )] =
                new BSStaticWrapperObject_UnityEngine_ParticleSystemJobs_IParticleSystemJobExtensions();

            StaticTypes[typeof( ParticleSystemNativeArray3 )] =
                new BSStaticWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemNativeArray3();

            StaticTypes[typeof( ParticleSystemNativeArray4 )] =
                new BSStaticWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemNativeArray4();

            StaticTypes[typeof( ParticleSystemJobData )] =
                new BSStaticWrapperObject_UnityEngine_ParticleSystemJobs_ParticleSystemJobData();

            StaticTypes[typeof( PerformanceReporting )] =
                new BSStaticWrapperObject_UnityEngine_Analytics_PerformanceReporting();

            StaticTypes[typeof( WheelFrictionCurve )] = new BSStaticWrapperObject_UnityEngine_WheelFrictionCurve();
            StaticTypes[typeof( SoftJointLimit )] = new BSStaticWrapperObject_UnityEngine_SoftJointLimit();
            StaticTypes[typeof( SoftJointLimitSpring )] = new BSStaticWrapperObject_UnityEngine_SoftJointLimitSpring();
            StaticTypes[typeof( JointDrive )] = new BSStaticWrapperObject_UnityEngine_JointDrive();
            StaticTypes[typeof( JointMotor )] = new BSStaticWrapperObject_UnityEngine_JointMotor();
            StaticTypes[typeof( JointSpring )] = new BSStaticWrapperObject_UnityEngine_JointSpring();
            StaticTypes[typeof( JointLimits )] = new BSStaticWrapperObject_UnityEngine_JointLimits();

            StaticTypes[typeof( ControllerColliderHit )] =
                new BSStaticWrapperObject_UnityEngine_ControllerColliderHit();

            StaticTypes[typeof( CharacterController )] = new BSStaticWrapperObject_UnityEngine_CharacterController();
            StaticTypes[typeof( Collider )] = new BSStaticWrapperObject_UnityEngine_Collider();
            StaticTypes[typeof( Collision )] = new BSStaticWrapperObject_UnityEngine_Collision();
            StaticTypes[typeof( ContactPoint )] = new BSStaticWrapperObject_UnityEngine_ContactPoint();
            StaticTypes[typeof( RaycastHit )] = new BSStaticWrapperObject_UnityEngine_RaycastHit();
            StaticTypes[typeof( MeshCollider )] = new BSStaticWrapperObject_UnityEngine_MeshCollider();
            StaticTypes[typeof( CapsuleCollider )] = new BSStaticWrapperObject_UnityEngine_CapsuleCollider();
            StaticTypes[typeof( BoxCollider )] = new BSStaticWrapperObject_UnityEngine_BoxCollider();
            StaticTypes[typeof( ConstantForce )] = new BSStaticWrapperObject_UnityEngine_ConstantForce();
            StaticTypes[typeof( Joint )] = new BSStaticWrapperObject_UnityEngine_Joint();
            StaticTypes[typeof( HingeJoint )] = new BSStaticWrapperObject_UnityEngine_HingeJoint();
            StaticTypes[typeof( SpringJoint )] = new BSStaticWrapperObject_UnityEngine_SpringJoint();
            StaticTypes[typeof( FixedJoint )] = new BSStaticWrapperObject_UnityEngine_FixedJoint();
            StaticTypes[typeof( CharacterJoint )] = new BSStaticWrapperObject_UnityEngine_CharacterJoint();
            StaticTypes[typeof( ConfigurableJoint )] = new BSStaticWrapperObject_UnityEngine_ConfigurableJoint();
            StaticTypes[typeof( PhysicsScene )] = new BSStaticWrapperObject_UnityEngine_PhysicsScene();

            StaticTypes[typeof( PhysicsSceneExtensions )] =
                new BSStaticWrapperObject_UnityEngine_PhysicsSceneExtensions();

            StaticTypes[typeof( ArticulationJacobian )] = new BSStaticWrapperObject_UnityEngine_ArticulationJacobian();
            StaticTypes[typeof( Physics )] = new BSStaticWrapperObject_UnityEngine_Physics();
            StaticTypes[typeof( RaycastCommand )] = new BSStaticWrapperObject_UnityEngine_RaycastCommand();
            StaticTypes[typeof( JobHandle )] = new BSStaticWrapperObject_Unity_Jobs_JobHandle();
            StaticTypes[typeof( SpherecastCommand )] = new BSStaticWrapperObject_UnityEngine_SpherecastCommand();
            StaticTypes[typeof( CapsulecastCommand )] = new BSStaticWrapperObject_UnityEngine_CapsulecastCommand();
            StaticTypes[typeof( BoxcastCommand )] = new BSStaticWrapperObject_UnityEngine_BoxcastCommand();
            StaticTypes[typeof( PhysicsScene2D )] = new BSStaticWrapperObject_UnityEngine_PhysicsScene2D();
            StaticTypes[typeof( RaycastHit2D )] = new BSStaticWrapperObject_UnityEngine_RaycastHit2D();
            StaticTypes[typeof( Collider2D )] = new BSStaticWrapperObject_UnityEngine_Collider2D();
            StaticTypes[typeof( CompositeCollider2D )] = new BSStaticWrapperObject_UnityEngine_CompositeCollider2D();
            StaticTypes[typeof( Rigidbody2D )] = new BSStaticWrapperObject_UnityEngine_Rigidbody2D();
            StaticTypes[typeof( PhysicsMaterial2D )] = new BSStaticWrapperObject_UnityEngine_PhysicsMaterial2D();
            StaticTypes[typeof( ContactFilter2D )] = new BSStaticWrapperObject_UnityEngine_ContactFilter2D();
            StaticTypes[typeof( ColliderDistance2D )] = new BSStaticWrapperObject_UnityEngine_ColliderDistance2D();

            StaticTypes[typeof( PhysicsSceneExtensions2D )] =
                new BSStaticWrapperObject_UnityEngine_PhysicsSceneExtensions2D();

            StaticTypes[typeof( Physics2D )] = new BSStaticWrapperObject_UnityEngine_Physics2D();
            StaticTypes[typeof( PhysicsJobOptions2D )] = new BSStaticWrapperObject_UnityEngine_PhysicsJobOptions2D();
            StaticTypes[typeof( Collision2D )] = new BSStaticWrapperObject_UnityEngine_Collision2D();
            StaticTypes[typeof( ContactPoint2D )] = new BSStaticWrapperObject_UnityEngine_ContactPoint2D();
            StaticTypes[typeof( JointAngleLimits2D )] = new BSStaticWrapperObject_UnityEngine_JointAngleLimits2D();

            StaticTypes[typeof( JointTranslationLimits2D )] =
                new BSStaticWrapperObject_UnityEngine_JointTranslationLimits2D();

            StaticTypes[typeof( JointMotor2D )] = new BSStaticWrapperObject_UnityEngine_JointMotor2D();
            StaticTypes[typeof( JointSuspension2D )] = new BSStaticWrapperObject_UnityEngine_JointSuspension2D();
            StaticTypes[typeof( CircleCollider2D )] = new BSStaticWrapperObject_UnityEngine_CircleCollider2D();
            StaticTypes[typeof( CapsuleCollider2D )] = new BSStaticWrapperObject_UnityEngine_CapsuleCollider2D();
            StaticTypes[typeof( EdgeCollider2D )] = new BSStaticWrapperObject_UnityEngine_EdgeCollider2D();
            StaticTypes[typeof( BoxCollider2D )] = new BSStaticWrapperObject_UnityEngine_BoxCollider2D();
            StaticTypes[typeof( PolygonCollider2D )] = new BSStaticWrapperObject_UnityEngine_PolygonCollider2D();
            StaticTypes[typeof( Joint2D )] = new BSStaticWrapperObject_UnityEngine_Joint2D();
            StaticTypes[typeof( AnchoredJoint2D )] = new BSStaticWrapperObject_UnityEngine_AnchoredJoint2D();
            StaticTypes[typeof( SpringJoint2D )] = new BSStaticWrapperObject_UnityEngine_SpringJoint2D();
            StaticTypes[typeof( DistanceJoint2D )] = new BSStaticWrapperObject_UnityEngine_DistanceJoint2D();
            StaticTypes[typeof( FrictionJoint2D )] = new BSStaticWrapperObject_UnityEngine_FrictionJoint2D();
            StaticTypes[typeof( HingeJoint2D )] = new BSStaticWrapperObject_UnityEngine_HingeJoint2D();
            StaticTypes[typeof( RelativeJoint2D )] = new BSStaticWrapperObject_UnityEngine_RelativeJoint2D();
            StaticTypes[typeof( SliderJoint2D )] = new BSStaticWrapperObject_UnityEngine_SliderJoint2D();
            StaticTypes[typeof( TargetJoint2D )] = new BSStaticWrapperObject_UnityEngine_TargetJoint2D();
            StaticTypes[typeof( FixedJoint2D )] = new BSStaticWrapperObject_UnityEngine_FixedJoint2D();
            StaticTypes[typeof( WheelJoint2D )] = new BSStaticWrapperObject_UnityEngine_WheelJoint2D();
            StaticTypes[typeof( Effector2D )] = new BSStaticWrapperObject_UnityEngine_Effector2D();
            StaticTypes[typeof( AreaEffector2D )] = new BSStaticWrapperObject_UnityEngine_AreaEffector2D();
            StaticTypes[typeof( BuoyancyEffector2D )] = new BSStaticWrapperObject_UnityEngine_BuoyancyEffector2D();
            StaticTypes[typeof( PointEffector2D )] = new BSStaticWrapperObject_UnityEngine_PointEffector2D();
            StaticTypes[typeof( PlatformEffector2D )] = new BSStaticWrapperObject_UnityEngine_PlatformEffector2D();
            StaticTypes[typeof( SurfaceEffector2D )] = new BSStaticWrapperObject_UnityEngine_SurfaceEffector2D();

            StaticTypes[typeof( PhysicsUpdateBehaviour2D )] =
                new BSStaticWrapperObject_UnityEngine_PhysicsUpdateBehaviour2D();

            StaticTypes[typeof( ConstantForce2D )] = new BSStaticWrapperObject_UnityEngine_ConstantForce2D();
            StaticTypes[typeof( ScreenCapture )] = new BSStaticWrapperObject_UnityEngine_ScreenCapture();
            StaticTypes[typeof( SpriteMask )] = new BSStaticWrapperObject_UnityEngine_SpriteMask();

            StaticTypes[typeof( SpriteShapeParameters )] =
                new BSStaticWrapperObject_UnityEngine_U2D_SpriteShapeParameters();

            StaticTypes[typeof( SpriteShapeSegment )] = new BSStaticWrapperObject_UnityEngine_U2D_SpriteShapeSegment();

            StaticTypes[typeof( SpriteShapeRenderer )] =
                new BSStaticWrapperObject_UnityEngine_U2D_SpriteShapeRenderer();

            StaticTypes[typeof( SpriteShapeMetaData )] =
                new BSStaticWrapperObject_UnityEngine_U2D_SpriteShapeMetaData();

            StaticTypes[typeof( ShapeControlPoint )] = new BSStaticWrapperObject_UnityEngine_U2D_ShapeControlPoint();
            StaticTypes[typeof( AngleRangeInfo )] = new BSStaticWrapperObject_UnityEngine_U2D_AngleRangeInfo();
            StaticTypes[typeof( SpriteShapeUtility )] = new BSStaticWrapperObject_UnityEngine_U2D_SpriteShapeUtility();
            StaticTypes[typeof( StreamingController )] = new BSStaticWrapperObject_UnityEngine_StreamingController();
            StaticTypes[typeof( IntegratedSubsystem )] = new BSStaticWrapperObject_UnityEngine_IntegratedSubsystem();

            StaticTypes[typeof( IntegratedSubsystemDescriptor )] =
                new BSStaticWrapperObject_UnityEngine_IntegratedSubsystemDescriptor();

            StaticTypes[typeof( ISubsystem )] = new BSStaticWrapperObject_UnityEngine_ISubsystem();
            StaticTypes[typeof( ISubsystemDescriptor )] = new BSStaticWrapperObject_UnityEngine_ISubsystemDescriptor();
            StaticTypes[typeof( Subsystem )] = new BSStaticWrapperObject_UnityEngine_Subsystem();
            StaticTypes[typeof( SubsystemDescriptor )] = new BSStaticWrapperObject_UnityEngine_SubsystemDescriptor();
            StaticTypes[typeof( SubsystemManager )] = new BSStaticWrapperObject_UnityEngine_SubsystemManager();

            StaticTypes[typeof( ExampleSubsystem )] =
                new BSStaticWrapperObject_UnityEngine_Subsystems_ExampleSubsystem();

            StaticTypes[typeof( ExampleSubsystemDescriptor )] =
                new BSStaticWrapperObject_UnityEngine_Subsystems_ExampleSubsystemDescriptor();

            StaticTypes[typeof( SubsystemDescriptorStore )] =
                new BSStaticWrapperObject_UnityEngine_SubsystemsImplementation_SubsystemDescriptorStore();

            StaticTypes[typeof( SubsystemDescriptorWithProvider )] =
                new BSStaticWrapperObject_UnityEngine_SubsystemsImplementation_SubsystemDescriptorWithProvider();

            StaticTypes[typeof( SubsystemProvider )] =
                new BSStaticWrapperObject_UnityEngine_SubsystemsImplementation_SubsystemProvider();

            StaticTypes[typeof( SubsystemWithProvider )] =
                new BSStaticWrapperObject_UnityEngine_SubsystemsImplementation_SubsystemWithProvider();

            StaticTypes[typeof( SubsystemDescriptorExtensions )] =
                new
                    BSStaticWrapperObject_UnityEngine_SubsystemsImplementation_Extensions_SubsystemDescriptorExtensions();

            StaticTypes[typeof( SubsystemExtensions )] =
                new BSStaticWrapperObject_UnityEngine_SubsystemsImplementation_Extensions_SubsystemExtensions();

            StaticTypes[typeof( Terrain )] = new BSStaticWrapperObject_UnityEngine_Terrain();
            StaticTypes[typeof( TerrainData )] = new BSStaticWrapperObject_UnityEngine_TerrainData();
            StaticTypes[typeof( TreeInstance )] = new BSStaticWrapperObject_UnityEngine_TreeInstance();
            StaticTypes[typeof( TerrainExtensions )] = new BSStaticWrapperObject_UnityEngine_TerrainExtensions();
            StaticTypes[typeof( Tree )] = new BSStaticWrapperObject_UnityEngine_Tree();
            StaticTypes[typeof( TreePrototype )] = new BSStaticWrapperObject_UnityEngine_TreePrototype();
            StaticTypes[typeof( DetailPrototype )] = new BSStaticWrapperObject_UnityEngine_DetailPrototype();
            StaticTypes[typeof( SplatPrototype )] = new BSStaticWrapperObject_UnityEngine_SplatPrototype();
            StaticTypes[typeof( PatchExtents )] = new BSStaticWrapperObject_UnityEngine_PatchExtents();
            StaticTypes[typeof( TerrainLayer )] = new BSStaticWrapperObject_UnityEngine_TerrainLayer();

            StaticTypes[typeof( BrushTransform )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_TerrainAPI_BrushTransform();

            StaticTypes[typeof( PaintContext )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_TerrainAPI_PaintContext();

            StaticTypes[typeof( TerrainCallbacks )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_TerrainAPI_TerrainCallbacks();

            StaticTypes[typeof( TerrainPaintUtility )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_TerrainAPI_TerrainPaintUtility();

            StaticTypes[typeof( TerrainUtility )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_TerrainAPI_TerrainUtility();

            StaticTypes[typeof( TerrainCollider )] = new BSStaticWrapperObject_UnityEngine_TerrainCollider();
            StaticTypes[typeof( FaceInfo )] = new BSStaticWrapperObject_UnityEngine_TextCore_FaceInfo();
            StaticTypes[typeof( GlyphRect )] = new BSStaticWrapperObject_UnityEngine_TextCore_GlyphRect();
            StaticTypes[typeof( GlyphMetrics )] = new BSStaticWrapperObject_UnityEngine_TextCore_GlyphMetrics();
            StaticTypes[typeof( Glyph )] = new BSStaticWrapperObject_UnityEngine_TextCore_Glyph();

            StaticTypes[typeof( GlyphValueRecord )] =
                new BSStaticWrapperObject_UnityEngine_TextCore_LowLevel_GlyphValueRecord();

            StaticTypes[typeof( GlyphAdjustmentRecord )] =
                new BSStaticWrapperObject_UnityEngine_TextCore_LowLevel_GlyphAdjustmentRecord();

            StaticTypes[typeof( GlyphPairAdjustmentRecord )] =
                new BSStaticWrapperObject_UnityEngine_TextCore_LowLevel_GlyphPairAdjustmentRecord();

            StaticTypes[typeof( FontEngine )] = new BSStaticWrapperObject_UnityEngine_TextCore_LowLevel_FontEngine();

            StaticTypes[typeof( TextGenerationSettings )] =
                new BSStaticWrapperObject_UnityEngine_TextGenerationSettings();

            StaticTypes[typeof( TextGenerator )] = new BSStaticWrapperObject_UnityEngine_TextGenerator();
            StaticTypes[typeof( TextMesh )] = new BSStaticWrapperObject_UnityEngine_TextMesh();
            StaticTypes[typeof( CharacterInfo )] = new BSStaticWrapperObject_UnityEngine_CharacterInfo();
            StaticTypes[typeof( UICharInfo )] = new BSStaticWrapperObject_UnityEngine_UICharInfo();
            StaticTypes[typeof( UILineInfo )] = new BSStaticWrapperObject_UnityEngine_UILineInfo();
            StaticTypes[typeof( UIVertex )] = new BSStaticWrapperObject_UnityEngine_UIVertex();

            StaticTypes[typeof( CustomGridBrushAttribute )] =
                new BSStaticWrapperObject_UnityEngine_CustomGridBrushAttribute();

            StaticTypes[typeof( GridBrushBase )] = new BSStaticWrapperObject_UnityEngine_GridBrushBase();
            StaticTypes[typeof( ITilemap )] = new BSStaticWrapperObject_UnityEngine_Tilemaps_ITilemap();
            StaticTypes[typeof( TileBase )] = new BSStaticWrapperObject_UnityEngine_Tilemaps_TileBase();
            StaticTypes[typeof( UnityEngine.Tilemaps.Tile )] = new BSStaticWrapperObject_UnityEngine_Tilemaps_Tile();
            StaticTypes[typeof( Tilemap )] = new BSStaticWrapperObject_UnityEngine_Tilemaps_Tilemap();
            StaticTypes[typeof( TilemapRenderer )] = new BSStaticWrapperObject_UnityEngine_Tilemaps_TilemapRenderer();
            StaticTypes[typeof( TileData )] = new BSStaticWrapperObject_UnityEngine_Tilemaps_TileData();

            StaticTypes[typeof( TileAnimationData )] =
                new BSStaticWrapperObject_UnityEngine_Tilemaps_TileAnimationData();

            StaticTypes[typeof( TilemapCollider2D )] =
                new BSStaticWrapperObject_UnityEngine_Tilemaps_TilemapCollider2D();

            StaticTypes[typeof( ICanvasRaycastFilter )] = new BSStaticWrapperObject_UnityEngine_ICanvasRaycastFilter();
            StaticTypes[typeof( CanvasGroup )] = new BSStaticWrapperObject_UnityEngine_CanvasGroup();
            StaticTypes[typeof( CanvasRenderer )] = new BSStaticWrapperObject_UnityEngine_CanvasRenderer();
            StaticTypes[typeof( RectTransformUtility )] = new BSStaticWrapperObject_UnityEngine_RectTransformUtility();
            StaticTypes[typeof( Canvas )] = new BSStaticWrapperObject_UnityEngine_Canvas();
            StaticTypes[typeof( UISystemProfilerApi )] = new BSStaticWrapperObject_UnityEngine_UISystemProfilerApi();
            StaticTypes[typeof( BindableElement )] = new BSStaticWrapperObject_UnityEngine_UIElements_BindableElement();
            StaticTypes[typeof( IBinding )] = new BSStaticWrapperObject_UnityEngine_UIElements_IBinding();
            StaticTypes[typeof( FocusController )] = new BSStaticWrapperObject_UnityEngine_UIElements_FocusController();
            StaticTypes[typeof( Focusable )] = new BSStaticWrapperObject_UnityEngine_UIElements_Focusable();
            StaticTypes[typeof( ITransform )] = new BSStaticWrapperObject_UnityEngine_UIElements_ITransform();

            StaticTypes[typeof( IExperimentalFeatures )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_IExperimentalFeatures();

            StaticTypes[typeof( ITransitionAnimations )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_Experimental_ITransitionAnimations();

            StaticTypes[typeof( VisualElement )] = new BSStaticWrapperObject_UnityEngine_UIElements_VisualElement();
            StaticTypes[typeof( IPanel )] = new BSStaticWrapperObject_UnityEngine_UIElements_IPanel();
            StaticTypes[typeof( EventDispatcher )] = new BSStaticWrapperObject_UnityEngine_UIElements_EventDispatcher();

            StaticTypes[typeof( ContextualMenuManager )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_ContextualMenuManager();

            StaticTypes[typeof( IVisualElementScheduler )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_IVisualElementScheduler();

            StaticTypes[typeof( IVisualElementScheduledItem )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_IVisualElementScheduledItem();

            StaticTypes[typeof( IStyle )] = new BSStaticWrapperObject_UnityEngine_UIElements_IStyle();
            StaticTypes[typeof( StyleColor )] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleColor();
            StaticTypes[typeof( StyleBackground )] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleBackground();
            StaticTypes[typeof( Background )] = new BSStaticWrapperObject_UnityEngine_UIElements_Background();
            StaticTypes[typeof( VectorImage )] = new BSStaticWrapperObject_UnityEngine_UIElements_VectorImage();
            StaticTypes[typeof( StyleLength )] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleLength();
            StaticTypes[typeof( Length )] = new BSStaticWrapperObject_UnityEngine_UIElements_Length();
            StaticTypes[typeof( StyleFloat )] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleFloat();
            StaticTypes[typeof( StyleCursor )] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleCursor();

            StaticTypes[typeof( UnityEngine.UIElements.Cursor )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_Cursor();

            StaticTypes[typeof( StyleFont )] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleFont();
            StaticTypes[typeof( StyleInt )] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleInt();
            StaticTypes[typeof( ICustomStyle )] = new BSStaticWrapperObject_UnityEngine_UIElements_ICustomStyle();

            StaticTypes[typeof( VisualElementStyleSheetSet )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_VisualElementStyleSheetSet();

            StaticTypes[typeof( StyleSheet )] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleSheet();
            StaticTypes[typeof( IResolvedStyle )] = new BSStaticWrapperObject_UnityEngine_UIElements_IResolvedStyle();
            StaticTypes[typeof( Clickable )] = new BSStaticWrapperObject_UnityEngine_UIElements_Clickable();

            StaticTypes[typeof( ContextualMenuManipulator )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_ContextualMenuManipulator();

            StaticTypes[typeof( DropdownMenuEventInfo )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_DropdownMenuEventInfo();

            StaticTypes[typeof( DropdownMenuItem )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_DropdownMenuItem();

            StaticTypes[typeof( DropdownMenuSeparator )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_DropdownMenuSeparator();

            StaticTypes[typeof( DropdownMenuAction )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_DropdownMenuAction();

            StaticTypes[typeof( DropdownMenu )] = new BSStaticWrapperObject_UnityEngine_UIElements_DropdownMenu();

            StaticTypes[typeof( EventDispatcherGate )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_EventDispatcherGate();

            StaticTypes[typeof( FocusChangeDirection )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_FocusChangeDirection();

            StaticTypes[typeof( IFocusRing )] = new BSStaticWrapperObject_UnityEngine_UIElements_IFocusRing();
            StaticTypes[typeof( EventBase )] = new BSStaticWrapperObject_UnityEngine_UIElements_EventBase();
            StaticTypes[typeof( IEventHandler )] = new BSStaticWrapperObject_UnityEngine_UIElements_IEventHandler();
            StaticTypes[typeof( IMGUIContainer )] = new BSStaticWrapperObject_UnityEngine_UIElements_IMGUIContainer();

            StaticTypes[typeof( ImmediateModeElement )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_ImmediateModeElement();

            StaticTypes[typeof( ManipulatorActivationFilter )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_ManipulatorActivationFilter();

            StaticTypes[typeof( IMouseEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_IMouseEvent();
            StaticTypes[typeof( IPointerEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_IPointerEvent();
            StaticTypes[typeof( IManipulator )] = new BSStaticWrapperObject_UnityEngine_UIElements_IManipulator();
            StaticTypes[typeof( Manipulator )] = new BSStaticWrapperObject_UnityEngine_UIElements_Manipulator();

            StaticTypes[typeof( MouseCaptureController )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_MouseCaptureController();

            StaticTypes[typeof( MouseManipulator )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_MouseManipulator();

            StaticTypes[typeof( PointerCaptureHelper )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_PointerCaptureHelper();

            StaticTypes[typeof( PointerManipulator )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_PointerManipulator();

            StaticTypes[typeof( TimerState )] = new BSStaticWrapperObject_UnityEngine_UIElements_TimerState();

            StaticTypes[typeof( TemplateContainer )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_TemplateContainer();

            StaticTypes[typeof( TextElement )] = new BSStaticWrapperObject_UnityEngine_UIElements_TextElement();
            StaticTypes[typeof( UQuery )] = new BSStaticWrapperObject_UnityEngine_UIElements_UQuery();

            StaticTypes[typeof( UQueryExtensions )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UQueryExtensions();

            StaticTypes[typeof( VisualElementExtensions )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_VisualElementExtensions();

            StaticTypes[typeof( VisualElementFocusChangeDirection )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_VisualElementFocusChangeDirection();

            StaticTypes[typeof( VisualElementFocusRing )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_VisualElementFocusRing();

            StaticTypes[typeof( IBindable )] = new BSStaticWrapperObject_UnityEngine_UIElements_IBindable();

            StaticTypes[typeof( IBindingExtensions )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_IBindingExtensions();

            StaticTypes[typeof( Box )] = new BSStaticWrapperObject_UnityEngine_UIElements_Box();
            StaticTypes[typeof( Button )] = new BSStaticWrapperObject_UnityEngine_UIElements_Button();
            StaticTypes[typeof( Foldout )] = new BSStaticWrapperObject_UnityEngine_UIElements_Foldout();
            StaticTypes[typeof( HelpBox )] = new BSStaticWrapperObject_UnityEngine_UIElements_HelpBox();
            StaticTypes[typeof( Image )] = new BSStaticWrapperObject_UnityEngine_UIElements_Image();

            StaticTypes[typeof( INotifyValueChangedExtensions )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_INotifyValueChangedExtensions();

            StaticTypes[typeof( Label )] = new BSStaticWrapperObject_UnityEngine_UIElements_Label();
            StaticTypes[typeof( ListView )] = new BSStaticWrapperObject_UnityEngine_UIElements_ListView();
            StaticTypes[typeof( IList )] = new BSStaticWrapperObject_System_Collections_IList();
            StaticTypes[typeof( MinMaxSlider )] = new BSStaticWrapperObject_UnityEngine_UIElements_MinMaxSlider();
            StaticTypes[typeof( PopupWindow )] = new BSStaticWrapperObject_UnityEngine_UIElements_PopupWindow();
            StaticTypes[typeof( RepeatButton )] = new BSStaticWrapperObject_UnityEngine_UIElements_RepeatButton();
            StaticTypes[typeof( Scroller )] = new BSStaticWrapperObject_UnityEngine_UIElements_Scroller();
            StaticTypes[typeof( Slider )] = new BSStaticWrapperObject_UnityEngine_UIElements_Slider();
            StaticTypes[typeof( ScrollView )] = new BSStaticWrapperObject_UnityEngine_UIElements_ScrollView();
            StaticTypes[typeof( SliderInt )] = new BSStaticWrapperObject_UnityEngine_UIElements_SliderInt();
            StaticTypes[typeof( TextField )] = new BSStaticWrapperObject_UnityEngine_UIElements_TextField();
            StaticTypes[typeof( Toggle )] = new BSStaticWrapperObject_UnityEngine_UIElements_Toggle();

            StaticTypes[typeof( TwoPaneSplitView )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_TwoPaneSplitView();

            StaticTypes[typeof( IPointerCaptureEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_IPointerCaptureEvent();

            StaticTypes[typeof( PointerCaptureOutEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_PointerCaptureOutEvent();

            StaticTypes[typeof( PointerCaptureEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_PointerCaptureEvent();

            StaticTypes[typeof( IMouseCaptureEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_IMouseCaptureEvent();

            StaticTypes[typeof( MouseCaptureOutEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_MouseCaptureOutEvent();

            StaticTypes[typeof( MouseCaptureEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_MouseCaptureEvent();

            StaticTypes[typeof( IChangeEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_IChangeEvent();
            StaticTypes[typeof( ICommandEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_ICommandEvent();

            StaticTypes[typeof( ValidateCommandEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_ValidateCommandEvent();

            StaticTypes[typeof( ExecuteCommandEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_ExecuteCommandEvent();

            StaticTypes[typeof( IDragAndDropEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_IDragAndDropEvent();

            StaticTypes[typeof( DragExitedEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_DragExitedEvent();
            StaticTypes[typeof( DragEnterEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_DragEnterEvent();
            StaticTypes[typeof( DragLeaveEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_DragLeaveEvent();

            StaticTypes[typeof( DragUpdatedEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_DragUpdatedEvent();

            StaticTypes[typeof( DragPerformEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_DragPerformEvent();

            StaticTypes[typeof( CallbackEventHandler )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_CallbackEventHandler();

            StaticTypes[typeof( IFocusEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_IFocusEvent();
            StaticTypes[typeof( FocusOutEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_FocusOutEvent();
            StaticTypes[typeof( BlurEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_BlurEvent();
            StaticTypes[typeof( FocusInEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_FocusInEvent();
            StaticTypes[typeof( FocusEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_FocusEvent();
            StaticTypes[typeof( InputEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_InputEvent();
            StaticTypes[typeof( IKeyboardEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_IKeyboardEvent();
            StaticTypes[typeof( KeyDownEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_KeyDownEvent();
            StaticTypes[typeof( KeyUpEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_KeyUpEvent();

            StaticTypes[typeof( GeometryChangedEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_GeometryChangedEvent();

            StaticTypes[typeof( MouseDownEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_MouseDownEvent();
            StaticTypes[typeof( MouseUpEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_MouseUpEvent();
            StaticTypes[typeof( MouseMoveEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_MouseMoveEvent();

            StaticTypes[typeof( ContextClickEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_ContextClickEvent();

            StaticTypes[typeof( WheelEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_WheelEvent();
            StaticTypes[typeof( MouseEnterEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_MouseEnterEvent();
            StaticTypes[typeof( MouseLeaveEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_MouseLeaveEvent();

            StaticTypes[typeof( MouseEnterWindowEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_MouseEnterWindowEvent();

            StaticTypes[typeof( MouseLeaveWindowEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_MouseLeaveWindowEvent();

            StaticTypes[typeof( MouseOverEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_MouseOverEvent();
            StaticTypes[typeof( MouseOutEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_MouseOutEvent();

            StaticTypes[typeof( ContextualMenuPopulateEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_ContextualMenuPopulateEvent();

            StaticTypes[typeof( IPanelChangedEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_IPanelChangedEvent();

            StaticTypes[typeof( AttachToPanelEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_AttachToPanelEvent();

            StaticTypes[typeof( DetachFromPanelEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_DetachFromPanelEvent();

            StaticTypes[typeof( PointerType )] = new BSStaticWrapperObject_UnityEngine_UIElements_PointerType();
            StaticTypes[typeof( PointerId )] = new BSStaticWrapperObject_UnityEngine_UIElements_PointerId();

            StaticTypes[typeof( PointerDownEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_PointerDownEvent();

            StaticTypes[typeof( PointerMoveEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_PointerMoveEvent();

            StaticTypes[typeof( PointerStationaryEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_PointerStationaryEvent();

            StaticTypes[typeof( PointerUpEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_PointerUpEvent();

            StaticTypes[typeof( PointerCancelEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_PointerCancelEvent();

            StaticTypes[typeof( ClickEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_ClickEvent();

            StaticTypes[typeof( PointerEnterEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_PointerEnterEvent();

            StaticTypes[typeof( PointerLeaveEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_PointerLeaveEvent();

            StaticTypes[typeof( PointerOverEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_PointerOverEvent();

            StaticTypes[typeof( PointerOutEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_PointerOutEvent();

            StaticTypes[typeof( CustomStyleResolvedEvent )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_CustomStyleResolvedEvent();

            StaticTypes[typeof( TooltipEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_TooltipEvent();
            StaticTypes[typeof( IMGUIEvent )] = new BSStaticWrapperObject_UnityEngine_UIElements_IMGUIEvent();
            StaticTypes[typeof( Vertex )] = new BSStaticWrapperObject_UnityEngine_UIElements_Vertex();
            StaticTypes[typeof( MeshWriteData )] = new BSStaticWrapperObject_UnityEngine_UIElements_MeshWriteData();

            StaticTypes[typeof( MeshGenerationContext )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_MeshGenerationContext();

            StaticTypes[typeof( ThemeStyleSheet )] = new BSStaticWrapperObject_UnityEngine_UIElements_ThemeStyleSheet();
            StaticTypes[typeof( IUxmlAttributes )] = new BSStaticWrapperObject_UnityEngine_UIElements_IUxmlAttributes();

            StaticTypes[typeof( UxmlRootElementFactory )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlRootElementFactory();

            StaticTypes[typeof( CreationContext )] = new BSStaticWrapperObject_UnityEngine_UIElements_CreationContext();
            StaticTypes[typeof( VisualTreeAsset )] = new BSStaticWrapperObject_UnityEngine_UIElements_VisualTreeAsset();

            StaticTypes[typeof( UxmlRootElementTraits )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlRootElementTraits();

            StaticTypes[typeof( UxmlStyleFactory )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlStyleFactory();

            StaticTypes[typeof( UxmlStyleTraits )] = new BSStaticWrapperObject_UnityEngine_UIElements_UxmlStyleTraits();

            StaticTypes[typeof( UxmlTemplateFactory )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlTemplateFactory();

            StaticTypes[typeof( UxmlTemplateTraits )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlTemplateTraits();

            StaticTypes[typeof( UxmlAttributeOverridesFactory )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlAttributeOverridesFactory();

            StaticTypes[typeof( UxmlAttributeOverridesTraits )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlAttributeOverridesTraits();

            StaticTypes[typeof( UxmlAttributeDescription )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlAttributeDescription();

            StaticTypes[typeof( UxmlTypeRestriction )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlTypeRestriction();

            StaticTypes[typeof( UxmlStringAttributeDescription )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlStringAttributeDescription();

            StaticTypes[typeof( UxmlFloatAttributeDescription )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlFloatAttributeDescription();

            StaticTypes[typeof( UxmlDoubleAttributeDescription )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlDoubleAttributeDescription();

            StaticTypes[typeof( UxmlIntAttributeDescription )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlIntAttributeDescription();

            StaticTypes[typeof( UxmlLongAttributeDescription )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlLongAttributeDescription();

            StaticTypes[typeof( UxmlBoolAttributeDescription )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlBoolAttributeDescription();

            StaticTypes[typeof( UxmlColorAttributeDescription )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlColorAttributeDescription();

            StaticTypes[typeof( UxmlChildElementDescription )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlChildElementDescription();

            StaticTypes[typeof( UxmlTraits )] = new BSStaticWrapperObject_UnityEngine_UIElements_UxmlTraits();
            StaticTypes[typeof( IUxmlFactory )] = new BSStaticWrapperObject_UnityEngine_UIElements_IUxmlFactory();

            StaticTypes[typeof( UxmlValueMatches )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_UxmlValueMatches();

            StaticTypes[typeof( UxmlValueBounds )] = new BSStaticWrapperObject_UnityEngine_UIElements_UxmlValueBounds();
            StaticTypes[typeof( UxmlEnumeration )] = new BSStaticWrapperObject_UnityEngine_UIElements_UxmlEnumeration();
            StaticTypes[typeof( Easing )] = new BSStaticWrapperObject_UnityEngine_UIElements_Experimental_Easing();

            StaticTypes[typeof( StyleValues )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_Experimental_StyleValues();

            StaticTypes[typeof( IValueAnimation )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_Experimental_IValueAnimation();

            StaticTypes[typeof( NetworkTransport )] =
                new BSStaticWrapperObject_UnityEngine_Networking_NetworkTransport();

            StaticTypes[typeof( EndPoint )] = new BSStaticWrapperObject_System_Net_EndPoint();
            StaticTypes[typeof( SocketAddress )] = new BSStaticWrapperObject_System_Net_SocketAddress();
            StaticTypes[typeof( HostTopology )] = new BSStaticWrapperObject_UnityEngine_Networking_HostTopology();

            StaticTypes[typeof( ConnectionConfig )] =
                new BSStaticWrapperObject_UnityEngine_Networking_ConnectionConfig();

            StaticTypes[typeof( ChannelQOS )] = new BSStaticWrapperObject_UnityEngine_Networking_ChannelQOS();
            StaticTypes[typeof( GlobalConfig )] = new BSStaticWrapperObject_UnityEngine_Networking_GlobalConfig();

            StaticTypes[typeof( ConnectionSimulatorConfig )] =
                new BSStaticWrapperObject_UnityEngine_Networking_ConnectionSimulatorConfig();

            StaticTypes[typeof( Utility )] = new BSStaticWrapperObject_UnityEngine_Networking_Utility();

            StaticTypes[typeof( NetworkAccessToken )] =
                new BSStaticWrapperObject_UnityEngine_Networking_Types_NetworkAccessToken();

            StaticTypes[typeof( MatchInfo )] = new BSStaticWrapperObject_UnityEngine_Networking_Match_MatchInfo();

            StaticTypes[typeof( MatchInfoSnapshot )] =
                new BSStaticWrapperObject_UnityEngine_Networking_Match_MatchInfoSnapshot();

            StaticTypes[typeof( NetworkMatch )] = new BSStaticWrapperObject_UnityEngine_Networking_Match_NetworkMatch();
            StaticTypes[typeof( Uri )] = new BSStaticWrapperObject_System_Uri();
            StaticTypes[typeof( RemoteSettings )] = new BSStaticWrapperObject_UnityEngine_RemoteSettings();
            StaticTypes[typeof( RemoteConfigSettings )] = new BSStaticWrapperObject_UnityEngine_RemoteConfigSettings();
            StaticTypes[typeof( ContinuousEvent )] = new BSStaticWrapperObject_UnityEngine_Analytics_ContinuousEvent();

            StaticTypes[typeof( AnalyticsSessionInfo )] =
                new BSStaticWrapperObject_UnityEngine_Analytics_AnalyticsSessionInfo();

            StaticTypes[typeof( Analytics )] = new BSStaticWrapperObject_UnityEngine_Analytics_Analytics();
            StaticTypes[typeof( WWWForm )] = new BSStaticWrapperObject_UnityEngine_WWWForm();

            StaticTypes[typeof( IMultipartFormSection )] =
                new BSStaticWrapperObject_UnityEngine_Networking_IMultipartFormSection();

            StaticTypes[typeof( MultipartFormDataSection )] =
                new BSStaticWrapperObject_UnityEngine_Networking_MultipartFormDataSection();

            StaticTypes[typeof( MultipartFormFileSection )] =
                new BSStaticWrapperObject_UnityEngine_Networking_MultipartFormFileSection();

            StaticTypes[typeof( UnityWebRequestAsyncOperation )] =
                new BSStaticWrapperObject_UnityEngine_Networking_UnityWebRequestAsyncOperation();

            StaticTypes[typeof( UnityWebRequest )] = new BSStaticWrapperObject_UnityEngine_Networking_UnityWebRequest();
            StaticTypes[typeof( UploadHandler )] = new BSStaticWrapperObject_UnityEngine_Networking_UploadHandler();
            StaticTypes[typeof( DownloadHandler )] = new BSStaticWrapperObject_UnityEngine_Networking_DownloadHandler();

            StaticTypes[typeof( CertificateHandler )] =
                new BSStaticWrapperObject_UnityEngine_Networking_CertificateHandler();

            StaticTypes[typeof( Encoding )] = new BSStaticWrapperObject_System_Text_Encoding();
            StaticTypes[typeof( EncoderFallback )] = new BSStaticWrapperObject_System_Text_EncoderFallback();
            StaticTypes[typeof( DecoderFallback )] = new BSStaticWrapperObject_System_Text_DecoderFallback();

            StaticTypes[typeof( DownloadHandlerBuffer )] =
                new BSStaticWrapperObject_UnityEngine_Networking_DownloadHandlerBuffer();

            StaticTypes[typeof( DownloadHandlerScript )] =
                new BSStaticWrapperObject_UnityEngine_Networking_DownloadHandlerScript();

            StaticTypes[typeof( DownloadHandlerFile )] =
                new BSStaticWrapperObject_UnityEngine_Networking_DownloadHandlerFile();

            StaticTypes[typeof( UploadHandlerRaw )] =
                new BSStaticWrapperObject_UnityEngine_Networking_UploadHandlerRaw();

            StaticTypes[typeof( UploadHandlerFile )] =
                new BSStaticWrapperObject_UnityEngine_Networking_UploadHandlerFile();

            StaticTypes[typeof( UnityWebRequestAssetBundle )] =
                new BSStaticWrapperObject_UnityEngine_Networking_UnityWebRequestAssetBundle();

            StaticTypes[typeof( DownloadHandlerAssetBundle )] =
                new BSStaticWrapperObject_UnityEngine_Networking_DownloadHandlerAssetBundle();

            StaticTypes[typeof( UnityWebRequestMultimedia )] =
                new BSStaticWrapperObject_UnityEngine_Networking_UnityWebRequestMultimedia();

            StaticTypes[typeof( DownloadHandlerAudioClip )] =
                new BSStaticWrapperObject_UnityEngine_Networking_DownloadHandlerAudioClip();

            StaticTypes[typeof( UnityWebRequestTexture )] =
                new BSStaticWrapperObject_UnityEngine_Networking_UnityWebRequestTexture();

            StaticTypes[typeof( DownloadHandlerTexture )] =
                new BSStaticWrapperObject_UnityEngine_Networking_DownloadHandlerTexture();

            StaticTypes[typeof( WWW )] = new BSStaticWrapperObject_UnityEngine_WWW();
            StaticTypes[typeof( WWWAudioExtensions )] = new BSStaticWrapperObject_UnityEngine_WWWAudioExtensions();
            StaticTypes[typeof( VFXEventAttribute )] = new BSStaticWrapperObject_UnityEngine_VFX_VFXEventAttribute();

            StaticTypes[typeof( VFXExpressionValues )] =
                new BSStaticWrapperObject_UnityEngine_VFX_VFXExpressionValues();

            StaticTypes[typeof( VFXManager )] = new BSStaticWrapperObject_UnityEngine_VFX_VFXManager();

            StaticTypes[typeof( VFXSpawnerCallbacks )] =
                new BSStaticWrapperObject_UnityEngine_VFX_VFXSpawnerCallbacks();

            StaticTypes[typeof( VFXSpawnerState )] = new BSStaticWrapperObject_UnityEngine_VFX_VFXSpawnerState();
            StaticTypes[typeof( VFXExposedProperty )] = new BSStaticWrapperObject_UnityEngine_VFX_VFXExposedProperty();
            StaticTypes[typeof( VisualEffectObject )] = new BSStaticWrapperObject_UnityEngine_VFX_VisualEffectObject();
            StaticTypes[typeof( VisualEffectAsset )] = new BSStaticWrapperObject_UnityEngine_VFX_VisualEffectAsset();
            StaticTypes[typeof( VFXOutputEventArgs )] = new BSStaticWrapperObject_UnityEngine_VFX_VFXOutputEventArgs();
            StaticTypes[typeof( VisualEffect )] = new BSStaticWrapperObject_UnityEngine_VFX_VisualEffect();

            StaticTypes[typeof( VFXParticleSystemInfo )] =
                new BSStaticWrapperObject_UnityEngine_VFX_VFXParticleSystemInfo();

            StaticTypes[typeof( RemoteSpeechAccess )] =
                new BSStaticWrapperObject_UnityEngineInternal_XR_WSA_RemoteSpeechAccess();

            StaticTypes[typeof( XRSettings )] = new BSStaticWrapperObject_UnityEngine_XR_XRSettings();
            StaticTypes[typeof( XRDevice )] = new BSStaticWrapperObject_UnityEngine_XR_XRDevice();
            StaticTypes[typeof( XRStats )] = new BSStaticWrapperObject_UnityEngine_XR_XRStats();
            StaticTypes[typeof( WheelHit )] = new BSStaticWrapperObject_UnityEngine_WheelHit();
            StaticTypes[typeof( WheelCollider )] = new BSStaticWrapperObject_UnityEngine_WheelCollider();

            StaticTypes[typeof( VideoClipPlayable )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Video_VideoClipPlayable();

            StaticTypes[typeof( VideoClip )] = new BSStaticWrapperObject_UnityEngine_Video_VideoClip();

            StaticTypes[typeof( VideoPlayerExtensions )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Video_VideoPlayerExtensions();

            StaticTypes[typeof( VideoPlayer )] = new BSStaticWrapperObject_UnityEngine_Video_VideoPlayer();

            StaticTypes[typeof( UnityEngine.Rendering.VirtualTexturing.System )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_VirtualTexturing_System();

            StaticTypes[typeof( EditorHelpers )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_VirtualTexturing_EditorHelpers();

            StaticTypes[typeof( Debugging )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_VirtualTexturing_Debugging();

            StaticTypes[typeof( Resolver )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_VirtualTexturing_Resolver();

            StaticTypes[typeof( GPUCacheSetting )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_VirtualTexturing_GPUCacheSetting();

            StaticTypes[typeof( Streaming )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_VirtualTexturing_Streaming();

            StaticTypes[typeof( Procedural )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_VirtualTexturing_Procedural();

            StaticTypes[typeof( WindZone )] = new BSStaticWrapperObject_UnityEngine_WindZone();
            StaticTypes[typeof( InputTracking )] = new BSStaticWrapperObject_UnityEngine_XR_InputTracking();
            StaticTypes[typeof( XRNodeState )] = new BSStaticWrapperObject_UnityEngine_XR_XRNodeState();
            StaticTypes[typeof( HapticCapabilities )] = new BSStaticWrapperObject_UnityEngine_XR_HapticCapabilities();
            StaticTypes[typeof( InputFeatureUsage )] = new BSStaticWrapperObject_UnityEngine_XR_InputFeatureUsage();
            StaticTypes[typeof( CommonUsages )] = new BSStaticWrapperObject_UnityEngine_XR_CommonUsages();
            StaticTypes[typeof( InputDevice )] = new BSStaticWrapperObject_UnityEngine_XR_InputDevice();
            StaticTypes[typeof( XRInputSubsystem )] = new BSStaticWrapperObject_UnityEngine_XR_XRInputSubsystem();

            StaticTypes[typeof( XRInputSubsystemDescriptor )] =
                new BSStaticWrapperObject_UnityEngine_XR_XRInputSubsystemDescriptor();

            StaticTypes[typeof( Hand )] = new BSStaticWrapperObject_UnityEngine_XR_Hand();
            StaticTypes[typeof( Eyes )] = new BSStaticWrapperObject_UnityEngine_XR_Eyes();
            StaticTypes[typeof( Bone )] = new BSStaticWrapperObject_UnityEngine_XR_Bone();
            StaticTypes[typeof( InputDevices )] = new BSStaticWrapperObject_UnityEngine_XR_InputDevices();
            StaticTypes[typeof( XRDisplaySubsystem )] = new BSStaticWrapperObject_UnityEngine_XR_XRDisplaySubsystem();

            StaticTypes[typeof( XRDisplaySubsystemDescriptor )] =
                new BSStaticWrapperObject_UnityEngine_XR_XRDisplaySubsystemDescriptor();

            StaticTypes[typeof( XRMirrorViewBlitMode )] =
                new BSStaticWrapperObject_UnityEngine_XR_XRMirrorViewBlitMode();

            StaticTypes[typeof( XRMirrorViewBlitModeDesc )] =
                new BSStaticWrapperObject_UnityEngine_XR_XRMirrorViewBlitModeDesc();

            StaticTypes[typeof( MeshId )] = new BSStaticWrapperObject_UnityEngine_XR_MeshId();

            StaticTypes[typeof( MeshGenerationResult )] =
                new BSStaticWrapperObject_UnityEngine_XR_MeshGenerationResult();

            StaticTypes[typeof( MeshInfo )] = new BSStaticWrapperObject_UnityEngine_XR_MeshInfo();
            StaticTypes[typeof( XRMeshSubsystem )] = new BSStaticWrapperObject_UnityEngine_XR_XRMeshSubsystem();

            StaticTypes[typeof( XRMeshSubsystemDescriptor )] =
                new BSStaticWrapperObject_UnityEngine_XR_XRMeshSubsystemDescriptor();

            StaticTypes[typeof( UnityEngine.XR.Provider.XRStats )] =
                new BSStaticWrapperObject_UnityEngine_XR_Provider_XRStats();

            StaticTypes[typeof( ConstructorInfo )] = new BSStaticWrapperObject_System_Reflection_ConstructorInfo();
            StaticTypes[typeof( IEqualityComparer )] = new BSStaticWrapperObject_System_Collections_IEqualityComparer();
            StaticTypes[typeof( IComparable )] = new BSStaticWrapperObject_System_IComparable();
            StaticTypes[typeof( AnimationTriggers )] = new BSStaticWrapperObject_UnityEngine_UI_AnimationTriggers();
            StaticTypes[typeof( UnityEngine.UI.Button )] = new BSStaticWrapperObject_UnityEngine_UI_Button();
            StaticTypes[typeof( Navigation )] = new BSStaticWrapperObject_UnityEngine_UI_Navigation();
            StaticTypes[typeof( Selectable )] = new BSStaticWrapperObject_UnityEngine_UI_Selectable();
            StaticTypes[typeof( ColorBlock )] = new BSStaticWrapperObject_UnityEngine_UI_ColorBlock();
            StaticTypes[typeof( SpriteState )] = new BSStaticWrapperObject_UnityEngine_UI_SpriteState();
            StaticTypes[typeof( Graphic )] = new BSStaticWrapperObject_UnityEngine_UI_Graphic();
            StaticTypes[typeof( UnityEngine.UI.Image )] = new BSStaticWrapperObject_UnityEngine_UI_Image();
            StaticTypes[typeof( ICanvasElement )] = new BSStaticWrapperObject_UnityEngine_UI_ICanvasElement();

            StaticTypes[typeof( CanvasUpdateRegistry )] =
                new BSStaticWrapperObject_UnityEngine_UI_CanvasUpdateRegistry();

            StaticTypes[typeof( ClipperRegistry )] = new BSStaticWrapperObject_UnityEngine_UI_ClipperRegistry();
            StaticTypes[typeof( Clipping )] = new BSStaticWrapperObject_UnityEngine_UI_Clipping();
            StaticTypes[typeof( IClipper )] = new BSStaticWrapperObject_UnityEngine_UI_IClipper();
            StaticTypes[typeof( IClippable )] = new BSStaticWrapperObject_UnityEngine_UI_IClippable();
            StaticTypes[typeof( DefaultControls )] = new BSStaticWrapperObject_UnityEngine_UI_DefaultControls();
            StaticTypes[typeof( Dropdown )] = new BSStaticWrapperObject_UnityEngine_UI_Dropdown();
            StaticTypes[typeof( Text )] = new BSStaticWrapperObject_UnityEngine_UI_Text();
            StaticTypes[typeof( FontData )] = new BSStaticWrapperObject_UnityEngine_UI_FontData();
            StaticTypes[typeof( FontUpdateTracker )] = new BSStaticWrapperObject_UnityEngine_UI_FontUpdateTracker();
            StaticTypes[typeof( GraphicRaycaster )] = new BSStaticWrapperObject_UnityEngine_UI_GraphicRaycaster();
            StaticTypes[typeof( BaseRaycaster )] = new BSStaticWrapperObject_UnityEngine_EventSystems_BaseRaycaster();

            StaticTypes[typeof( GraphicRebuildTracker )] =
                new BSStaticWrapperObject_UnityEngine_UI_GraphicRebuildTracker();

            StaticTypes[typeof( GraphicRegistry )] = new BSStaticWrapperObject_UnityEngine_UI_GraphicRegistry();
            StaticTypes[typeof( IMaskable )] = new BSStaticWrapperObject_UnityEngine_UI_IMaskable();
            StaticTypes[typeof( InputField )] = new BSStaticWrapperObject_UnityEngine_UI_InputField();
            StaticTypes[typeof( AspectRatioFitter )] = new BSStaticWrapperObject_UnityEngine_UI_AspectRatioFitter();
            StaticTypes[typeof( CanvasScaler )] = new BSStaticWrapperObject_UnityEngine_UI_CanvasScaler();
            StaticTypes[typeof( ContentSizeFitter )] = new BSStaticWrapperObject_UnityEngine_UI_ContentSizeFitter();
            StaticTypes[typeof( GridLayoutGroup )] = new BSStaticWrapperObject_UnityEngine_UI_GridLayoutGroup();

            StaticTypes[typeof( HorizontalLayoutGroup )] =
                new BSStaticWrapperObject_UnityEngine_UI_HorizontalLayoutGroup();

            StaticTypes[typeof( HorizontalOrVerticalLayoutGroup )] =
                new BSStaticWrapperObject_UnityEngine_UI_HorizontalOrVerticalLayoutGroup();

            StaticTypes[typeof( ILayoutElement )] = new BSStaticWrapperObject_UnityEngine_UI_ILayoutElement();
            StaticTypes[typeof( ILayoutController )] = new BSStaticWrapperObject_UnityEngine_UI_ILayoutController();
            StaticTypes[typeof( ILayoutGroup )] = new BSStaticWrapperObject_UnityEngine_UI_ILayoutGroup();

            StaticTypes[typeof( ILayoutSelfController )] =
                new BSStaticWrapperObject_UnityEngine_UI_ILayoutSelfController();

            StaticTypes[typeof( ILayoutIgnorer )] = new BSStaticWrapperObject_UnityEngine_UI_ILayoutIgnorer();
            StaticTypes[typeof( LayoutElement )] = new BSStaticWrapperObject_UnityEngine_UI_LayoutElement();
            StaticTypes[typeof( LayoutGroup )] = new BSStaticWrapperObject_UnityEngine_UI_LayoutGroup();
            StaticTypes[typeof( LayoutRebuilder )] = new BSStaticWrapperObject_UnityEngine_UI_LayoutRebuilder();
            StaticTypes[typeof( LayoutUtility )] = new BSStaticWrapperObject_UnityEngine_UI_LayoutUtility();
            StaticTypes[typeof( VerticalLayoutGroup )] = new BSStaticWrapperObject_UnityEngine_UI_VerticalLayoutGroup();
            StaticTypes[typeof( Mask )] = new BSStaticWrapperObject_UnityEngine_UI_Mask();
            StaticTypes[typeof( MaskUtilities )] = new BSStaticWrapperObject_UnityEngine_UI_MaskUtilities();
            StaticTypes[typeof( RectMask2D )] = new BSStaticWrapperObject_UnityEngine_UI_RectMask2D();
            StaticTypes[typeof( MaskableGraphic )] = new BSStaticWrapperObject_UnityEngine_UI_MaskableGraphic();
            StaticTypes[typeof( IMaterialModifier )] = new BSStaticWrapperObject_UnityEngine_UI_IMaterialModifier();
            StaticTypes[typeof( RawImage )] = new BSStaticWrapperObject_UnityEngine_UI_RawImage();
            StaticTypes[typeof( ScrollRect )] = new BSStaticWrapperObject_UnityEngine_UI_ScrollRect();
            StaticTypes[typeof( Scrollbar )] = new BSStaticWrapperObject_UnityEngine_UI_Scrollbar();
            StaticTypes[typeof( UnityEngine.UI.Slider )] = new BSStaticWrapperObject_UnityEngine_UI_Slider();
            StaticTypes[typeof( StencilMaterial )] = new BSStaticWrapperObject_UnityEngine_UI_StencilMaterial();
            StaticTypes[typeof( UnityEngine.UI.Toggle )] = new BSStaticWrapperObject_UnityEngine_UI_Toggle();
            StaticTypes[typeof( ToggleGroup )] = new BSStaticWrapperObject_UnityEngine_UI_ToggleGroup();
            StaticTypes[typeof( VertexHelper )] = new BSStaticWrapperObject_UnityEngine_UI_VertexHelper();
            StaticTypes[typeof( BaseMeshEffect )] = new BSStaticWrapperObject_UnityEngine_UI_BaseMeshEffect();
            StaticTypes[typeof( IMeshModifier )] = new BSStaticWrapperObject_UnityEngine_UI_IMeshModifier();
            StaticTypes[typeof( Outline )] = new BSStaticWrapperObject_UnityEngine_UI_Outline();
            StaticTypes[typeof( PositionAsUV1 )] = new BSStaticWrapperObject_UnityEngine_UI_PositionAsUV1();
            StaticTypes[typeof( Shadow )] = new BSStaticWrapperObject_UnityEngine_UI_Shadow();
            StaticTypes[typeof( AxisEventData )] = new BSStaticWrapperObject_UnityEngine_EventSystems_AxisEventData();

            StaticTypes[typeof( BaseInputModule )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_BaseInputModule();

            StaticTypes[typeof( BaseInput )] = new BSStaticWrapperObject_UnityEngine_EventSystems_BaseInput();

            StaticTypes[typeof( AbstractEventData )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_AbstractEventData();

            StaticTypes[typeof( BaseEventData )] = new BSStaticWrapperObject_UnityEngine_EventSystems_BaseEventData();

            StaticTypes[typeof( PointerEventData )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_PointerEventData();

            StaticTypes[typeof( RaycastResult )] = new BSStaticWrapperObject_UnityEngine_EventSystems_RaycastResult();

            StaticTypes[typeof( IEventSystemHandler )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_IEventSystemHandler();

            StaticTypes[typeof( IPointerEnterHandler )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_IPointerEnterHandler();

            StaticTypes[typeof( IPointerExitHandler )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_IPointerExitHandler();

            StaticTypes[typeof( IPointerDownHandler )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_IPointerDownHandler();

            StaticTypes[typeof( IPointerUpHandler )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_IPointerUpHandler();

            StaticTypes[typeof( IPointerClickHandler )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_IPointerClickHandler();

            StaticTypes[typeof( IBeginDragHandler )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_IBeginDragHandler();

            StaticTypes[typeof( IInitializePotentialDragHandler )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_IInitializePotentialDragHandler();

            StaticTypes[typeof( IDragHandler )] = new BSStaticWrapperObject_UnityEngine_EventSystems_IDragHandler();

            StaticTypes[typeof( IEndDragHandler )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_IEndDragHandler();

            StaticTypes[typeof( IDropHandler )] = new BSStaticWrapperObject_UnityEngine_EventSystems_IDropHandler();
            StaticTypes[typeof( IScrollHandler )] = new BSStaticWrapperObject_UnityEngine_EventSystems_IScrollHandler();

            StaticTypes[typeof( IUpdateSelectedHandler )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_IUpdateSelectedHandler();

            StaticTypes[typeof( ISelectHandler )] = new BSStaticWrapperObject_UnityEngine_EventSystems_ISelectHandler();

            StaticTypes[typeof( IDeselectHandler )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_IDeselectHandler();

            StaticTypes[typeof( IMoveHandler )] = new BSStaticWrapperObject_UnityEngine_EventSystems_IMoveHandler();
            StaticTypes[typeof( ISubmitHandler )] = new BSStaticWrapperObject_UnityEngine_EventSystems_ISubmitHandler();
            StaticTypes[typeof( ICancelHandler )] = new BSStaticWrapperObject_UnityEngine_EventSystems_ICancelHandler();
            StaticTypes[typeof( EventSystem )] = new BSStaticWrapperObject_UnityEngine_EventSystems_EventSystem();
            StaticTypes[typeof( EventTrigger )] = new BSStaticWrapperObject_UnityEngine_EventSystems_EventTrigger();
            StaticTypes[typeof( ExecuteEvents )] = new BSStaticWrapperObject_UnityEngine_EventSystems_ExecuteEvents();

            StaticTypes[typeof( PointerInputModule )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_PointerInputModule();

            StaticTypes[typeof( StandaloneInputModule )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_StandaloneInputModule();

            StaticTypes[typeof( TouchInputModule )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_TouchInputModule();

            StaticTypes[typeof( Physics2DRaycaster )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_Physics2DRaycaster();

            StaticTypes[typeof( PhysicsRaycaster )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_PhysicsRaycaster();

            StaticTypes[typeof( UIBehaviour )] = new BSStaticWrapperObject_UnityEngine_EventSystems_UIBehaviour();

        }

#endregion
    }

}
