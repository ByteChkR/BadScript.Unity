using System.Collections;
using System.Collections.Generic;
using BadScript.Common.Types;
using BadScript.Interfaces;
using UnityEngine;

namespace BadScript.Unity
{

    public class BadScriptRuntimeComponent : MonoBehaviour
    {
        private BSEngine m_Engine;

        [Tooltip("Settings for the BadScript Runtime")]
        public BadScriptSettingsObject EngineSettings;

        public List < BadScriptSource > StartupScripts;

        private void Awake()
        {
            m_Engine = EngineSettings.Build();

            foreach ( BadScriptSource badScriptSource in StartupScripts )
            {
                badScriptSource.Run( m_Engine );
            }
        }

        public ABSObject Run(string script, ABSObject[] args) => m_Engine.LoadString(false, script, args);
        public ABSObject Run(string script, string[] args) => m_Engine.LoadString(false, script, args);

        public ABSObject Run( BadScriptSource script ) => script.Run( m_Engine );
    }
}
