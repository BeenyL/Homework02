using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Equipment))]
public class EquipmentDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);
        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        var indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;
        var nameRect = new Rect(position.x, position.y + 5, 75, position.height);
        var defenseRect = new Rect(position.x + 80, position.y + 5, 30, position.height);
        var typeRect = new Rect(position.x + 115, position.y + 5, 60, position.height);
        var rarityRect = new Rect(position.x + 175, position.y + 5, 75, position.height);

        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("name"), GUIContent.none);
        EditorGUI.PropertyField(defenseRect, property.FindPropertyRelative("defense"), GUIContent.none);
        EditorGUI.PropertyField(typeRect, property.FindPropertyRelative("Type"), GUIContent.none);
        EditorGUI.PropertyField(rarityRect, property.FindPropertyRelative("RarityType"), GUIContent.none);

        EditorGUI.indentLevel = indent;
        EditorGUI.EndProperty();
    }
}
