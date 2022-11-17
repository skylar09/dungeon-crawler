using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stats : MonoBehaviour
{
     public TextMeshProUGUI health;
     public TextMeshProUGUI armor;
     public TextMeshProUGUI damage;
     public TextMeshProUGUI critChance;
     public TextMeshProUGUI moveSpeed;
     public TextMeshProUGUI attackSpeed;

     public void changeText()
     {
        health.text = PlayerInfo.playerHealth.ToString();
        armor.text = PlayerInfo.playerDefense.ToString();
        damage.text = PlayerInfo.playerDamage.ToString();
        critChance.text = PlayerInfo.critChance.ToString() + "%";
        moveSpeed.text = "+" + PlayerInfo.movementSpeed.ToString() + "%";
        attackSpeed.text = "+" + PlayerInfo.swordSwingSpeed.ToString() + "%";
     }
}
