#define BS_WRAPPED

using BadScript.Common.Types;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Unity;
using BadScript.Unity.Utils.Expressions;
#if BS_WRAPPED
using BadScript.Wrapper.Internal;
#endif
using UnityEngine;

public class TestComponent : MonoBehaviour
{
    [SerializeField]
    private BadScriptValue<decimal> MyValue;
    [SerializeField]
    private BadScriptValue<decimal> MyConstValue;
#if BS_WRAPPED

    [SerializeField]
    [TextArea( 5, 50 )]
    private string WrapperTest = "";

#endif
    

    private void Start()
    {
        decimal d = MyValue.Compute( 2, 5 );
        Debug.Log( "Value: " + d );

        decimal cv = MyConstValue; //Implicit cast if no arguments required
        Debug.Log( "Constant Value: " + cv );

#if BS_WRAPPED
        
        BadScriptCTorDB db = new BadScriptCTorDB();
        BadScriptStaticDB sdb = new BadScriptStaticDB();
        BadScriptRuntimeComponent.Instance.Engine.AddInterface(db.CreateInterface("unity"));
        BadScriptRuntimeComponent.Instance.Engine.AddInterface(sdb.CreateInterface("unity"));

        BadScriptRuntimeComponent.Instance.Run(
            WrapperTest,
            new ABSObject[] { new BSWrapperObject_MonoBehaviour( this ) } );
#endif
    }
}
