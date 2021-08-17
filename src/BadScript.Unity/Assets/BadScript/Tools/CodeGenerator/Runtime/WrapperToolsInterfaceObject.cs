using BadScript.Interfaces;
using UnityEngine;

namespace BadScript.Unity.Wrapper
{

    [CreateAssetMenu( menuName = "BadScript/Interfaces/WrapperTools" )]
    public class WrapperToolsInterfaceObject : BadScriptInterfaceObject
    {
        public override ABSScriptInterface Get()
        {
            return new WrapperToolsInterface();
        }
    }

}