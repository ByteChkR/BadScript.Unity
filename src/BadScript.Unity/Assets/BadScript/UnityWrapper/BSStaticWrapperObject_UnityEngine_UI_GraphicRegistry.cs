using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UI_GraphicRegistry : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UI_GraphicRegistry() : base( typeof( GraphicRegistry ) )
        {
            m_StaticProperties["instance"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_GraphicRegistry( GraphicRegistry.instance ),
                null );

        }

        #endregion
    }

}
