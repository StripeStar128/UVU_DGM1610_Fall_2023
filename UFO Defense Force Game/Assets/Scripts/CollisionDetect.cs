using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager; // Store reference to score manager

    public int scoreToGive;
    public AudioClip explosion;
    private AudioSource enemyAudio;
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find ScoreManager gameObject and reference ScoreManager script component
        enemyAudio = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other) // Once the Trigger has been entered record collision in the argument variable "other"
    {
        scoreManager.IncreaseScore(scoreToGive); // Increase the Score
        enemyAudio.PlayOneShot(explosion, 1.0f);
        Destroy(gameObject); // Destroy this gameObject
        Destroy(other.gameObject); // Destroys the other gameObject it hits
        
    }
}
