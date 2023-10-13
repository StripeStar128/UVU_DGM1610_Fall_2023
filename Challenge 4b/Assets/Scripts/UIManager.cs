using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Text _canvasText;

    private void Start()
    {
        if (GetComponentInChildren<Text>() != null)
        {
            _canvasText = GetComponentInChildren<Text>();
            UpdateCollectibleScoreDisplay(0); // Calling the method here so that initially, we can see score 0.
        }
    }

    public void UpdateCollectibleScoreDisplay(int collectible)
    {
        _canvasText.text = "Collectibles " + collectible.ToString();
    }
}
