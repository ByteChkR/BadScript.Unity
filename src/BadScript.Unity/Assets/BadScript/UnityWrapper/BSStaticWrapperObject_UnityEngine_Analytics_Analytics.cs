using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Analytics;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Analytics_Analytics : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Analytics_Analytics() : base( typeof( Analytics ) )
        {
            m_StaticProperties["initializeOnStartup"] = new BSReflectionReference(
                () => Analytics.initializeOnStartup ? BSObject.One : BSObject.Zero,
                x => Analytics.initializeOnStartup = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["playerOptedOut"] = new BSReflectionReference(
                () => Analytics.playerOptedOut ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["eventUrl"] =
                new BSReflectionReference( () => new BSObject( Analytics.eventUrl ), null );

            m_StaticProperties["dashboardUrl"] = new BSReflectionReference(
                () => new BSObject( Analytics.dashboardUrl ),
                null );

            m_StaticProperties["configUrl"] = new BSReflectionReference(
                () => new BSObject( Analytics.configUrl ),
                null );

            m_StaticProperties["limitUserTracking"] = new BSReflectionReference(
                () => Analytics.limitUserTracking ? BSObject.One : BSObject.Zero,
                x => Analytics.limitUserTracking = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["deviceStatsEnabled"] = new BSReflectionReference(
                () => Analytics.deviceStatsEnabled ? BSObject.One : BSObject.Zero,
                x => Analytics.deviceStatsEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["enabled"] = new BSReflectionReference(
                () => Analytics.enabled ? BSObject.One : BSObject.Zero,
                x => Analytics.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

        }

        #endregion
    }

}
