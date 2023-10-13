using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private int _score;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerController playerController = other.GetComponent<PlayerController>();

        if (playerController != null)
        {
            playerController.updatePlayerCollectibles();
            Destroy(this.gameObject);
        }
    }
}
