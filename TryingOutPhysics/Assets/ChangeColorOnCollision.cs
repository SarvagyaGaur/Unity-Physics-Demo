using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour
{
    private Renderer renderer;
    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }
    private void OnCollisionEnter(Collision other)
    {
        Color randomColor = GetRandomColor();
        renderer.material.color = randomColor;
    }
    private Color GetRandomColor()
    {
        return new Color(r: UnityEngine.Random.Range(0f, 1f), g: UnityEngine.Random.Range(0f, 1f), b: UnityEngine.Random.Range(0f, 1f));
    }
}
