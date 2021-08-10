using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_OnDemandRendering : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_OnDemandRendering() : base( typeof( OnDemandRendering ) )
        {
            m_StaticProperties["willCurrentFrameRender"] = new BSReflectionReference(
                () => OnDemandRendering.willCurrentFrameRender ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["renderFrameInterval"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) OnDemandRendering.renderFrameInterval ),
                x => OnDemandRendering.renderFrameInterval = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["effectiveRenderFrameRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) OnDemandRendering.effectiveRenderFrameRate ),
                null );

        }

        #endregion
    }

}
