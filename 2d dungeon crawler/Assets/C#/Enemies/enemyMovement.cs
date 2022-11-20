using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    //enemy rigid body
    public Rigidbody2D rb;
    public bool canMove = true;
    public bool closeTo = false;
    public float moveSpeed;

    // FixedUpdate is called once per set amount of frames
    void FixedUpdate()
    {
        //checks if enemy is within a certain distance of the player
        if (Vector2.Distance(transform.position, PlayerInfo.playerLocation) < 6)
        {
            closeTo = true;
            
            //makes the enemy move towards the player
            if (canMove == true)
            {
                transform.position = Vector2.MoveTowards(transform.position, PlayerInfo.playerLocation, moveSpeed * Time.deltaTime);
            }
                    
        }
        else
        {
            closeTo = false;
        }
    }
}
