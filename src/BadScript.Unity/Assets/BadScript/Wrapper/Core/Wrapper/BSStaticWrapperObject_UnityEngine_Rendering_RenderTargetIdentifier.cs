using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_RenderTargetIdentifier : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Rendering_RenderTargetIdentifier() : base(typeof(UnityEngine.Rendering.RenderTargetIdentifier))
        {
            m_StaticProperties["AllDepthSlices"] = new BSReflectionReference(() => new BSObject((decimal)UnityEngine.Rendering.RenderTargetIdentifier.AllDepthSlices), null);

        }
    }

}