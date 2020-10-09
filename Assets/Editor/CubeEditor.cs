using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Cube))]
public class CubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Cube cube = (Cube)target;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Generate Color"))
        {
            cube.GenerateColor();
        }

        if (GUILayout.Button("Reset"))
        {
            cube.Reset();
        }

        GUILayout.EndHorizontal();

        GUILayout.Label("Changes the Size of the Cube");
        cube.baseSize = EditorGUILayout.Slider("Size", cube.baseSize, .1f, 2f);
        cube.transform.localScale = Vector3.one * cube.baseSize;
    }
}
