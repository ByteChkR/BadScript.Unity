using System;
using BadScript.Common.Types;

namespace BadScript.Unity.Console
{
    [Serializable]
    public abstract class UnityConsoleInput
    {
        public abstract ABSObject Read();
    }

}
