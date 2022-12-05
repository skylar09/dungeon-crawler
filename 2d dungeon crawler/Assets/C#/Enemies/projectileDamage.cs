using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileDamage : MonoBehaviour
{
    public int damage;

    public void damagePlayer()
    {
        //makes sure the player loses at least 1 health
        if (damage - PlayerInfo.playerDefense <= 0 || PlayerInfo.playerDefense - damage >= 3)
        {
            PlayerInfo.playerHealth -= 1;
        }
        else
        {
            //player loses health equal to the difference in player defense and enemy dmg
            PlayerInfo.playerHealth -= damage - PlayerInfo.playerDefense;
        }
    }
}
