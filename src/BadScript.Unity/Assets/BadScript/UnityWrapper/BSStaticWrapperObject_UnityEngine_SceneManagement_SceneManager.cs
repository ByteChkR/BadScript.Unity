using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SceneManagement;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_SceneManagement_SceneManager : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_SceneManagement_SceneManager() : base( typeof( SceneManager ) )
        {
            m_StaticProperties["sceneCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SceneManager.sceneCount ),
                null );

            m_StaticProperties["sceneCountInBuildSettings"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SceneManager.sceneCountInBuildSettings ),
                null );

            m_StaticProperties["SetActiveScene"] = new BSFunctionReference(
                new BSFunction(
                    "function SetActiveScene(scene)",
                    a => SceneManager.SetActiveScene( WrapperHelper.UnwrapObject < Scene >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetSceneByPath"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSceneByPath(scenePath)",
                    a => new BSWrapperObject_UnityEngine_SceneManagement_Scene(
                        SceneManager.GetSceneByPath( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetSceneByName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSceneByName(name)",
                    a => new BSWrapperObject_UnityEngine_SceneManagement_Scene(
                        SceneManager.GetSceneByName( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetSceneByBuildIndex"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSceneByBuildIndex(buildIndex)",
                    a => new BSWrapperObject_UnityEngine_SceneManagement_Scene(
                        SceneManager.GetSceneByBuildIndex( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetSceneAt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetSceneAt(index)",
                    a => new BSWrapperObject_UnityEngine_SceneManagement_Scene(
                        SceneManager.GetSceneAt( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["CreateScene"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateScene(sceneName, parameters)",
                    a => new BSWrapperObject_UnityEngine_SceneManagement_Scene(
                        SceneManager.CreateScene(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < CreateSceneParameters >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["CreateScene"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateScene(sceneName)",
                    a => new BSWrapperObject_UnityEngine_SceneManagement_Scene(
                        SceneManager.CreateScene( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadScene"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadScene(sceneName, parameters)",
                    a => new BSWrapperObject_UnityEngine_SceneManagement_Scene(
                        SceneManager.LoadScene(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < LoadSceneParameters >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["LoadScene"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadScene(sceneBuildIndex, parameters)",
                    a => new BSWrapperObject_UnityEngine_SceneManagement_Scene(
                        SceneManager.LoadScene(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < LoadSceneParameters >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["LoadSceneAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadSceneAsync(sceneBuildIndex)",
                    a => new BSWrapperObject_UnityEngine_AsyncOperation(
                        SceneManager.LoadSceneAsync( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadSceneAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadSceneAsync(sceneBuildIndex, parameters)",
                    a => new BSWrapperObject_UnityEngine_AsyncOperation(
                        SceneManager.LoadSceneAsync(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < LoadSceneParameters >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["LoadSceneAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadSceneAsync(sceneName)",
                    a => new BSWrapperObject_UnityEngine_AsyncOperation(
                        SceneManager.LoadSceneAsync( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadSceneAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadSceneAsync(sceneName, parameters)",
                    a => new BSWrapperObject_UnityEngine_AsyncOperation(
                        SceneManager.LoadSceneAsync(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < LoadSceneParameters >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["UnloadScene"] = new BSFunctionReference(
                new BSFunction(
                    "function UnloadScene(scene)",
                    a => SceneManager.UnloadScene( WrapperHelper.UnwrapObject < Scene >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["UnloadScene"] = new BSFunctionReference(
                new BSFunction(
                    "function UnloadScene(sceneBuildIndex)",
                    a => SceneManager.UnloadScene( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["UnloadScene"] = new BSFunctionReference(
                new BSFunction(
                    "function UnloadScene(sceneName)",
                    a => SceneManager.UnloadScene( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["UnloadSceneAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function UnloadSceneAsync(sceneBuildIndex)",
                    a => new BSWrapperObject_UnityEngine_AsyncOperation(
                        SceneManager.UnloadSceneAsync( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["UnloadSceneAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function UnloadSceneAsync(sceneName)",
                    a => new BSWrapperObject_UnityEngine_AsyncOperation(
                        SceneManager.UnloadSceneAsync( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["UnloadSceneAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function UnloadSceneAsync(scene)",
                    a => new BSWrapperObject_UnityEngine_AsyncOperation(
                        SceneManager.UnloadSceneAsync( WrapperHelper.UnwrapObject < Scene >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
