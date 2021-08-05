using System.Collections;
using System.Collections.Generic;
using BadScript.Interfaces;
using BadScript.Zip;
using UnityEngine;

namespace BadScript.Unity.Zip
{
    [CreateAssetMenu(menuName = "BadScript/Interfaces/Zip")]
    public class BadScriptZipInterface : BadScriptInterfaceObject
    {
        public override ABSScriptInterface Get()
        {
            return new ZipApi();
        }
    }
}
