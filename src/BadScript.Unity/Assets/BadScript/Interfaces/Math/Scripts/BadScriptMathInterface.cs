
using BadScript.Interfaces;
using BadScript.Math;
using UnityEngine;

namespace BadScript.Unity.Math
{

    [CreateAssetMenu( menuName = "BadScript/Interfaces/Math" )]
    public class BadScriptMathInterface : BadScriptInterfaceObject
    {
        public override ABSScriptInterface Get()
        {
            return new BSMathApi();
        }
    }

}