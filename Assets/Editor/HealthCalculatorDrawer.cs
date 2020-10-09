using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Inventory))]
public class HealthCalculatorDrawer : Editor
{
   public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Inventory player = (Inventory)target;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Take Damage"))
        {
            player.TakeDamage();
        }

        if (GUILayout.Button("Reset Health"))
        {
            player.ResetHealth();
        }

        GUILayout.EndHorizontal();

        //GUILayout.Label("Player HealthBar");

        player.stats.CurrentHealth = EditorGUILayout.Slider("Player Health", player.stats.CurrentHealth, 0, player.stats.Health);
    }
}
