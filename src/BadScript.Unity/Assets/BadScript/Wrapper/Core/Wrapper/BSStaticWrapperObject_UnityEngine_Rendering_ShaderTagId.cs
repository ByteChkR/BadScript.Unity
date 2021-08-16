using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_ShaderTagId : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_ShaderTagId() : base( typeof( ShaderTagId ) )
        {
            m_StaticProperties["none"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_ShaderTagId( ShaderTagId.none ),
                null );

        }

        #endregion
    }

}
