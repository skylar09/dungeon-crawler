using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    // Update is called once per frame
    void OnCollisionEnter (Collision collisionInfo)
    {
        //checks for the tag on the object it collides with
        if (collisionInfo.collider.tag == "enemy")
        {
            //changes the player health
            PlayerInfo.playerHealth = 4 - PlayerInfo.playerDefense;

            Debug.Log(PlayerInfo.playerHealth);
        }
    }
}
