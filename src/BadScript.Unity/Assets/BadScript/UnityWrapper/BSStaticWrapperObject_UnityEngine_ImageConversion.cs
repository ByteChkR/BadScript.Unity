using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_ImageConversion : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_ImageConversion() : base( typeof( ImageConversion ) )
        {
            m_StaticProperties["EnableLegacyPngGammaRuntimeLoadBehavior"] = new BSReflectionReference(
                () => ImageConversion.EnableLegacyPngGammaRuntimeLoadBehavior ? BSObject.One : BSObject.Zero,
                x => ImageConversion.EnableLegacyPngGammaRuntimeLoadBehavior =
                    WrapperHelper.UnwrapObject < bool >( x ) );

        }

        #endregion
    }

}
