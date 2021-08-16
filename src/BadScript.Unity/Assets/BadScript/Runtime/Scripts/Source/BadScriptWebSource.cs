using System.Net;
using UnityEngine;

namespace BadScript.Unity
{

    [CreateAssetMenu( menuName = "BadScript/Scripts/WebSource" )]
    public class BadScriptWebSource : BadScriptSource
    {
        [SerializeField]
        [Tooltip( "The Bad Script Source Url" )]
        private string m_SourceUrl = "";

        #region Public

        public override string GetSource()
        {
            using ( WebClient wc = new WebClient() )
            {
                return wc.DownloadString( m_SourceUrl );
            }
        }

        #endregion
    }

}
