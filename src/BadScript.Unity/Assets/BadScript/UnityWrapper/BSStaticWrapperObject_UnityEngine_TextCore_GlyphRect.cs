using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.TextCore;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_TextCore_GlyphRect : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_TextCore_GlyphRect() : base( typeof( GlyphRect ) )
        {
            m_StaticProperties["zero"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_TextCore_GlyphRect( GlyphRect.zero ),
                null );

        }

        #endregion
    }

}
