using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_LightProbeProxyVolume : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_LightProbeProxyVolume() : base( typeof( LightProbeProxyVolume ) )
        {
            m_StaticProperties["isFeatureSupported"] = new BSReflectionReference(
                () => LightProbeProxyVolume.isFeatureSupported ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}
