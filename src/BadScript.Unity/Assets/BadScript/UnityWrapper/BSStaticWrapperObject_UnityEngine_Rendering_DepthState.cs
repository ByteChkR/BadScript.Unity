using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_DepthState : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_DepthState() : base( typeof( DepthState ) )
        {
            m_StaticProperties["defaultValue"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_DepthState( DepthState.defaultValue ),
                null );

        }

        #endregion
    }

}
