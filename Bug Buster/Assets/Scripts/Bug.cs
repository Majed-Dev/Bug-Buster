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
    Health health;

    private void Start()
    {
        text = gameObject.GetComponent<TextMeshPro>();
        wm = GameObject.FindFirstObjectByType<WordManager>();
        health = GameObject.Find("Health").GetComponent<Health>();
    }
    void Update()
    {
        movement();
    }
    private void movement()
    {
        transform.Translate(Vector2.down * bugSpeed * Time.deltaTime);

        //when the bug moves down the camera
        if (transform.position.y <= Camera.main.transform.position.y - 7)
        {
            //hurt the player
            health.health--;
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
        AudioManager.Instance.PlaySFX(AudioManager.Instance.bugDeath);
        Destroy(gameObject);
    }
}
