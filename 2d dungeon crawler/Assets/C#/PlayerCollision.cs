using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerCollision : MonoBehaviour
{


    // Update is called once per frame
    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        //checks for the tag on the object it collides with
        if (collisionInfo.collider.tag == "enemy")
        {
            //changes the player health
            PlayerInfo.playerHealth = PlayerInfo.playerHealth - (Math.Abs(PlayerInfo.playerDefense - 4));

            Debug.Log(PlayerInfo.playerHealth);
        }

        // if (collisionInfo.collider.tag == "next room up")
        // {
            
        // }
    }
}
