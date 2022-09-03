using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowPlayerHealth : MonoBehaviour
{
    int health;

    public List<GameObject> hearts = new List<GameObject>();

    void Start()
    {
        health = PlayerInfo.playerHealth;
    }


    // Update is called once per frame
    void Update()
    {
        if (health > PlayerInfo.playerHealth)
        {
            heartOff();
            health = PlayerInfo.playerHealth;
        }

        else if (health < PlayerInfo.playerHealth)
        {
            heartOn();
            health = PlayerInfo.playerHealth;
        }
    }

    //turns hearts on if you gained health
    public void heartOn()
    {
        for (int i = 0; i < PlayerInfo.playerHealth; i ++)
        {
            hearts[i].SetActive(true);
        }
    }

    //turns hearts off in you lost health
    public void heartOff()
    {
        for (int i = 0; i < hearts.Count; i ++)
        {
            hearts[i].SetActive(false);
        }
        heartOn();
    }
}
