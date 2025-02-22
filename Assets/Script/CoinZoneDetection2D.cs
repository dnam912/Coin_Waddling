using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinZoneDetection2D : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Detection of a coin zone & destruction of the coin
        // while (CoinCounter.coinCounter >= 20) { }

        if (other.CompareTag("Player"))
        {
                Debug.Log("CoinZone is triggered.");
                CoinCounter.coinCounter++; // Increment of collected coins

                Destroy(gameObject); // The coin is destroyed after the player collected it


       
            if (CoinCounter.coinCounter >= 2)
            {
                Debug.Log("Success");
                SceneManager.LoadScene("Success");
                CoinCounter.coinCounter = 0;
            }
        }
    }
}
