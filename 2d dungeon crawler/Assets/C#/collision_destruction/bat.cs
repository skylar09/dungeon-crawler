using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat : MonoBehaviour
{
    public int health = 1;

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
        }
    }
}
