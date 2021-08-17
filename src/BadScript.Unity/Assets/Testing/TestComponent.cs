using BadScript.Unity.Utils.Expressions;
using UnityEngine;

public class TestComponent : MonoBehaviour
{
    [SerializeField]
    private BadScriptValue < decimal > MyValue;
    [SerializeField]
    private BadScriptValue < decimal > MyConstValue;

    #region Unity Event Functions

    private void Start()
    {

        decimal d = MyValue.Compute( 2, 5 );
        Debug.Log( "Value: " + d );

        decimal cv = MyConstValue; //Implicit cast if no arguments required
        Debug.Log( "Constant Value: " + cv );
    }

    #endregion
}
