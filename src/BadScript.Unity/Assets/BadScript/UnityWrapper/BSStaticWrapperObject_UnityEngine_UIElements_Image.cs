using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UIElements_Image : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UIElements_Image() : base( typeof( Image ) )
        {
            m_StaticProperties["ussClassName"] = new BSReflectionReference(
                () => new BSObject( Image.ussClassName ),
                null );

        }

        #endregion
    }

}
