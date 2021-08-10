using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_SleepTimeout : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_SleepTimeout() : base( typeof( SleepTimeout ) )
        {
            m_StaticProperties["NeverSleep"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SleepTimeout.NeverSleep ),
                null );

            m_StaticProperties["SystemSetting"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) SleepTimeout.SystemSetting ),
                null );

        }

        #endregion
    }

}
