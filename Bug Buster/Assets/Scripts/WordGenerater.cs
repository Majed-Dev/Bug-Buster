using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class WordGenerater : MonoBehaviour
{
    private static string[] PythonWordList = File.ReadAllLines("Assets/Assets/Keywords/Python Keywrods.txt");
    private static string[] JavaWordList = File.ReadAllLines("Assets/Assets/Keywords/Java keywrods.txt");
    private static string[] CPPWordList = File.ReadAllLines("Assets/Assets/Keywords/c++ keywords.txt");
    private static string[] JavascriptWordList = File.ReadAllLines("Assets/Assets/Keywords/Javascript Keywords.txt");

    public static int languageIndex = 1;
    private static string[] wordList;


    public static string GetRandomWord()
    {
        switch (languageIndex)
        {
            case 0: wordList = PythonWordList; break;
            case 1: wordList = JavaWordList; break;
            case 2: wordList = CPPWordList; break;
            case 3: wordList = JavascriptWordList; break;
            default: wordList = JavaWordList; break;
            
        }
       int randomIndex = Random.Range(0,wordList.Length);
        return wordList[randomIndex];
    }
}
