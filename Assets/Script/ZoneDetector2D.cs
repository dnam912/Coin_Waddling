using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ZoneDetector2D : MonoBehaviour
{
    public GameManagement gameManager; // Connect to the GameManagement Script
    private bool isDead; // Define whether the player is dead or not


    // In the zone
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D is activated");


        if (other.CompareTag("Player") && !isDead)
        {
            Debug.Log("A player is in the 2D zone.");

            isDead = true; // Player is dead because they're fallen in water
            gameManager.gameOver(); // Game Over

            CoinCounter.coinCounter = 0; // Reset the number of coins once the player died, 
        }

    }

    // Out of zone
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("OnTriggerExit2D is activated");

        if (other.CompareTag("Player"))
        {
            Debug.Log("A player is out of zone.");
        }
    }
}
