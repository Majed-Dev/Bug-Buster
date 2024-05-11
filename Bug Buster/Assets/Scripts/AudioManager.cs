using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource SFXSource;
    [SerializeField] private AudioSource MusicSource;
    public static AudioManager Instance;

    public AudioClip music;
    public AudioClip[] keyboardSounds;
    public AudioClip bugDeath;
    private void Start()
    {
        Instance = this;
        MusicSource.clip = music;
        MusicSource.Play();
    }
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
    public void PlayKeyboardSFX()
    {
        int random = Random.Range(0,keyboardSounds.Length);
        SFXSource.PlayOneShot(keyboardSounds[random]);
    }
}
