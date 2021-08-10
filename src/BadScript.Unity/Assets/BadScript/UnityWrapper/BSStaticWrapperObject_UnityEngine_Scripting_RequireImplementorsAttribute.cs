using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Scripting;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Scripting_RequireImplementorsAttribute : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Scripting_RequireImplementorsAttribute() : base(
            typeof( RequireImplementorsAttribute ) )
        {

        }

        #endregion
    }

}
