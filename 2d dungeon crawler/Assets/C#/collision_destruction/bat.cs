using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat : MonoBehaviour
{
    public int health = 1;
    public int damage = 1;

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        //checks for the tag on the object it collides with
        if (collisionInfo.collider.tag == "weapon")
        {
           health --;
        }

        //makes player take damage for hitting an enemy
        if (collisionInfo.collider.tag == "Player")
        {
            //makes sure the player loses at least 1 health
            if (damage - PlayerInfo.playerDefense <= 0 || PlayerInfo.playerDefense - damage >= 4)
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

    void Update()
    {
        if (health <= 0)
        {
            //destroys (kills) the enemy
            Destroy(gameObject);
        }
    }
}
