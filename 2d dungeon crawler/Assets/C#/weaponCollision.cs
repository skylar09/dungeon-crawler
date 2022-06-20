using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class weaponCollision : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        //checks for the tag on the object it collides with
        //**add new if statements for each enemy**
        //**add new tag for each enemy**
        if (collisionInfo.collider.tag == "batEnemy")
        {
            enemyInfo.batHealth --;
        }

        if (collisionInfo.collider.tag == "slimeEnemy")
        {
            enemyInfo.slimeHealth --;
        }
    }
}
