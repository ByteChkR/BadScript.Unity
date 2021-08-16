using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UI;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UI_Image : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UI_Image() : base( typeof( Image ) )
        {
            m_StaticProperties["defaultETC1GraphicMaterial"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( Image.defaultETC1GraphicMaterial ),
                null );

        }

        #endregion
    }

}
