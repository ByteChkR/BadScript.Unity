using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_BlendState : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_BlendState() : base( typeof( BlendState ) )
        {
            m_StaticProperties["defaultValue"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_BlendState( BlendState.defaultValue ),
                null );

        }

        #endregion
    }

}
