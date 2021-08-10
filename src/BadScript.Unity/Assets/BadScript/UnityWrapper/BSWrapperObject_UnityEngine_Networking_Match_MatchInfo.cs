using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Networking.Match;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Networking_Match_MatchInfo : BSWrapperObject < MatchInfo >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Networking_Match_MatchInfo( MatchInfo obj ) : base( obj )
        {
            m_Properties["address"] = new BSReflectionReference( () => new BSObject( m_InternalObject.address ), null );

            m_Properties["port"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.port ),
                null );

            m_Properties["domain"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.domain ),
                null );

            m_Properties["accessToken"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Networking_Types_NetworkAccessToken(
                    m_InternalObject.accessToken ),
                null );

            m_Properties["usingRelay"] = new BSReflectionReference(
                () => m_InternalObject.usingRelay ? BSObject.One : BSObject.Zero,
                null );

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
