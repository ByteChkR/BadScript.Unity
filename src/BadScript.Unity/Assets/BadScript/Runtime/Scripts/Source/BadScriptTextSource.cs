using BadScript.Common.Types;
using UnityEngine;

namespace BadScript.Unity
{

    [CreateAssetMenu( menuName = "BadScript/Scripts/TextSource" )]
    public class BadScriptTextSource : BadScriptSource
    {
        [SerializeField]
        [TextArea( 5, 150 )]
        [Tooltip( "The Bad Script Source" )]
        private string m_Source = "";

        #region Public

        public override string GetSource()
        {
            return m_Source;
        }

        #endregion
    }

}
