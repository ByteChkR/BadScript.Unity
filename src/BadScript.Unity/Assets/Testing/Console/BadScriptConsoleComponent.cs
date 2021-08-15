using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Unity;
using BadScript.Unity.Console;
using UnityEngine;
using UnityEngine.UI;

public class BadScriptConsoleComponent : MonoBehaviour
{
    [SerializeField]
    private RectTransform m_ConsoleUI;
    [SerializeField]
    private ScrollRect m_OutputScrollRect;
    [SerializeField]
    private KeyCode m_ToggleKey;
    [SerializeField]
    private bool m_ToggleFullScreen;
    private int m_ToggleState = 0;
    [SerializeField]
    private Text m_ConsoleOutput;
    [SerializeField]
    private bool m_ClearOnInput = true;
    [SerializeField]
    private InputField m_ConsoleInput;
    [SerializeField]
    private string m_InputFunctionName = "onInput";
    [SerializeField]
    private BadScriptSource m_ConsoleSource;
    [SerializeField]
    private BadScriptSource[] m_ConsolePlugins;
    private ABSObject m_InputFunction;

    private void Start()
    {
        if ( m_ConsoleOutput == null || m_ConsoleInput == null )
            return;

        BadScriptUnityConsoleInterface.ConsoleInstance.OnClear += ConsoleInstance_OnClear;
        BadScriptUnityConsoleInterface.ConsoleInstance.OnWrite += ConsoleInstance_OnWrite;
        BadScriptUnityConsoleInterface.ConsoleInstance.OnWriteLine += ConsoleInstance_OnWriteLine;

        string[] src = m_ConsolePlugins.Select( x => x.GetSource() ).ToArray();
        ABSObject table=BadScriptRuntimeComponent.Instance.Run( m_ConsoleSource.GetSource(), src);
        m_InputFunction = table.GetProperty( m_InputFunctionName );
        



    }

    private IEnumerator ScrollBottomHelper()
    {
        yield return new WaitForEndOfFrame();

        m_OutputScrollRect.normalizedPosition = new Vector2(0, 0);
    }

    private void ConsoleInstance_OnWriteLine(ABSObject obj)
    {
        m_ConsoleOutput.text += obj.ConvertString() + "\n";
        StartCoroutine( ScrollBottomHelper() );
    }

    private void ConsoleInstance_OnWrite(ABSObject obj)
    {
        m_ConsoleOutput.text += obj.ConvertString();
        StartCoroutine(ScrollBottomHelper());
    }

    private void ConsoleInstance_OnClear()
    {
        m_ConsoleOutput.text = "";
    }

    private void Resize(float minuvx, float minuvy, float maxuvx, float maxuvy)
    {
        m_ConsoleUI.anchorMin = new Vector2(minuvx, minuvy);
        m_ConsoleUI.anchorMax = new Vector2(maxuvx, maxuvy);
    }

    private void Update()
    {
        if ( Input.GetKeyDown(m_ToggleKey) )
        {
            if ( m_ToggleState == 0 )
            {
                //Resize to Half Screen
                Resize(0.0f, 0.5f, 1.0f, 1 );
                Show();
                m_ToggleState++;
            }
            else if(m_ToggleState==1 && m_ToggleFullScreen)
            {
                //Resize to Full Screen
                Resize(0.0f, 0.0f, 1.0f, 1.0f);
                m_ToggleState++;
            }
            else
            {
                Hide();
                m_ToggleState=0;
            }
        }
    }

    public void Show()
    {
        m_ConsoleUI.gameObject.SetActive( true );
    }

    public void Hide()
    {
        m_ConsoleUI.gameObject.SetActive(false);
    }

    public void InputText(string text)
    {
        m_InputFunction.Invoke( new ABSObject[]{ new BSObject(text) } );
        m_ConsoleInput.Select();
        m_ConsoleInput.ActivateInputField();
    }


    public void OnInputTextEndEdit(string v)
    {
        InputText();
    }

    public void InputText()
    {
        InputText(m_ConsoleInput.text);
        if(m_ClearOnInput)
        m_ConsoleInput.text = "";

    }
}