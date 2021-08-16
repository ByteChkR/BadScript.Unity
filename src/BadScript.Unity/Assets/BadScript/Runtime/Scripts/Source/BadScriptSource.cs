using BadScript.Common.Types;
using UnityEngine;

namespace BadScript.Unity
{

    public abstract class BadScriptSource : ScriptableObject
    {
        [SerializeField]
        [Tooltip( "If set to true, the runtime will print the ellapsed time" )]
        protected bool m_IsBenchmark = false;
        [SerializeField]
        [Tooltip( "The Arguments that are passed to the script. Name inside the script: 'args'" )]
        protected string[] m_Arguments = new string[0];

        #region Public

        public abstract string GetSource();

        public virtual ABSObject Run( BSEngine engine )
        {
            return engine.LoadString( m_IsBenchmark, GetSource(), m_Arguments );
        }

        #endregion
    }

}
