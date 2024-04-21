using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health = 3;
    [SerializeField] List<Sprite> sprites;
    SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene("Gameplay");
        }
        SpriteSwap();   
    }
    private void SpriteSwap()
    {
        switch (health)
        {
            case 3: sr.sprite = sprites[0]; break;
            case 2: sr.sprite = sprites[1]; break;
            case 1: sr.sprite = sprites[2]; break;
            case 0: sr.sprite = sprites[3]; break;
        }
    }
}
