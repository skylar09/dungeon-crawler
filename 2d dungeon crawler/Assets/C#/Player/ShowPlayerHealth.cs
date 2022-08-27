using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowPlayerHealth : MonoBehaviour
{
    int health;

    // void Start()
    // {
    //     Debug.Log(Screen.width);
    //     Debug.Log(Screen.height);
    // }


    // Update is called once per frame
    void Update()
    {
        health = PlayerInfo.playerHealth;
        GameObject.Find("Player Health").GetComponent<TextMeshProUGUI>().SetText("health " + health.ToString() + "   Gold " + PlayerInfo.gold.ToString());
    }
}
