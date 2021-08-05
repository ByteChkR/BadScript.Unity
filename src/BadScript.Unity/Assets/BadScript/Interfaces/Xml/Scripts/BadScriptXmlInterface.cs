using System.Collections;
using System.Collections.Generic;
using BadScript.Interfaces;
using BadScript.Xml;
using UnityEngine;

namespace BadScript.Unity.Xml
{
    [CreateAssetMenu(menuName = "BadScript/Interfaces/Xml")]
    public class BadScriptXmlInterface : BadScriptInterfaceObject
    {
        public override ABSScriptInterface Get()
        {
            return new XmlInterface();
        }
    }
}
