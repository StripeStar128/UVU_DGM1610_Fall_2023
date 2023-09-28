using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public string myName = "Julia";
    
    //use this for initialization
    private void Start()
    {
        Debug.Log("I am alive and my name is " + myName);
    }
}
