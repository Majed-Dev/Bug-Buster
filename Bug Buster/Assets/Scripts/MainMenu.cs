using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI hscore;
    private void Start()
    {
        hscore.text = PlayerPrefs.GetInt("Hscore").ToString();

    }
    public void Play()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
