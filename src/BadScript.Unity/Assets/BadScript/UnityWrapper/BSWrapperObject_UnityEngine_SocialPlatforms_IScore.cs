using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SocialPlatforms;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_SocialPlatforms_IScore : BSWrapperObject < IScore >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SocialPlatforms_IScore( IScore obj ) : base( obj )
        {
            m_Properties["leaderboardID"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.leaderboardID ),
                x => m_InternalObject.leaderboardID = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["value"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.value ),
                x => m_InternalObject.value = WrapperHelper.UnwrapObject < long >( x ) );

            m_Properties["date"] = new BSReflectionReference(
                () => new BSWrapperObject_System_DateTime( m_InternalObject.date ),
                null );

            m_Properties["formattedValue"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.formattedValue ),
                null );

            m_Properties["userID"] = new BSReflectionReference( () => new BSObject( m_InternalObject.userID ), null );

            m_Properties["rank"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.rank ),
                null );

        }

        #endregion
    }

}
