using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject player;
    public Rigidbody2D rb;
    Vector2 movement;
    public GameObject weapon;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        weapon.GetComponent<Transform>().position = PlayerInfo.playerLocation + new Vector3(2, 2, 0);
    }

    // FixedUpdate is called once per set amount of frames
    void FixedUpdate()
    {
        if (PlayerInfo.playerHealth > 0)
        {
            //moves player with wasd or arrow keys
            rb.MovePosition(rb.position + movement * PlayerInfo.movementSpeed * Time.fixedDeltaTime);
        }

        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
