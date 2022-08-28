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
        //GameObject.Find("Player Health").GetComponent<TextMeshProUGUI>().SetText("health " + health.ToString() + "   Gold " + PlayerInfo.gold.ToString());
    }

    public void heartOn()
    {
        for (int i = 0; i < PlayerInfo.playerHealth; i ++)
        {
            hearts[i].SetActive(true);
        }
    }

    public void heartOff()
    {
        for (int i = 0; i < hearts.Count; i ++)
        {
            hearts[i].SetActive(false);
        }
        heartOn();
    }
}
