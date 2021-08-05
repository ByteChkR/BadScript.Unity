using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using BadScript.Http;
using BadScript.Interfaces;
using UnityEngine;

namespace BadScript.Unity.Http
{
    [CreateAssetMenu(menuName = "BadScript/Interfaces/Http")]
    public class BadScriptHttpInterface : BadScriptInterfaceObject
    {
        public override ABSScriptInterface Get()
        {
            return new HttpApi();
        }
    }
}
