using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public List<Word> words;

    public bool hasActiveWord;
    public Word activeWord;

    public BugSpawner bugSpawner;

    public float spawnCooldown = 1.5f;
    private float lastSpawnTime;

    private void Start()
    {
       bugSpawner = gameObject.GetComponent<BugSpawner>();
    }
    private void Update()
    {
        Spawning();
    }
    
    public void AddWord()
    {
        Word word = new Word(WordGenerater.GetRandomWord(),bugSpawner.SpawnBug());
        words.Add(word);
    }
    public void TypeLetter(char letter)
    {
        if(hasActiveWord && activeWord.GetNextLetter()==letter)
        {
                activeWord.TypeLetter();
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
            activeWord = null;
        }
    }

    private void Spawning()
    {
        if (Time.time < spawnCooldown + lastSpawnTime)
            return;
        else
        {
            lastSpawnTime = Time.time;
            AddWord();
        }
    }
}
