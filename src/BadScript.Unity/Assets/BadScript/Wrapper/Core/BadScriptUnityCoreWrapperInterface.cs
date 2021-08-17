using BadScript.Interfaces;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Unity;
using BadScript.Unity.Wrapper.Core;
using UnityEngine;

[CreateAssetMenu( menuName = "BadScript/Interfaces/Unity/Core" )]
public class BadScriptUnityCoreWrapperInterface : BadScriptInterfaceObject
{
    #region Public

    public override ABSScriptInterface Get()
    {
        WrapperHelper.AllowRecurseToString = false;

        return new BadScriptWrapperInterface( "unity_core", new UnityCoreStaticDB(), new UnityCoreCTorDB() );
    }

    #endregion
}
