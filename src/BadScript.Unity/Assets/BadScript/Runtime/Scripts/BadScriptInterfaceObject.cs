using System;
using BadScript.Interfaces;
using UnityEngine;

namespace BadScript.Unity
{

    [Serializable]
    public abstract class BadScriptInterfaceObject : ScriptableObject
    {
        public abstract ABSScriptInterface Get();
    }

}