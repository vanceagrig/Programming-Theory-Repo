using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

   public void NewGameButton()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}