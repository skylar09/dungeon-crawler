using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
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
}
