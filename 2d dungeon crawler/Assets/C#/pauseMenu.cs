using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject Player;
    public GameObject OptionsMenu;

    public static int whichScene = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
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

    public void UnPause()
    {
        PauseMenu.SetActive(false);
        Player.GetComponent<pauseGame>().unpause();
    }

    public void Options()
    {
        PauseMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void MainMenu()
    {
        DontDestroyOnLoad(Player);
        whichScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(0);
    }

    public void CloseOptions()
    {
        OptionsMenu.SetActive(false);
        PauseMenu.SetActive(true);
    }
}
