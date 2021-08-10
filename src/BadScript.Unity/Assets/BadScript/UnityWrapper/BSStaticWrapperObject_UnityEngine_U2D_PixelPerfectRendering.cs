using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.U2D;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_U2D_PixelPerfectRendering : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_U2D_PixelPerfectRendering() : base( typeof( PixelPerfectRendering ) )
        {
            m_StaticProperties["pixelSnapSpacing"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) PixelPerfectRendering.pixelSnapSpacing ),
                x => PixelPerfectRendering.pixelSnapSpacing = WrapperHelper.UnwrapObject < float >( x ) );

        }

        #endregion
    }

}
