using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private Text _canvasText;

    private void Start()
    {
        if (GetComponentInChildren<Text>() != null)
        {
            _canvasText = GetComponentInChildren<Text>();
            updateCollectibleScoreDisplay(0); // Calling the method here so that initially, we can see score 0.
        }
    }

    public void updateCollectibleScoreDisplay(int collectible)
    {
        _canvasText.text = "Collectibles " + collectible.ToString();
    }
}
