using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UI;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UI_ColorBlock : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UI_ColorBlock() : base( typeof( ColorBlock ) )
        {
            m_StaticProperties["defaultColorBlock"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_ColorBlock( ColorBlock.defaultColorBlock ),
                x => ColorBlock.defaultColorBlock = WrapperHelper.UnwrapObject < ColorBlock >( x ) );

        }

        #endregion
    }

}
