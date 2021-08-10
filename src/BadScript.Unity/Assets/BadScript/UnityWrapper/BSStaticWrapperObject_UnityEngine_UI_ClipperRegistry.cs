using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UI_ClipperRegistry : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UI_ClipperRegistry() : base( typeof( ClipperRegistry ) )
        {
            m_StaticProperties["instance"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_ClipperRegistry( ClipperRegistry.instance ),
                null );

        }

        #endregion
    }

}
