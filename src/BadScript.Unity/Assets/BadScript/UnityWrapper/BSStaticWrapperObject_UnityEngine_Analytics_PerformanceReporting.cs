using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Analytics;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Analytics_PerformanceReporting : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Analytics_PerformanceReporting() : base(
            typeof( PerformanceReporting ) )
        {
            m_StaticProperties["enabled"] = new BSReflectionReference(
                () => PerformanceReporting.enabled ? BSObject.One : BSObject.Zero,
                x => PerformanceReporting.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["graphicsInitializationFinishTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) PerformanceReporting.graphicsInitializationFinishTime ),
                null );

        }

        #endregion
    }

}
