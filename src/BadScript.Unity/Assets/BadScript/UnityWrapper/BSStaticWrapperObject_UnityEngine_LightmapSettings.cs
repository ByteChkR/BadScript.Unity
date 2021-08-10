using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_LightmapSettings : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_LightmapSettings() : base( typeof( LightmapSettings ) )
        {
            m_StaticProperties["lightProbes"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_LightProbes( LightmapSettings.lightProbes ),
                x => LightmapSettings.lightProbes = WrapperHelper.UnwrapObject < LightProbes >( x ) );

        }

        #endregion
    }

}
