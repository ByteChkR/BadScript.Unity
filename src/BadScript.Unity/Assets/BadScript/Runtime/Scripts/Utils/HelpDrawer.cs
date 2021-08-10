using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer( typeof( NoteAttribute ) )]
public class HelpDrawer : PropertyDrawer
{
    private const int PaddingHeight = 8;

    private const int MarginHeight = 2;

    private float m_BaseHeight = 0;

    private float m_AddedHeight = 0;

    private NoteAttribute NoteAttribute => ( NoteAttribute ) attribute;

    private RangeAttribute RangeAttribute
    {
        get
        {
            object[] attributes = fieldInfo.GetCustomAttributes( typeof( RangeAttribute ), true );

            return attributes.Length > 0 ? ( RangeAttribute ) attributes[0] : null;
        }
    }

    private MultilineAttribute MultilineAttribute
    {
        get
        {
            object[] attributes = fieldInfo.GetCustomAttributes( typeof( MultilineAttribute ), true );

            return attributes.Length > 0 ? ( MultilineAttribute ) attributes[0] : null;
        }
    }

    #region Unity Event Functions

    public override void OnGUI( Rect position, SerializedProperty prop, GUIContent label )
    {
        MultilineAttribute multiline = MultilineAttribute;

        EditorGUI.BeginProperty( position, label, prop );

        Rect helpPos = position;

        helpPos.height -= m_BaseHeight + MarginHeight;

        if ( multiline != null )
        {
            helpPos.height -= m_AddedHeight;
        }

        EditorGUI.HelpBox( helpPos, NoteAttribute.Text, NoteAttribute.Type );

        position.y += helpPos.height + MarginHeight;
        position.height = m_BaseHeight;

        RangeAttribute range = RangeAttribute;

        if ( range != null )
        {
            if ( prop.propertyType == SerializedPropertyType.Float )
            {
                EditorGUI.Slider( position, prop, range.min, range.max, label );
            }
            else if ( prop.propertyType == SerializedPropertyType.Integer )
            {
                EditorGUI.IntSlider( position, prop, ( int ) range.min, ( int ) range.max, label );
            }
            else
            {
                EditorGUI.PropertyField( position, prop, label );
            }
        }
        else if ( multiline != null )
        {
            if ( prop.propertyType == SerializedPropertyType.String )
            {
                GUIStyle style = GUI.skin.label;
                float size = style.CalcHeight( label, EditorGUIUtility.currentViewWidth );

                EditorGUI.LabelField( position, label );

                position.y += size;
                position.height += m_AddedHeight - size;

                prop.stringValue = EditorGUI.TextArea( position, prop.stringValue );
            }
            else
            {
                EditorGUI.PropertyField( position, prop, label );
            }
        }
        else
        {
            EditorGUI.PropertyField( position, prop, label );
        }

        EditorGUI.EndProperty();
    }

    #endregion

    #region Public

    public override float GetPropertyHeight( SerializedProperty prop, GUIContent label )
    {
        m_BaseHeight = base.GetPropertyHeight( prop, label );

        float minHeight = PaddingHeight * 5;

        GUIContent content = new GUIContent( NoteAttribute.Text );
        GUIStyle style = GUI.skin.GetStyle( "helpbox" );

        float height = style.CalcHeight( content, EditorGUIUtility.currentViewWidth );

        height += MarginHeight * 2;

        if ( MultilineAttribute != null && prop.propertyType == SerializedPropertyType.String )
        {
            m_AddedHeight = 48f;
        }

        return height > minHeight ? height + m_BaseHeight + m_AddedHeight : minHeight + m_BaseHeight + m_AddedHeight;
    }

    #endregion
}
