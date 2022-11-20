using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //player gameObject
    public GameObject player;
    //the rigid body component of the player
    public Rigidbody2D rb;
    //used in player movement
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //used in player movement
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //checks for key press of d or right arrow key
       /* if (Input.GetKey ("d") || Input.GetKey(KeyCode.RightArrow))
        {
            if (PlayerInfo.directionFacing != "right")
            {
                PlayerInfo.directionFacing = "right";
                turn();
            }
        }

        //checks for key press of a or left arrow key
        if (Input.GetKey ("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            if (PlayerInfo.directionFacing != "left")
            {
                PlayerInfo.directionFacing = "left";
                turn();
            }
        }*/
    }

    // FixedUpdate is called once per set amount of frames
    void FixedUpdate()
    {
        //moves player with wasd or arrow keys
        rb.MovePosition(rb.position + movement * PlayerInfo.movementSpeed * Time.fixedDeltaTime);
    }
}
