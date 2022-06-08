using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{

    public GameObject Enemy;
    public float differenceInX;
    public float differenceInY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //makes the enemy move towards the player

        // differenceInX = PlayerInfo.playerLocation.x - Enemy.GetComponent<Transform>().position.x;
        // differenceInY = PlayerInfo.playerLocation.y - Enemy.GetComponent<Transform>().position.y;

        if (PlayerInfo.playerLocation.x > Enemy.GetComponent<Transform>().position.x)
        {
            transform.position = new Vector2 (Enemy.GetComponent<Transform>().position.x + (PlayerInfo.movementSpeed / 2), Enemy.GetComponent<Transform>().position.y);
        }

        else if (PlayerInfo.playerLocation.x < Enemy.GetComponent<Transform>().position.x)
        {
            transform.position = new Vector2 (Enemy.GetComponent<Transform>().position.x - (PlayerInfo.movementSpeed / 2), Enemy.GetComponent<Transform>().position.y);
        }

         if (PlayerInfo.playerLocation.y > Enemy.GetComponent<Transform>().position.y)
        {
            transform.position = new Vector2 (Enemy.GetComponent<Transform>().position.x, Enemy.GetComponent<Transform>().position.y + (PlayerInfo.movementSpeed / 2));
        }

        else if (PlayerInfo.playerLocation.y < Enemy.GetComponent<Transform>().position.y)
        {
            transform.position = new Vector2 (Enemy.GetComponent<Transform>().position.x, Enemy.GetComponent<Transform>().position.y - (PlayerInfo.movementSpeed / 2));
        }
    }
}
