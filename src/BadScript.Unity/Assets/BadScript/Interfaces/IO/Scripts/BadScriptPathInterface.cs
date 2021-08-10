using System.IO;
using BadScript.Interfaces;
using BadScript.IO;
using UnityEngine;

namespace BadScript.Unity.IO
{

    [CreateAssetMenu( menuName = "BadScript/Interfaces/Path" )]
    public class BadScriptPathInterface : BadScriptInterfaceObject
    {
        public string AppRoot = "./";

        #region Public

        public override ABSScriptInterface Get()
        {
            return new BSFileSystemPathInterface( Path.GetFullPath( AppRoot ) );
        }

        #endregion
    }

}
