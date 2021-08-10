using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Application : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Application() : base( typeof( Application ) )
        {
            m_StaticProperties["isLoadingLevel"] = new BSReflectionReference(
                () => Application.isLoadingLevel ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["streamedBytes"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Application.streamedBytes ),
                null );

            m_StaticProperties["isPlaying"] = new BSReflectionReference(
                () => Application.isPlaying ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["isFocused"] = new BSReflectionReference(
                () => Application.isFocused ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["buildGUID"] = new BSReflectionReference(
                () => new BSObject( Application.buildGUID ),
                null );

            m_StaticProperties["runInBackground"] = new BSReflectionReference(
                () => Application.runInBackground ? BSObject.One : BSObject.Zero,
                x => Application.runInBackground = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["isBatchMode"] = new BSReflectionReference(
                () => Application.isBatchMode ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["dataPath"] = new BSReflectionReference(
                () => new BSObject( Application.dataPath ),
                null );

            m_StaticProperties["streamingAssetsPath"] = new BSReflectionReference(
                () => new BSObject( Application.streamingAssetsPath ),
                null );

            m_StaticProperties["persistentDataPath"] = new BSReflectionReference(
                () => new BSObject( Application.persistentDataPath ),
                null );

            m_StaticProperties["temporaryCachePath"] = new BSReflectionReference(
                () => new BSObject( Application.temporaryCachePath ),
                null );

            m_StaticProperties["absoluteURL"] = new BSReflectionReference(
                () => new BSObject( Application.absoluteURL ),
                null );

            m_StaticProperties["unityVersion"] = new BSReflectionReference(
                () => new BSObject( Application.unityVersion ),
                null );

            m_StaticProperties["version"] = new BSReflectionReference(
                () => new BSObject( Application.version ),
                null );

            m_StaticProperties["installerName"] = new BSReflectionReference(
                () => new BSObject( Application.installerName ),
                null );

            m_StaticProperties["identifier"] = new BSReflectionReference(
                () => new BSObject( Application.identifier ),
                null );

            m_StaticProperties["productName"] = new BSReflectionReference(
                () => new BSObject( Application.productName ),
                null );

            m_StaticProperties["companyName"] = new BSReflectionReference(
                () => new BSObject( Application.companyName ),
                null );

            m_StaticProperties["cloudProjectId"] = new BSReflectionReference(
                () => new BSObject( Application.cloudProjectId ),
                null );

            m_StaticProperties["targetFrameRate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Application.targetFrameRate ),
                x => Application.targetFrameRate = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["consoleLogPath"] = new BSReflectionReference(
                () => new BSObject( Application.consoleLogPath ),
                null );

            m_StaticProperties["genuine"] = new BSReflectionReference(
                () => Application.genuine ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["genuineCheckAvailable"] = new BSReflectionReference(
                () => Application.genuineCheckAvailable ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["isShowingSplashScreen"] = new BSReflectionReference(
                () => Application.isShowingSplashScreen ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["isMobilePlatform"] = new BSReflectionReference(
                () => Application.isMobilePlatform ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["isConsolePlatform"] = new BSReflectionReference(
                () => Application.isConsolePlatform ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["isPlayer"] = new BSReflectionReference(
                () => Application.isPlayer ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["levelCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Application.levelCount ),
                null );

            m_StaticProperties["loadedLevel"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Application.loadedLevel ),
                null );

            m_StaticProperties["loadedLevelName"] = new BSReflectionReference(
                () => new BSObject( Application.loadedLevelName ),
                null );

            m_StaticProperties["isEditor"] = new BSReflectionReference(
                () => Application.isEditor ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["GetStreamProgressForLevel"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStreamProgressForLevel(levelIndex)",
                    a => new BSObject(
                        ( decimal ) Application.GetStreamProgressForLevel(
                            WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetStreamProgressForLevel"] = new BSFunctionReference(
                new BSFunction(
                    "function GetStreamProgressForLevel(levelName)",
                    a => new BSObject(
                        ( decimal ) Application.GetStreamProgressForLevel(
                            WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["CanStreamedLevelBeLoaded"] = new BSFunctionReference(
                new BSFunction(
                    "function CanStreamedLevelBeLoaded(levelIndex)",
                    a => Application.CanStreamedLevelBeLoaded( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["CanStreamedLevelBeLoaded"] = new BSFunctionReference(
                new BSFunction(
                    "function CanStreamedLevelBeLoaded(levelName)",
                    a => Application.CanStreamedLevelBeLoaded( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["IsPlaying"] = new BSFunctionReference(
                new BSFunction(
                    "function IsPlaying(obj)",
                    a => Application.IsPlaying( WrapperHelper.UnwrapObject < Object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["LoadLevelAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadLevelAsync(index)",
                    a => new BSWrapperObject_UnityEngine_AsyncOperation(
                        Application.LoadLevelAsync( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadLevelAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadLevelAsync(levelName)",
                    a => new BSWrapperObject_UnityEngine_AsyncOperation(
                        Application.LoadLevelAsync( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadLevelAdditiveAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadLevelAdditiveAsync(index)",
                    a => new BSWrapperObject_UnityEngine_AsyncOperation(
                        Application.LoadLevelAdditiveAsync( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadLevelAdditiveAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadLevelAdditiveAsync(levelName)",
                    a => new BSWrapperObject_UnityEngine_AsyncOperation(
                        Application.LoadLevelAdditiveAsync( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["UnloadLevel"] = new BSFunctionReference(
                new BSFunction(
                    "function UnloadLevel(index)",
                    a => Application.UnloadLevel( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["UnloadLevel"] = new BSFunctionReference(
                new BSFunction(
                    "function UnloadLevel(scenePath)",
                    a => Application.UnloadLevel( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
