using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerAttributes player;
    public Text currentSceneNameText;
    protected string currentSceneNameString;
    
    private float playerLifepoints;

    void Update()
    {
        currentSceneNameString = "Current scene: "+SceneManager.GetActiveScene().name;
        currentSceneNameText.text = currentSceneNameString;
        if(player.lifePoints<=0)
        {
            GameOverDead();
        }
    }
    public void GameOverDead()
    {
      SceneManager.LoadScene("GameOverScreen");
    }
}
