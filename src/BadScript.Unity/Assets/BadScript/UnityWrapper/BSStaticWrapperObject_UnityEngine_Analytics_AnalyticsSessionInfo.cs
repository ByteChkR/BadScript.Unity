using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Analytics;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Analytics_AnalyticsSessionInfo : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Analytics_AnalyticsSessionInfo() : base(
            typeof( AnalyticsSessionInfo ) )
        {
            m_StaticProperties["sessionId"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) AnalyticsSessionInfo.sessionId ),
                null );

            m_StaticProperties["sessionCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) AnalyticsSessionInfo.sessionCount ),
                null );

            m_StaticProperties["sessionElapsedTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) AnalyticsSessionInfo.sessionElapsedTime ),
                null );

            m_StaticProperties["sessionFirstRun"] = new BSReflectionReference(
                () => AnalyticsSessionInfo.sessionFirstRun ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["userId"] = new BSReflectionReference(
                () => new BSObject( AnalyticsSessionInfo.userId ),
                null );

            m_StaticProperties["customUserId"] = new BSReflectionReference(
                () => new BSObject( AnalyticsSessionInfo.customUserId ),
                x => AnalyticsSessionInfo.customUserId = WrapperHelper.UnwrapObject < string >( x ) );

            m_StaticProperties["customDeviceId"] = new BSReflectionReference(
                () => new BSObject( AnalyticsSessionInfo.customDeviceId ),
                x => AnalyticsSessionInfo.customDeviceId = WrapperHelper.UnwrapObject < string >( x ) );

            m_StaticProperties["identityToken"] = new BSReflectionReference(
                () => new BSObject( AnalyticsSessionInfo.identityToken ),
                null );

        }

        #endregion
    }

}
