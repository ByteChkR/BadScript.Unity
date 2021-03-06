using BadScript.Http;
using BadScript.Interfaces;
using UnityEngine;

namespace BadScript.Unity.Http
{

    [CreateAssetMenu( menuName = "BadScript/Interfaces/Http" )]
    public class BadScriptHttpInterface : BadScriptInterfaceObject
    {
        #region Public

        public override ABSScriptInterface Get()
        {
            return new HttpApi();
        }

        #endregion
    }

}
