using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UI_Graphic : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_UI_Graphic() : base(typeof(UnityEngine.UI.Graphic))
        {
            m_StaticProperties["defaultGraphicMaterial"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Material(UnityEngine.UI.Graphic.defaultGraphicMaterial), null);

        }
    }

}