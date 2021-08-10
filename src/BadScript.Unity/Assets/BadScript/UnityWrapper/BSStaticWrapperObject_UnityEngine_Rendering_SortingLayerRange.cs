using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_SortingLayerRange : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_SortingLayerRange() : base( typeof( SortingLayerRange ) )
        {
            m_StaticProperties["all"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_SortingLayerRange( SortingLayerRange.all ),
                null );

        }

        #endregion
    }

}
