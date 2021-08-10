using System;
using BadScript.Common.Runtime;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Common.Types.References;
using UnityEngine;

namespace BadScript.Unity.Utils.Expressions
{

    [Serializable]
    public class BadScriptValue < T >
    {
        [SerializeField]
        [Tooltip( "A single Line Expression does not require a return statement" )]
        private bool m_IsMultiLineExpression = false;
        [SerializeField]
        [TextArea( 1, 5 )]
        [Tooltip( "The Expression to Compute." )]
        private string m_Expression = "0";
        [SerializeField]
        [Tooltip( "The Arguments that are required and are available when computing the expression." )]
        private BadScriptExpressionArgument[] Arguments = new BadScriptExpressionArgument[0];

        public static implicit operator T( BadScriptValue < T > v )
        {
            return v.Compute();
        }

        #region Public

        public T Compute( params object[] arg )
        {
            if ( arg.Length != Arguments.Length )
            {
                throw new Exception( "Invalid Argument Count: " + arg.Length );
            }

            ABSObject[] args = new ABSObject[arg.Length];

            BSScope scope = BadScriptRuntimeComponent.Instance.CreateScope();

            for ( int i = 0; i < arg.Length; i++ )
            {
                scope.AddLocalVar( Arguments[i].Name, Arguments[i].CreateObject( arg[i] ) );
            }

            string expr = m_IsMultiLineExpression ? m_Expression : "return " + m_Expression;
            ABSObject ret = BadScriptRuntimeComponent.Instance.Run( scope, expr, new string[0] );

            if ( ret.ResolveReference() is BSObject bsRet )
            {
                return ( T ) bsRet.GetInternalObject();
            }

            throw new Exception( "Invalid Return Type: " + ret.GetType().Name );
        }

        #endregion
    }

}
