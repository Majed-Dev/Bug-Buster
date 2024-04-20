using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.AI;

[System.Serializable]
public class Word
{

    public string word;

    private int typeIndex;

    private Bug bug;
    private bool bugRunning = false;

    public Word(string word, Bug bug)
    {
        this.word = word;
        typeIndex = 0;

        this.bug = bug;
        bug.SetWord(word);
    }
    public char GetNextLetter()
    {
        return word[typeIndex];
    }
    public void TypeLetter()
    {
        typeIndex++;
        bug.RemoveLetter();
        if (!bugRunning)
        {
            bug.bugSpeed*= 3f;
            bugRunning = true;
        }

        
    }
    public bool WordTyped()
    {
        if(typeIndex >=word.Length)
        {
            bug.BustBug();
        }
        return (typeIndex >= word.Length);
    }
}
