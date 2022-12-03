using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stats : MonoBehaviour
{
   
   public TextMeshProUGUI health, armor, damage, critChance, moveSpeed, attackSpeed;

   //updates the text to the most recent player info 
   public void Awake()
   {
      health.text = PlayerInfo.playerHealth.ToString();
      armor.text = PlayerInfo.playerDefense.ToString();
      damage.text = PlayerInfo.playerDamage.ToString();
      critChance.text = PlayerInfo.critChance.ToString() + "%";
      moveSpeed.text = "+" + PlayerInfo.movementSpeed.ToString() + "%";
      attackSpeed.text = "+" + PlayerInfo.swordSwingSpeed.ToString() + "%";
   }
}
