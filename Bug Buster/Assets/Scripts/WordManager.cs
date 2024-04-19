using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public List<Word> words;

    private bool hasActiveWord;
    private Word activeWord;

    public BugSpawner bugSpawner;

    private void Start()
    {
       bugSpawner = gameObject.GetComponent<BugSpawner>();
    }

    public void AddWord()
    {
        Word word = new Word(WordGenerater.GetRandomWord(),bugSpawner.SpawnBug());
        words.Add(word);
    }
    public void TypeLetter(char letter)
    {
        if(hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach(Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }
        if(hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
           
        }
    }
}
