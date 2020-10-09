using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Inventory))]
public class HealthCalculatorDrawer : Editor
{
    public float sumDef;

    public override void OnInspectorGUI()
    {
        this.serializedObject.Update();
        base.OnInspectorGUI();

        Inventory player = (Inventory)target;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Take Damage"))
        {
            player.TakeDamage(sumDef);
        }

        if (GUILayout.Button("Reset Health"))
        {
            player.ResetHealth();
        }

        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Update Defense"))
        {
            sumDef = 0;
            int SumLength = player.CurrentEquipment.Length;
            for (int i = 0; i < SumLength; i++)
            {
                sumDef += player.CurrentEquipment[i].defense;
            }
        }
        GUILayout.Label("Total Defense: " + sumDef.ToString());
        GUILayout.EndHorizontal();

        player.stats.CurrentHealth = EditorGUILayout.Slider("Player Health", player.stats.CurrentHealth, 0, player.stats.Health);
    }
}
