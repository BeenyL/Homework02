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
/*
[CustomEditor(typeof(PlayerStat))]
public class HealthCalculator : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            PlayerStat player = (PlayerStat)target;

            GUILayout.BeginHorizontal();

            if (GUILayout.Button("Take Damage"))
            {
                player.TakeDamage(player.DamageIntakeBase, player.Defense);
            }

            if (GUILayout.Button("Reset Health"))
            {
                player.CurrentHealth = player.Health;
            }

            GUILayout.EndHorizontal();

            //GUILayout.Label("Player HealthBar");

            player.CurrentHealth = EditorGUILayout.Slider("Player HealthBar", player.CurrentHealth, 0, player.Health);
        }
    }

*/
/*
[CustomEditor(typeof(PlayerStats))]
public class HealthCalculator : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        PlayerStat player = (PlayerStat)target;



        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Take Damage"))
        {
            player.TakeDamage(player.DamageIntakeBase, player.Defense);
        }

        if (GUILayout.Button("Reset Health"))
        {
            player.CurrentHealth = player.Health;
        }

        GUILayout.EndHorizontal();

        //GUILayout.Label("Player HealthBar");

        player.CurrentHealth = EditorGUILayout.Slider("Player HealthBar", player.CurrentHealth, 0, player.Health);
    }
}


 public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);
        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);


        var indent_calc = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        var healthRect = new Rect(position.x, position.y, 30, position.height);
        var curHealthRect = new Rect(position.x, position.y, 30, position.height);
        var DmgIntakeBase = new Rect(position.x, position.y, 30, position.height);

        EditorGUI.PropertyField(healthRect, property.FindPropertyRelative("Health"));
        EditorGUI.PropertyField(curHealthRect, property.FindPropertyRelative("CurrentHealth"));
        EditorGUI.PropertyField(DmgIntakeBase, property.FindPropertyRelative("DamageIntakeBase"));

        if (GUILayout.Button("Reset Health"))
        {

        }

        if (GUILayout.Button("Take Damage"))
        {

        }

        EditorGUI.indentLevel = indent_calc;
        EditorGUILayout.Space();
        EditorGUI.EndProperty();
    }
*/

