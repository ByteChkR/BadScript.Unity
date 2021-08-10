using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_StencilState : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_StencilState() : base( typeof( StencilState ) )
        {
            m_StaticProperties["defaultValue"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_StencilState( StencilState.defaultValue ),
                null );

        }

        #endregion
    }

}
