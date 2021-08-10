using BadScript.Interfaces;
using BadScript.Json;
using UnityEngine;

namespace BadScript.Unity.Json
{

    [CreateAssetMenu( menuName = "BadScript/Interfaces/BS2Json" )]
    public class BadScript2JsonInterface : BadScriptInterfaceObject
    {
        #region Public

        public override ABSScriptInterface Get()
        {
            return new BS2JsonInterface();
        }

        #endregion
    }

}
