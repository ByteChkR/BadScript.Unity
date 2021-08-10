using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_ShadowSplitData : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_ShadowSplitData() : base( typeof( ShadowSplitData ) )
        {
            m_StaticProperties["maximumCullingPlaneCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) ShadowSplitData.maximumCullingPlaneCount ),
                null );

        }

        #endregion
    }

}
