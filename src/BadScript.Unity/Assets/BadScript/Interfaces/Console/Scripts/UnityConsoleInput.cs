using System;
using BadScript.Common.Types;

namespace BadScript.Unity.Console
{

    [Serializable]
    public abstract class UnityConsoleInput
    {
        #region Public

        public abstract ABSObject Read();

        #endregion
    }

}
