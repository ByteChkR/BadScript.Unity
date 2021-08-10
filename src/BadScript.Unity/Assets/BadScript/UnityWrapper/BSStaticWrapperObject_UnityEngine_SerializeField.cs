using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_SerializeField : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_SerializeField() : base( typeof( SerializeField ) )
        {

        }

        #endregion
    }

}
