using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UI_Image : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_UI_Image() : base(typeof(UnityEngine.UI.Image))
        {
            m_StaticProperties["defaultETC1GraphicMaterial"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Material(UnityEngine.UI.Image.defaultETC1GraphicMaterial), null);

        }
    }

}