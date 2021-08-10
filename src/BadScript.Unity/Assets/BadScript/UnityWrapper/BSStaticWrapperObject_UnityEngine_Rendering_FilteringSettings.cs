using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_FilteringSettings : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_FilteringSettings() : base( typeof( FilteringSettings ) )
        {
            m_StaticProperties["defaultValue"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_FilteringSettings( FilteringSettings.defaultValue ),
                null );

        }

        #endregion
    }

}
