using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Windows;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Windows_LicenseInformation : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Windows_LicenseInformation() : base( typeof( LicenseInformation ) )
        {
            m_StaticProperties["isOnAppTrial"] = new BSReflectionReference(
                () => LicenseInformation.isOnAppTrial ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}
