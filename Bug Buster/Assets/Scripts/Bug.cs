using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class Bug : MonoBehaviour
{
    public float bugSpeed = 1f;
    public TextMeshPro text;
    WordManager wm;

    private void Start()
    {
        text = gameObject.GetComponent<TextMeshPro>();
        wm = GameObject.FindObjectOfType<WordManager>();
    }
    void Update()
    {
        movement();
    }
    private void movement()
    {
        transform.Translate(Vector2.down * bugSpeed * Time.deltaTime);
        if (transform.position.y <= Camera.main.transform.position.y - 7)
        {
            //hurt the player
            wm.hasActiveWord = false;
            wm.words.RemoveAt(0);
            BustBug();
        }
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
