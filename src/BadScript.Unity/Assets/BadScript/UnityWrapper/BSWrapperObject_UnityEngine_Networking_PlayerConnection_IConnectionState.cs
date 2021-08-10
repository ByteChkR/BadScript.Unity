using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking.PlayerConnection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Networking_PlayerConnection_IConnectionState : BSWrapperObject < IConnectionState >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Networking_PlayerConnection_IConnectionState( IConnectionState obj ) : base(
            obj )
        {
            m_Properties["connectionName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.connectionName ),
                null );

        }

        #endregion
    }

}
