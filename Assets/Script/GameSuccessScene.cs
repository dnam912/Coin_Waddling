using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSuccessScene : MonoBehaviour
{
    
    public void MainMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
