using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Experimental.GlobalIllumination;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_RenderSettings : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Experimental_GlobalIllumination_RenderSettings() : base(
            typeof( RenderSettings ) )
        {
            m_StaticProperties["useRadianceAmbientProbe"] = new BSReflectionReference(
                () => RenderSettings.useRadianceAmbientProbe ? BSObject.One : BSObject.Zero,
                x => RenderSettings.useRadianceAmbientProbe = WrapperHelper.UnwrapObject < bool >( x ) );

        }

        #endregion
    }

}
