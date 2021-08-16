using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UI_ColorBlock : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_UI_ColorBlock() : base(typeof(UnityEngine.UI.ColorBlock))
        {
            m_StaticProperties["defaultColorBlock"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_UI_ColorBlock(UnityEngine.UI.ColorBlock.defaultColorBlock), x=> UnityEngine.UI.ColorBlock.defaultColorBlock = WrapperHelper.UnwrapObject<UnityEngine.UI.ColorBlock>(x));

        }
    }

}