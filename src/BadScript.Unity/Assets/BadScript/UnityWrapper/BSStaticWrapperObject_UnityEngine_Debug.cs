using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Debug : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Debug() : base( typeof( Debug ) )
        {
            m_StaticProperties["unityLogger"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ILogger( Debug.unityLogger ),
                null );

            m_StaticProperties["developerConsoleVisible"] = new BSReflectionReference(
                () => Debug.developerConsoleVisible ? BSObject.One : BSObject.Zero,
                x => Debug.developerConsoleVisible = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["isDebugBuild"] = new BSReflectionReference(
                () => Debug.isDebugBuild ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["logger"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_ILogger( Debug.unityLogger ),
                null );

        }

        #endregion
    }

}
