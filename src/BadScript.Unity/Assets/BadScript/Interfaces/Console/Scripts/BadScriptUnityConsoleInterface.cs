using System;
using System.Collections;
using System.Collections.Generic;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.ConsoleUtils;
using BadScript.Interfaces;
using UnityEngine;
using BadScript.Unity;
using UnityEditor;

namespace BadScript.Unity.Console
{
    [CreateAssetMenu(menuName = "BadScript/Interfaces/Console")]
    public class BadScriptUnityConsoleInterface : BadScriptInterfaceObject
    {

        [Note("Unity Console has the same implementations for Write and WriteLine", MessageType.Warning)]
        [Header( "Console Output" )]
        public bool UseUnityConsole = true;
        public event Action OnClear;
        public event Action<ABSObject> OnWrite;
        public event Action<ABSObject> OnWriteLine;

        [Header("Console Input")]
        [SerializeField]
        private UnityConsoleInput m_ConsoleInput;

        public override ABSScriptInterface Get()
        {
            ConsoleApi api = new ConsoleApi( Write, WriteLine, Clear, Read );
            return api;
        }

        private ABSObject Read()
        {
            if ( m_ConsoleInput == null )
            {
                Debug.LogError( "Reading from Console Input is not Supported." );

                return new BSObject( "" );
            }
            else
            {
                return m_ConsoleInput.Read();
            }
        }

        private void Clear()
        {
            OnClear?.Invoke();
            if(UseUnityConsole)
            Debug.ClearDeveloperConsole();
        }

        private void WriteLine( ABSObject obj )
        {
            OnWriteLine?.Invoke( obj );

            if (UseUnityConsole)
                Debug.Log( obj );
        }

        private void Write( ABSObject obj )
        {
            OnWrite?.Invoke( obj );

            if (UseUnityConsole)
                Debug.Log( obj );
        }
    }
}
