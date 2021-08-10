using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.XR;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_XR_MeshId : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_XR_MeshId() : base( typeof( MeshId ) )
        {
            m_StaticProperties["InvalidId"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_XR_MeshId( MeshId.InvalidId ),
                null );

        }

        #endregion
    }

}
