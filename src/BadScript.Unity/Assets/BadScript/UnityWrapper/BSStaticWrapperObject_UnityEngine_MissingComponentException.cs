using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_MissingComponentException : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_MissingComponentException() : base(
            typeof( MissingComponentException ) )
        {

        }

        #endregion
    }

}
