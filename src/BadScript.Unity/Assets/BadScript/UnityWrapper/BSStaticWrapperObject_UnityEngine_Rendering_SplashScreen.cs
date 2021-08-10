using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_SplashScreen : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_SplashScreen() : base( typeof( SplashScreen ) )
        {
            m_StaticProperties["isFinished"] = new BSReflectionReference(
                () => SplashScreen.isFinished ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}
