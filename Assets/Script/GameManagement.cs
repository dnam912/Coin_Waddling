using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Reference: 
// 
public class GameManagement : MonoBehaviour
{
    public GameObject gameOverUI;

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }
}
