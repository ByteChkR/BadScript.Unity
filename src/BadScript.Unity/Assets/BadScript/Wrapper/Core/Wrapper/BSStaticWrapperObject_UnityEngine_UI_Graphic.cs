using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UI;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UI_Graphic : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UI_Graphic() : base( typeof( Graphic ) )
        {
            m_StaticProperties["defaultGraphicMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( Graphic.defaultGraphicMaterial ),
                null );

        }

        #endregion
    }

}
