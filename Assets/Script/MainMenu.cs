using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Code Reference:
// https://youtu.be/zc8ac_qUXQY?si=sW0iocjuc0o7Q3xl


public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CreditButton()
    {
        SceneManager.LoadScene("CreditMenu");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitButton()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
