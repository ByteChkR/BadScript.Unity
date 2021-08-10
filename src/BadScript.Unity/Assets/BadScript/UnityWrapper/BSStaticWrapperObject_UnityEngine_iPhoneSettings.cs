using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_iPhoneSettings : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_iPhoneSettings() : base( typeof( iPhoneSettings ) )
        {
            m_StaticProperties["verticalOrientation"] = new BSReflectionReference(
                () => iPhoneSettings.verticalOrientation ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["screenCanDarken"] = new BSReflectionReference(
                () => iPhoneSettings.screenCanDarken ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}
