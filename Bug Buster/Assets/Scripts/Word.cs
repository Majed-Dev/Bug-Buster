using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;

    private int typeIndex;

    public Word(string word)
    {
        this.word = word;
        typeIndex = 0;
    }
    public char GetNextLetter()
    {
        return word[typeIndex];
    }
    public void TypeLetter()
    {
        typeIndex++;
        
    }
    public bool WordTyped()
    {


        if(typeIndex >=word.Length)
        {
            //remove the word on screen
        }
        return (typeIndex >= word.Length);
    }
}
