using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Bug : MonoBehaviour
{
    [SerializeField] private float bugSpeed = 1f;

    void Start()
    {
        
    }
    void Update()
    {
        movement();
    }
    private void movement()
    {
        transform.Translate(Vector2.down * bugSpeed * Time.deltaTime);
    }
}
