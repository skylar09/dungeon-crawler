using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public int health = 4;

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        //checks for the tag on the object it collides with
        if (collisionInfo.collider.tag == "weapon")
        {
           health --;
        }
    }

    void Update()
    {
        if (health <= 0)
        {
            //destroys (kills) the enemy
            Destroy(gameObject);

                //resets slime health so when a new slime is created it has health of 4
            //**should find a way to make it so this doesnt need to happen bc it resets all current slime healths to 4**
            // health = 4;
        }
    }
}
