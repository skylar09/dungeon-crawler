using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {//moves player to the right            
            transform.position = new Vector2 (player.GetComponent<Transform>().position.x + PlayerInfo.movementSpeed, player.GetComponent<Transform>().position.y);
        }

        if (Input.GetKey("a"))
        {//moves player to the left
            transform.position = new Vector2 (player.GetComponent<Transform>().position.x - PlayerInfo.movementSpeed, player.GetComponent<Transform>().position.y);
        }

        if (Input.GetKey("w"))
        {//moves player up
            transform.position = new Vector2 (player.GetComponent<Transform>().position.x, player.GetComponent<Transform>().position.y + PlayerInfo.movementSpeed);
        }

        if (Input.GetKey("s"))
        {//moves player down
            transform.position = new Vector2 (player.GetComponent<Transform>().position.x, player.GetComponent<Transform>().position.y - PlayerInfo.movementSpeed);
        }
    }
}
