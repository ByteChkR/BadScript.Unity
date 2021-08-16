using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
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

    public class UnityCoreStaticDB : WrapperStaticDataBase
    {
        #region Public

        public UnityCoreStaticDB()
        {
            StaticTypes[typeof( GameObject )] = new BSStaticWrapperObject_UnityEngine_GameObject();
            StaticTypes[typeof( Transform )] = new BSStaticWrapperObject_UnityEngine_Transform();
            StaticTypes[typeof( Vector3 )] = new BSStaticWrapperObject_UnityEngine_Vector3();
            StaticTypes[typeof( object )] = new BSStaticWrapperObject_System_Object();
            StaticTypes[typeof( IFormatProvider )] = new BSStaticWrapperObject_System_IFormatProvider();
            StaticTypes[typeof( Quaternion )] = new BSStaticWrapperObject_UnityEngine_Quaternion();
            StaticTypes[typeof( Matrix4x4 )] = new BSStaticWrapperObject_UnityEngine_Matrix4x4();
            StaticTypes[typeof( FrustumPlanes )] = new BSStaticWrapperObject_UnityEngine_FrustumPlanes();
            StaticTypes[typeof( Vector4 )] = new BSStaticWrapperObject_UnityEngine_Vector4();
            StaticTypes[typeof( Plane )] = new BSStaticWrapperObject_UnityEngine_Plane();
            StaticTypes[typeof( IEnumerator )] = new BSStaticWrapperObject_System_Collections_IEnumerator();
            StaticTypes[typeof( Component )] = new BSStaticWrapperObject_UnityEngine_Component();
            StaticTypes[typeof( Scene )] = new BSStaticWrapperObject_UnityEngine_SceneManagement_Scene();
            StaticTypes[typeof( MonoBehaviour )] = new BSStaticWrapperObject_UnityEngine_MonoBehaviour();
            StaticTypes[typeof( Coroutine )] = new BSStaticWrapperObject_UnityEngine_Coroutine();
            StaticTypes[typeof( Object )] = new BSStaticWrapperObject_UnityEngine_Object();
            StaticTypes[typeof( Physics )] = new BSStaticWrapperObject_UnityEngine_Physics();
            StaticTypes[typeof( PhysicsScene )] = new BSStaticWrapperObject_UnityEngine_PhysicsScene();
            StaticTypes[typeof( Collider )] = new BSStaticWrapperObject_UnityEngine_Collider();
            StaticTypes[typeof( Rigidbody )] = new BSStaticWrapperObject_UnityEngine_Rigidbody();
            StaticTypes[typeof( ArticulationBody )] = new BSStaticWrapperObject_UnityEngine_ArticulationBody();
            StaticTypes[typeof( ArticulationDrive )] = new BSStaticWrapperObject_UnityEngine_ArticulationDrive();

            StaticTypes[typeof( ArticulationReducedSpace )] =
                new BSStaticWrapperObject_UnityEngine_ArticulationReducedSpace();

            StaticTypes[typeof( Bounds )] = new BSStaticWrapperObject_UnityEngine_Bounds();
            StaticTypes[typeof( Ray )] = new BSStaticWrapperObject_UnityEngine_Ray();
            StaticTypes[typeof( PhysicMaterial )] = new BSStaticWrapperObject_UnityEngine_PhysicMaterial();
            StaticTypes[typeof( Input )] = new BSStaticWrapperObject_UnityEngine_Input();
            StaticTypes[typeof( Vector2 )] = new BSStaticWrapperObject_UnityEngine_Vector2();
            StaticTypes[typeof( LocationService )] = new BSStaticWrapperObject_UnityEngine_LocationService();
            StaticTypes[typeof( LocationInfo )] = new BSStaticWrapperObject_UnityEngine_LocationInfo();
            StaticTypes[typeof( Compass )] = new BSStaticWrapperObject_UnityEngine_Compass();
            StaticTypes[typeof( Gyroscope )] = new BSStaticWrapperObject_UnityEngine_Gyroscope();
            StaticTypes[typeof( Touch )] = new BSStaticWrapperObject_UnityEngine_Touch();
            StaticTypes[typeof( AccelerationEvent )] = new BSStaticWrapperObject_UnityEngine_AccelerationEvent();
            StaticTypes[typeof( LayerMask )] = new BSStaticWrapperObject_UnityEngine_LayerMask();
            StaticTypes[typeof( Camera )] = new BSStaticWrapperObject_UnityEngine_Camera();
            StaticTypes[typeof( Color )] = new BSStaticWrapperObject_UnityEngine_Color();
            StaticTypes[typeof( Rect )] = new BSStaticWrapperObject_UnityEngine_Rect();
            StaticTypes[typeof( RenderTexture )] = new BSStaticWrapperObject_UnityEngine_RenderTexture();
            StaticTypes[typeof( RenderBuffer )] = new BSStaticWrapperObject_UnityEngine_RenderBuffer();
            StaticTypes[typeof( IntPtr )] = new BSStaticWrapperObject_System_IntPtr();

            StaticTypes[typeof( RenderTextureDescriptor )] =
                new BSStaticWrapperObject_UnityEngine_RenderTextureDescriptor();

            StaticTypes[typeof( Hash128 )] = new BSStaticWrapperObject_UnityEngine_Hash128();
            StaticTypes[typeof( Shader )] = new BSStaticWrapperObject_UnityEngine_Shader();
            StaticTypes[typeof( ShaderTagId )] = new BSStaticWrapperObject_UnityEngine_Rendering_ShaderTagId();
            StaticTypes[typeof( Texture )] = new BSStaticWrapperObject_UnityEngine_Texture();
            StaticTypes[typeof( ComputeBuffer )] = new BSStaticWrapperObject_UnityEngine_ComputeBuffer();
            StaticTypes[typeof( Array )] = new BSStaticWrapperObject_System_Array();
            StaticTypes[typeof( IComparer )] = new BSStaticWrapperObject_System_Collections_IComparer();
            StaticTypes[typeof( GraphicsBuffer )] = new BSStaticWrapperObject_UnityEngine_GraphicsBuffer();
            StaticTypes[typeof( Cubemap )] = new BSStaticWrapperObject_UnityEngine_Cubemap();
            StaticTypes[typeof( CommandBuffer )] = new BSStaticWrapperObject_UnityEngine_Rendering_CommandBuffer();

            StaticTypes[typeof( RenderTargetIdentifier )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_RenderTargetIdentifier();

            StaticTypes[typeof( ComputeShader )] = new BSStaticWrapperObject_UnityEngine_ComputeShader();

            StaticTypes[typeof( RayTracingShader )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Rendering_RayTracingShader();

            StaticTypes[typeof( RayTracingAccelerationStructure )] =
                new BSStaticWrapperObject_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure();

            StaticTypes[typeof( Renderer )] = new BSStaticWrapperObject_UnityEngine_Renderer();
            StaticTypes[typeof( Material )] = new BSStaticWrapperObject_UnityEngine_Material();

            StaticTypes[typeof( MaterialPropertyBlock )] =
                new BSStaticWrapperObject_UnityEngine_MaterialPropertyBlock();

            StaticTypes[typeof( CustomSampler )] = new BSStaticWrapperObject_UnityEngine_Profiling_CustomSampler();
            StaticTypes[typeof( Recorder )] = new BSStaticWrapperObject_UnityEngine_Profiling_Recorder();

            StaticTypes[typeof( RenderTargetBinding )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_RenderTargetBinding();

            StaticTypes[typeof( Mesh )] = new BSStaticWrapperObject_UnityEngine_Mesh();

            StaticTypes[typeof( VertexAttributeDescriptor )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_VertexAttributeDescriptor();

            StaticTypes[typeof( SubMeshDescriptor )] =
                new BSStaticWrapperObject_UnityEngine_Rendering_SubMeshDescriptor();

            StaticTypes[typeof( RectInt )] = new BSStaticWrapperObject_UnityEngine_RectInt();
            StaticTypes[typeof( Vector2Int )] = new BSStaticWrapperObject_UnityEngine_Vector2Int();
            StaticTypes[typeof( GraphicsFence )] = new BSStaticWrapperObject_UnityEngine_Rendering_GPUFence();
            StaticTypes[typeof( MeshFilter )] = new BSStaticWrapperObject_UnityEngine_MeshFilter();
            StaticTypes[typeof( MeshCollider )] = new BSStaticWrapperObject_UnityEngine_MeshCollider();
            StaticTypes[typeof( BoxCollider )] = new BSStaticWrapperObject_UnityEngine_BoxCollider();
            StaticTypes[typeof( SphereCollider )] = new BSStaticWrapperObject_UnityEngine_SphereCollider();
            StaticTypes[typeof( CapsuleCollider )] = new BSStaticWrapperObject_UnityEngine_CapsuleCollider();
            StaticTypes[typeof( RectTransform )] = new BSStaticWrapperObject_UnityEngine_RectTransform();
            StaticTypes[typeof( ScrollView )] = new BSStaticWrapperObject_UnityEngine_UIElements_ScrollView();
            StaticTypes[typeof( VisualElement )] = new BSStaticWrapperObject_UnityEngine_UIElements_VisualElement();
            StaticTypes[typeof( FocusController )] = new BSStaticWrapperObject_UnityEngine_UIElements_FocusController();
            StaticTypes[typeof( Focusable )] = new BSStaticWrapperObject_UnityEngine_UIElements_Focusable();
            StaticTypes[typeof( EventBase )] = new BSStaticWrapperObject_UnityEngine_UIElements_EventBase();
            StaticTypes[typeof( IEventHandler )] = new BSStaticWrapperObject_UnityEngine_UIElements_IEventHandler();
            StaticTypes[typeof( Event )] = new BSStaticWrapperObject_UnityEngine_Event();
            StaticTypes[typeof( char )] = new BSStaticWrapperObject_System_Char();
            StaticTypes[typeof( CultureInfo )] = new BSStaticWrapperObject_System_Globalization_CultureInfo();
            StaticTypes[typeof( Calendar )] = new BSStaticWrapperObject_System_Globalization_Calendar();
            StaticTypes[typeof( DateTime )] = new BSStaticWrapperObject_System_DateTime();
            StaticTypes[typeof( TimeSpan )] = new BSStaticWrapperObject_System_TimeSpan();
            StaticTypes[typeof( TextInfo )] = new BSStaticWrapperObject_System_Globalization_TextInfo();
            StaticTypes[typeof( CompareInfo )] = new BSStaticWrapperObject_System_Globalization_CompareInfo();
            StaticTypes[typeof( SortVersion )] = new BSStaticWrapperObject_System_Globalization_SortVersion();
            StaticTypes[typeof( Guid )] = new BSStaticWrapperObject_System_Guid();
            StaticTypes[typeof( SortKey )] = new BSStaticWrapperObject_System_Globalization_SortKey();
            StaticTypes[typeof( Assembly )] = new BSStaticWrapperObject_System_Reflection_Assembly();
            StaticTypes[typeof( MethodInfo )] = new BSStaticWrapperObject_System_Reflection_MethodInfo();
            StaticTypes[typeof( ParameterInfo )] = new BSStaticWrapperObject_System_Reflection_ParameterInfo();
            StaticTypes[typeof( MemberInfo )] = new BSStaticWrapperObject_System_Reflection_MemberInfo();
            StaticTypes[typeof( Module )] = new BSStaticWrapperObject_System_Reflection_Module();
            StaticTypes[typeof( ModuleHandle )] = new BSStaticWrapperObject_System_ModuleHandle();
            StaticTypes[typeof( RuntimeFieldHandle )] = new BSStaticWrapperObject_System_RuntimeFieldHandle();

            StaticTypes[typeof( SerializationInfo )] =
                new BSStaticWrapperObject_System_Runtime_Serialization_SerializationInfo();

            StaticTypes[typeof( SerializationInfoEnumerator )] =
                new BSStaticWrapperObject_System_Runtime_Serialization_SerializationInfoEnumerator();

            StaticTypes[typeof( SerializationEntry )] =
                new BSStaticWrapperObject_System_Runtime_Serialization_SerializationEntry();

            StaticTypes[typeof( StreamingContext )] =
                new BSStaticWrapperObject_System_Runtime_Serialization_StreamingContext();

            StaticTypes[typeof( RuntimeMethodHandle )] = new BSStaticWrapperObject_System_RuntimeMethodHandle();
            StaticTypes[typeof( RuntimeTypeHandle )] = new BSStaticWrapperObject_System_RuntimeTypeHandle();
            StaticTypes[typeof( TypeFilter )] = new BSStaticWrapperObject_System_Reflection_TypeFilter();
            StaticTypes[typeof( IAsyncResult )] = new BSStaticWrapperObject_System_IAsyncResult();
            StaticTypes[typeof( WaitHandle )] = new BSStaticWrapperObject_System_Threading_WaitHandle();

            StaticTypes[typeof( SafeWaitHandle )] =
                new BSStaticWrapperObject_Microsoft_Win32_SafeHandles_SafeWaitHandle();

            StaticTypes[typeof( IDictionary )] = new BSStaticWrapperObject_System_Collections_IDictionary();
            StaticTypes[typeof( ICollection )] = new BSStaticWrapperObject_System_Collections_ICollection();

            StaticTypes[typeof( IDictionaryEnumerator )] =
                new BSStaticWrapperObject_System_Collections_IDictionaryEnumerator();

            StaticTypes[typeof( DictionaryEntry )] = new BSStaticWrapperObject_System_Collections_DictionaryEntry();
            StaticTypes[typeof( AsyncCallback )] = new BSStaticWrapperObject_System_AsyncCallback();
            StaticTypes[typeof( FieldInfo )] = new BSStaticWrapperObject_System_Reflection_FieldInfo();
            StaticTypes[typeof( Binder )] = new BSStaticWrapperObject_System_Reflection_Binder();
            StaticTypes[typeof( MethodBase )] = new BSStaticWrapperObject_System_Reflection_MethodBase();
            StaticTypes[typeof( MethodBody )] = new BSStaticWrapperObject_System_Reflection_MethodBody();
            StaticTypes[typeof( PropertyInfo )] = new BSStaticWrapperObject_System_Reflection_PropertyInfo();

            StaticTypes[typeof( X509Certificate )] =
                new BSStaticWrapperObject_System_Security_Cryptography_X509Certificates_X509Certificate();

            StaticTypes[typeof( SecureString )] = new BSStaticWrapperObject_System_Security_SecureString();

            StaticTypes[typeof( ICustomAttributeProvider )] =
                new BSStaticWrapperObject_System_Reflection_ICustomAttributeProvider();

            StaticTypes[typeof( Delegate )] = new BSStaticWrapperObject_System_Delegate();
            StaticTypes[typeof( IPermission )] = new BSStaticWrapperObject_System_Security_IPermission();
            StaticTypes[typeof( SecurityElement )] = new BSStaticWrapperObject_System_Security_SecurityElement();
            StaticTypes[typeof( Hashtable )] = new BSStaticWrapperObject_System_Collections_Hashtable();
            StaticTypes[typeof( ArrayList )] = new BSStaticWrapperObject_System_Collections_ArrayList();
            StaticTypes[typeof( IList )] = new BSStaticWrapperObject_System_Collections_IList();

            StaticTypes[typeof( ModuleResolveEventHandler )] =
                new BSStaticWrapperObject_System_Reflection_ModuleResolveEventHandler();

            StaticTypes[typeof( ResolveEventArgs )] = new BSStaticWrapperObject_System_ResolveEventArgs();
            StaticTypes[typeof( FileStream )] = new BSStaticWrapperObject_System_IO_FileStream();

            StaticTypes[typeof( SafeFileHandle )] =
                new BSStaticWrapperObject_Microsoft_Win32_SafeHandles_SafeFileHandle();

            StaticTypes[typeof( Task )] = new BSStaticWrapperObject_System_Threading_Tasks_Task();
            StaticTypes[typeof( TaskFactory )] = new BSStaticWrapperObject_System_Threading_Tasks_TaskFactory();
            StaticTypes[typeof( CancellationToken )] = new BSStaticWrapperObject_System_Threading_CancellationToken();

            StaticTypes[typeof( CancellationTokenRegistration )] =
                new BSStaticWrapperObject_System_Threading_CancellationTokenRegistration();

            StaticTypes[typeof( Action )] = new BSStaticWrapperObject_System_Action();
            StaticTypes[typeof( TaskScheduler )] = new BSStaticWrapperObject_System_Threading_Tasks_TaskScheduler();
            StaticTypes[typeof( AggregateException )] = new BSStaticWrapperObject_System_AggregateException();
            StaticTypes[typeof( Exception )] = new BSStaticWrapperObject_System_Exception();

            StaticTypes[typeof( TaskAwaiter )] =
                new BSStaticWrapperObject_System_Runtime_CompilerServices_TaskAwaiter();

            StaticTypes[typeof( ConfiguredTaskAwaitable )] =
                new BSStaticWrapperObject_System_Runtime_CompilerServices_ConfiguredTaskAwaitable();

            StaticTypes[typeof( YieldAwaitable )] =
                new BSStaticWrapperObject_System_Runtime_CompilerServices_YieldAwaitable();

            StaticTypes[typeof( Stream )] = new BSStaticWrapperObject_System_IO_Stream();
            StaticTypes[typeof( AssemblyName )] = new BSStaticWrapperObject_System_Reflection_AssemblyName();
            StaticTypes[typeof( StrongNameKeyPair )] = new BSStaticWrapperObject_System_Reflection_StrongNameKeyPair();
            StaticTypes[typeof( Version )] = new BSStaticWrapperObject_System_Version();

            StaticTypes[typeof( ManifestResourceInfo )] =
                new BSStaticWrapperObject_System_Reflection_ManifestResourceInfo();

            StaticTypes[typeof( NumberFormatInfo )] = new BSStaticWrapperObject_System_Globalization_NumberFormatInfo();

            StaticTypes[typeof( DateTimeFormatInfo )] =
                new BSStaticWrapperObject_System_Globalization_DateTimeFormatInfo();

            StaticTypes[typeof( ITransform )] = new BSStaticWrapperObject_UnityEngine_UIElements_ITransform();

            StaticTypes[typeof( IExperimentalFeatures )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_IExperimentalFeatures();

            StaticTypes[typeof( ITransitionAnimations )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_Experimental_ITransitionAnimations();

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
            StaticTypes[typeof( Texture2D )] = new BSStaticWrapperObject_UnityEngine_Texture2D();
            StaticTypes[typeof( VectorImage )] = new BSStaticWrapperObject_UnityEngine_UIElements_VectorImage();
            StaticTypes[typeof( StyleLength )] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleLength();
            StaticTypes[typeof( Length )] = new BSStaticWrapperObject_UnityEngine_UIElements_Length();
            StaticTypes[typeof( StyleFloat )] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleFloat();
            StaticTypes[typeof( StyleCursor )] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleCursor();
            StaticTypes[typeof( Cursor )] = new BSStaticWrapperObject_UnityEngine_UIElements_Cursor();
            StaticTypes[typeof( StyleFont )] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleFont();
            StaticTypes[typeof( Font )] = new BSStaticWrapperObject_UnityEngine_Font();
            StaticTypes[typeof( StyleInt )] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleInt();
            StaticTypes[typeof( ICustomStyle )] = new BSStaticWrapperObject_UnityEngine_UIElements_ICustomStyle();

            StaticTypes[typeof( VisualElementStyleSheetSet )] =
                new BSStaticWrapperObject_UnityEngine_UIElements_VisualElementStyleSheetSet();

            StaticTypes[typeof( StyleSheet )] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleSheet();
            StaticTypes[typeof( IResolvedStyle )] = new BSStaticWrapperObject_UnityEngine_UIElements_IResolvedStyle();
            StaticTypes[typeof( Scroller )] = new BSStaticWrapperObject_UnityEngine_UIElements_Scroller();
            StaticTypes[typeof( Slider )] = new BSStaticWrapperObject_UnityEngine_UIElements_Slider();
            StaticTypes[typeof( Label )] = new BSStaticWrapperObject_UnityEngine_UIElements_Label();
            StaticTypes[typeof( IBinding )] = new BSStaticWrapperObject_UnityEngine_UIElements_IBinding();
            StaticTypes[typeof( RepeatButton )] = new BSStaticWrapperObject_UnityEngine_UIElements_RepeatButton();
            StaticTypes[typeof( Text )] = new BSStaticWrapperObject_UnityEngine_UI_Text();
            StaticTypes[typeof( TextGenerator )] = new BSStaticWrapperObject_UnityEngine_TextGenerator();

            StaticTypes[typeof( TextGenerationSettings )] =
                new BSStaticWrapperObject_UnityEngine_TextGenerationSettings();

            StaticTypes[typeof( Canvas )] = new BSStaticWrapperObject_UnityEngine_Canvas();
            StaticTypes[typeof( CanvasRenderer )] = new BSStaticWrapperObject_UnityEngine_CanvasRenderer();
            StaticTypes[typeof( UnityAction )] = new BSStaticWrapperObject_UnityEngine_Events_UnityAction();
            StaticTypes[typeof( InputField )] = new BSStaticWrapperObject_UnityEngine_UI_InputField();
            StaticTypes[typeof( Graphic )] = new BSStaticWrapperObject_UnityEngine_UI_Graphic();
            StaticTypes[typeof( TouchScreenKeyboard )] = new BSStaticWrapperObject_UnityEngine_TouchScreenKeyboard();
            StaticTypes[typeof( RangeInt )] = new BSStaticWrapperObject_UnityEngine_RangeInt();
            StaticTypes[typeof( Navigation )] = new BSStaticWrapperObject_UnityEngine_UI_Navigation();
            StaticTypes[typeof( Selectable )] = new BSStaticWrapperObject_UnityEngine_UI_Selectable();
            StaticTypes[typeof( ColorBlock )] = new BSStaticWrapperObject_UnityEngine_UI_ColorBlock();
            StaticTypes[typeof( SpriteState )] = new BSStaticWrapperObject_UnityEngine_UI_SpriteState();
            StaticTypes[typeof( Sprite )] = new BSStaticWrapperObject_UnityEngine_Sprite();
            StaticTypes[typeof( AnimationTriggers )] = new BSStaticWrapperObject_UnityEngine_UI_AnimationTriggers();
            StaticTypes[typeof( Image )] = new BSStaticWrapperObject_UnityEngine_UI_Image();
            StaticTypes[typeof( Animator )] = new BSStaticWrapperObject_UnityEngine_Animator();

            StaticTypes[typeof( RuntimeAnimatorController )] =
                new BSStaticWrapperObject_UnityEngine_RuntimeAnimatorController();

            StaticTypes[typeof( Avatar )] = new BSStaticWrapperObject_UnityEngine_Avatar();
            StaticTypes[typeof( HumanDescription )] = new BSStaticWrapperObject_UnityEngine_HumanDescription();
            StaticTypes[typeof( PlayableGraph )] = new BSStaticWrapperObject_UnityEngine_Playables_PlayableGraph();
            StaticTypes[typeof( Playable )] = new BSStaticWrapperObject_UnityEngine_Playables_Playable();
            StaticTypes[typeof( PlayableHandle )] = new BSStaticWrapperObject_UnityEngine_Playables_PlayableHandle();
            StaticTypes[typeof( PlayableOutput )] = new BSStaticWrapperObject_UnityEngine_Playables_PlayableOutput();

            StaticTypes[typeof( PlayableOutputHandle )] =
                new BSStaticWrapperObject_UnityEngine_Playables_PlayableOutputHandle();

            StaticTypes[typeof( IExposedPropertyTable )] =
                new BSStaticWrapperObject_UnityEngine_IExposedPropertyTable();

            StaticTypes[typeof( PropertyName )] = new BSStaticWrapperObject_UnityEngine_PropertyName();
            StaticTypes[typeof( AnimatorStateInfo )] = new BSStaticWrapperObject_UnityEngine_AnimatorStateInfo();

            StaticTypes[typeof( AnimatorTransitionInfo )] =
                new BSStaticWrapperObject_UnityEngine_AnimatorTransitionInfo();

            StaticTypes[typeof( AnimatorControllerParameter )] =
                new BSStaticWrapperObject_UnityEngine_AnimatorControllerParameter();

            StaticTypes[typeof( MatchTargetWeightMask )] =
                new BSStaticWrapperObject_UnityEngine_MatchTargetWeightMask();

            StaticTypes[typeof( AxisEventData )] = new BSStaticWrapperObject_UnityEngine_EventSystems_AxisEventData();

            StaticTypes[typeof( BaseInputModule )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_BaseInputModule();

            StaticTypes[typeof( BaseInput )] = new BSStaticWrapperObject_UnityEngine_EventSystems_BaseInput();

            StaticTypes[typeof( PointerEventData )] =
                new BSStaticWrapperObject_UnityEngine_EventSystems_PointerEventData();

            StaticTypes[typeof( RaycastResult )] = new BSStaticWrapperObject_UnityEngine_EventSystems_RaycastResult();
            StaticTypes[typeof( BaseRaycaster )] = new BSStaticWrapperObject_UnityEngine_EventSystems_BaseRaycaster();
            StaticTypes[typeof( BaseEventData )] = new BSStaticWrapperObject_UnityEngine_EventSystems_BaseEventData();

        }

        #endregion
    }

}
