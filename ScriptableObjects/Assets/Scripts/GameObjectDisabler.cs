using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectDisabler : MonoBehaviour
{
    private void OnEnable()
    {
        var triggerEventBehavior = FindObjectOfType<TriggerEventBehavior>();
        if (triggerEventBehavior != null)
        {
         //   triggerEventBehavior.triggerExitEvent.AddListener(DisableGameObject);
        }
    }

    private void OnDisable()
    {
        var triggerEventBehavior = FindObjectOfType<TriggerEventBehavior>();
        if (triggerEventBehavior != null)
        {
           // triggerEventBehavior.triggerExitEvent.RemoveListener(DisableGameObject);
        }
    }

    private void DisableGameObject()
    {
        gameObject.SetActive(false);
    }
}

