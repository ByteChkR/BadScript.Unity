using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.SceneManagement;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_SceneManagement_SceneUtility : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_SceneManagement_SceneUtility() : base( typeof( SceneUtility ) )
        {
            m_StaticProperties["GetScenePathByBuildIndex"] = new BSFunctionReference(
                new BSFunction(
                    "function GetScenePathByBuildIndex(buildIndex)",
                    a => new BSObject(
                        SceneUtility.GetScenePathByBuildIndex( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetBuildIndexByScenePath"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBuildIndexByScenePath(scenePath)",
                    a => new BSObject(
                        ( decimal ) SceneUtility.GetBuildIndexByScenePath(
                            WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
