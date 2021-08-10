using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Scripting;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Scripting_AlwaysLinkAssemblyAttribute : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Scripting_AlwaysLinkAssemblyAttribute() : base(
            typeof( AlwaysLinkAssemblyAttribute ) )
        {

        }

        #endregion
    }

}
