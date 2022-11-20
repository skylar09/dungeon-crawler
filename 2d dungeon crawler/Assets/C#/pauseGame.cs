using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour
{
    //semi transparent black rectangle for when game is paused
    public GameObject DarkScreen;

    //turns DarkScreen on and time scale to 0 which makes time stop (enemies and player cant move or attack)
    public void pause()
    {
        DarkScreen.SetActive(true);
        Time.timeScale = 0;
    }

    //DarkCreen off and time scale to 1 which is normal game speed
    public void unpause()
    {
        DarkScreen.SetActive(false);
        Time.timeScale = 1;
    }
}
