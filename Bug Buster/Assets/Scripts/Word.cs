using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.AI;

[System.Serializable]
public class Word
{

    public string word;

    private int typeIndex;

    public Bug bug;
    private bool bugRunning = false;

    public ScoreManager scoreManager;


    public Word(string word, Bug bug)
    {
        this.word = word;
        typeIndex = 0;

        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
        this.bug = bug;
        bug.SetWord(word);

        //making bigger words slower and bigger
        if(this.word.Length >= 7)
        {
            bug.bugSpeed /= 3;
            //make the sprite bigger
            bug.transform.localScale *= 2;
        }
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
            // increase score
            scoreManager.score++;
            //set highest score
            if (PlayerPrefs.GetInt("Hscore") < scoreManager.score)
            {
                PlayerPrefs.SetInt("Hscore",scoreManager.score);
            }
            bug.BustBug();
        }
        return (typeIndex >= word.Length);
    }
}
