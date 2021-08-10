using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Texture2DArray : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Texture2DArray() : base( typeof( Texture2DArray ) )
        {
            m_StaticProperties["allSlices"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Texture2DArray.allSlices ),
                null );

        }

        #endregion
    }

}
