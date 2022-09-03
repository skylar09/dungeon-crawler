using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options_Credits : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject creditScreen;
    // public GameObject start;

    public void openOptions()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void closeOptions()
    {
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void startCredits()
    {
        mainMenu.SetActive(false);
        creditScreen.SetActive(true);
    }

    public void endCredits()
    {
        mainMenu.SetActive(true);
        creditScreen.SetActive(false);
    }
}
