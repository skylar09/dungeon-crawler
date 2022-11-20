using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    //pause meno object
    public GameObject PauseMenu;
    //player object
    public GameObject Player;
    //options menu object
    public GameObject OptionsMenu;

    //what scene is currently open
    public static int whichScene = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            //if pause menu is open then close it and unpause game otherwise open it and pause game
            if (PauseMenu.activeInHierarchy == true)
            {
                PauseMenu.SetActive(false);
                Player.GetComponent<pauseGame>().unpause();
            }

            else
            {
                PauseMenu.SetActive(true);
                Player.GetComponent<pauseGame>().pause();
            }
        }
    }

    //turns off pause menu and unpauses game
    public void UnPause()
    {
        PauseMenu.SetActive(false);
        Player.GetComponent<pauseGame>().unpause();
    }

    //turns off pause menu and turns on options menu
    public void Options()
    {
        PauseMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    //goes to main menu scene
    public void MainMenu()
    {
        //DontDestroyOnLoad(Player);
        //sets whichScene to current scene number
        whichScene = SceneManager.GetActiveScene().buildIndex;
        //opens main menu scene
        SceneManager.LoadScene(0);
        //sets time scale to 1 which sets game speed to normal speed
        Time.timeScale = 1;
        //puts the player in the first room when level is loaded again
        PlayerCollision.currentRoom = 0;
    }

    //tuns option menu off and pause menu on
    public void CloseOptions()
    {
        OptionsMenu.SetActive(false);
        PauseMenu.SetActive(true);
    }
}
