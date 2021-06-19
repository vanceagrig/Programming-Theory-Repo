using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public string lastSceneBeforeGameOver;
    private void Start()
    {
        lastSceneBeforeGameOver = SceneManager.GetActiveScene().name;
    }
    private void Update()
    {
        
    }

    public void NewGameButton()
    {
        SceneManager.LoadScene("FirstScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void RestartLastScene()
    {
      
        SceneManager.LoadScene(2);
    }
}
