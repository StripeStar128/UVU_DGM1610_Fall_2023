using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;
    public AudioClip buttonSound;
    private AudioSource menuAudio;

    private void Start()
    {
        menuAudio = GetComponent<AudioSource>();
    }

    public void StartGame()
    {
        menuAudio.PlayOneShot(buttonSound, 1.0f);
        SceneManager.LoadScene(sceneToLoad); // Scene to Load
        Debug.Log("New Scene Loaded!");
    }

    public void QuitGame()
    {
        menuAudio.PlayOneShot(buttonSound, 1.0f);
        Application.Quit();
        Debug.Log("Quit Game!");
    }
}
