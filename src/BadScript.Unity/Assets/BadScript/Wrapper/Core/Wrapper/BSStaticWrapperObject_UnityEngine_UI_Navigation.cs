using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.UI;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_UI_Navigation : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_UI_Navigation() : base( typeof( Navigation ) )
        {
            m_StaticProperties["defaultNavigation"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UI_Navigation( Navigation.defaultNavigation ),
                null );

        }

        #endregion
    }

}
