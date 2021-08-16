using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Unity.Wrapper.Core.Generated;

namespace BadScript.Unity.Wrapper.Core
{

    public class UnityCoreStaticDB : WrapperStaticDataBase
    {
        public UnityCoreStaticDB()
        {
            StaticTypes[typeof(UnityEngine.GameObject)] = new BSStaticWrapperObject_UnityEngine_GameObject();
            StaticTypes[typeof(UnityEngine.Transform)] = new BSStaticWrapperObject_UnityEngine_Transform();
            StaticTypes[typeof(UnityEngine.Vector3)] = new BSStaticWrapperObject_UnityEngine_Vector3();
            StaticTypes[typeof(System.Object)] = new BSStaticWrapperObject_System_Object();
            StaticTypes[typeof(System.IFormatProvider)] = new BSStaticWrapperObject_System_IFormatProvider();
            StaticTypes[typeof(UnityEngine.Quaternion)] = new BSStaticWrapperObject_UnityEngine_Quaternion();
            StaticTypes[typeof(UnityEngine.Matrix4x4)] = new BSStaticWrapperObject_UnityEngine_Matrix4x4();
            StaticTypes[typeof(UnityEngine.FrustumPlanes)] = new BSStaticWrapperObject_UnityEngine_FrustumPlanes();
            StaticTypes[typeof(UnityEngine.Vector4)] = new BSStaticWrapperObject_UnityEngine_Vector4();
            StaticTypes[typeof(UnityEngine.Plane)] = new BSStaticWrapperObject_UnityEngine_Plane();
            StaticTypes[typeof(System.Collections.IEnumerator)] = new BSStaticWrapperObject_System_Collections_IEnumerator();
            StaticTypes[typeof(UnityEngine.Component)] = new BSStaticWrapperObject_UnityEngine_Component();
            StaticTypes[typeof(UnityEngine.SceneManagement.Scene)] = new BSStaticWrapperObject_UnityEngine_SceneManagement_Scene();
            StaticTypes[typeof(UnityEngine.MonoBehaviour)] = new BSStaticWrapperObject_UnityEngine_MonoBehaviour();
            StaticTypes[typeof(UnityEngine.Coroutine)] = new BSStaticWrapperObject_UnityEngine_Coroutine();
            StaticTypes[typeof(UnityEngine.Object)] = new BSStaticWrapperObject_UnityEngine_Object();
            StaticTypes[typeof(UnityEngine.Physics)] = new BSStaticWrapperObject_UnityEngine_Physics();
            StaticTypes[typeof(UnityEngine.PhysicsScene)] = new BSStaticWrapperObject_UnityEngine_PhysicsScene();
            StaticTypes[typeof(UnityEngine.Collider)] = new BSStaticWrapperObject_UnityEngine_Collider();
            StaticTypes[typeof(UnityEngine.Rigidbody)] = new BSStaticWrapperObject_UnityEngine_Rigidbody();
            StaticTypes[typeof(UnityEngine.ArticulationBody)] = new BSStaticWrapperObject_UnityEngine_ArticulationBody();
            StaticTypes[typeof(UnityEngine.ArticulationDrive)] = new BSStaticWrapperObject_UnityEngine_ArticulationDrive();
            StaticTypes[typeof(UnityEngine.ArticulationReducedSpace)] = new BSStaticWrapperObject_UnityEngine_ArticulationReducedSpace();
            StaticTypes[typeof(UnityEngine.Bounds)] = new BSStaticWrapperObject_UnityEngine_Bounds();
            StaticTypes[typeof(UnityEngine.Ray)] = new BSStaticWrapperObject_UnityEngine_Ray();
            StaticTypes[typeof(UnityEngine.PhysicMaterial)] = new BSStaticWrapperObject_UnityEngine_PhysicMaterial();
            StaticTypes[typeof(UnityEngine.Input)] = new BSStaticWrapperObject_UnityEngine_Input();
            StaticTypes[typeof(UnityEngine.Vector2)] = new BSStaticWrapperObject_UnityEngine_Vector2();
            StaticTypes[typeof(UnityEngine.LocationService)] = new BSStaticWrapperObject_UnityEngine_LocationService();
            StaticTypes[typeof(UnityEngine.LocationInfo)] = new BSStaticWrapperObject_UnityEngine_LocationInfo();
            StaticTypes[typeof(UnityEngine.Compass)] = new BSStaticWrapperObject_UnityEngine_Compass();
            StaticTypes[typeof(UnityEngine.Gyroscope)] = new BSStaticWrapperObject_UnityEngine_Gyroscope();
            StaticTypes[typeof(UnityEngine.Touch)] = new BSStaticWrapperObject_UnityEngine_Touch();
            StaticTypes[typeof(UnityEngine.AccelerationEvent)] = new BSStaticWrapperObject_UnityEngine_AccelerationEvent();
            StaticTypes[typeof(UnityEngine.LayerMask)] = new BSStaticWrapperObject_UnityEngine_LayerMask();
            StaticTypes[typeof(UnityEngine.Camera)] = new BSStaticWrapperObject_UnityEngine_Camera();
            StaticTypes[typeof(UnityEngine.Color)] = new BSStaticWrapperObject_UnityEngine_Color();
            StaticTypes[typeof(UnityEngine.Rect)] = new BSStaticWrapperObject_UnityEngine_Rect();
            StaticTypes[typeof(UnityEngine.RenderTexture)] = new BSStaticWrapperObject_UnityEngine_RenderTexture();
            StaticTypes[typeof(UnityEngine.RenderBuffer)] = new BSStaticWrapperObject_UnityEngine_RenderBuffer();
            StaticTypes[typeof(System.IntPtr)] = new BSStaticWrapperObject_System_IntPtr();
            StaticTypes[typeof(UnityEngine.RenderTextureDescriptor)] = new BSStaticWrapperObject_UnityEngine_RenderTextureDescriptor();
            StaticTypes[typeof(UnityEngine.Hash128)] = new BSStaticWrapperObject_UnityEngine_Hash128();
            StaticTypes[typeof(UnityEngine.Shader)] = new BSStaticWrapperObject_UnityEngine_Shader();
            StaticTypes[typeof(UnityEngine.Rendering.ShaderTagId)] = new BSStaticWrapperObject_UnityEngine_Rendering_ShaderTagId();
            StaticTypes[typeof(UnityEngine.Texture)] = new BSStaticWrapperObject_UnityEngine_Texture();
            StaticTypes[typeof(UnityEngine.ComputeBuffer)] = new BSStaticWrapperObject_UnityEngine_ComputeBuffer();
            StaticTypes[typeof(System.Array)] = new BSStaticWrapperObject_System_Array();
            StaticTypes[typeof(System.Collections.IComparer)] = new BSStaticWrapperObject_System_Collections_IComparer();
            StaticTypes[typeof(UnityEngine.GraphicsBuffer)] = new BSStaticWrapperObject_UnityEngine_GraphicsBuffer();
            StaticTypes[typeof(UnityEngine.Cubemap)] = new BSStaticWrapperObject_UnityEngine_Cubemap();
            StaticTypes[typeof(UnityEngine.Rendering.CommandBuffer)] = new BSStaticWrapperObject_UnityEngine_Rendering_CommandBuffer();
            StaticTypes[typeof(UnityEngine.Rendering.RenderTargetIdentifier)] = new BSStaticWrapperObject_UnityEngine_Rendering_RenderTargetIdentifier();
            StaticTypes[typeof(UnityEngine.ComputeShader)] = new BSStaticWrapperObject_UnityEngine_ComputeShader();
            StaticTypes[typeof(UnityEngine.Experimental.Rendering.RayTracingShader)] = new BSStaticWrapperObject_UnityEngine_Experimental_Rendering_RayTracingShader();
            StaticTypes[typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)] = new BSStaticWrapperObject_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure();
            StaticTypes[typeof(UnityEngine.Renderer)] = new BSStaticWrapperObject_UnityEngine_Renderer();
            StaticTypes[typeof(UnityEngine.Material)] = new BSStaticWrapperObject_UnityEngine_Material();
            StaticTypes[typeof(UnityEngine.MaterialPropertyBlock)] = new BSStaticWrapperObject_UnityEngine_MaterialPropertyBlock();
            StaticTypes[typeof(UnityEngine.Profiling.CustomSampler)] = new BSStaticWrapperObject_UnityEngine_Profiling_CustomSampler();
            StaticTypes[typeof(UnityEngine.Profiling.Recorder)] = new BSStaticWrapperObject_UnityEngine_Profiling_Recorder();
            StaticTypes[typeof(UnityEngine.Rendering.RenderTargetBinding)] = new BSStaticWrapperObject_UnityEngine_Rendering_RenderTargetBinding();
            StaticTypes[typeof(UnityEngine.Mesh)] = new BSStaticWrapperObject_UnityEngine_Mesh();
            StaticTypes[typeof(UnityEngine.Rendering.VertexAttributeDescriptor)] = new BSStaticWrapperObject_UnityEngine_Rendering_VertexAttributeDescriptor();
            StaticTypes[typeof(UnityEngine.Rendering.SubMeshDescriptor)] = new BSStaticWrapperObject_UnityEngine_Rendering_SubMeshDescriptor();
            StaticTypes[typeof(UnityEngine.RectInt)] = new BSStaticWrapperObject_UnityEngine_RectInt();
            StaticTypes[typeof(UnityEngine.Vector2Int)] = new BSStaticWrapperObject_UnityEngine_Vector2Int();
            StaticTypes[typeof(UnityEngine.Rendering.GraphicsFence)] = new BSStaticWrapperObject_UnityEngine_Rendering_GPUFence();
            StaticTypes[typeof(UnityEngine.MeshFilter)] = new BSStaticWrapperObject_UnityEngine_MeshFilter();
            StaticTypes[typeof(UnityEngine.MeshCollider)] = new BSStaticWrapperObject_UnityEngine_MeshCollider();
            StaticTypes[typeof(UnityEngine.BoxCollider)] = new BSStaticWrapperObject_UnityEngine_BoxCollider();
            StaticTypes[typeof(UnityEngine.SphereCollider)] = new BSStaticWrapperObject_UnityEngine_SphereCollider();
            StaticTypes[typeof(UnityEngine.CapsuleCollider)] = new BSStaticWrapperObject_UnityEngine_CapsuleCollider();
            StaticTypes[typeof(UnityEngine.RectTransform)] = new BSStaticWrapperObject_UnityEngine_RectTransform();
            StaticTypes[typeof(UnityEngine.UIElements.ScrollView)] = new BSStaticWrapperObject_UnityEngine_UIElements_ScrollView();
            StaticTypes[typeof(UnityEngine.UIElements.VisualElement)] = new BSStaticWrapperObject_UnityEngine_UIElements_VisualElement();
            StaticTypes[typeof(UnityEngine.UIElements.FocusController)] = new BSStaticWrapperObject_UnityEngine_UIElements_FocusController();
            StaticTypes[typeof(UnityEngine.UIElements.Focusable)] = new BSStaticWrapperObject_UnityEngine_UIElements_Focusable();
            StaticTypes[typeof(UnityEngine.UIElements.EventBase)] = new BSStaticWrapperObject_UnityEngine_UIElements_EventBase();
            StaticTypes[typeof(UnityEngine.UIElements.IEventHandler)] = new BSStaticWrapperObject_UnityEngine_UIElements_IEventHandler();
            StaticTypes[typeof(UnityEngine.Event)] = new BSStaticWrapperObject_UnityEngine_Event();
            StaticTypes[typeof(System.Char)] = new BSStaticWrapperObject_System_Char();
            StaticTypes[typeof(System.Globalization.CultureInfo)] = new BSStaticWrapperObject_System_Globalization_CultureInfo();
            StaticTypes[typeof(System.Globalization.Calendar)] = new BSStaticWrapperObject_System_Globalization_Calendar();
            StaticTypes[typeof(System.DateTime)] = new BSStaticWrapperObject_System_DateTime();
            StaticTypes[typeof(System.TimeSpan)] = new BSStaticWrapperObject_System_TimeSpan();
            StaticTypes[typeof(System.Globalization.TextInfo)] = new BSStaticWrapperObject_System_Globalization_TextInfo();
            StaticTypes[typeof(System.Globalization.CompareInfo)] = new BSStaticWrapperObject_System_Globalization_CompareInfo();
            StaticTypes[typeof(System.Globalization.SortVersion)] = new BSStaticWrapperObject_System_Globalization_SortVersion();
            StaticTypes[typeof(System.Guid)] = new BSStaticWrapperObject_System_Guid();
            StaticTypes[typeof(System.Globalization.SortKey)] = new BSStaticWrapperObject_System_Globalization_SortKey();
            StaticTypes[typeof(System.Reflection.Assembly)] = new BSStaticWrapperObject_System_Reflection_Assembly();
            StaticTypes[typeof(System.Reflection.MethodInfo)] = new BSStaticWrapperObject_System_Reflection_MethodInfo();
            StaticTypes[typeof(System.Reflection.ParameterInfo)] = new BSStaticWrapperObject_System_Reflection_ParameterInfo();
            StaticTypes[typeof(System.Reflection.MemberInfo)] = new BSStaticWrapperObject_System_Reflection_MemberInfo();
            StaticTypes[typeof(System.Reflection.Module)] = new BSStaticWrapperObject_System_Reflection_Module();
            StaticTypes[typeof(System.ModuleHandle)] = new BSStaticWrapperObject_System_ModuleHandle();
            StaticTypes[typeof(System.RuntimeFieldHandle)] = new BSStaticWrapperObject_System_RuntimeFieldHandle();
            StaticTypes[typeof(System.Runtime.Serialization.SerializationInfo)] = new BSStaticWrapperObject_System_Runtime_Serialization_SerializationInfo();
            StaticTypes[typeof(System.Runtime.Serialization.SerializationInfoEnumerator)] = new BSStaticWrapperObject_System_Runtime_Serialization_SerializationInfoEnumerator();
            StaticTypes[typeof(System.Runtime.Serialization.SerializationEntry)] = new BSStaticWrapperObject_System_Runtime_Serialization_SerializationEntry();
            StaticTypes[typeof(System.Runtime.Serialization.StreamingContext)] = new BSStaticWrapperObject_System_Runtime_Serialization_StreamingContext();
            StaticTypes[typeof(System.RuntimeMethodHandle)] = new BSStaticWrapperObject_System_RuntimeMethodHandle();
            StaticTypes[typeof(System.RuntimeTypeHandle)] = new BSStaticWrapperObject_System_RuntimeTypeHandle();
            StaticTypes[typeof(System.Reflection.TypeFilter)] = new BSStaticWrapperObject_System_Reflection_TypeFilter();
            StaticTypes[typeof(System.IAsyncResult)] = new BSStaticWrapperObject_System_IAsyncResult();
            StaticTypes[typeof(System.Threading.WaitHandle)] = new BSStaticWrapperObject_System_Threading_WaitHandle();
            StaticTypes[typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle)] = new BSStaticWrapperObject_Microsoft_Win32_SafeHandles_SafeWaitHandle();
            StaticTypes[typeof(System.Collections.IDictionary)] = new BSStaticWrapperObject_System_Collections_IDictionary();
            StaticTypes[typeof(System.Collections.ICollection)] = new BSStaticWrapperObject_System_Collections_ICollection();
            StaticTypes[typeof(System.Collections.IDictionaryEnumerator)] = new BSStaticWrapperObject_System_Collections_IDictionaryEnumerator();
            StaticTypes[typeof(System.Collections.DictionaryEntry)] = new BSStaticWrapperObject_System_Collections_DictionaryEntry();
            StaticTypes[typeof(System.AsyncCallback)] = new BSStaticWrapperObject_System_AsyncCallback();
            StaticTypes[typeof(System.Reflection.FieldInfo)] = new BSStaticWrapperObject_System_Reflection_FieldInfo();
            StaticTypes[typeof(System.Reflection.Binder)] = new BSStaticWrapperObject_System_Reflection_Binder();
            StaticTypes[typeof(System.Reflection.MethodBase)] = new BSStaticWrapperObject_System_Reflection_MethodBase();
            StaticTypes[typeof(System.Reflection.MethodBody)] = new BSStaticWrapperObject_System_Reflection_MethodBody();
            StaticTypes[typeof(System.Reflection.PropertyInfo)] = new BSStaticWrapperObject_System_Reflection_PropertyInfo();
            StaticTypes[typeof(System.Security.Cryptography.X509Certificates.X509Certificate)] = new BSStaticWrapperObject_System_Security_Cryptography_X509Certificates_X509Certificate();
            StaticTypes[typeof(System.Security.SecureString)] = new BSStaticWrapperObject_System_Security_SecureString();
            StaticTypes[typeof(System.Reflection.ICustomAttributeProvider)] = new BSStaticWrapperObject_System_Reflection_ICustomAttributeProvider();
            StaticTypes[typeof(System.Delegate)] = new BSStaticWrapperObject_System_Delegate();
            StaticTypes[typeof(System.Security.IPermission)] = new BSStaticWrapperObject_System_Security_IPermission();
            StaticTypes[typeof(System.Security.SecurityElement)] = new BSStaticWrapperObject_System_Security_SecurityElement();
            StaticTypes[typeof(System.Collections.Hashtable)] = new BSStaticWrapperObject_System_Collections_Hashtable();
            StaticTypes[typeof(System.Collections.ArrayList)] = new BSStaticWrapperObject_System_Collections_ArrayList();
            StaticTypes[typeof(System.Collections.IList)] = new BSStaticWrapperObject_System_Collections_IList();
            StaticTypes[typeof(System.Reflection.ModuleResolveEventHandler)] = new BSStaticWrapperObject_System_Reflection_ModuleResolveEventHandler();
            StaticTypes[typeof(System.ResolveEventArgs)] = new BSStaticWrapperObject_System_ResolveEventArgs();
            StaticTypes[typeof(System.IO.FileStream)] = new BSStaticWrapperObject_System_IO_FileStream();
            StaticTypes[typeof(Microsoft.Win32.SafeHandles.SafeFileHandle)] = new BSStaticWrapperObject_Microsoft_Win32_SafeHandles_SafeFileHandle();
            StaticTypes[typeof(System.Threading.Tasks.Task)] = new BSStaticWrapperObject_System_Threading_Tasks_Task();
            StaticTypes[typeof(System.Threading.Tasks.TaskFactory)] = new BSStaticWrapperObject_System_Threading_Tasks_TaskFactory();
            StaticTypes[typeof(System.Threading.CancellationToken)] = new BSStaticWrapperObject_System_Threading_CancellationToken();
            StaticTypes[typeof(System.Threading.CancellationTokenRegistration)] = new BSStaticWrapperObject_System_Threading_CancellationTokenRegistration();
            StaticTypes[typeof(System.Action)] = new BSStaticWrapperObject_System_Action();
            StaticTypes[typeof(System.Threading.Tasks.TaskScheduler)] = new BSStaticWrapperObject_System_Threading_Tasks_TaskScheduler();
            StaticTypes[typeof(System.AggregateException)] = new BSStaticWrapperObject_System_AggregateException();
            StaticTypes[typeof(System.Exception)] = new BSStaticWrapperObject_System_Exception();
            StaticTypes[typeof(System.Runtime.CompilerServices.TaskAwaiter)] = new BSStaticWrapperObject_System_Runtime_CompilerServices_TaskAwaiter();
            StaticTypes[typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable)] = new BSStaticWrapperObject_System_Runtime_CompilerServices_ConfiguredTaskAwaitable();
            StaticTypes[typeof(System.Runtime.CompilerServices.YieldAwaitable)] = new BSStaticWrapperObject_System_Runtime_CompilerServices_YieldAwaitable();
            StaticTypes[typeof(System.IO.Stream)] = new BSStaticWrapperObject_System_IO_Stream();
            StaticTypes[typeof(System.Reflection.AssemblyName)] = new BSStaticWrapperObject_System_Reflection_AssemblyName();
            StaticTypes[typeof(System.Reflection.StrongNameKeyPair)] = new BSStaticWrapperObject_System_Reflection_StrongNameKeyPair();
            StaticTypes[typeof(System.Version)] = new BSStaticWrapperObject_System_Version();
            StaticTypes[typeof(System.Reflection.ManifestResourceInfo)] = new BSStaticWrapperObject_System_Reflection_ManifestResourceInfo();
            StaticTypes[typeof(System.Globalization.NumberFormatInfo)] = new BSStaticWrapperObject_System_Globalization_NumberFormatInfo();
            StaticTypes[typeof(System.Globalization.DateTimeFormatInfo)] = new BSStaticWrapperObject_System_Globalization_DateTimeFormatInfo();
            StaticTypes[typeof(UnityEngine.UIElements.ITransform)] = new BSStaticWrapperObject_UnityEngine_UIElements_ITransform();
            StaticTypes[typeof(UnityEngine.UIElements.IExperimentalFeatures)] = new BSStaticWrapperObject_UnityEngine_UIElements_IExperimentalFeatures();
            StaticTypes[typeof(UnityEngine.UIElements.Experimental.ITransitionAnimations)] = new BSStaticWrapperObject_UnityEngine_UIElements_Experimental_ITransitionAnimations();
            StaticTypes[typeof(UnityEngine.UIElements.IPanel)] = new BSStaticWrapperObject_UnityEngine_UIElements_IPanel();
            StaticTypes[typeof(UnityEngine.UIElements.EventDispatcher)] = new BSStaticWrapperObject_UnityEngine_UIElements_EventDispatcher();
            StaticTypes[typeof(UnityEngine.UIElements.ContextualMenuManager)] = new BSStaticWrapperObject_UnityEngine_UIElements_ContextualMenuManager();
            StaticTypes[typeof(UnityEngine.UIElements.IVisualElementScheduler)] = new BSStaticWrapperObject_UnityEngine_UIElements_IVisualElementScheduler();
            StaticTypes[typeof(UnityEngine.UIElements.IVisualElementScheduledItem)] = new BSStaticWrapperObject_UnityEngine_UIElements_IVisualElementScheduledItem();
            StaticTypes[typeof(UnityEngine.UIElements.IStyle)] = new BSStaticWrapperObject_UnityEngine_UIElements_IStyle();
            StaticTypes[typeof(UnityEngine.UIElements.StyleColor)] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleColor();
            StaticTypes[typeof(UnityEngine.UIElements.StyleBackground)] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleBackground();
            StaticTypes[typeof(UnityEngine.UIElements.Background)] = new BSStaticWrapperObject_UnityEngine_UIElements_Background();
            StaticTypes[typeof(UnityEngine.Texture2D)] = new BSStaticWrapperObject_UnityEngine_Texture2D();
            StaticTypes[typeof(UnityEngine.UIElements.VectorImage)] = new BSStaticWrapperObject_UnityEngine_UIElements_VectorImage();
            StaticTypes[typeof(UnityEngine.UIElements.StyleLength)] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleLength();
            StaticTypes[typeof(UnityEngine.UIElements.Length)] = new BSStaticWrapperObject_UnityEngine_UIElements_Length();
            StaticTypes[typeof(UnityEngine.UIElements.StyleFloat)] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleFloat();
            StaticTypes[typeof(UnityEngine.UIElements.StyleCursor)] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleCursor();
            StaticTypes[typeof(UnityEngine.UIElements.Cursor)] = new BSStaticWrapperObject_UnityEngine_UIElements_Cursor();
            StaticTypes[typeof(UnityEngine.UIElements.StyleFont)] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleFont();
            StaticTypes[typeof(UnityEngine.Font)] = new BSStaticWrapperObject_UnityEngine_Font();
            StaticTypes[typeof(UnityEngine.UIElements.StyleInt)] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleInt();
            StaticTypes[typeof(UnityEngine.UIElements.ICustomStyle)] = new BSStaticWrapperObject_UnityEngine_UIElements_ICustomStyle();
            StaticTypes[typeof(UnityEngine.UIElements.VisualElementStyleSheetSet)] = new BSStaticWrapperObject_UnityEngine_UIElements_VisualElementStyleSheetSet();
            StaticTypes[typeof(UnityEngine.UIElements.StyleSheet)] = new BSStaticWrapperObject_UnityEngine_UIElements_StyleSheet();
            StaticTypes[typeof(UnityEngine.UIElements.IResolvedStyle)] = new BSStaticWrapperObject_UnityEngine_UIElements_IResolvedStyle();
            StaticTypes[typeof(UnityEngine.UIElements.Scroller)] = new BSStaticWrapperObject_UnityEngine_UIElements_Scroller();
            StaticTypes[typeof(UnityEngine.UIElements.Slider)] = new BSStaticWrapperObject_UnityEngine_UIElements_Slider();
            StaticTypes[typeof(UnityEngine.UIElements.Label)] = new BSStaticWrapperObject_UnityEngine_UIElements_Label();
            StaticTypes[typeof(UnityEngine.UIElements.IBinding)] = new BSStaticWrapperObject_UnityEngine_UIElements_IBinding();
            StaticTypes[typeof(UnityEngine.UIElements.RepeatButton)] = new BSStaticWrapperObject_UnityEngine_UIElements_RepeatButton();
            StaticTypes[typeof(UnityEngine.UI.Text)] = new BSStaticWrapperObject_UnityEngine_UI_Text();
            StaticTypes[typeof(UnityEngine.TextGenerator)] = new BSStaticWrapperObject_UnityEngine_TextGenerator();
            StaticTypes[typeof(UnityEngine.TextGenerationSettings)] = new BSStaticWrapperObject_UnityEngine_TextGenerationSettings();
            StaticTypes[typeof(UnityEngine.Canvas)] = new BSStaticWrapperObject_UnityEngine_Canvas();
            StaticTypes[typeof(UnityEngine.CanvasRenderer)] = new BSStaticWrapperObject_UnityEngine_CanvasRenderer();
            StaticTypes[typeof(UnityEngine.Events.UnityAction)] = new BSStaticWrapperObject_UnityEngine_Events_UnityAction();
            StaticTypes[typeof(UnityEngine.UI.InputField)] = new BSStaticWrapperObject_UnityEngine_UI_InputField();
            StaticTypes[typeof(UnityEngine.UI.Graphic)] = new BSStaticWrapperObject_UnityEngine_UI_Graphic();
            StaticTypes[typeof(UnityEngine.TouchScreenKeyboard)] = new BSStaticWrapperObject_UnityEngine_TouchScreenKeyboard();
            StaticTypes[typeof(UnityEngine.RangeInt)] = new BSStaticWrapperObject_UnityEngine_RangeInt();
            StaticTypes[typeof(UnityEngine.UI.Navigation)] = new BSStaticWrapperObject_UnityEngine_UI_Navigation();
            StaticTypes[typeof(UnityEngine.UI.Selectable)] = new BSStaticWrapperObject_UnityEngine_UI_Selectable();
            StaticTypes[typeof(UnityEngine.UI.ColorBlock)] = new BSStaticWrapperObject_UnityEngine_UI_ColorBlock();
            StaticTypes[typeof(UnityEngine.UI.SpriteState)] = new BSStaticWrapperObject_UnityEngine_UI_SpriteState();
            StaticTypes[typeof(UnityEngine.Sprite)] = new BSStaticWrapperObject_UnityEngine_Sprite();
            StaticTypes[typeof(UnityEngine.UI.AnimationTriggers)] = new BSStaticWrapperObject_UnityEngine_UI_AnimationTriggers();
            StaticTypes[typeof(UnityEngine.UI.Image)] = new BSStaticWrapperObject_UnityEngine_UI_Image();
            StaticTypes[typeof(UnityEngine.Animator)] = new BSStaticWrapperObject_UnityEngine_Animator();
            StaticTypes[typeof(UnityEngine.RuntimeAnimatorController)] = new BSStaticWrapperObject_UnityEngine_RuntimeAnimatorController();
            StaticTypes[typeof(UnityEngine.Avatar)] = new BSStaticWrapperObject_UnityEngine_Avatar();
            StaticTypes[typeof(UnityEngine.HumanDescription)] = new BSStaticWrapperObject_UnityEngine_HumanDescription();
            StaticTypes[typeof(UnityEngine.Playables.PlayableGraph)] = new BSStaticWrapperObject_UnityEngine_Playables_PlayableGraph();
            StaticTypes[typeof(UnityEngine.Playables.Playable)] = new BSStaticWrapperObject_UnityEngine_Playables_Playable();
            StaticTypes[typeof(UnityEngine.Playables.PlayableHandle)] = new BSStaticWrapperObject_UnityEngine_Playables_PlayableHandle();
            StaticTypes[typeof(UnityEngine.Playables.PlayableOutput)] = new BSStaticWrapperObject_UnityEngine_Playables_PlayableOutput();
            StaticTypes[typeof(UnityEngine.Playables.PlayableOutputHandle)] = new BSStaticWrapperObject_UnityEngine_Playables_PlayableOutputHandle();
            StaticTypes[typeof(UnityEngine.IExposedPropertyTable)] = new BSStaticWrapperObject_UnityEngine_IExposedPropertyTable();
            StaticTypes[typeof(UnityEngine.PropertyName)] = new BSStaticWrapperObject_UnityEngine_PropertyName();
            StaticTypes[typeof(UnityEngine.AnimatorStateInfo)] = new BSStaticWrapperObject_UnityEngine_AnimatorStateInfo();
            StaticTypes[typeof(UnityEngine.AnimatorTransitionInfo)] = new BSStaticWrapperObject_UnityEngine_AnimatorTransitionInfo();
            StaticTypes[typeof(UnityEngine.AnimatorControllerParameter)] = new BSStaticWrapperObject_UnityEngine_AnimatorControllerParameter();
            StaticTypes[typeof(UnityEngine.MatchTargetWeightMask)] = new BSStaticWrapperObject_UnityEngine_MatchTargetWeightMask();
            StaticTypes[typeof(UnityEngine.EventSystems.AxisEventData)] = new BSStaticWrapperObject_UnityEngine_EventSystems_AxisEventData();
            StaticTypes[typeof(UnityEngine.EventSystems.BaseInputModule)] = new BSStaticWrapperObject_UnityEngine_EventSystems_BaseInputModule();
            StaticTypes[typeof(UnityEngine.EventSystems.BaseInput)] = new BSStaticWrapperObject_UnityEngine_EventSystems_BaseInput();
            StaticTypes[typeof(UnityEngine.EventSystems.PointerEventData)] = new BSStaticWrapperObject_UnityEngine_EventSystems_PointerEventData();
            StaticTypes[typeof(UnityEngine.EventSystems.RaycastResult)] = new BSStaticWrapperObject_UnityEngine_EventSystems_RaycastResult();
            StaticTypes[typeof(UnityEngine.EventSystems.BaseRaycaster)] = new BSStaticWrapperObject_UnityEngine_EventSystems_BaseRaycaster();
            StaticTypes[typeof(UnityEngine.EventSystems.BaseEventData)] = new BSStaticWrapperObject_UnityEngine_EventSystems_BaseEventData();

        }
    }

}