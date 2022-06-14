using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class weaponCollision : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        //checks for the tag on the object it collides with
        if (collisionInfo.collider.tag == "enemy")
        {
            Debug.Log("ouch");

            enemyInfo.enemyHealth --;
        }
    }
}
