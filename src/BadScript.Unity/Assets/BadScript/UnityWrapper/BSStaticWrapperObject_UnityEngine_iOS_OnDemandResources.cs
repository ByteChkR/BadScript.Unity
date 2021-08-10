using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.iOS;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_iOS_OnDemandResources : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_iOS_OnDemandResources() : base( typeof( OnDemandResources ) )
        {
            m_StaticProperties["enabled"] = new BSReflectionReference(
                () => OnDemandResources.enabled ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}
