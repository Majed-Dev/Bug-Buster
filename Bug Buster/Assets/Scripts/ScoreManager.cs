using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private TextMeshPro scoreText;
    public int score = 0;

    private void Start()
    {
        Instance = this;
        scoreText = GetComponent<TextMeshPro>();
    }
    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
