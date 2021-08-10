using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_RenderTargetBlendState : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_RenderTargetBlendState() : base(
            typeof( RenderTargetBlendState ) )
        {
            m_StaticProperties["defaultValue"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderTargetBlendState(
                    RenderTargetBlendState.defaultValue ),
                null );

        }

        #endregion
    }

}
