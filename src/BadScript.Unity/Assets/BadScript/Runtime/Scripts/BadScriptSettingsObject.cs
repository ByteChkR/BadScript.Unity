using System;
using System.Collections.Generic;
using System.Linq;
using BadScript.Interfaces;
using BadScript.Settings;
using UnityEngine;

namespace BadScript.Unity
{

    [Serializable]
    [CreateAssetMenu( menuName = "BadScript/Settings" )]
    public class BadScriptSettingsObject : ScriptableObject
    {
        [Note( "Settings Object that holds all the configurations needed for the BadScriptRuntimeComponent" )]
        [Header( "Parser Settings" )]
        [Tooltip( "Optimize Constant Expressions like '1+45'" )]
        public bool AllowOptimizations = true;

        [Header( "Runtime Settings" )]
        [Tooltip( "Adds the 'environment' interface that allows for dynamically loading more interfaces" )]
        public bool AddEnvironmentApi = true;
        [Tooltip( "All Available Interfaces" )]
        public List < BadScriptInterfaceObject > AvailableInterfaces;
        [Tooltip(
            "The Interfaces that are loaded when the engine starts. Prefix with '#' to load interface in global scope" )]
        public List < string > DefaultInterfaces;

        #region Public

        public BSEngine Build()
        {
            BSEngineSettings e = GetSettings();
            BSEngine engine = e.Build();

            if ( AddEnvironmentApi )
            {
                engine.AddInterface( new BSEngineEnvironmentInterface( engine ) );
                engine.LoadInterface( "environment" );
            }

            return engine;
        }

        #endregion

        #region Private

        private BSParserSettings GetParserSettings()
        {
            return new BSParserSettings { AllowOptimization = AllowOptimizations };
        }

        private BSEngineSettings GetSettings()
        {
            BSEngineSettings e = new BSEngineSettings( GetParserSettings() );
            e.ActiveInterfaces.AddRange( DefaultInterfaces );
            e.Interfaces.AddRange( AvailableInterfaces.Select( x => x.Get() ) );

            return e;
        }

        #endregion
    }

}
