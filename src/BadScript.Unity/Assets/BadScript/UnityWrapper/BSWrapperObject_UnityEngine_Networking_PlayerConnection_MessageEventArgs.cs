using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking.PlayerConnection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Networking_PlayerConnection_MessageEventArgs : BSWrapperObject < MessageEventArgs >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Networking_PlayerConnection_MessageEventArgs( MessageEventArgs obj ) : base(
            obj )
        {
            m_Properties["playerId"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.playerId ),
                x => m_InternalObject.playerId = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
