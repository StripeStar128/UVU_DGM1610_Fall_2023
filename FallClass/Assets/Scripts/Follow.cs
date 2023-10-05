using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform objectToFollow;
    public float followSpeed = 1;

    void Update()
    {
        // calculate the distance between this object an the target object
        // and move a small portion of that distance each frame:
        
        var delta = objectToFollow.position - transform.position;
        transform.position += delta * Time.deltaTime * followSpeed;
    }
}
