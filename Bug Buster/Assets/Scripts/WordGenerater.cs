using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerater : MonoBehaviour
{
    private static string[] wordList = {"for","while","if","public","static","private","int","float","bool","double","short","byte","extends","string","char"};
    public static string GetRandomWord()
    {
       int randomIndex = Random.Range(0,wordList.Length);
        return wordList[randomIndex];
    }
}
