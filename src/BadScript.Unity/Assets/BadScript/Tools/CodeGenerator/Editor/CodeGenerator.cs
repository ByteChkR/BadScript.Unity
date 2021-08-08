using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BadScript.Tools.CodeGenerator;
using UnityEditor;
using UnityEngine;
namespace BadScript.Unity.Tools.CodeGenerator.Editor
{

    public class CodeGenerator : EditorWindow
    {
        private string m_NameSpace = "BadScript.Wrapper.Internal";
        private string m_ScriptFile = "./Assets/BadScript_Wrappers.cs";
        [SerializeField]
        private string[] m_Types = new[] { nameof(GameObject), nameof(MonoBehaviour) };

        static CodeGenerator()
        {
            WrapperGenerator.Log += Debug.Log;
        }

        [MenuItem("BadScript/Tools/Wrapper Generator")]
        private static void ShowWindow()
        {
            CodeGenerator window =
                (CodeGenerator)GetWindow(typeof(CodeGenerator));

            window.Show();
        }

        private void Generate()
        {
            Type[] types = AppDomain.CurrentDomain.GetAssemblies().
                                     SelectMany(x => x.GetTypes()).
                                     Where(x => m_Types.Contains(x.Name)).
                                     ToArray();
            string p = Path.GetFullPath(m_ScriptFile);
            Debug.Log("Source File: " + p);

            Dictionary<Type, (string, string)> wrappers = new Dictionary<Type, (string, string)>();
            string src = null;
            foreach (Type t in types)
            {
                src = WrapperGenerator.Generate(t, m_NameSpace, wrappers);
            }

            src = "using Object = System.Object;\n" + src;
            File.WriteAllText(p, src);

            AssetDatabase.Refresh();
        }

        private void OnGUI()
        {
            m_NameSpace = EditorGUILayout.TextField("Namespace: ", m_NameSpace);
            m_ScriptFile = EditorGUILayout.TextField("File Path: ", m_ScriptFile);

            ScriptableObject target = this;
            SerializedObject so = new SerializedObject(target);
            SerializedProperty stringsProperty = so.FindProperty("m_Types");

            EditorGUILayout.PropertyField(stringsProperty, true); // True means show children
            so.ApplyModifiedProperties();                         // Remember to apply modified properties



            if (GUILayout.Button("Generate"))
            {
                Generate();
            }

        }
    }

}