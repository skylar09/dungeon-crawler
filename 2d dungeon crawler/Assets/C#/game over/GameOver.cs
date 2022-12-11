using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    //see pauseMenu script
    public GameObject darkScreen;

    // Update is called once per frame
    void Update()
    {
        //if player is dead
        if (PlayerInfo.playerHealth <= 0)
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
            darkScreen.SetActive(true);
        }
    }

    //resets all the neccesary variables when the player dies
    public void Restart()
    {
        Destroy(GameStart.dontDestroyonLoad);
        resetStatics();
        SceneManager.LoadScene(1); 
        statTracker.tries ++;
        if (statTracker.whichLevel > statTracker.highestLevel)
            statTracker.highestLevel = statTracker.whichLevel;
        statTracker.whichLevel = 0;
    }

    //goes to main menu (see pauseMenu script for more comments)
    public void MainMenu()
    {
        //DontDestroyOnLoad(Player);
        
        pauseMenu.whichScene = SceneManager.GetActiveScene().buildIndex;
        Destroy(GameStart.dontDestroyonLoad.gameObject);
        SceneManager.LoadScene(0);
        
        resetStatics();
    }

    private void resetStatics(){
        Time.timeScale = 1;
        PlayerInfo.gold = 0;
        PlayerInfo.playerHealth = 3;
        SpawnEnemy.enemyCount = 0;
    }
}
