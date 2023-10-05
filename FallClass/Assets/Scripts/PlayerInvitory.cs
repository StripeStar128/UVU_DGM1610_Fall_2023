using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInvitory : MonoBehaviour
{
    public int NumberOfDiamonds { get; private set;  }

    public UnityEvent<PlayerInvitory> OnDiamondCollected;
    
    public void DiamondCollected()
    {
        NumberOfDiamonds++;
        OnDiamondCollected.Invoke(this);
    }
}
