using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_HDROutputSettings : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_HDROutputSettings() : base( typeof( HDROutputSettings ) )
        {
            m_StaticProperties["main"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_HDROutputSettings( HDROutputSettings.main ),
                null );

        }

        #endregion
    }

}
