using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float baseSize = 1f;
    void Start()
    {
        GenerateColor();
    }

    private void Update()
    {
        transform.localScale = Vector3.one * baseSize;
    }

    public void GenerateColor()
    {
        GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
    }

    public void Reset()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.white;
    }
}
