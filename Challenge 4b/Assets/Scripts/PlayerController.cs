using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;

    private int _playerCollectibles;
    
    // Update is called once per frame
    void Update()
    {
        // Set horizontalInput to receive values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        
        // Moves Player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // Keep player within bounds
        //Left side wall
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Right side wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    // Delete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

    public void updatePlayerCollectibles()
    {
        _playerCollectibles++;
        UIManager.print(_playerCollectibles);
    }
}
