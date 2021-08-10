using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_ExcludeFromObjectFactoryAttribute : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_ExcludeFromObjectFactoryAttribute() : base(
            typeof( ExcludeFromObjectFactoryAttribute ) )
        {

        }

        #endregion
    }

}
