using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UI_FontData : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UI_FontData() : base( typeof( FontData ) )
        {
            m_StaticProperties["defaultFontData"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_FontData( FontData.defaultFontData ),
                null );

        }

        #endregion
    }

}
