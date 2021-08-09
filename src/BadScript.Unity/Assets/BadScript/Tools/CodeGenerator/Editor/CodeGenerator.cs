using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BadScript.Tools.CodeGenerator;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace BadScript.Unity.Tools.CodeGenerator.Editor
{

    public class CodeGenerator : EditorWindow
    {
        private bool m_GenerateDB = false;
        private string m_DBName = "BadScriptCTorDB";
        private bool m_GenerateStaticDB = false;
        private string m_StaticDBName = "BadScriptStaticDB";
        private string m_NameSpace = "BadScript.Wrapper.Internal";
        private string m_ScriptFile = "./Assets/BadScript_Wrappers.cs";
        [SerializeField]
        private string[] m_Types = new[] { nameof(GameObject), nameof(MonoBehaviour) };
        [SerializeField]
        private string[] m_Defines = new string[0];

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
                                     SelectMany( x => x.GetTypes() ).ToArray();
            List < Type > ts = new List < Type >();

            foreach ( string type in m_Types )
            {
                Type t = types.FirstOrDefault( x => x.FullName == type);
                Type t1 = types.FirstOrDefault( x => x.Name == type);
                if ( t != null )
                    ts.Add( t );
                else if ( t1 != null )
                    ts.Add( t1 );
                else
                {
                    Debug.LogError( "Ambiguous Type. Use Full Name: " + type );
                }
            }

            string p = Path.GetFullPath(m_ScriptFile);
            Debug.Log("Source File: " + p);

            Dictionary<Type, WrapperTypeInfo> wrappers = new Dictionary<Type, WrapperTypeInfo>();
            string src = null;
            foreach (Type t in ts)
            {
                src = WrapperGenerator.Generate(t, m_NameSpace, wrappers);
            }

            src = "using Object = UnityEngine.Object;\n" + src;
            if(m_GenerateDB)
                src+="\n"+WrapperGenerator.GenerateConstructorDataBase( m_DBName, wrappers );

            if ( m_GenerateStaticDB )
                src += "\n" + WrapperGenerator.GenerateStaticDataBase( m_StaticDBName, wrappers );

            foreach (string define in m_Defines)
            {
                src = $"#define {define}\n" + src;
            }

            File.WriteAllText(p, src);

            AssetDatabase.Refresh();
        }

        private void OnGUI()
        {
            m_NameSpace = EditorGUILayout.TextField("Namespace: ", m_NameSpace);
            m_ScriptFile = EditorGUILayout.TextField("File Path: ", m_ScriptFile);
            m_GenerateDB = EditorGUILayout.Toggle("Generate Constructor DB", m_GenerateDB);

            if (m_GenerateDB)
                m_DBName = EditorGUILayout.TextField("Database Name", m_DBName);

            m_GenerateStaticDB = EditorGUILayout.Toggle("Generate Static DB", m_GenerateStaticDB);

            if (m_GenerateStaticDB)
                m_StaticDBName = EditorGUILayout.TextField("Static Database Name", m_StaticDBName);
            
            SerializedObject so = new SerializedObject(this);



            SerializedProperty targetTypes = so.FindProperty("m_Types");
            EditorGUILayout.PropertyField(targetTypes, true); // True means show children
            so.ApplyModifiedProperties();                         // Remember to apply modified properties


            SerializedProperty defines = so.FindProperty("m_Defines");
            EditorGUILayout.PropertyField(defines, true); // True means show children
            so.ApplyModifiedProperties();                         // Remember to apply modified properties



            if (GUILayout.Button("Generate"))
            {
                Generate();
            }

        }
    }

}