using System.Net;
using BadScript.Common.Types;
using UnityEngine;

namespace BadScript.Unity
{

    [CreateAssetMenu(menuName = "BadScript/Scripts/WebSource")]
    public class BadScriptWebSource : BadScriptSource
    {
        [SerializeField]
        [Tooltip("The Bad Script Source Url")]
        private string m_SourceUrl;
        [SerializeField]
        [Tooltip("If set to true, the runtime will print the ellapsed time")]
        private bool m_IsBenchmark;
        [SerializeField]
        [Tooltip("The Arguments that are passed to the script. Name inside the script: 'args'")]
        private string[] m_Arguments;
        public override ABSObject Run(BSEngine engine)
        {
            using (WebClient wc = new WebClient())
            {
                string src = wc.DownloadString(m_SourceUrl);

                return engine.LoadString(m_IsBenchmark, src, m_Arguments);
            }
        }
    }

}