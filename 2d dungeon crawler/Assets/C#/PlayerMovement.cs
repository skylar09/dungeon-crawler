using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject player;
    public Rigidbody2D rb;
    Vector2 movement;
    

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
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
}
