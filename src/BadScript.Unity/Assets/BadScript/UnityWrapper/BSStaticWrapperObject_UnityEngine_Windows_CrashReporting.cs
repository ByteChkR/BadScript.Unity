using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Windows;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Windows_CrashReporting : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Windows_CrashReporting() : base( typeof( CrashReporting ) )
        {
            m_StaticProperties["crashReportFolder"] = new BSReflectionReference(
                () => new BSObject( CrashReporting.crashReportFolder ),
                null );

        }

        #endregion
    }

}
