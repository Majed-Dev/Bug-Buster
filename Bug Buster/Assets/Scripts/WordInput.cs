using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    WordManager wordManager;
    void Start()
    {
        wordManager = GameObject.Find("Word Manager").GetComponent<WordManager>();
    }
    void Update()
    {
        foreach(char letter in Input.inputString)
        {
            wordManager.TypeLetter(letter);
        }
    }
}
