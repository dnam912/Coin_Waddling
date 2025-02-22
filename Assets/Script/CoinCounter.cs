using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    static public int coinCounter = 0; // Counting collected coins

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TMP_Text coinTextUI = GetComponent<TMP_Text>();
        coinTextUI.text = "Coin: " + coinCounter.ToString(); // Convert int to string
        
        if (coinCounter >= 20)
        {
            TMP_Text successTextUI = GetComponent<TMP_Text>();
            successTextUI.text = "SUCCESS";
        }
    }

}
