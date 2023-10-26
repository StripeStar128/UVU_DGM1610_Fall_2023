using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    #region Properties

    // The player's health at the start
    [SerializeField] private int healthInitial = 3;
    
    // The player's health right now
    private int healthCurrent;

    #endregion

    #region Initialisation methods

    // Initialises this component
    // (NB: Is called automatically before the first frame update)
    void Start()
    {
        // Initialise the player's current health
        ResetHealth();
    }
    
    // Sets the player's current health back to its initial value
    public void ResetHealth()
    {
        // Reset the player's current health
        healthCurrent = addHealth;
    }

    #endregion

    #region Gameplay methods

    // Reduces the player's current health
    // (NB: Call this if hit by enemy, activated trap, etc)
    public void TakeDamage(int damageAmount)
    {
        // Deduct the provided damage amount from the player's current health
        healthCurrent -= damageAmount;
        
        // If the player has no health left now
        if (healthCurrent <= 0)
        {
            // Kill the player
            Destroy(gameObject);
            
            // NB: Here, you may want to restart the game
            // (e.g. by informing your game manager that the player has died,
            // of by raising an event using your event system)
        }
    }
    
    // Increase the player's current health
    // (NB: Call this if picked up potion, herb, etc)
    public void Heal(int AddHealth)
    {
        // Add the provided heal amount to the player's current health
        healthCurrent += addHealth();

        // If the player has too much health now
        if (healthCurrent > healthInitial)
        {
            // Reset the player's current health
            ResetHealth();
        }
    }

    private int addHealth()
    {
        // Retrieve the player's health component (e.g. HealthController script)
        HealthPowerUp healthController = player.GetComponent<HealthPowerUp>();
        
        // Check if the player has a health component
        if (typeof(HealthPowerUp) != null)
        {
            // Add the health value to the player's current health
            HealthPowerUp.AddHealth(healthValue.Value);
        }
    }

    #endregion
}
