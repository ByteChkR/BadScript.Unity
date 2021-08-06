using System.Collections;
using System.Collections.Generic;
using BadScript.Common.Runtime;
using BadScript.Common.Types;
using BadScript.Interfaces;
using BadScript.Unity.Utils;
using UnityEngine;

namespace BadScript.Unity
{

    public class BadScriptRuntimeComponent : Singleton <BadScriptRuntimeComponent>
    {
        private BSEngine m_Engine;

        [Note("Wrapper for the BSEngine Instance that is used when executing BadScript Code.")]
        [Tooltip("Settings for the BadScript Runtime")]
        public BadScriptSettingsObject EngineSettings;

        public List < BadScriptSource > StartupScripts;

        protected override void Awake()
        {
            base.Awake();
            m_Engine = EngineSettings.Build();

            foreach ( BadScriptSource badScriptSource in StartupScripts )
            {
                badScriptSource.Run( m_Engine );
            }
        }

        public BSScope CreateScope() => new BSScope( m_Engine );

        public ABSObject Run(string script, ABSObject[] args) => m_Engine.LoadString(false, script, args);
        public ABSObject Run(string script, string[] args) => m_Engine.LoadString(false, script, args);
        public ABSObject Run(BSScope scope, string script, ABSObject[] args) => m_Engine.LoadString(false, scope, script, args);
        public ABSObject Run(BSScope scope, string script, string[] args) => m_Engine.LoadString(false, scope, script, args);

        public ABSObject Run( BadScriptSource script ) => script.Run( m_Engine );
    }
}
