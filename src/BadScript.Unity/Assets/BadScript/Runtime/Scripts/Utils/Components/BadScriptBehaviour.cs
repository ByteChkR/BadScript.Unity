using BadScript.Common.Types;
using BadScript.Common.Types.References;
using UnityEngine;

namespace BadScript.Unity
{

    public class BadScriptBehaviour : MonoBehaviour
    {
        [Note(
            "Calls the MonoBehaviour Functions inside the BadScript Source.\nAvailable Functions:\n\t'Start'\n\t'Update'\n\t'FixedUpdate'\n" )]
        [SerializeField]
        private BadScriptSource m_ScriptSource = null;
        private ABSObject m_Start;
        private ABSObject m_Update;
        private ABSObject m_FixedUpdate;

        #region Unity Event Functions

        private void FixedUpdate()
        {
            m_FixedUpdate?.Invoke( new ABSObject[0] );
        }

        private void Start()
        {
            Populate();
            m_Start?.Invoke( new ABSObject[0] );
        }

        private void Update()
        {
            m_Update?.Invoke( new ABSObject[0] );
        }

        #endregion

        #region Private

        private void Populate()
        {
            ABSObject o = BadScriptRuntimeComponent.Instance.Run(
                m_ScriptSource );

            if ( o.HasProperty( "Start" ) )
            {
                m_Start = o.GetProperty( "Start" ).ResolveReference();
            }

            if ( o.HasProperty( "Update" ) )
            {
                m_Update = o.GetProperty( "Update" ).ResolveReference();
            }

            if ( o.HasProperty( "FixedUpdate" ) )
            {
                m_FixedUpdate = o.GetProperty( "FixedUpdate" ).ResolveReference();
            }
        }

        #endregion
    }

}
