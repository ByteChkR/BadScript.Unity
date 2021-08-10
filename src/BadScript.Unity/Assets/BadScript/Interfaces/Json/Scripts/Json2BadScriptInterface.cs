using BadScript.Interfaces;
using BadScript.Json;
using UnityEngine;

namespace BadScript.Unity.Json
{

    [CreateAssetMenu( menuName = "BadScript/Interfaces/Json2BS" )]
    public class Json2BadScriptInterface : BadScriptInterfaceObject
    {
        #region Public

        public override ABSScriptInterface Get()
        {
            return new Json2BSInterface();
        }

        #endregion
    }

}
