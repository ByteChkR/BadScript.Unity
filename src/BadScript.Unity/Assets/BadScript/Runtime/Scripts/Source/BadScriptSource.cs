using BadScript.Common.Types;
using UnityEngine;

namespace BadScript.Unity
{

    public abstract class BadScriptSource : ScriptableObject
    {
        #region Public

        public abstract ABSObject Run( BSEngine engine );

        #endregion
    }

}
