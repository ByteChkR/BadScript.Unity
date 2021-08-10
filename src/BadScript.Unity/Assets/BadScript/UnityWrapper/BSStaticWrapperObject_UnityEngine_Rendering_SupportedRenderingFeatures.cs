using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_SupportedRenderingFeatures : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_SupportedRenderingFeatures() : base(
            typeof( SupportedRenderingFeatures ) )
        {
            m_StaticProperties["active"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_SupportedRenderingFeatures(
                    SupportedRenderingFeatures.active ),
                x => SupportedRenderingFeatures.active =
                    WrapperHelper.UnwrapObject < SupportedRenderingFeatures >( x ) );

        }

        #endregion
    }

}
