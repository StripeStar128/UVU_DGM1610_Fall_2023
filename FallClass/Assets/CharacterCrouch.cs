using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCrouch : MonoBehaviour
{
    private bool JumpKeyWasPressed;

    // Update is called once per frame
    void Update()
    {
        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpKeyWasPressed = true;
        }
        // Right and Left movement
        float horizontalInput = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().velocity = new Vector3(horizontalInput * 2.5f, GetComponent<Rigidbody>().velocity.y, 0);
        // Crouch
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            transform.localScale = new Vector3(0.5f, 0.25f, 0.5f);
        }
        else
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
    }
 
    private void FixedUpdate()
    {
        // Jump
        if (JumpKeyWasPressed == true)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            JumpKeyWasPressed = false;
        }
    }
}