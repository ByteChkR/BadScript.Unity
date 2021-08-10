using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SceneManagement;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_SceneManagement_SceneManagerAPI : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_SceneManagement_SceneManagerAPI() : base( typeof( SceneManagerAPI ) )
        {
            m_StaticProperties["overrideAPI"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_SceneManagement_SceneManagerAPI( SceneManagerAPI.overrideAPI ),
                x => SceneManagerAPI.overrideAPI = WrapperHelper.UnwrapObject < SceneManagerAPI >( x ) );

        }

        #endregion
    }

}
