using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance = null;
    private AudioSource _audioSource;
    public static float Music;
    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            InitializeManager();
            return;
        }
            Destroy(gameObject);
    }
    private void InitializeManager()
    {
        Music = PlayerPrefs.GetFloat("music");
        _audioSource.volume = Music;
    }
    public void SaveSettings(float vol)
    {
        _audioSource.volume = vol;
        PlayerPrefs.SetFloat("music", Music);
        PlayerPrefs.Save();
    }
}
