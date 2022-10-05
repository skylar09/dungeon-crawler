using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject player;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //checks for key press of d or right arrow key
        if (Input.GetKey ("d") || Input.GetKey(KeyCode.RightArrow))
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
        }
    }

    // FixedUpdate is called once per set amount of frames
    void FixedUpdate()
    {
        //checks if the player is alive (health above 0)
        if (PlayerInfo.playerHealth > 0)
        {
            //moves player with wasd or arrow keys
            rb.MovePosition(rb.position + movement * PlayerInfo.movementSpeed * Time.fixedDeltaTime);
        }

        else
        {
            //changes player velocity to 0 if the player is dead (health 0 or less)
            rb.velocity = new Vector2(0, 0);
        }
    }

    public void turn()
    {
        if (PlayerInfo.directionFacing == "right")
        {
            animator.SetBool("facingRight", true);
        }
        else
        {
            animator.SetBool("facingRight", false);
            
        }
    }

    public void turnedRight()
    {
        animator.SetBool("facingRight", true);
       // player.GetComponent<Transform>().rotation = new Quaternion(0, 180, 0, 0);
    }

    public void turnedLeft()
    {
        animator.SetBool("facingRight", false);
        //player.GetComponent<Transform>().rotation = new Quaternion(0, 0, 0, 0);
    }
}
