using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Diagnostics;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Diagnostics_PlayerConnection : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Diagnostics_PlayerConnection() : base( typeof( PlayerConnection ) )
        {
            m_StaticProperties["connected"] = new BSReflectionReference(
                () => PlayerConnection.connected ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}
