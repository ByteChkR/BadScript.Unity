using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Scripting;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Scripting_RequireDerivedAttribute : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Scripting_RequireDerivedAttribute() : base(
            typeof( RequireDerivedAttribute ) )
        {

        }

        #endregion
    }

}
