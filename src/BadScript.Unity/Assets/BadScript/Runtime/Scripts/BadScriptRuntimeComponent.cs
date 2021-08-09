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
        public BSEngine Engine { get; private set; }


        [Note("Wrapper for the BSEngine Instance that is used when executing BadScript Code.")]
        [Tooltip("Settings for the BadScript Runtime")]
        public BadScriptSettingsObject EngineSettings;

        public List < BadScriptSource > StartupScripts;

        protected override void Awake()
        {
            base.Awake();
            Engine = EngineSettings.Build();

            foreach ( BadScriptSource badScriptSource in StartupScripts )
            {
                badScriptSource.Run( Engine );
            }
        }

        public BSScope CreateScope() => new BSScope( Engine );

        public ABSObject Run(string script, ABSObject[] args) => Engine.LoadString(false, script, args);
        public ABSObject Run(string script, string[] args) => Engine.LoadString(false, script, args);
        public ABSObject Run(BSScope scope, string script, ABSObject[] args) => Engine.LoadString(false, scope, script, args);
        public ABSObject Run(BSScope scope, string script, string[] args) => Engine.LoadString(false, scope, script, args);

        public ABSObject Run( BadScriptSource script ) => script.Run( Engine );
    }
}
