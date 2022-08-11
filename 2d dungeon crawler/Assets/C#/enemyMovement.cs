using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{

    private Transform target;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //sets target as the GameObject with the tag "Player"
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, 0);
    }

    // FixedUpdate is called once per set amount of frames
    void FixedUpdate()
    {
        //checks if enemy is within a certain distance of the player
        if (Vector2.Distance(transform.position, target.position) < 6)
        {
            //makes the enemy move towards the player
            transform.position = Vector2.MoveTowards(transform.position, target.position, PlayerInfo.movementSpeed / 2 * Time.deltaTime);
        }
        
        else
        {

        }
    }
}
