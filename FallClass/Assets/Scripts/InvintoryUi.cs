using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InvintoryUi : MonoBehaviour
{
    private TextMeshProUGUI collectibleText;
    
    // Start is called before the first frame update
    void Start()
    {
        collectibleText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCollectibleText(PlayerInvitory playerInvitory)
    {
        collectibleText.text = playerInvitory.NumberOfDiamonds.ToString();
    }

}
