using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject slime;
    public GameObject bat;
    public static bool enterRoom = false;
    public static int enemyCount = 0;

    void Start()
    {
        //spawns 1 bat in the first room
        if (PlayerCollision.currentRoom == 0)
        {
            Instantiate(bat, new Vector2(3, 2), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //should spawn enemy when you enter a new room
        if (enterRoom == true && RoomLocation.newRoom[PlayerCollision.currentRoom] == true)
        {
            RoomLocation.newRoom[PlayerCollision.currentRoom] = false;

            float LocationX = RoomLocation.roomCords[PlayerCollision.currentRoom].x;
            float LocationY = RoomLocation.roomCords[PlayerCollision.currentRoom].y;

            int numOfEnemies = Random.Range(2, 5);

            for (int i = 0; i < numOfEnemies; i++)
            {
                int enemyNum = Random.Range(0, 2);
                
                //gives either 1 or -1
                int leftOrRight = Random.Range(0, 2) * 2 - 1;
                int upOrDown = Random.Range(0, 2) * 2 - 1;

                if (enemyNum == 0)
                {
                    //creates a version of an enemy prefab
                    Instantiate(bat, new Vector2(LocationX + (Random.Range(3f, 7f) * leftOrRight), LocationY + (Random.Range(1.5f, 3f)) * upOrDown), Quaternion.identity);
                }

                else if (enemyNum == 1)
                {
                    //creates a version of an enemy prefab
                    Instantiate(slime, new Vector2(LocationX + (Random.Range(3f, 7f) * leftOrRight), LocationY + (Random.Range(1.5f, 3f)) * upOrDown), Quaternion.identity);
                }
            }
            
            enterRoom = false;
            Debug.Log("spawned");
        }        
    }
}
