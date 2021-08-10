using BadScript.Common.Types;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Unity;
using BadScript.Unity.Utils.Expressions;
using BSWrapperObjects.Internal.UnityWrapper;
using UnityEngine;
using UnityEngine.Playables;

public class TestComponent : MonoBehaviour
{
    [SerializeField]
    private BadScriptValue < decimal > MyValue;
    [SerializeField]
    private BadScriptValue < decimal > MyConstValue;

    [SerializeField]
    [TextArea( 5, 50 )]
    private string WrapperTest = "";

    #region Unity Event Functions

    private void Start()
    {
        decimal d = MyValue.Compute( 2, 5 );
        Debug.Log( "Value: " + d );

        decimal cv = MyConstValue; //Implicit cast if no arguments required
        Debug.Log( "Constant Value: " + cv );
        

        WrapperHelper.AllowRecurseToString = false;
        UnityCTorDB db = new UnityCTorDB();
        UnityStaticDB sdb = new UnityStaticDB();
        BadScriptRuntimeComponent.Instance.Engine.AddInterface( db.CreateInterface( "unity" ) );
        BadScriptRuntimeComponent.Instance.Engine.AddInterface( sdb.CreateInterface( "unity" ) );

        BadScriptRuntimeComponent.Instance.Run(
            WrapperTest,
            new ABSObject[] { new BSWrapperObject_UnityEngine_MonoBehaviour( this ) } );

    }

    #endregion
}
