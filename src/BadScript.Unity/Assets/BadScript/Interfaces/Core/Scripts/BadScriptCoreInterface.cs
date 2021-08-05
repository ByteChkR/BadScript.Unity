using System.Collections;
using System.Collections.Generic;
using BadScript.Core;
using BadScript.Interfaces;
using UnityEngine;

namespace BadScript.Unity.Core
{

    [CreateAssetMenu(menuName = "BadScript/Interfaces/Core")]
    public class BadScriptCoreInterface : BadScriptInterfaceObject
    {
        public override ABSScriptInterface Get()
        {
            return new BadScriptCoreApi();
        }
    }
}
