using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking.PlayerConnection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Networking_PlayerConnection_PlayerConnection : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Networking_PlayerConnection_PlayerConnection() : base(
            typeof( PlayerConnection ) )
        {
            m_StaticProperties["instance"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Networking_PlayerConnection_PlayerConnection(
                    PlayerConnection.instance ),
                null );

        }

        #endregion
    }

}
