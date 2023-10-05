using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInvitory playerInvitory = other.GetComponent<PlayerInvitory>();

        if (playerInvitory != null)
        {
            playerInvitory.DiamondCollected();
            gameObject.SetActive(false);
        }
    }
}
