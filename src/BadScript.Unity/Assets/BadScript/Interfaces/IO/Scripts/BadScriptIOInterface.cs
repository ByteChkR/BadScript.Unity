using BadScript.Interfaces;
using BadScript.IO;
using UnityEngine;

namespace BadScript.Unity.IO
{

    [CreateAssetMenu( menuName = "BadScript/Interfaces/IO" )]
    public class BadScriptIOInterface : BadScriptInterfaceObject
    {
        #region Public

        public override ABSScriptInterface Get()
        {
            return new BSFileSystemInterface();
        }

        #endregion
    }

}
