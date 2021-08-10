using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_CrashReport : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_CrashReport() : base( typeof( CrashReport ) )
        {
            m_StaticProperties["lastReport"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_CrashReport( CrashReport.lastReport ),
                null );

        }

        #endregion
    }

}
