using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); // Destroy this gameobject
        //Destroy(other.gameObject); // Destroys the other gameobject it hits
    }
}
