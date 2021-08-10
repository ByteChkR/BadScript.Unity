using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_RenderPipelineManager : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_RenderPipelineManager() : base(
            typeof( RenderPipelineManager ) )
        {
            m_StaticProperties["currentPipeline"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderPipeline( RenderPipelineManager.currentPipeline ),
                null );

        }

        #endregion
    }

}
