using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //the rigid body component of the player
    public Rigidbody2D rb;
    //used in player movement
    Vector2 movement;

    public Animator Animator;

    // Update is called once per frame
    void Update()
    {
        //used in player movement
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //checks for key press of d or right arrow key
        if (Input.GetKey ("d") || Input.GetKey(KeyCode.RightArrow))
        {
            Animator.SetBool("move", true);
            if (PlayerInfo.directionFacing != "right"){
                PlayerInfo.directionFacing = "right";
            turn(0);
            }
        }
        //checks for key press of a or left arrow key
        else if (Input.GetKey ("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            Animator.SetBool("move", true);
            if (PlayerInfo.directionFacing != "left"){
                PlayerInfo.directionFacing = "left";
                turn(180);
            }
        }
        else if (Input.GetKey ("w") || Input.GetKey(KeyCode.UpArrow)){
            Animator.SetBool("move", true);
        }
        else if (Input.GetKey ("s") || Input.GetKey(KeyCode.DownArrow)){
            Animator.SetBool("move", true);
        }
        else
            Animator.SetBool("move", false);
    }

    // FixedUpdate is called once per set amount of frames
    void FixedUpdate()
    {
        //moves player with wasd or arrow keys
        rb.MovePosition(rb.position + movement * PlayerInfo.movementSpeed * Time.fixedDeltaTime);
    }

    private void turn(float angle){
        transform.rotation = Quaternion.Euler(0, angle, 0);
    }
}
