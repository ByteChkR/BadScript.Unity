using BadScript.Common.Types;
using UnityEngine;
using UnityEngine.Networking;

namespace BadScript.Unity
{


    [CreateAssetMenu(menuName = "BadScript/Scripts/TextSource")]
    public class BadScriptTextSource : BadScriptSource
    {
        [SerializeField]
        [TextArea(5, 150)]
        [Tooltip("The Bad Script Source")]
        private string m_Source;
        [SerializeField]
        [Tooltip("If set to true, the runtime will print the ellapsed time")]
        private bool m_IsBenchmark;
        [SerializeField]
        [Tooltip("The Arguments that are passed to the script. Name inside the script: 'args'")]
        private string[] m_Arguments;
        public override ABSObject Run(BSEngine engine)
        {
            return engine.LoadString(m_IsBenchmark, m_Source, m_Arguments);
        }
    }

}
