using BadScript.Interfaces;
using BadScript.StringUtils;
using UnityEngine;

namespace BadScript.Unity.StringUtils
{

    [CreateAssetMenu( menuName = "BadScript/Interfaces/String" )]
    public class BadScriptStringInterface : BadScriptInterfaceObject
    {
        #region Public

        public override ABSScriptInterface Get()
        {
            return new StringUtilsApi();
        }

        #endregion
    }

}
