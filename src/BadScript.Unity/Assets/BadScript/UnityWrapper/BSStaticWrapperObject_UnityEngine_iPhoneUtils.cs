using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_iPhoneUtils : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_iPhoneUtils() : base( typeof( iPhoneUtils ) )
        {
            m_StaticProperties["isApplicationGenuine"] = new BSReflectionReference(
                () => Application.genuine ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["isApplicationGenuineAvailable"] = new BSReflectionReference(
                () => Application.genuineCheckAvailable ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}
