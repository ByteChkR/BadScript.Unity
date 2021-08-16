using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_RenderTargetIdentifier : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_RenderTargetIdentifier() : base(
            typeof( RenderTargetIdentifier ) )
        {
            m_StaticProperties["AllDepthSlices"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) RenderTargetIdentifier.AllDepthSlices ),
                null );

        }

        #endregion
    }

}
