using System;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

#endif

[AttributeUsage( AttributeTargets.Field, Inherited = true )]
public class NoteAttribute : PropertyAttribute
{
    public readonly string Text;

    public readonly MessageType Type;

    #region Public

    public NoteAttribute( string text, MessageType type = MessageType.Info )
    {
        Text = text;
        Type = type;
    }

    #endregion
}

#if UNITY_EDITOR
#else
    public enum MessageType
    {
        None,
        Info,
        Warning,
        Error,
    }
#endif
