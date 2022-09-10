using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour
{
    public GameObject DarkScreen;

    public void pause()
    {
        DarkScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void unpause()
    {
        DarkScreen.SetActive(false);
        Time.timeScale = 1;
    }
}
