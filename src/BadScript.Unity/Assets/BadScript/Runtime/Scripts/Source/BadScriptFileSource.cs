using System.IO;
using UnityEngine;

namespace BadScript.Unity
{

    [CreateAssetMenu( menuName = "BadScript/Scripts/FileSource" )]
    public class BadScriptFileSource : BadScriptSource
    {
        [SerializeField]
        [Tooltip( "The Bad Script Source Path" )]
        private string m_SourcePath = "";

        #region Public

        public override string GetSource()
        {
            return File.ReadAllText( m_SourcePath );
        }

        #endregion
    }

}
