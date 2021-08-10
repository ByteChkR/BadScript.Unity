using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.WSA;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_WSA_Application : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_WSA_Application() : base( typeof( Application ) )
        {
            m_StaticProperties["arguments"] = new BSReflectionReference(
                () => new BSObject( Application.arguments ),
                null );

            m_StaticProperties["advertisingIdentifier"] = new BSReflectionReference(
                () => new BSObject( Application.advertisingIdentifier ),
                null );

        }

        #endregion
    }

}
