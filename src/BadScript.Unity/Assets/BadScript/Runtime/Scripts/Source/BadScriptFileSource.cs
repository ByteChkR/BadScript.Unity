using System.IO;
using BadScript.Common.Types;
using UnityEngine;

namespace BadScript.Unity
{

    [CreateAssetMenu(menuName = "BadScript/Scripts/FileSource")]
    public class BadScriptFileSource : BadScriptSource
    {

        [Note("BadScript File Source will load the Script from the specified path.")]

        [SerializeField]
        [Tooltip("The Bad Script Source Path")]
        private string m_SourcePath = "";
        [SerializeField]
        [Tooltip("If set to true, the runtime will print the ellapsed time")]
        private bool m_IsBenchmark = false;
        [SerializeField]
        [Tooltip("The Arguments that are passed to the script. Name inside the script: 'args'")]
        private string[] m_Arguments = new string[0];
        public override ABSObject Run(BSEngine engine)
        {

            string src = File.ReadAllText( m_SourcePath );

            return engine.LoadString(m_IsBenchmark, src, m_Arguments);
        }
    }

}
