using BadScript.Interfaces;
using BadScript.Xml;
using UnityEngine;

namespace BadScript.Unity.Xml
{

    [CreateAssetMenu( menuName = "BadScript/Interfaces/Xml" )]
    public class BadScriptXmlInterface : BadScriptInterfaceObject
    {
        #region Public

        public override ABSScriptInterface Get()
        {
            return new XmlInterface();
        }

        #endregion
    }

}
