using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{

    public GameObject Enemy;
    public float enemyMoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //makes the enemy move towards the player

        enemyMoveSpeed = (PlayerInfo.movementSpeed / 2);

        //enemy moves in x direction towards player
        if (PlayerInfo.playerLocation.x > Enemy.GetComponent<Transform>().position.x)
        {
            transform.position = new Vector2 (Enemy.GetComponent<Transform>().position.x + enemyMoveSpeed, Enemy.GetComponent<Transform>().position.y);
        }

        else if (PlayerInfo.playerLocation.x < Enemy.GetComponent<Transform>().position.x)
        {
            transform.position = new Vector2 (Enemy.GetComponent<Transform>().position.x - enemyMoveSpeed, Enemy.GetComponent<Transform>().position.y);
        }

        //enemy moves in y direction towards player
         if (PlayerInfo.playerLocation.y > Enemy.GetComponent<Transform>().position.y)
        {
            transform.position = new Vector2 (Enemy.GetComponent<Transform>().position.x, Enemy.GetComponent<Transform>().position.y + enemyMoveSpeed);
        }

        else if (PlayerInfo.playerLocation.y < Enemy.GetComponent<Transform>().position.y)
        {
            transform.position = new Vector2 (Enemy.GetComponent<Transform>().position.x, Enemy.GetComponent<Transform>().position.y - enemyMoveSpeed);
        }
    }
}
