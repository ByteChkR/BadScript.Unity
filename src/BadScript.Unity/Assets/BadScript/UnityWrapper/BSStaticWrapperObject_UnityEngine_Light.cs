using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Light : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Light() : base( typeof( Light ) )
        {
            m_StaticProperties["pixelLightCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Light.pixelLightCount ),
                x => Light.pixelLightCount = WrapperHelper.UnwrapObject < int >( x ) );

        }

        #endregion
    }

}
