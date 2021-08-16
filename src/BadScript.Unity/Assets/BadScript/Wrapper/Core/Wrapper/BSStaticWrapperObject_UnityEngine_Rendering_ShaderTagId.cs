using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_ShaderTagId : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_UnityEngine_Rendering_ShaderTagId() : base(typeof(UnityEngine.Rendering.ShaderTagId))
        {
            m_StaticProperties["none"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_Rendering_ShaderTagId(UnityEngine.Rendering.ShaderTagId.none), null);

        }
    }

}