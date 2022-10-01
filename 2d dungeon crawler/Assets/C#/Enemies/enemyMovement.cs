using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    private Transform target;
    public Rigidbody2D rb;
    public bool canMove = true;
    public bool closeTo = false;
    public bool meleeAttack = false;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //sets target as the GameObject with the tag "Player"
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // FixedUpdate is called once per set amount of frames
    void FixedUpdate()
    {
        //checks if enemy is within a certain distance of the player
        if (Vector2.Distance(transform.position, target.position) < 6)
        {
            closeTo = true;
            if (Vector2.Distance(transform.position, target.position) < 2)
            {
                meleeAttack = true;
            }
            else{
                meleeAttack = false;
            }
            //makes the enemy move towards the player
            if (canMove == true)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            }
                    
        }
        else
        {
            closeTo = false;
        }
    }
}
