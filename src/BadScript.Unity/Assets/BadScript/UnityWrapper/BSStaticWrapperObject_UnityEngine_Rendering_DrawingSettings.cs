using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_DrawingSettings : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_DrawingSettings() : base( typeof( DrawingSettings ) )
        {
            m_StaticProperties["maxShaderPasses"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) DrawingSettings.maxShaderPasses ),
                null );

        }

        #endregion
    }

}
