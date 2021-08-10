using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_UI_Selectable : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UI_Selectable() : base( typeof( Selectable ) )
        {
            m_StaticProperties["allSelectableCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Selectable.allSelectableCount ),
                null );

        }

        #endregion
    }

}
