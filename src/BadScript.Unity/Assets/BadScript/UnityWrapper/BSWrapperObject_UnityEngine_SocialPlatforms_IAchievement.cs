using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SocialPlatforms;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_SocialPlatforms_IAchievement : BSWrapperObject < IAchievement >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SocialPlatforms_IAchievement( IAchievement obj ) : base( obj )
        {
            m_Properties["id"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.id ),
                x => m_InternalObject.id = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["percentCompleted"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.percentCompleted ),
                x => m_InternalObject.percentCompleted = WrapperHelper.UnwrapObject < double >( x ) );

            m_Properties["completed"] = new BSReflectionReference(
                () => m_InternalObject.completed ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["hidden"] = new BSReflectionReference(
                () => m_InternalObject.hidden ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["lastReportedDate"] = new BSReflectionReference(
                () => new BSWrapperObject_System_DateTime( m_InternalObject.lastReportedDate ),
                null );

        }

        #endregion
    }

}
