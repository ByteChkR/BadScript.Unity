using System.Collections;
using System.Linq;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Unity;
using BadScript.Unity.Console;
using UnityEngine;
using UnityEngine.UI;

public class BadScriptConsoleComponent : MonoBehaviour
{
    [Header( "UI References" )]
    [SerializeField]
    private RectTransform m_ConsoleUI;
    [Header( "Output" )]
    [SerializeField]
    private ScrollRect m_OutputScrollRect;
    [SerializeField]
    private Text m_ConsoleOutput;
    [SerializeField]
    private int m_MaxConsoleCharacters = 100000;
    [Header( "Input" )]
    [SerializeField]
    private bool m_ClearOnInput = true;
    [SerializeField]
    private InputField m_ConsoleInput;
    [Header( "Activation Controls" )]
    [SerializeField]
    private KeyCode m_ToggleKey;
    [SerializeField]
    private BadScriptConsoleViewState[] m_ViewStates;

    [Header( "Console Source" )]
    [SerializeField]
    private BadScriptSource m_ConsoleSource;
    [Tooltip( "The Function that gets invoked when a command gets entered" )]
    [SerializeField]
    private string m_InputFunctionName = "onInput";
    [SerializeField]
    [Tooltip(
        "Plugins that get loaded in the context of the console. This can be used to load helper scripts before the console starts." )]
    private BadScriptSource[] m_ConsolePlugins;
    private int m_ViewState = 0;
    private ABSObject m_InputFunction;

    private bool IsShown => m_ConsoleUI.gameObject.activeSelf;

    #region Unity Event Functions

    private void Start()
    {
        if ( m_ConsoleOutput == null || m_ConsoleInput == null )
        {
            return;
        }

        BadScriptUnityConsoleInterface.ConsoleInstance.OnClear += ConsoleInstance_OnClear;
        BadScriptUnityConsoleInterface.ConsoleInstance.OnWrite += ConsoleInstance_OnWrite;
        BadScriptUnityConsoleInterface.ConsoleInstance.OnWriteLine += ConsoleInstance_OnWriteLine;

        string[] src = m_ConsolePlugins.Select( x => x.GetSource() ).ToArray();
        ABSObject table = BadScriptRuntimeComponent.Instance.Run( m_ConsoleSource.GetSource(), src );
        m_InputFunction = table.GetProperty( m_InputFunctionName );
    }

    private void Update()
    {
        if ( Input.GetKeyDown( m_ToggleKey ) )
        {
            m_ViewState++;

            if ( m_ViewState == m_ViewStates.Length )
            {
                m_ViewState = 0;
            }

            BadScriptConsoleViewState state = m_ViewStates[m_ViewState];

            if ( state.Show )
            {
                Show();
                state.Apply( m_ConsoleUI );
            }
            else
            {
                Hide();
            }

        }
    }

    #endregion

    #region Public

    public void Hide()
    {
        m_ConsoleUI.gameObject.SetActive( false );
    }

    public void InputText( string text )
    {
        m_InputFunction.Invoke( new ABSObject[] { new BSObject( text ) } );
        m_ConsoleInput.Select();
        m_ConsoleInput.ActivateInputField();
    }

    public void InputText()
    {
        InputText( m_ConsoleInput.text );

        if ( m_ClearOnInput )
        {
            m_ConsoleInput.text = "";
        }

    }

    public void OnInputTextEndEdit( string v )
    {
        InputText();
    }

    public void Show()
    {
        m_ConsoleUI.gameObject.SetActive( true );
    }

    #endregion

    #region Private

    private void ConsoleInstance_OnClear()
    {
        m_ConsoleOutput.text = "";
        if ( IsShown )
        {
            StartCoroutine( ScrollBottomHelper() );
        }
    }

    private void ConsoleInstance_OnWrite( ABSObject obj )
    {
        string s = obj.ConvertString();
        EnsureSize(s);

        if ( IsShown )
        {
            StartCoroutine( ScrollBottomHelper() );
        }
    }

    private void ConsoleInstance_OnWriteLine( ABSObject obj )
    {
        EnsureSize(obj.ConvertString() + "\n");

        if ( IsShown )
        {
            StartCoroutine( ScrollBottomHelper() );
        }
    }

    private void EnsureSize(string newText)
    {
        if ( m_ConsoleOutput.text.Length + newText.Length > m_MaxConsoleCharacters )
        {
            int sz = ( m_ConsoleOutput.text.Length + newText.Length ) - m_MaxConsoleCharacters;
            
            m_ConsoleOutput.text = ( m_ConsoleOutput.text + newText ).Substring( sz, m_MaxConsoleCharacters );
        }
        else
            m_ConsoleOutput.text += newText;
    }

    private IEnumerator ScrollBottomHelper()
    {
        yield return new WaitForEndOfFrame();

        m_OutputScrollRect.normalizedPosition = new Vector2( 0, 0 );
    }

    #endregion
}
