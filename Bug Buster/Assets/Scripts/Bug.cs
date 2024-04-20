using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;

public class Bug : MonoBehaviour
{
    public float bugSpeed = 1f;
    public TextMeshPro text;

    private void Start()
    {
        text = gameObject.GetComponent<TextMeshPro>();
    }
    void Update()
    {
        movement();
    }
    private void movement()
    {
        transform.Translate(Vector2.down * bugSpeed * Time.deltaTime);
    }
    public void SetWord(string word)
    {
        text.SetText(word);
    }
    public void RemoveLetter()
    {
        text.SetText(text.text.Remove(0, 1));
        text.color = Color.red;
    }
    public void BustBug()
    {
        Destroy(gameObject);
    }
}
