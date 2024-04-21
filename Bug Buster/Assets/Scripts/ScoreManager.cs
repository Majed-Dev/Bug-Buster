using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private TextMeshPro scoreText;
    public int score = 0;

    private void Start()
    {
        scoreText = GetComponent<TextMeshPro>();
    }
    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
